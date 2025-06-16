//Example of a simple while loop that prints numbers from 1 to 10
function Call_Loop() {
    var Count = "";
    var X = 1;
    while (X < 11) {
        Count += "<br>" + X;
        X++;
    }
    document.getElementById("Loop").innerHTML = Count;
}

//Example of the string length property
function How_Long() {
    var Text = "How long is this sentence?";
    var Length = Text.length;
    document.getElementById("Long").innerHTML = Length;
}

//Example of a simple for loop that prints the values in an array
var Instruments = ["Guitar", "Drums", "Piano", "Bass", "Violin", "Trumpet", "Flute"];
var Content = "";
var Y;
function for_Loop() {
    for (Y = 0; Y < Instruments.length; Y++) {
        Content += Instruments[Y] + "<br>";
    }
    document.getElementById("List_of_Instruments").innerHTML = Content;
}

//Example of an array that prints a specific value in the array
function array_Function() {
    var Picture = [];
    Picture[0] = "sleeping";
    Picture[1] = "playing";
    Picture[2] = "eating";
    Picture[3] = "purring";
    document.getElementById("Array").innerHTML = "In this picture, the cat is " + Picture[2] + ".";
}

//Example of a constant
function constant_Function() {
    const Musical_Instrument = { type: "guitar", brand: "Fender", color: "black" };
    Musical_Instrument.color = "blue";
    Musical_Instrument.price = "$900";
    document.getElementById("Constant").innerHTML = "The cost of the " + Musical_Instrument.color + " " + Musical_Instrument.type + " was " + Musical_Instrument.price;
}

//Example of a 'let' vs a 'var' with regards to scope
function let_vs_var() {
    var X = 69;
    document.write(X);
    {
        let X = 33;
        document.write("<br>" + X);
    }
    document.write("<br>" + X);
}

//Example of a return statement
function return_Statement() {
    document.getElementById("Return").innerHTML = greeting("Howdy");
    function greeting(greeting) {
        return greeting + " partner!"
    }
}

//Example of a object data structure
function car_Object() {
    let car = {
        make: "Dodge ",
        model: "Viper ",
        gen: "(SR II) ",
        color: "red ",
        description: function () {
            return "The car is a " + this.color + this.make + this.model + this.gen;
        }
    };
    document.getElementById("Car").innerHTML = car.description();
}

//Example of a break statement
function break_Example() {
    let text = "";
    for (let num = 1; num < 11; num++) {
        if (num === 4) {
            break;
        }
        text += "The number is " + num + "<br>";
    }
    document.getElementById("Break").innerHTML = text;
}

//Example of a continue statement
function continue_Example() {
    let text = "";
    for (let num = 1; num < 11; num++) {
        if (num === 4) {
            continue;
        }
        text += "The number is " + num + "<br>";
    }
    document.getElementById("Continue").innerHTML = text;
}