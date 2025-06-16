//Function to see if a user is tall enough to ride
function Ride_Function() {
    var Height, Can_ride;
    Height = document.getElementById("Height").value;
    Can_ride = (Height < 52) ? "You are too short" : "You are tall enough";
    document.getElementById("Ride").innerHTML = Can_ride + " to ride.";
}


//Function to see if a user is old enough to vote
function Vote_Function() {
    var Age = document.getElementById("Age").value;
    document.getElementById("Vote").innerHTML = (Age < 18) ? "You are not old enough to vote" : "You are old enough to vote";
}

//Constructor function for the Vehicle class
function Vehicle(Make, Model, Year, Color) {
    this.Vehicle_Make = Make;
    this.Vehicle_Model = Model;
    this.Vehicle_Year = Year;
    this.Vehicle_Color = Color;
}

//Car variables created by invoking Vehicle constructor class
var Jack = new Vehicle("Dodge", "Viper", 2020, "Red");
var Emily = new Vehicle("Jeep", "Trail Hawk", 2019, "White and Black");
var Erik = new Vehicle("Ford", "Pinto", 1971, "Mustard");

//Function to return what car Erik drives
function myFunction() {
    document.getElementById("Keywords_and_Constructors").innerHTML = "Erik drives a " + Erik.Vehicle_Color + "-colored " + Erik.Vehicle_Model + " manufactured in " + Erik.Vehicle_Year;
}

//Chris's car
var Chris = new Vehicle("Ferrari", "F40", 1990, "red");

//Function to return what car Chris drives
function myCar() {
    document.getElementById("New_and_This").innerHTML = "Chris drives a " + Chris.Vehicle_Color + " " + Chris.Vehicle_Make + " " + Chris.Vehicle_Model + " manufactured in " + Chris.Vehicle_Year;
}

//Nested function to yell at the user
function yelling_Function() {
    document.getElementById("Nested_Function").innerHTML = Yell();
    function Yell() {
        var Surprise = "HELLO!"
        return Surprise;
    }
}