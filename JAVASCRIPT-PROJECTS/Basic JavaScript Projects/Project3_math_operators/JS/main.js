//Adds two numbers
function quickAdd() {
    var num = 10 + 15;
    document.getElementById("Add").innerHTML = "Wow! " + (num);
}

//Subtracts two numbers
function quickSub() {
    var num = 100 - 45;
    document.getElementById("Sub").innerHTML = "Less wow! " + (num);
}

//Multiplies two numbers
function quickMul() {
    var num = 100 * 2;
    document.getElementById("Mul").innerHTML = "Double Wow! " + (num);
}

//Divides two numbers
function quickDiv() {
    var num = 1440 / 12;
    document.getElementById("Div").innerHTML = "Fractions of wow! " + (num);
}

//Does multiple operations
function allMaths() {
    var num = (7 + 2) * 10 / 2 - 5;
    document.getElementById("Maths").innerHTML = "So much wow! " + (num);
}

//Finds the remainder (or modulus) after dividing two numbers
function modulusMath() {
    var num = 43 % 7;
    document.getElementById("Mod").innerHTML = "Wow-ish! " + (num);
}

//Returns the opposite (or negative form) of something
function negationOperator() {
    var num = 100;
    document.getElementById("Unary").innerHTML = "Negative wow! " + (-num);
}

//Adds one to the number (or increments) it
function increment() {
    var num = 68;
    num++;
    document.getElementById("Increase").innerHTML = "More wow! " + (num);
}

//Subtracts one from the number (or decrements) it
function decrement() {
    var num = 85;
    num--;
    document.getElementById("Decrease").innerHTML = "Less wow again! " + (num);
}

//Returns a random number between 0 and 100
function randoNum() {
    var num = Math.random() * 100;
    document.getElementById("Rando").innerHTML = "Random wow! " + (num);
}

//Returns a random number between 0 and 100 and rounds it to the nearest integer
function roundNum() {
    var num = Math.round(Math.random() * 100);
    document.getElementById("Round").innerHTML = "Rounded wow! " + (num);
}