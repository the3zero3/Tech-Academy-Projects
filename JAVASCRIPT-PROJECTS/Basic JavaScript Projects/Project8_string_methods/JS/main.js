//Builds a full sentence using the concatenate method
function full_Sentence() {
    var part1 = "I love building ";
    var part2 = "sentences with JavaScript!";
    document.getElementById("Concatenate").innerHTML = part1.concat(part2);
}

//Extracts a section of a string and then returns the extracted section in a new string
function slice_Method() {
    var Sentence = "All work and no play makes Johnny a dull boy.";
    var Section = Sentence.slice(27, 33);
    document.getElementById("Slice").innerHTML = Section;
}

//Converts a string to uppercase letters
function to_Uppercase() {
    var Word = "ahhhhhhhhhhhhh!";
    var Upper = Word.toUpperCase();
    document.getElementById("Uppercase").innerHTML = Upper;
}

//Matches a string against a regular expression (if the search value is a string, it is converted to a regular expression)
function string_Search() {
    var Sentence = "Look at this neat sentence!";
    var Position = Sentence.search("neat");
    document.getElementById("Search").innerHTML = Position;
}

//Returns a number as a string
function string_Method() {
    var Num = 5280;
    document.getElementById("Numbers_to_string").innerHTML = Num.toString();
}

//Formats a number to a specified length
function precision_Method() {
    var Num = 23423438.3084212;
    document.getElementById("Precision").innerHTML = Num.toPrecision(10);
}

//Converts a number to a string, rounded to a specified number of decimals
function fix_Number() {
    var Num = 23423438.3084212;
    document.getElementById("Fixed").innerHTML = Num.toFixed();
}

//Returns the primitive value of a number
function value_Of() {
    var Num = 1500;
    document.getElementById("Value").innerHTML = Num.valueOf();
}