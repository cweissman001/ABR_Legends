import { ColorThumb, updateColorThumbs, DataRemappingSlider } from './components.js'
import { ColorMap, floatToHex } from './color.js';
import { storage } from './storage.js';
import { uuid } from '../../composition/js/UUID.js';
import { sendInputUpdate } from '../../composition/js/MessageUtils.js';
import { initAbrEngineInterface, messenger } from '../../composition/js/AbrMessenger.js';

const margin = { top: 10, right: 0, bottom: 30, left: 0 };
const width = 780 - margin.left - margin.right;
const height = 200 - margin.top - margin.bottom;

// Canvas for exporting thumbnail.png
const exportWidth = 200;
const exportHeight = 30;
var EXPORT_CANVAS = document.createElement('canvas');
EXPORT_CANVAS.width = exportWidth;
EXPORT_CANVAS.height = exportHeight;


async function fetchData(url) {
    let resp = await fetch(url);
    return await resp.text(); 
}

// Inspiration: https://www.d3-graph-gallery.com/graph/histogram_basic.html
function updateHistogram(data, minm, maxm) {
    if (typeof(minm) === 'undefined' || typeof(maxm) === 'undefined') {
        [minm, maxm] = d3.extent(data);
    }

    d3.selectAll('#histogram > *').remove();

    // append the svg object to the body of the page
    var svg = d3.select("#histogram")
        .append("svg")
        .attr("width", width + margin.left + margin.right)
        .attr("height", height + margin.top + margin.bottom)
        .append("g")
        .attr("transform",
            "translate(" + margin.left + "," + margin.top + ")");

    // Add the scale element for the colormap
    d3.select('#colormap > svg').remove();
    let colormapScaleHeight = 20;
    var colormapSVG = d3.select("#colormap")
        .append("svg")
        .attr("width", width + margin.left + margin.right)
        .attr("height", colormapScaleHeight)
        .append("g")
        // .attr("transform", "translate(" + margin.left + "," + margin.top + ")");

    // Options for binning (opportunity to improve here):
    // https://en.wikipedia.org/wiki/Histogram#Mathematical_definition
    let numBins = d3.thresholdSturges(data);
    // let numBins = d3.thresholdScott(data, d3.min(data), d3.max(data));
    // let numBins = d3.thresholdFreedmanDiaconis(data, d3.min(data), d3.max(data));
    // let numBins = Math.ceil(Math.sqrt(data.length));

    // Provide one more (sometimes empty) bin on each side so bins on the ends
    // don't overflow
    let extent = maxm - minm;
    let binSpan = extent / numBins;
    var x = d3.scaleLinear()
        .domain([minm - binSpan, maxm + binSpan])
        .range([0, width]);

    svg.append('g')
        .attr('transform', `translate(0, ${height})`)
        .call(d3.axisBottom(x));

    colormapSVG.append('g')
        // .attr('transform', `translate(0, ${colormapScaleHeight})`)
        .call(d3.axisBottom(x));

    let histogram = d3.histogram()
        .domain(x.domain())
        .thresholds(numBins);

    let bins = histogram(data);

    var y = d3.scaleLinear()
        .domain([0, d3.max(bins, (d) => d.length)])
        .range([height, 0]);
    // No left axis for now
    // svg.append('g');
        // .call(d3.axisLeft(y));
    
    // append the bar rectangles to the svg element
    svg.selectAll("rect")
        .data(bins)
        .enter()
        .append("rect")
        .attr("x", 1)
        .attr("transform", (d) => `translate(${x(d.x0)},${y(d.length)})`)
        .attr("width", (d) => x(d.x1) - x(d.x0) - 1)
        .attr("height", (d) => height - y(d.length))
        .style("fill", "#545050")

    // Update the slider values, and register the callback for interactively
    // changing the min/max
    let outsideMargin = 0.1;
    let marginExtent = outsideMargin * extent;
    $('.data-remapping-slider')
        .slider('option', 'min', minm - marginExtent)
        .slider('option', 'max', maxm + marginExtent)
        .slider('option', 'step', extent / width)
        .slider('values', 0, minm)
        .slider('values', 1, maxm)
        .slider('option', 'slide', (evt, ui) => {
            let [filterMin, filterMax] = ui.values;
            $('.slider-labels #slider-minLabel').text(filterMin);
            $('.slider-labels #slider-maxLabel').text(filterMax);
        });

    // Update the Engine with the min/max from this slider
    storage.variableInfo.minValue = minm;
    storage.variableInfo.maxValue = maxm;
    $('.slider-labels #slider-minLabel').text(minm);
    $('.slider-labels #slider-maxLabel').text(maxm);
    sendInputUpdate(storage.variableInfo);
}

function init() {
    // We assume that colormaps will be state-specific by the time they get to the editor.
    let urlParams = new URLSearchParams(window.location.search);
    let variableInfoURI = urlParams.get('variable-info');
    storage.variableInfo = JSON.parse(decodeURIComponent(variableInfoURI));
    storage.colormapUUID = urlParams.get('colormap-uuid');
    storage.dataLabel = urlParams.get('data-label');

    // Allow this client to talk to the engine as well
    initAbrEngineInterface();
    messenger.addMessageCallback((evt, state) => {
        $('#colormap-save-spinner').css('visibility', 'hidden');
    });

    $('#color-slider').width(width).height('2rem');

    // Add save colormap button
    $('#file-header').append($('<button>', {
        class: 'material-icons',
        html: 'save',
        title: 'Save colormap to palette',
        id: 'save-colormap',
    }).on('click', (evt) => {
        $('#colormap-save-spinner').css('visibility', 'visible');
        let serializedXML = storage.colormap.toXML();

        // Splat the colormap onto another canvas for exporting the correct dimensions
        let screenThumbnail = $('#colormap .colormap-canvas').get(0);//.toDataURL('image/png');
        let ctx = EXPORT_CANVAS.getContext('2d');
        ctx.drawImage(
            screenThumbnail,
            0, 0,
            screenThumbnail.width, screenThumbnail.height,
            0, 0,
            exportWidth, exportHeight
        );

        let thumbnail = EXPORT_CANVAS.toDataURL('image/png');
        let firstComma = thumbnail.indexOf(',');
        thumbnail = thumbnail.slice(firstComma + 1);

        let postData = {
            uuid: storage.colormapUUID,
            pngB64: thumbnail,
            colormapXML: serializedXML,
        };
        $.ajax({
            url: '/api/update-colormap/',
            type: 'post',
            data: JSON.stringify(postData),
        })
            // .then((_msg) => $('#colormap-save-spinner').css('visibility', 'hidden'))
            .catch((err) => alert(err.message));
    }));

    // Flip colormap button
    $('#state-header').append($('<button>', {
            class: 'flip-colormap material-icons',
            text: 'swap_horiz',
            title: 'Flip colormap',
        }).on('click', (evt) => {
            storage.colormap.flip();
            updateColorThumbs(false);
    }));

    // Add color button
    $('#state-header').append($('<button>', {
            class: 'create-color material-icons',
            text: 'add_box',
            title: 'Add a new color to the colormap',
        }).on('click', (evt) => {
            $('#color-slider').append(ColorThumb());
            updateColorThumbs();
    }));

    // Add copy button (forces a copy of an already state-specific VisAsset)
    $('#file-header').append($('<button>', {
            class: 'copy-colormap material-icons',
            text: 'file_copy',
            title: 'Copy colormap',
        }).on('click', (evt) => {
            let postData = {
                'oldUuid': storage.colormapUUID,
                'newUuid': uuid(),
                'forceCopy': true,
            };
            $.ajax({
                url: '/api/copy-colormap/',
                type: 'post',
                data: JSON.stringify(postData),
            })
                .then((msg) => {
                    $('#colormap-save-spinner').css('visibility', 'hidden');
                })
                .catch((err) => alert(err.message));
    }));

    // Add loading spinner
    $('#file-header').append($('<div>', {
            class: 'loading-spinner',
            id: 'colormap-save-spinner',
            css: {visibility: 'hidden'},
    }));

    $('#trash').droppable({
        tolerance: 'touch',
        accept: '.color-thumb',
        drop: (evt, ui) => {
            $(ui.draggable).remove();
        },
        // Indicate that it's about to be deleted
        over: (_evt, ui) => {
            $(ui.helper).css('opacity', '25%');
        },
        out: (_evt, ui) => {
            $(ui.helper).css('opacity', '100%');
        }
    }).attr('title', 'Drop a color swatch here to discard');

    $('#colormap').append(
        $('<canvas>', {
            class: 'colormap-canvas',
            attr: {
                width: width,
                height: height,
            }
        })
    );

    $('#data-remapper').on('mouseup', (evt, ui) => {
        let filterMin = $('.data-remapping-slider').slider('values', 0);
        let filterMax = $('.data-remapping-slider').slider('values', 1);
        updateHistogram(storage.data, filterMin, filterMax);
    });

    let $slider = DataRemappingSlider(0, 1, 0, 1, width);
    $slider.insertAfter($('#histogram'));

    let $labels = $('<div>', {class: 'slider-labels'}).append(
        $('<p>', {id: 'slider-minLabel', text: storage.variableInfo.minValue})
    ).append(
        $('<p>', {id: 'slider-maxLabel', text: storage.variableInfo.maxValue})
    ).insertAfter($slider);

    let $resetButton = $('<button>', {
        class: 'reset-slider',
        text: 'Reset mapping',
    }).on('click', (evt) => {
        updateHistogram(storage.data);
    }).insertAfter($labels);

    if (storage.colormapUUID) {
        // Cache bust the file
        let colormapFile = `${MEDIA_URL}visassets/${storage.colormapUUID}/colormap.xml?${new Date().getTime()}`;
        fetchData(colormapFile).then((colorStr) => {
            let colormap = ColorMap.fromXML(colorStr);
            colormap.entries.forEach((c) => {
                let pt = c[0];
                let color = floatToHex(c[1]);
                $('#color-slider').append(ColorThumb(pt, color));
            });
            storage.colormap = colormap;
            updateColorThumbs();
        });
    }

    if (storage.dataLabel) {
        // Cache bust the file
        let dataFile = `${MEDIA_URL}datasets/${storage.dataLabel}.json?${new Date().getTime()}`;
        fetchData(dataFile).then((dataStr) => {
            let parsed = JSON.parse(dataStr);

            // Default to the variable that was passed as a param, if any
            let varIndex = parsed.scalarArrayNames.indexOf(storage.variableInfo.label);
            if (storage.variableInfo.label && typeof(varIndex) !== 'undefined') {
                $('<h2>', {
                    class: 'centered',
                    text: `Variable: ${storage.variableInfo.label}`,
                }).insertAfter($resetButton);
                let data = parsed.scalarArrays[varIndex].array;
                storage.data = data;
                updateHistogram(data, storage.variableInfo.minValue, storage.variableInfo.maxValue);
            }
        });
    }
}

window.onload = init;