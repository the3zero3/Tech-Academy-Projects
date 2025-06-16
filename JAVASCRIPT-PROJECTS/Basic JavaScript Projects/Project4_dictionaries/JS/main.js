//Automobile dictionary with a function that outputs a KVP into an HTML element
//Output will be 'undefined' because a delete statement removes the key before its value is displayed
function carDictionary() {
    var Car = {
        Make: "Mercedes-Benz",
        Model: "C63",
        Year: 2014,
        Color: "Black",
        Drivetrain: "RWD"
    };
    delete Car.Model;
    document.getElementById("Dictionary").innerHTML = Car.Model;
}