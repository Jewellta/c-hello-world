using System;

namespace HelloWorldProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World in C#!");
			Console.WriteLine("C# written by Tyler Jewell");
			var counter = 0;
			Console.WriteLine(counter);
			counter = counter + 13;
			Console.WriteLine(counter);
			counter = counter - 3;
			Console.WriteLine(counter);
			counter = counter * 5;
			Console.WriteLine(counter);
			counter = counter /7;
			Console.WriteLine(counter);

			var numerator = 10.0;
			var denominator = 3.0;
			var answer = numerator / denominator;
			Console.WriteLine(answer);

			var module = 10 % 3;
			Console.WriteLine(module);

			var firstname = "Tyler";
			var lastname = "Jewell";
			var fullname = firstname +" "+ lastname;
			fullname = $"first name is {firstname}, and lastname is {lastname}";
			Console.WriteLine(fullname);
			fullname = fullname.ToUpper();
			Console.WriteLine(fullname);
			var biggerScopeVariable = 77;
			{
				var scopeVariable = 1;
				Console.WriteLine(scopeVariable);
			}
			biggerScopeVariable = biggerScopeVariable + 1;

			bool oneEqualsOne = 1 == 1;
			Console.WriteLine(oneEqualsOne);

			int[] assesmentScores = new int[2];
			assesmentScores[0] = 120;
			assesmentScores[1] = 95;
			Console.WriteLine ($"index 0 is {assesmentScores[0]} index 1 is {assesmentScores[1]}");

			string[] longString = new string[5];
			longString[0] = "Git / Github";
			longString[1] = "SQL";
			longString[2] = "C#";
			longString[3] = "Javascript";
			longString[4] = "Angular";

		}
	}
}
