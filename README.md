# Word Counter

#### An Epicodus project using C# focusing on xUnit method testing

#### **By David Wilson**

## Description

This web application will allow a user to enter a word and a sentence to see if the sentence contains the word. It will return the amount of times the word appears in the sentence.

#### RESTful Routing
| Behavior | Input | Output |
|---|---|---|
| Home Page | "localhost:5004/" | index.cshtml |
| Results Page | "localhost:5004/result" | result.cshtml or ohSnap.cshtml |

### Specs
| Behavior | Input | Output |
|---|---|---|
| Will enter a word | "Word" | Word |
|---| This is the basest functionality of the program, the ability to accept input from the user |---|
| Will enter a sentence | "Today I saw a cat, and it had one blue eye." | Today I saw a cat, and it had one blue eye |
|---| This is an upgrade on the previous spec, instead of one word the program needs to accept an entire sentence |---|
| Punctuation will be removed from the sentence | "One, Two, Three." | One Two Three |
|---| By removing punctuation the sentence will be easier to parse |---|
| Will check the sentence to see if it contains the previously entered single word | "Bird, bird, bird, bird is the word", "bird" | True |
|---| Checking the sentence for a word is a requirement of this program |---|
| Will turn a sentence into a list | "Today I saw a cat, and it had one blue eye" | ["Today", "I", "saw", "a", "cat", "and", "it", "had", "one", "blue", "eye"] |
|---| Splitting the sentence into a list will allow me to count the words, and to see if there are any duplicates (and how many) |---|
| Determine the amount of times a word in is a sentence | "Bird, bird, bird, bird is the word" | bird, 4 |
|---| This is also a requirement of the program |---|

## Setup/Installation Requirements

Go to the Github repository page at https://github.com/GrapeSalad/WordCounter
Click the "download or clone" button and copy the link.
In your Microsoft Windows installation location open PowerShell.
In PowerShell navigate to the directory in which you want to store the app files.
Clone using "git clone " and the copied link.
To run the project locally you will need Mono Compiler (http://www.mono-project.com/download/#download-win), Visual Studio 2015 (https://go.microsoft.com/fwlink/?LinkId=532606), and ASP.Net 5 (https://go.microsoft.com/fwlink/?LinkId=627627).
Once those are all installed, restart PowerShell and enter "dnvm upgrade" into the prompt.
Now you can navigate to the directory in which you downloaded the WordCounter App, and then into the WordCounter home file.
To start the web server necessary for proper app functionality you will need to type in "dnu restore" then "dnx kestrel".
Open a web browser, and type "localhost:5004".
To view the code you can open the files using your editor of choice.
If you have the editor path set in your system properties you will be able to open them through PowerShell.

## Known Bugs

The program doesn't account for special characters well.

## Support and Contact Details

If you have any issues, questions, ideas, concerns, or contribution ideas please contact any of the contributors via Github.

## Technologies used

* C-Sharp
* CSS
* Javascript
* HTML
* Boostrap
* JSON
* DVNM
* PowerShell
* Google Chrome
* Razor
* Nancy
* xUnit

### License

This software is licensed under the MIT license.

Copyright (c) 2017 **David Wilson**
