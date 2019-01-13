function isAnagram(str1, str2) {
    let len = str1.length();
    let char;
    let isAnagram = true;
    if(len == str2.length()) {
        for(let i = 0; i < len; i++) {
            char = str1[i];
            if(str2.contains(char)) {
                str2.removeFirst(char);
            } else {
                isAnagram = false;
            }
        }
        if(str2.length > 0)
            isAnagram = false;
    } else
        isAnagram = false;

    return isAnagram;
}
