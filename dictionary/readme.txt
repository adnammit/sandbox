DICTIONARY:

This is a simple challenge to write a program that produces a JSON 
structure that reports the following information about your system’s 
English dictionary file (for sharing purposes, that file has been 
copied into a local .txt file, but you might be able to find it at
/usr/share/dict/words).

We will be counting:
- total number of words
- number of proper nouns (words that begin with a capital letter)
- number of possessive words (words that end with an apostrophe ‘s’)
- number of words of one or more letters that are neither proper nor 
  possessive. 
  
If a word is both possessive and proper it will only be counted as proper.



TO RUN:

Within the directory simply type 'g++ *.cpp' and then './a.out' from the
command line. 

Tah dah -- all of your words have been counted! The data should display on
your screen and you should now have a json file in your directory as well.


FUTURE OBJECTIVES:
- count number of long words (say, over 15 characters)
- calculate average occurance of each letter
- add an html page to display the data in a nice way



Thanks for using my silly program.
- Amanda
