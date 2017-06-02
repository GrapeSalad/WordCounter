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
