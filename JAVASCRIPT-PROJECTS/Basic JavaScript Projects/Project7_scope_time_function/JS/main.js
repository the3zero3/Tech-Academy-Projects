//Global variable
var Days = 365

//Function that sets a local variable and calls the global variable
function World() {
    var Years = 4
    document.write(Years * Days);
}

//Funtion with an intentional error that uses the console.log() method to debug
function World2() {
    console.log(Years * Days);
}

World();
World2();

//IF Statements
//Function to ask a user how they are doing based on a specific time of day
function Get_Date() {
    if (new Date().getHours() < 18) {
        document.getElementById("Greeting").innerHTML = "How are you today?";
    } else {
        document.getElementById("Greeting").innerHTML = "How are you this evening?";
    }
}

//ELSE Statements
//Function to tell a user what time of year it is when they click the button
function What_Season() {
    if (new Date().getMonth() < 3) {
        document.getElementById("Season").innerHTML = "It's winter!";
    } else if (new Date().getMonth() < 7) {
        document.getElementById("Season").innerHTML = "It's spring!";
    } else if (new Date().getMonth() < 10) {
        document.getElementById("Season").innerHTML = "It's summer!";
    } else {
        document.getElementById("Season").innerHTML = "It's fall!";
    }
}

//ELSE IF Statements
//Function to tell a user what time of year it is based on what numerical month they enter
function Enter_Month() {
    var Month = document.getElementById("Month").value;
    if (Month == 12 || Month == 1 || Month == 2) {
        document.getElementById("Seasons").innerHTML = "It's winter!";
    } else if (Month == 3 || Month == 4 || Month == 5) {
        document.getElementById("Seasons").innerHTML = "It's spring!";
    } else if (Month == 6 || Month == 7 || Month == 8) {
        document.getElementById("Seasons").innerHTML = "It's summer!";
    } else {
        document.getElementById("Seasons").innerHTML = "It's fall!";
    }
}

//Funtion to tell a user what time of day it is when they click the button
function Time_Function() {
    var Time = new Date().getHours();
    var Reply;
    if (Time < 12 == Time > 0) {
        Reply = "It is morning time!";
    } else if (Time >= 12 == Time < 18) {
        Reply = "It is afternoon!";
    } else {
        Reply = "It is evening time!";
    }
    document.getElementById("Time_of_day").innerHTML = Reply;
}