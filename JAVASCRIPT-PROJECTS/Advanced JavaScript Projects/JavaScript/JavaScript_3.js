function displayType(car) {
    var carModel = car.getAttribute("data-car-model");
    alert("The " + carModel + " was made by " + car.innerHTML + ".");
}