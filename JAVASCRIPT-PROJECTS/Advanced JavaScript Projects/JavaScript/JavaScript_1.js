//Performs different actions based on the conditions presented to it
function Color_Function() {
    var Color_Output;
    var Colors = document.getElementById("Color_Input").value;
    var Color_String = " is a great color!";
    switch (Colors) {
        case "Red":
            Color_Output = "Red" + Color_String;
            break;
        case "Yellow":
            Color_Output = "Yellow" + Color_String;
            break;
        case "Green":
            Color_Output = "Green" + Color_String;
            break;
        case "Blue":
            Color_Output = "Blue" + Color_String;
            break;
        case "Pink":
            Color_Output = "Pink" + Color_String;
            break;
        case "Purple":
            Color_Output = "Purple" + Color_String;
            break;
        default:
            Color_Output = "Please enter a color exactly as written on the above list.";
    }
    document.getElementById("Output").innerHTML = Color_Output;
}

//Displays the first element with the class "Click"
function Hello_World_Function() {
    var A = document.getElementsByClassName("Click");
    A[0].innerHTML = "The text has changed!";
}

var A = document.getElementById("Graphics");
var Txt = A.getContext("2d");

//Adds a gradient background to the canvas
var Grad = Txt.createLinearGradient(0, 0, 500, 0);
Grad.addColorStop(0, "blue");
Grad.addColorStop(1, "pink");
Txt.fillStyle = Grad;
Txt.fillRect(0, 0, 500, 300);

//Adds text graphics within the canvas and centers them
Txt.font = "50px Arial";
Txt.textAlign = "center";
Txt.strokeStyle = "white";
Txt.strokeText("Hello World", 250, 150);