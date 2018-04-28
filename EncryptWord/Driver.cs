﻿// AUTHOR: Luke Korsman
// FILENAME: Driver.cs
// DATE: 26Apr2018
// VERSION: 1

using System;
using encryption;

namespace DriverFile
{
    public class Driver
    {
        public static string testObjectInitialState()
        {
            encryption.encryptWord initialState = new encryptWord();
            return initialState.DisplayGuessStatistics();
        }

        public static string testEncryptEndOfAlphabet()
        {
            encryption.encryptWord alphabetTest = new encryptWord();
            string testWord = "xxyyzz";

            return alphabetTest.Encrypt(testWord);
        }

        public static string testLessThan4CharInputWord()
        {
            encryption.encryptWord wordLength = new encryptWord();
            return wordLength.Encrypt("abc");
        }

        public static string testZeroCharInputWord()
        {
            encryption.encryptWord wordLength = new encryptWord();
            return wordLength.Encrypt("");
        }

        public static string testLowGuessValue()
        {
            encryption.encryptWord lowGuess = new encryptWord();
            lowGuess.GuessShiftValue(0);
            return lowGuess.DisplayGuessStatistics();
        }
    }
}
