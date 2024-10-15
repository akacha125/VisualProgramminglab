/*exercise 1
using System;

class Program
{
    static void Main()
    {
        // Initialize a 2D array of integers
        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


        Print2DArray(array);
    }

    static void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {

                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/
/* Exercise 2
using System;

class Program
{
    static void Main()
    {
        string[] strings = { "hello", "and", "welcome", "to", "this", "Task!" };

        string mergedString = Merger(strings);

        Console.WriteLine(mergedString);
    }

    static string Merger(string[] strings)
    {
        string mergedString = "";

        foreach (string str in strings)
        {
            mergedString += str + " ";
        }

        return mergedString.Trim();
    }
}*/
/* Exercise 3
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputString = "This is a sample sentence with words of different lengths.";

        string[] extractedWords = ExtractWords(inputString);

        foreach (string word in extractedWords)
        {
            Console.WriteLine(word);
        }
    }

    static string[] ExtractWords(string inputString)
    {
        string[] words = inputString.Split(' ');

        List<string> extractedWordsList = new List<string>();

        foreach (string word in words)
        {

            if (word.Length >= 4 && word.Length <= 5)
            {

                if (ContainsVowels(word))
                {
                    extractedWordsList.Add(word);
                }
            }
        }

        return extractedWordsList.ToArray();
    }

    static bool ContainsVowels(string word)
    {

        return word.Any(char.IsLower);
    }
}
*/


// Exercise 04
/*
using System;

class Program
{
    static void Main()
    {
        int[] ratings = { 3, 4, 2, 1, 5, 4, 3, 2, 3, 4, 5, 4, 3, 2, 1, 4, 3, 2, 3, 4, 5, 4, 3, 2, 1, 4, 3, 2, 3, 4, 5, 4, 3, 2, 1, 4, 3, 2, 3, 4 };

        int[] frequency = new int[5];

        foreach (int rating in ratings)
        {
            frequency[rating - 1]++;
        }

        for (int i = 0; i < frequency.Length; i++)
        {
            Console.WriteLine($"Response {i + 1} given by: {frequency[i]} people");
        }
    }
}
*/
/* exercise 5
 using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary equivalent: " + DecimalToBinary(decimalNumber));

        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();

        Console.WriteLine("Decimal equivalent: " + BinaryToDecimal(binaryNumber));
    }

    static string DecimalToBinary(int decimalNumber)
    {
        string binaryNumber = "";

        while (decimalNumber > 0)
        {
            binaryNumber = (decimalNumber % 2) + binaryNumber;
            decimalNumber /= 2;
        }

        return binaryNumber;
    }

    static int BinaryToDecimal(string binaryNumber)
    {
        int decimalNumber = 0;
        int power = 0;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            decimalNumber += (binaryNumber[i] - '0') * (int)Math.Pow(2, power);
            power++;
        }

        return decimalNumber;
    }
}*/

/* exercise  6
 using System;

class Program
{
    static void Main()
    {
        // Create a rectangular array to store test marks
        int[,] testMarks = new int[5, 10];

        // Populate the array with sample test marks
        testMarks[0, 0] = 92;
        testMarks[0, 1] = 73;
        // ... (fill the rest of the array)

        // Print the test marks in a formatted table
        Console.WriteLine("Test 1\tTest 2\tTest 3\tTest 4\tTest 5\tAverage");
        for (int i = 0; i < 5; i++)
        {
            int sum = 0;
            for (int j = 0; j < 10; j++)
            {
                Console.Write("{0,4}\t", testMarks[i, j]); // Format the output with 4 spaces
                sum += testMarks[i, j];
            }
            Console.WriteLine("{0,4}", (double)sum / 10); // Format the average with 4 spaces
        }
    }
}*/
/*  Exercise 7
 using System;

class Program
{
    static void Main()
    {
        int[,] matrixA = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] matrixB = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

        int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

        PrintMatrix(resultMatrix);
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);

        int[,] resultMatrix = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                for (int k = 0; k < colsA; k++)
                {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return resultMatrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}*/
 


