  function reverse(s) {
            return s.split("").reverse().join("");
        }
 
        function isDigit(aChar) {
            myCharCode = aChar.charCodeAt(0);
 
            if ((myCharCode > 47) && (myCharCode < 58)) {
                return true;
            }
 
            return false;
        }
 
        function isLetter(str) {
            return str.length === 1 && str.match(/[a-z]/i);
        }