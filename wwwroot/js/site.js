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
function ddlsel( controller,  action, _Id, _parqs){
    var url=window.location.protocol+"//"+window.location.hostname+":"+window.location.port+"/"+controller+"/"+action+"/"+_id+"?"+_parqs;//&sortExpression="+sortExpression.toString()+"&filterExpression="+filterExpression.toString()+"&IdGrid="+_gridId.toString();
    window.location.href = url2;

}


