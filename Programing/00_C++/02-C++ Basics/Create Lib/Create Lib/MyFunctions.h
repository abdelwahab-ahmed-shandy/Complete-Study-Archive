#pragma once
#include <iostream>
#include <string>

using namespace std;

namespace MyFunctions
{








	// Multiplication Table from 1 to 10
	// Returns a standard column separator.
    /// <summary>
    /// Returns a standard column separator based on the counter value.
    /// </summary>
    /// <param name="Counter">The current counter value.</param>
    /// <returns>A string representing the column separator.</returns>
	string ColumnSeparator(int Counter)
	{
		if (Counter < 10)
			return " |";
		else
			return " |";
	}

    // This function prompts the user to enter a positive number and validates the input.
    /// <summary>
    /// Prompts the user to enter a positive number and validates the input.
    /// This function repeatedly asks the user for input until a positive number is entered.
    /// </summary>
    /// <param name="Message">The message to display when asking the user for input.</param>
    /// <returns>A positive integer entered by the user.</returns>
    int ReadPositiveNumber(string Message)
    {
        int Number = 0;
        do
        {
            cout << Message << endl;
            cin >> Number;
        } while (Number <= 0);
        return Number;
    }

    // Enum to define the result of prime number checking
    /// <summary>
    /// Enum to define the result of prime number checking.
    /// </summary>
    enum enPrimeNotPrime { Prime = 1, NotPrime = 2 };
    // Function to check if a number is prime
    /// <summary>
    /// Function to check if a number is prime.
    /// The function returns "Prime" if the number is prime, otherwise "NotPrime".
    /// </summary>
    /// <param name="Number">The number to check for primality.</param>
    /// <returns>Returns an enum value of type enPrimeNotPrime indicating if the number is prime or not.</returns>
    enPrimeNotPrime CheckPrime(int Number)
    {
        int M = round(Number / 2);
        for (int Counter = 2; Counter <= M; Counter++)
        {
            if (Number % Counter == 0)
                return enPrimeNotPrime::NotPrime;
        }
        return enPrimeNotPrime::Prime;
    }

    // Function to calculate the sum of the digits of a number
    // Sum of Digits 1234 => 10
    /// <summary>
    /// Function to calculate the sum of the digits of a number.
    /// The function adds up all the digits in the number and returns the total sum.
    /// </summary>
    /// <param name="Number">The number whose digits will be summed.</param>
    /// <returns>The sum of the digits of the given number.</returns>
    int SumOfDigits(int Number)
    {
        int Sum = 0, Remainder = 0;
        while (Number > 0)
        {
            Remainder = Number % 10;
            Number = Number / 10;
            Sum = Sum + Remainder;
        }
        return Sum;
    }

    // Function to reverse the digits of a number
    // 1234 => 4321
    /// <summary>
    /// Function to reverse the digits of a number.
    /// The function takes a number and returns the number with its digits in reverse order.
    /// </summary>
    /// <param name="Number">The number whose digits will be reversed.</param>
    /// <returns>The number with digits reversed.</returns>
    int ReverseNumber(int Number)
    {
        int Remainder = 0, Number2 = 0;
        while (Number > 0)
        {
            Remainder = Number % 10;
            Number = Number / 10;
            Number2 = Number2 * 10 + Remainder;
        }
        return Number2;
    }

    // Function to count the frequency of a specific digit in a number
    // Digit Frequency
    // Input  : 1223222  // 2
    // Output : Digit 2 Frequency is 5 Time(s).
    /// <summary>
    /// Function to count the frequency of a specific digit in a number.
    /// The function checks how many times a specific digit appears in the given number.
    /// </summary>
    /// <param name="DigitToCheck">The digit to count its frequency.</param>
    /// <param name="Number">The number in which the digit's frequency will be counted.</param>
    /// <returns>The frequency of the specified digit in the given number.</returns>
    int CountDigitFrequency(short DigitToCheck, int Number)
    {
        int FreqCount = 0, Remainder = 0;
        while (Number > 0)
        {
            Remainder = Number % 10;
            Number = Number / 10;
            if (DigitToCheck == Remainder)
            {
                FreqCount++;
            }
        }
        return FreqCount;
    }

    // Function to check if a number is a Palindrome
     /*Palindrome Number
     NOTE : Palindrome is a number that reads the same from right to left.
     Input:
     1234
     12321
     Output:
     No, it is NOT a Palindrome number.
     Yes, it is a Palindrome number.*/
     /// <summary>
    /// Function to check if a number is a palindrome.
    /// A palindrome number is a number that reads the same forward and backward.
    /// </summary>
    /// <param name="Number">The number to check for palindrome property.</param>
    /// <returns>True if the number is a palindrome, otherwise false.</returns>
    bool IsPalindromeNumber(int Number)
    {
        return Number == ReverseNumber(Number);
    }

    // Function to read a valid 3-letter password (all uppercase)
    /* Guess a 3-Letter Password
     Input: AAF
     Output:
     Trial[1]: AAA
     Trial[2]: AAB
     Trial[3]: AAC
     Trial[4]: AAD
     Password is AAD
     Found after 6 Trial(s)*/
    /// <summary>
    /// Function to prompt the user to enter a 3-letter password.
    /// The user is asked to input a password consisting of only uppercase letters.
    /// </summary>
    /// <returns>The password entered by the user.</returns>
    string ReadPassword()
    {
        string Password;
        cout << "Please enter a 3-Letter Password (all capital)?\n";
        cin >> Password;
        return Password;
    }

    // This function attempts to guess a password by trying all combinations of 3 uppercase letters (A-Z).
    // It iterates over all possible combinations (A-Z, A-Z, A-Z), printing each trial and comparing it with the original password.
    // If the password is found, it outputs the password and the number of trials it took to find it.
    /// <summary>
    /// Function to guess a 3-letter password by brute force.
    /// It tries all combinations of uppercase letters (A-Z) until it finds the correct password.
    /// </summary>
    /// <param name="OriginalPassword">The original password that needs to be guessed.</param>
    /// <returns>True if the password is found, otherwise false.</returns>
    bool GuessPassword(string OriginalPassword)
    {
        string word = "";
        int Counter = 0;
        cout << "\n";
        for (int i = 65; i <= 90; i++) // Loop for the first letter (A-Z)
        {
            for (int j = 65; j <= 90; j++) // Loop for the second letter (A-Z)
            {
                for (int k = 65; k <= 90; k++) // Loop for the third letter (A-Z)
                {
                    Counter++;
                    word = word + char(i);
                    word = word + char(j);
                    word = word + char(k);
                    cout << "Trial [" << Counter << "] : " << word << endl;

                    // Check if the guessed password matches the original
                    if (word == OriginalPassword)
                    {
                        cout << "\nPassword is " << word << "\n";
                        cout << "Found after " << Counter << " Trial(s)\n";
                        return true; // Password is found
                    }
                    word = ""; // Reset word for the next combination
                }
            }
        }
        return false; // Password not found
    }


    // Function to check if a number is a perfect number
    // A perfect number is equal to the sum of all numbers smaller than it 
    // (excluding itself) that divide it with no remainder.
    /// <summary>
    /// Function to check if a number is a perfect number.
    /// A perfect number is a positive integer that is equal to the sum of its proper divisors (excluding itself).
    /// </summary>
    /// <param name="Number">The number to check for being perfect.</param>
    /// <returns>True if the number is perfect, otherwise false.</returns>
    bool isPerfectNumber(int Number)
    {
        int Sum = 0;
        for (int i = 1; i < Number; i++)
        {
            if (Number % i == 0)
                Sum += i;
        }
        return Number == Sum;
    }

    // Encrypt/Decrypt Text
    // Text Before Encryption: Mohammed
    /// <summary>
    /// Function to prompt the user to enter some text.
    /// </summary>
    /// <returns>The text entered by the user.</returns>
    string ReadText()
    {
        string Text;
        cout << "Please enter Text?\n";
        getline(cin, Text);
        return Text;
    }
    // Text After Encryption: Oqjcoogf
    /// <summary>
    /// Function to encrypt a given text using a simple Caesar cipher-like approach.
    /// Each character is shifted by the value of the EncryptionKey.
    /// </summary>
    /// <param name="Text">The text to be encrypted.</param>
    /// <param name="EncryptionKey">The key used to encrypt the text.</param>
    /// <returns>The encrypted text.</returns>
    string EncryptText(string Text, short EncryptionKey)
    {
        for (int i = 0; i <= Text.length(); i++)
        {
            Text[i] = char((int)Text[i] + EncryptionKey);
        }
        return Text;
    }
    // Text After Decryption: Mohammed    
    /// <summary>
    /// Function to decrypt a given text that was encrypted using the EncryptText function.
    /// Each character is shifted back by the value of the EncryptionKey.
    /// </summary>
    /// <param name="Text">The encrypted text to be decrypted.</param>
    /// <param name="EncryptionKey">The key used to decrypt the text.</param>
    /// <returns>The decrypted text.</returns>
    string DecryptText(string Text, short EncryptionKey)
    {
        for (int i = 0; i <= Text.length(); i++)
        {
            Text[i] = char((int)Text[i] - EncryptionKey);
        }
        return Text;
    }

    //
    /// <summary>
    /// Function to generate a random number within a specified range [From, To].
    /// </summary>
    /// <param name="From">The lower bound of the range.</param>
    /// <param name="To">The upper bound of the range.</param>
    /// <returns>A random integer between From and To, inclusive.</returns>
    int RandomNumber(int From, int To)
    {
        //Function to generate a random number
        int randNum = rand() % (To - From + 1) + From;
        return randNum;
    }


}