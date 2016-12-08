# Word Counter

#### The program can check a given sentence and output how many times a word appears in that sentence, 12.02.16.

#### By **Anne Belka**

### Specifications

* Behavior: The program can compare two inputted words and determine if they are different.
* Input: "hello", "yo"
* Output: false

* Behavior: The program can compare two inputted words and determine if they are the same.
* Input: "hello", "hello"
* Output: true

* Behavior: The program can compare two inputted words and determine if they are the same regardless of case.
* Input: "Hello", "hello"
* Output: true

* Behavior: The program can compare two inputted words to see if they are the same regardless of punctuation.
* Input: "Hello," "hello"
* Output: true

* Behavior: The program can compare each word in an inputted sentence to an inputted word to see if they are the same.
* Input: "Hello, you!", "hello"
* Output: true

* Behavior: The program can compare each word in an inputted sentence to an inputted word to see if they are the same and return how frequently the word appears.
* Input: "Hello, you! I love to say hello to friends!", "hello"
* Output: 2

## Setup/Installation Requirements

* Clone this repository or download it to your computer.
* Navigate to the project directory in the terminal.
* Use the command > dnu restore to download any necessary dependencies.
* Use the command > dnx kestrel to run the project on the local server.
* Navigate to localhost:5004 in your browser to view the app.

### License

GPL

Copyright (c) 2016 **_Anne Belka_**
