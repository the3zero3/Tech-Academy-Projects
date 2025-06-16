//Assigns two string variables
var Sent1 = "This is the beginning of the string", Sent2 = " and this is the end of the string"

//Concatenates and prints the provided arguements
document.write(Sent1 + Sent2);

//Displays a pop-up with the provided expression
window.alert(1015 + 1009);

//Sets the 'onclick' event to display today's date and time
function displayDate() {
    document.getElementById("demo2").innerHTML = Date();
}

//Changes elements when the user moves their mouse over them
document.getElementById("demo").onmouseover = function () { mouseOver() };
document.getElementById("demo").onmouseout = function () { mouseOut() };

//Changes h1 elements to red when the user moves their mouse over them
function mouseOver() {
    document.getElementById("demo").style.color = "red";
}

//Changes h1 elements back to black when the user moves their mouse away from them
function mouseOut() {
    document.getElementById("demo").style.color = "black";
}
