document.addEventListener("DOMContentLoader", function () {
    var element = document.createElement("p");
    element.textContent = "This is element from the third.js file";
    document.querySelector("body").appendChild(element);
}
);