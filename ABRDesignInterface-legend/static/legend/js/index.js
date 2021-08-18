import { initAbrEngineInterface, messenger } from '../../composition/js/AbrMessenger.js';

const STATE_FILE = 'http://localhost:8001/states/gulf-starter-sz.json'; //currently the hardcoded way to 'upload' a specific JSON file. This file must be in C:\Users\<your user>\AppData\LocalLow\IVLab\ABREngine\media\states to work


//function takes in the given stragey and sends message to render the specific legend preview and then take a screenshot
function LegendPreview(strategy) {
    let $preview = $('<div>', {
        class: 'legend-preview',
	id: strategy.label + 'legend-preview',
    }).append(
        $('<img>', {
            class: 'abr-legend-image',
            src: null, // Will be populated later by ABR
        })
    ).append(
        $('<img>', {
            class: 'colormap-preview',
            src: `${MEDIA_URL}visassets/${strategy.inputs['Colormap']}/thumbnail.png`
        })

    ).data('uuid', strategy.uuid); // UUID is used to match returned image from ABR
           return $preview;
}

function requestLegendPreview(strategy) {
    // Need to send twice because ABR doesn't fully update the first time (bug)
    messenger.sendMessage({
        type: 6, // LegendViewRequest
        message: JSON.stringify(strategy),
    });
}

//returns just the value to replace the meaningless uuid
function realNumAssetArrayLooping(variableArr, uuid, type){ //used to loop through either the vis asset or real num supplimentary array to add more info to the component entries---type options: rn, va
	for(var i = 0; i<variableArr.length; i++){
		if(variableArr[i].uuid == uuid){
                	if(type == "rn"){
				return variableArr[i].floatVal;
			}
			if(type == "va"){
      				return variableArr[i].type;
			}

		}
	}
}
//returns object with info needed to replace uuid
function rangedScaleDVLooping(variableArr, dataNodes, uuid){ //used to get entire object from data nodes
	var uuidDN;
	for(var i = 0; i<variableArr.length; i++){
		if(variableArr[i].inputs.InputVariable == uuid){ //when uuid refers to the input variable within the Data variable
			uuidDN = uuid;
			}
		else if(variableArr[i].uuid == uuid){ //when uuid refers to uuid is data variable  
			uuidDN = variableArr[i].inputs.InputVariable;
		}
	}
	for(var k =0; k<dataNodes.length; k++){
		if(dataNodes[k].uuid == uuidDN){
			return dataNodes[k];
		}
	}	
}

function skip(impressionSubject){ //check to see if null or undefined so can skip looping function to prevent an error or extra run time
	var bool = true;
	if(impressionSubject == null || undefined){
		bool = false;
	}
	return bool;
}

//replaces UUID's in the simpleSurfacegEncodingStrategy with the actual data values from the data objects and color variable objects in the JSON file
function LegendSurfaceEntryComponent(impressionObject, rangedScaleDV, dataNodes, realNumArr, visAsset){
	//Color variable
	if(skip(impressionObject['inputs']['Color Variable']) == true){ 
		impressionObject['inputs']['Color Variable'] = rangedScaleDVLooping(rangedScaleDV, dataNodes, impressionObject['inputs']['Color Variable']);
	}
	//Pattern
	if(skip(impressionObject['inputs']['Pattern']) == true){
		impressionObject['inputs']['PatternInput'] = realNumAssetArrayLooping(visAsset, impressionObject['inputs']['Pattern'], "va");
	}
	//Pattern scaler
	if(skip(impressionObject['inputs']['Pattern Scale']) == true){
		impressionObject['inputs']['Pattern Scale'] = realNumAssetArrayLooping(realNumArr, impressionObject['inputs']['Pattern Scale'], "rn");
	}
	//Pattern Saturation
	if(skip(impressionObject['inputs']['Pattern Saturation']) == true){
		impressionObject['inputs']['Pattern Saturation'] = realNumAssetArrayLooping(realNumArr, impressionObject['inputs']['Pattern Saturation'], "rn");
	}
	//Pattern Intensity
	if(skip(impressionObject['inputs']['Pattern Intensity']) == true){
		impressionObject['inputs']['Pattern Intensity'] = realNumAssetArrayLooping(realNumArr, impressionObject['inputs']['PatternIntensity'], "rn");
	}

	return impressionObject;
        
	}
//replaces UUID's in the simpleLineEncodingStrategy with the actual data values from the data objects and color variable objects in the JSON file
function LegendLineEntryComponent(impressionObject, rangedScaleDV, dataNodes, realNumArr, visAsset){
	//width
	if(skip(impressionObject['inputs']['Width']) ==true){
		impressionObject['inputs']['Width'] = realNumAssetArrayLooping(realNumArr, impressionObject['inputs']['Width'], "rn");
	}
	//average
	if(skip(impressionObject['inputs']['Average']) == true){
		impressionObject['inputs']['Average'] = realNumAssetArrayLooping(realNumArr, impressionObject['inputs']['Average'], "rn");
	}
	//color variable
	if(skip(impressionObject['inputs']['Color Variable']) == true){
		impressionObject['inputs']['Color Variable'] = rangedScaleDVLooping(rangedScaleDV, dataNodes, impressionObject['inputs']['Color Variable']);
	}
	//texture
	if(skip(impressionObject['inputs']['Texture']) == true){
		impressionObject['inputs']['TextureInput'] = realNumAssetArrayLooping(visAsset, impressionObject['inputs']['Texture'], "va");
	}
	//Ribbon brightness
	if(skip(impressionObject['inputs']['RibbonBrightness']) == true){
		impressionObject['inputs']['RibbonBrightness'] = realNumAssetArrayLooping(realNumArr, impressionObject['inputs']['RibbonBrightness'], "rn");
	}
	//ribbon rotation
	if(skip(impressionObject['inputs']['Ribbon Rotation']) == true){
		impressionObject['inputs']['Ribbon Rotation'] = realNumAssetArrayLooping(realNumArr, impressionObject['inputs']['Ribbon Rotation'], "rn");
	}
	//curve
        return impressionObject;
	}
//replaces UUID's in the simpleGlyphEncodingStrategy with the actual data values from the data objects and color variable objects in the JSON file
function LegendGlyphEntryComponent(impressionObject, rangedScaleDV, dataNodes, realNumArr, visAsset){
        //Glyph size
	if(skip(impressionObject['inputs']['Glyph Size']) == true){
		impressionObject['inputs']['Glyph Size'] = realNumAssetArrayLooping(realNumArr, impressionObject['inputs']['GlyphSize'])
	}
	//color variable
	if(skip(impressionObject['inputs']['Color Variable']) == true){
		impressionObject['inputs']['Color Variable'] = rangedScaleDVLooping(rangedScaleDV, dataNodes, impressionObject['inputs']['Color Variable'])
	}
	//glyph
	if(skip(impressionObject['inputs']['Glyph']) == true){
		impressionObject['inputs']['Glyph Input'] = realNumAssetArrayLooping(visAsset, impressionObject['inputs']['Glyph'], "va");
	}
        return impressionObject;
	}
//Function to looping through the the created arrays and then call entry components
function LoopDataArrays(impressionObjectArray, type, rangedScaleDV, dataNodes, realNumArr, visAsset){ //type is either glyph, line, surface
	var objectArr = [];
	if(type == "glyph"){
		for(var i = 0; i< impressionObjectArray.length; i++){
			objectArr.push(LegendGlyphEntryComponent(impressionObjectArray[i], rangedScaleDV, dataNodes, realNumArr, visAsset));
		}
	}
	if(type == "line"){
		for(var i = 0; i< impressionObjectArray.length; i++){
			objectArr.push(LegendLineEntryComponent(impressionObjectArray[i], rangedScaleDV, dataNodes, realNumArr, visAsset));
		}
	}
	if(type == "surface"){
		for(var i = 0; i < impressionObjectArray.length; i++){
			objectArr.push(LegendSurfaceEntryComponent(impressionObjectArray[i], rangedScaleDV, dataNodes, realNumArr, visAsset));

		}
	}

	return objectArr;
}

//replaces the color varible UUID with the entire color varible object that the UUID points to
function divColorvar(impressionObject){
	return $('<div>', {id: impressionObject['label'] + 'ColorInputs',})
		.append(
			$('<p>' , { text: 'Label: ' + impressionObject['inputs']['Color Variable']['label']}),
		).append(
			$('<p>' , { text: 'Max Value: ' + impressionObject['inputs']['Color Variable']['maxValue']}),
		).append(
			$('<p>' , { text: 'Min Value: ' + impressionObject['inputs']['Color Variable']['minValue']}),
		).append(
			$('<p>' , { text: 'Type: ' + impressionObject['inputs']['Color Variable']['type']}),
		);

}
//appends the legend layout for the surface object
function surfaceImpressionPrint(impressionObject, objs){
		return $('<div>', {class: 'centerdiv', id: impressionObject['label'] + 'inputs',})
	.append(
		$('<p>', {class: 'centerit', text: impressionObject.label})
	).append(
		gradientPrint(impressionObject.uuid, objs, impressionObject),
	).append(
		$('<div>', {class: 'container' , id: impressionObject['label'] + 'range'}).append(
			$('<p>', {text:  impressionObject['inputs']['Color Variable']['minValue'].toFixed(4)}),
		).append(
			$('<p>', {text:  impressionObject['inputs']['Color Variable']['label'].replace(/_/g, " ")})
		).append(
			$('<p>', {text: impressionObject['inputs']['Color Variable']['maxValue'].toFixed(4)})),
    	);
}
//appends the legend layout for the line object
function lineImpressionPrint(impressionObject, objs){
		return $('<div>', {class: 'centerdiv', id: impressionObject['label'] + 'inputs' ,})
	.append(
		$('<p>', {class: 'centerit', text: impressionObject.label})
	).append(
		gradientPrint(impressionObject.uuid, objs, impressionObject),
	).append(
		$('<div>', {class: 'container' , id: impressionObject['label'] + 'range'}).append(
			$('<p>', {text:  impressionObject['inputs']['Color Variable']['minValue'].toFixed(4)}),
		).append(
			$('<p>', {text:  impressionObject['inputs']['Color Variable']['label'].replace(/_/g, " ")})
		).append(
			$('<p>', {text: impressionObject['inputs']['Color Variable']['maxValue'].toFixed(4)})),
	);


}
//appends the legend layout for the glyph object
function glyphImpressionPrint(impressionObject, objs){	
		return $('<div>', {class: 'centerdiv', id: impressionObject['label'] + 'inputs',})
	.append(
		$('<p>', {class: 'centerit', text: impressionObject.label})
	).append(
		gradientPrint(impressionObject.uuid, objs, impressionObject),
	).append(
		$('<div>', {class: 'container' , id: impressionObject['label'] + 'range'}).append(
			$('<p>', {text:  impressionObject['inputs']['Color Variable']['minValue'].toFixed(4)}),
		).append(
			$('<p>', {text:  impressionObject['inputs']['Color Variable']['label'].replace(/_/g, " ")})
		).append(
			$('<p>', {text: impressionObject['inputs']['Color Variable']['maxValue'].toFixed(4)})),
    );
	
}

//calls the LegendPreview and requestLegendPreview after looping through to find unchanged object from the given UUID
function gradientPrint(uuidCode, objs){
	console.log("uuid: " + uuidCode);
	let gradObject;
	let preview;
	for(var i = 0; i<objs.compositionNodes.length; i++){
		if(uuidCode == objs.compositionNodes[i].uuid){
			gradObject = objs.compositionNodes[i];
			console.log("grad object");
			console.log(gradObject);
		}
	}
	preview = LegendPreview(gradObject);
	requestLegendPreview(gradObject);
	return preview;
}
function legFormat(id){
	$(id).css('background-color', '#C3C3C3');
	$(id).css('margin', '2px');

}
//loops through each array of impression object and calls the function that begins to create the legend layout
function printLoop(surfaceImpObject, lineImpObject, glyphImpObject, objs){
	for(var i = 0; i<surfaceImpObject.length; i++){

		surfaceImpressionPrint(surfaceImpObject[i], objs).appendTo('body');	
		legFormat('#' + surfaceImpObject[i].label + 'legend-preview');
		
	}
	for(var k = 0; k<lineImpObject.length; k++){

		lineImpressionPrint(lineImpObject[k],objs).appendTo('body');
		legFormat('#' + lineImpObject[k].label + 'legend-preview');

	}
	for(var j = 0; j<glyphImpObject.length; j++){

		glyphImpressionPrint(glyphImpObject[j], objs).appendTo('body');	
		legFormat('#' + glyphImpObject[j].label + 'legend-preview');

	}

 }
function init() {
    initAbrEngineInterface();

    fetch(STATE_FILE).then((resp) => resp.text()).then((text) => {
        let state = JSON.parse(text);
        console.log(state);
	
	//the state that is going to be changed to print
	let objs = JSON.parse(text);
	let compNodes = objs.compositionNodes;
	let dataNodes = objs.dataNodes;
	let visAssets = objs.visassetNodes;
        let surfaceImpressionObjects = [];
        let lineImpressionObjects = [];
        let glyphImpressionObjects = [];
        let realNumArr = [];
	let rangedScaleDV = [];
	for(let i =0; i<compNodes.length; i++){
    		if(compNodes[i].type == "SimpleSurfaceEncodingRenderStrategy"){//render surface
	         surfaceImpressionObjects.push(compNodes[i]);
	     }
	     else if(compNodes[i].type == "SimpleLineEncodingRenderStrategy") {//render line
                 lineImpressionObjects.push(compNodes[i]);
	     }     
	     else if(compNodes[i].type == "SimpleGlyphEncodingRenderStrategy") {//render glyph
                 glyphImpressionObjects.push(compNodes[i]);
	     }
	     else if(compNodes[i].type == "RealNumber"){
                 realNumArr.push(compNodes[i]); 
	     }
	     else if(compNodes[i].type == "RangedScalarDataVariable"){
                 rangedScaleDV.push(compNodes[i]);
	     }
	}
	
       	let surfaceRenderOb = LoopDataArrays(surfaceImpressionObjects, "surface", rangedScaleDV, dataNodes, realNumArr, visAssets);
	let lineRenderOb = LoopDataArrays(lineImpressionObjects, "line", rangedScaleDV, dataNodes, realNumArr, visAssets);
	let glyphRenderOb = LoopDataArrays(glyphImpressionObjects, "glyph", rangedScaleDV, dataNodes, realNumArr, visAssets);

	printLoop(surfaceRenderOb, lineRenderOb, glyphRenderOb, state);


        // Add the callback so we know to update the images once ABR finishes rendering them
        messenger.addMessageCallback((message) => {
            // Stop if it's not a LegendView message (from ABRMessenger.cs in the engine)
            if (message.type != 7) {
                return;
            }
            let msgJson = JSON.parse(message.message);

            // Find the matching UUID out of all the .abr-legend-preview entries
            let $previews = $('.legend-preview').filter((_i, el) => $(el).data('uuid') == msgJson.uuid);

            // Update the img src with base64 bytes from ABR
            $previews.find('.abr-legend-image').attr('src', 'data:image/png;base64,' + msgJson.bytes);
        });
    })
}

window.onload = init;

