//This function changes the text on both buttons when the left button is clicked
function My_First_Function() {
    var str1 = "This is the button text", str2 = "This is more text";
    document.getElementById("Button_Text").innerHTML = str1;
    document.getElementById("Other_Text").innerHTML = str2;
}

//This function concatenates two string variables and returns the result when the right button is clicked
function My_Second_Function() {
    var str1 = "This is the beginning", str2 = " and the end of this sentence.";
    document.getElementById("Other_Text").innerHTML = (str1 + str2);
}