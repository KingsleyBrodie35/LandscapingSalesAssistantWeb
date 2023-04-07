//global vars
formInputPaver = document.getElementById("paver");
formInputWall = document.getElementById("retainingWall");
inputSize = document.getElementById("inputSize");
inputColour = document.getElementById("inputColour");
inputCrushRock = document.getElementById("inputCrushRock");
inputWallHeight = document.getElementById("inputWallHeight");
inputCurve = document.getElementById("inputCurve");
inputDiv = document.getElementById("inputDiv");
formButton = document.getElementById("formButton")

//funcs
formInputPaver.generateInputs = function () {
    formButton.classList.remove("hidden")
    inputColour.classList.remove("hidden")
    inputSize.classList.remove("hidden")
    inputCrushRock.classList.remove("hidden")
    formButton.classList.add("show")
    inputColour.classList.add("show")
    inputSize.classList.add("show")
    inputCrushRock.classList.add("show")


    inputWallHeight.classList.add("hidden")
    inputCurve.classList.add("hidden")
    inputWallHeight.classList.remove("show")
    inputCurve.classList.remove("show")
    
}
formInputWall.generateInputs = function () {
    inputColour.classList.remove("hidden")
    formButton.classList.remove("hidden")
    inputWallHeight.classList.remove("hidden")
    inputCurve.classList.remove("hidden")
    inputColour.classList.add("show")
    formButton.classList.add("show")
    inputWallHeight.classList.add("show")
    inputCurve.classList.add("show")


    inputSize.classList.add("hidden")
    inputCrushRock.classList.add("hidden")
    inputSize.classList.remove("show")
    inputCrushRock.classList.remove("show")
}

function rowClicked(ProductId, TypeId) {
    window.location.href = `./Product?ProductId=${ProductId}&TypeId=${TypeId}`
    console.log("row clicked")
}
