using System;

namespace Homework
{
	public class Homework1
	{
		// Task 1

		int input = Int32.Parse(Console.ReadLine());
		int[] numbers = new int[0];

		for (int i = 1; i <= input; i++)
		{
			int newInput = Int32.Parse(Console.ReadLine());
			numbers.Add(newInput);
		}

		int[] evens = new int[0];
		foreach (int number in numbers)
		{
			if(number % 2 == 0)
				{
					evens.Add(number);
				}
		}
		Console.WriteLine(evens);

		// Task 2

		int inputn = Int32.Parse(Console.ReadLine());
		int inputm = Int32.Parse(Console.ReadLine());
		int[] newNumbers = new int[0];
		int[] divisibles = new int[0];

		for (int i = 1; i <= inputn; i++)
		{
			int newInput = Int32.Parse(Console.ReadLine());
			newNumbers.Add(newInput);
		}

		foreach (int number in newNumbers)
		{
			if(number % inputm == 0)
			{
				divisibles.Add(number);
			}
		}
		Console.WriteLine(divisibles);
		
		// Task 3
		int input3 = Int32.Parse(Console.ReadLine());
		string[] words = new string[0];

		for (int i = 1; i <= input3; i++)
		{
			string word = Console.ReadLine();
			words.Add(word);
		}
		Console.WriteLine(Array.Reverse(words));

		// Task 4
		string sentence = Console.ReadLine();
		int wordNumber = sentence.Split(" ".Length);
		int letterNumber = 0;
		foreach (char letter in sentence)
		{
			if (letter != " ")
			{
				letterNumber++;
			}
		}
		Console.WriteLine(wordNumber);
		Console.WriteLine(letterNumber);
	}
}
