document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "This is element from the (modified) third.js file";
    document.querySelector("body").appendChild(element);
}
);