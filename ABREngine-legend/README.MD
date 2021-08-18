This is the legend design for the original 2D legend for the most current version of ABR available in summer 2020. 
In order to change the design of the file navigate to Assets/StreamingAssets/ABRDesignInterface/static/legend
This leads you to the js and css folders with all of the code that effects the legend layout in a web browser. 

This layout works by taking a state file from an ABR visulization, pulling the requiste info, sending what needs to be 
rendered back to the ABR Engine, taking screenshots, and then laying it out in a 2D legend format

Due to the way ABR is currently set up, the state file must be parsed through a few times in order to pair each impression
object with it correct color variable object which contains the min and max data value that is applied to the glyph as well
as the label of the variable


Currently the ABR state file that this code uses is hardcoded into the code and must be placed in the States section of ABR 
on your local machine
