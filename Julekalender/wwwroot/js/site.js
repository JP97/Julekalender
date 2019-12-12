// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//open a door for the julekalender
var element = document.querySelector(".frontdoor");
element.addEventListener("click", toggleDoor);

function toggleDoor() {
    element.classList.toggle("doorOpen");
}