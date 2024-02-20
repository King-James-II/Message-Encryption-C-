# Message Encryption Program

This program encrypts a message by generating a random string array and hiding characters of a hidden message within it. It utilizes random number generators to create the random array and randomly select characters to hide the message. The encrypted message is then printed to the console.

## Key Features:
- **Random Array Generation**: Generates a random string array with 22 lines, each containing 60 random characters chosen from a predefined character set.
- **Hidden Message Embedding**: Breaks the hidden message into 5-character segments and hides them within the random array by replacing random characters with segments of the hidden message.
- **Randomization**: Utilizes two instances of the `Random` class with different seeds to ensure randomness in both the array generation and character hiding processes.
- **Console Output**: Prints the encrypted message, represented as the modified random array, to the console for display.

## Technologies and Concepts Covered:
- **Random Number Generation**: Uses the `Random` class to generate random numbers for creating the random string array and selecting characters to hide the message.
- **String Manipulation**: Manipulates strings to generate the random array, break down the hidden message into segments, and hide the segments within the random array.
- **StringBuilder Usage**: Utilizes `StringBuilder` to efficiently manipulate and build strings during the encryption process.
- **Nested Looping**: Employs nested `for` loops to iterate over the random array lines and characters, and to embed the hidden message segments.
- **Console Output Formatting**: Prints the encrypted message to the console in a formatted manner for display.
