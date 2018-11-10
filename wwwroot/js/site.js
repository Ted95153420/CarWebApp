// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Chapter 3 - show a quick demo of Javascript in action

//Chapter 3 - talk about immediately invokable function and why we implement this
//hint : so there are no variable 'clashes' in the global scope
(function() {
    var element = document.getElementById("usernameheader");
    element.innerHTML = "Welcome Ted! ";
})();
