//TYPEOF
//Returns the data type of the JavaScript variable, in this case 'string'
function typeStr() {
    document.getElementById("String").innerHTML = "Data type = " + document.write(typeof "What is this data type");
}

//Returns the data type of the JavaScript variable, in this case 'number'
function typeNum() {
    document.getElementById("Number").innerHTML = document.write(typeof 42);
}

//TYPE COERCION
//Returns the type coercion of two variables
function typeCoer() {
    document.getElementById("Coercion").innerHTML = document.write("58" + 42);
}

//NOT A NUMBER
//Returns NaN because 0 cannot be divided by 0
function notNum() {
    document.getElementById("NotNum").innerHTML = 0 / 0;
}

//Returns whether or not something is a number, in this case it is NOT a number so 'true' is displayed
function isNota() {
    document.getElementById("IsNota").innerHTML = isNaN('James Bond');
}

//Returns whether or not something is a number, in this case it IS a number so 'false' is displayed
function isNum() {
    document.getElementById("IsNum").innerHTML = isNaN('007');
}

//INFINITY
//Returns 'Infinity' because we wrote a number larger than 1.7976931348623157E308
function infi() {
    document.getElementById("Infi").innerHTML = document.write(2E310);
}

//Returns '-Infinity' because we wrote a negative number larger than -1.7976931348623157E308
function negInfi() {
    document.getElementById("NegInfi").innerHTML = document.write(-2E310);
}

//BOOLEAN LOGIC
//Returns 'true' or 'false' after evaluating the expression, in this case 'true'
function booTrue() {
    document.getElementById("BooTrue").innerHTML = document.write(10 > 2);
}

//Returns 'true' or 'false' after evaluating the expression, in this case 'false'
function booFalse() {
    document.getElementById("BooFalse").innerHTML = document.write(10 < 2);
}

//CONSOLE LOG
//Displays the result of the expression in the browser's console, in this case '10'
function consoleMath() {
    document.getElementById("ConsoleMath").innerHTML = console.log(5 + 5);
}

//Displays the result of the expression in the browser's console, in this case 'false'
function consoleBoo() {
    document.getElementById("ConsoleBoo").innerHTML = console.log(10 < 2);
}

//DOUBLE EQUALS SIGNS
//Checks whether the data on the left side of the double equals symbol is equal to the data on the right side, in this case 'true'
function compTrue() {
    document.getElementById("CompTrue").innerHTML = document.write(10 == 10);
}

//Checks whether the data on the left side of the double equals symbol is equal to the data on the right side, in this case 'false'
function compFalse() {
    document.getElementById("CompFalse").innerHTML = document.write(10 == 2);
}

//TRIPLE EQUAL SIGNS
//Checks whether the data on the left side of the triple equals symbol is equal to the data on the right side and that it is the same type of data as that on the right
//Same Data Type and Values
function tripleEqualA() {
    X = 25;
    Y = 25;
    document.getElementById("TripleA").innerHTML = document.write(X === Y);
}

//Different Data Type and Different Values
function tripleEqualB() {
    X = 25;
    Y = "Twenty-five";
    document.getElementById("TripleB").innerHTML = document.write(X === Y);
}

//Different Data Type but Same Values
function tripleEqualC() {
    X = 25;
    Y = "25";
    document.getElementById("TripleC").innerHTML = document.write(X === Y);
}

//Same Data Type but Different Values
function tripleEqualD() {
    X = 25;
    Y = 10;
    document.getElementById("TripleD").innerHTML = document.write(X === Y);
}

//LOGICAL OPERATORS
//AND
//Returns 'true' because both expressions are true
function andTrue() {
    document.getElementById("AndTrue").innerHTML = document.write(5 > 2 && 10 > 4);
}

//Returns 'false' because only one expression is true
function andFalse() {
    document.getElementById("AndFalse").innerHTML = document.write(5 > 10 && 10 > 4);
}

//OR
//Returns 'true' because one or the other expression is true
function orTrue() {
    document.getElementById("OrTrue").innerHTML = document.write(5 > 10 || 10 > 4);
}

//Returns 'false' because neither expression is true
function orFalse() {
    document.getElementById("OrFalse").innerHTML = document.write(5 > 10 || 10 > 20);
}

//NOT
//Returns whether or not something is true
function notFalse() {
    document.getElementById("NotFalse").innerHTML = !(20 < 10);
}

//Returns whether or not something is false
function notTrue() {
    document.getElementById("NotTrue").innerHTML = !(5 < 10);
}