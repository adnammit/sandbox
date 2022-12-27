/*

DICTIONARY:

Write a program that produces a JSON structure that reports the following 
information about your system’s English dictionary file: 

o number of proper nouns (words that begin with a capital letter)
o number of possessive words (words that end with an apostrophe ‘s’)
o number of words of one or more letters that are neither proper nor 
  possessive. 
  
Return a mapping of integers using the keys ‘proper-nouns’, ‘possessive’,
and ‘other’. If a word is both possessive and proper, pick one to win, it
should be only counted once.

*/


#include<iostream>
#include<fstream>
#include<string.h>
#include<cstring>
using namespace std;

bool isProper(string line) {
    if (isupper(line[0])) return true;
    return false;
}

bool isPossessive(string line) {
    int len = line.length();
    char ending[] = {line[len-2], line[len-1], '\0'};
    if (strcmp(ending, "'s") == 0) return true;
    return false;
}

void json(int proper, int possessive, int other) {
// EXPORT RESULTS IN JSON FORMAT:
    ofstream file;
    file.open("dictionary.json");
    file << "[\n"
	<< "\t{\n"
	<< "\t\t\"proper-nouns\" : \"" << proper << "\",\n"
	<< "\t\t\"possessive\" : \"" << possessive << "\",\n"
	<< "\t\t\"other\" : \"" << other << "\"\n"
	<< "\t}\n"
	<< "]";
    file.close();
}




int main () {

// READ IN THE FILE:
    ifstream file;
    file.open("dictionary.txt");
    string line = "";
    int wordCount = 0;

// LET'S COUNT SOME WORDS:
    int properNouns = 0;
    int possessive = 0;
    int other = 0;

    getline(file, line);
    while(!file.eof()) {
	wordCount++;
	if (isProper(line)) properNouns++;
	else if (isPossessive(line)) possessive++;
	else other++;
	getline(file, line);
    }

    cout << endl << "TOTAL # OF WORDS:\t\t" << wordCount << endl
	<< "TOTAL # OF PROPER NOUNS:\t" << properNouns << endl
	<< "TOTAL # OF POSSESSIVES:\t\t" << possessive << endl
	<< "TOTAL # OF OTHER WORDS:\t\t" << other << endl;

// SEND RESULTS TO BE SAVED IN JSON FORMAT:
    json(properNouns, possessive, other);
    return 0;
}



