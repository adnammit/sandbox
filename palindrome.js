
function isPalindrome(str) {

    let isPalindrome = true;
    char * ptr = str[str.length-1];
    let len = str.length();


    for (let i = 0; i < len; i++) {
        if (ptr != str[i])
            isPalindrome = false;
        else
            ptr = str[str.length()-i-1]; 

    }
}
