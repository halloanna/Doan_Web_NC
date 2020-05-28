

//----------------------------------------------
//---------------MODAL-LOGIN--------------------
//----------------------------------------------

//Lay id modal
var modal = document.getElementById("myModal");
//lay btn open modal
var btn = document.getElementById("viewModal");
//
var span = document.getElementsByClassName("close")[0];
//
var cancelBtn = document.getElementById("cancelBtn");

btn.onclick = function () {
    modal.style.display = "block";
}
span.onclick = function () {
    modal.style.display = "none";
}
function cancel(Button) {
    modal.style.display = "none";
}
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}
