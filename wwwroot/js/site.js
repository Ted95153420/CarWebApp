﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Chapter 3 - show a quick demo of Javascript in action

//Chapter 3 - talk about immediately invokable function and why we implement this
//hint : so there are no variable 'clashes' in the global scope
(function() {
    $("#VehMakesDD").on("change",
        function(e){
            e.stopImmediatePropagation();
            var makeId = $(this).val();
            debugger
            $.ajax({
                type : "Post",
                url : "/Home/GetModelList?makeID_="+makeId,
                contentType:"html",
                success: function(response){
                    debugger
                    $("#VehModelsDD").empty();
                    $("#VehModelsDD").append(response);
                }
            })
        }
    ); 
})();
