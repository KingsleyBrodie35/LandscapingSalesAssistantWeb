function changeRWValue(size, p, id) {
    amount = document.getElementById(`${id}_input`).value
    //
    totalOrderValue = document.getElementById("totalOrderValue").innerText
    totalOrderValue = totalOrderValue.replace("$", "")
    currentRowTotal = document.getElementById(`${id}_totalValue`).innerText
    currentRowTotal = currentRowTotal.replace("$", "")

    valuetd = document.getElementById(`${id}_totalValue`)
    value = valuetd.value

    arr = size.split("x")
    try {
        length = parseInt(arr[0])
        price = parseInt(p)
        amt = parseInt(amount)
        //
        totalOrderInt = parseInt(totalOrderValue)
        currentRowInt = parseInt(currentRowTotal)
    } catch (e) {
        console.log(e)
    }
    totalAmount = Math.round((1000 / length) * amt)
    totalValue = totalAmount * price
    amounttd = document.getElementById(`${id}_totalAmount`)
    amounttd.innerText = totalAmount
    valuetd.innerText = `$${totalValue.toFixed(2)}`
    totalTd = document.getElementById("totalOrderValue")
    totalTd.innerText = `$${(totalOrderInt - currentRowInt + totalValue).toFixed(2)}`
}

function changePValue(size, p, id) {
    amount = document.getElementById(`${id}_input`).value
    arr = size.split("x")
    totalOrderValue = document.getElementById("totalOrderValue").innerText
    totalOrderValue = totalOrderValue.replace("$", "")
    currentRowTotal = document.getElementById(`${id}_totalValue`).innerText
    currentRowTotal = currentRowTotal.replace("$", "")
    valuetd = document.getElementById(`${id}_totalValue`)
    value = valuetd.value
    try {
        length = parseInt(arr[0])
        width = parseInt(arr[1])
        price = parseFloat(p)
        amt = parseFloat(amount)
        totalOrderInt = parseInt(totalOrderValue)
        currentRowInt = parseInt(currentRowTotal)
    } catch (e) {
       console.log(e)
    }
    totalAmount = Math.round((1000 / length) * (1000 / width) * amt)
    totalValue = totalAmount * price
    amounttd = document.getElementById(`${id}_totalAmount`)
    valuetd = document.getElementById(`${id}_totalValue`)
    amounttd.innerText = totalAmount
    valuetd.innerText = `$${totalValue.toFixed(2)}`
    totalTd = document.getElementById("totalOrderValue")
    totalTd.innerText = `$${(totalOrderInt - currentRowInt + totalValue).toFixed(2)}`
}