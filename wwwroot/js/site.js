// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function opengMnu() {
    if (document.getElementById("engMenu").style.display!= "block"){
    document.getElementById("engMenu").style.display= "block" ;}
    else {
    document.getElementById("engMenu").style.display= "none" ;}
}
function ddlfunc(panel, svalue,value){
    var url = window.location.href;
    url=url.split("?")[0];
    url = url+"?panel="+panel.toString()+"&"+svalue+"=" + value.toString();
    window.location.href = url
}

