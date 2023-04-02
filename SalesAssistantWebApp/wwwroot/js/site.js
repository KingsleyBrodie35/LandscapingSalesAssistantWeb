//global vars
formInputPaver = document.getElementById("paver");
formInputWall = document.getElementById("retainingWall");
form = document.getElementById("form");
sizeInput = document.createElement("input");
colourInput = document.createElement("input");
sizeLabel = document.createElement("label");
colourLabel = document.createElement("label");
wallHeight = document.createElement("input");
wallHeightLabel = document.createElement("label");
wallCurvesT = document.createElement("input");
wallCurvesF = document.createElement("input");
wallCurvesLabelT = document.createElement("label");
wallCurvesLabelF = document.createElement("label");
canCrushRockT = document.createElement("input");
canCrushRockF = document.createElement("input");
canCrushRockLabelT = document.createElement("label");
canCrushRockLabelF = document.createElement("label");

function main() {
    setAttributes(sizeInput, { "type": "text", "id": "size", "placeholder": "400x400x40mm", "pattern": "^\d{3,4}x\d{3,4}x\d{1,3}mm$" })
    setAttributes(colourInput, { "type": "text", "id": "colour", "placeholder": "grey", "pattern": "^[a-zA-Z]+$" })
    setAttributes(wallHeight, { "type": "text", "id": "wallHeight", "placeholder": "600mm", "pattern": "\b\d{3-4}mm\b" })
    setAttributes(wallCurvesT, { "type": "radio", "id": "curveTrue", "value": "true", "name": "true" })
    setAttributes(wallCurvesF, { "type": "radio", "id": "curveFalse", "value": "false", "name": "false" })
    setAttributes(canCrushRockT, { "type": "radio", "id": "canCrushRockT", "value": "true", "name": "true" })
    setAttributes(canCrushRockF, { "type": "radio", "id": "canCrushRockF", "value": "false", "name": "false" })
    sizeLabel.setAttribute("for", "size")
    sizeLabel.innerText = "size"
    colourLabel.setAttribute("for", "colour")
    colourLabel.innerText = "colour"
    wallHeightLabel.setAttribute("for", "wallHeight")
    wallHeightLabel.innerText = "wall height"
    wallCurvesLabelT.innerText = "true"
    wallCurvesLabelT.setAttribute("for", "curveTrue")
    wallCurvesLabelF.innerText = "false"
    wallCurvesLabelF.setAttribute("for", "curveFalse")
    canCrushRockLabelT.innerText = "true"
    canCrushRockLabelT.setAttribute("for", "canCrushRockT")
    canCrushRockLabelF.innerText = "false"
    canCrushRockLabelF.setAttribute("for", "canCrushRockF")
}

//funcs
formInputPaver.generateInputs = function () {
    //attribute display none
    wallHeightLabel.setAttribute("display", "none")
    wallHeight.setAttribute("display", "none")
    form.appendChild(sizeLabel)
    form.appendChild(sizeInput)
    form.appendChild(colourLabel)
    form.appendChild(colourInput)
    form.appendChild(canCrushRockLabelT)
    form.appendChild(canCrushRockT)
    form.appendChild(canCrushRockLabelF)
    form.appendChild(canCrushRockF)
    
}
formInputWall.generateInputs = function () {
    
    form.appendChild(colourLabel)
    form.appendChild(colourInput)
    form.appendChild(wallHeightLabel)
    form.appendChild(wallHeight)
    form.appendChild(wallCurvesLabelT)
    form.appendChild(wallCurvesT)
    form.appendChild(wallCurvesLabelF)
    form.appendChild(wallCurvesF)
}

function setAttributes(element, attributeList) {
    for (let key in attributeList) {
        element.setAttribute(key, attributeList[key])
    }
}

main()