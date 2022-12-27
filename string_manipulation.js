//// CODERBYTE STRING STUFF:

// Shift all letters to the following letter in the alphabet (both lower and upper case)
// Then capitalize all vowels
function LetterChanges(str) {

    var shifted = str.replace(/[a-z]/gi, function(char) {
        return (char === 'z' || char === 'Z') ? 'a' : String.fromCharCode( char.charCodeAt() + 1 );
    });

    var capitalVowels = shifted.replace(/a|e|i|o|u/gi, function(char) {
        return char.toUpperCase();
    });

    return capitalVowels;

}

// capitalize the first letter of each word
function LetterCapitalize(str) {

    var words = str.split(" ");
    for (var i = 0; i < words.length; i++) {
        words[i] = words[i].substring(0,1).toUpperCase() + words[i].substring(1);
    }
    return words.join(" ");

}

// capitalize the first letter of each word using regex and word boundaries
function RegexLetterCapitalize(str) {

    var capitalized = str.replace(/\b[a-z]/gi, function(char) {
        return char.toUpperCase();
    });
    return capitalized;
}



// ternary if-then-else:
function makeUpperLower(caseFlag, str) {
    return (caseFlag ? str.toUpperCase() : str.toLowerCase());
}






function LongestWord(sen) {

    var words = sen.split(" ");
    var tmp;
    var longest = "";
    for(i = 0; i < words.length; i++) {
        tmp = words[i].replace(/^[a-z0-9]+/,"");
        if(tmp.length > longest.length)
            longest = tmp;
    }
    return longest;

}
LongestWord("hello. this is a run-on sentence.")
LongestWord("a confusing /:sentence:/[ this is not!!!!!!!~");




function LongestWordTwo(sen) {
    var words = sen.match(/[a-z0-9]+/gi);
    var sorted = words.sort(function (a, b) {
        return b.length - a.length;
    });

    return sorted[0];

}
LongestWordTwo("hello. this is a run-on sentence.")
