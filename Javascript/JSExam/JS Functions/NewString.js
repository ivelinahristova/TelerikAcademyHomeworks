function newString(char, times) {
    var outString = "";
    var i = 0;
    
    for (i = 0; i < times; i++) {
        outString += char;
    }

    return outString;
}