function addedToCart() {
    div = document.getElementById("outputMsg")
    addToCartMsg = document.createElement("p");
    addToCartMsg.innerText = "added to cart"
    div.appendChild(addToCartMsg)
}