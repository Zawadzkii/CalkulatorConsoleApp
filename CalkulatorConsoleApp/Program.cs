using System.Diagnostics;

namespace KalkulatorCnsollApp
{
	class Program
	{
		static void Main(string[] args)
		{

			// 1.  Displaying some header, Description of our application
			Console.WriteLine("Welcome to the Calculator App !");

			// 2. Request for the first Number

			Console.WriteLine("Please enter the First Number");

			// 3. Retrieving Numbers from the user

			var number1 = int.Parse(Console.ReadLine());

			// 4.Request for Activities

			Console.WriteLine("What operation do you want to perform? Possible Operations This: +, - , *, /, . ");

			// 5. Retrieving the Selected Action from the user

			var operacion = Console.ReadLine();

			// 6. Request for the second number from the user

			Console.WriteLine("Please Enter Second Number ");

			// 7. Retrieving Numbers from the user

			var number2 = int.Parse(Console.ReadLine());

			var result = 0;

			// 8. Performing Calculations

			switch (operacion)



			{
				case "+":
					result = number1 + number2;
					break;

				case "-":
					result = number1 - number2;
					break;

				case "*":
					result = number1 * number2;
					break;

				case "/":
					result = number1 / number2;
					break;

					throw new Exception("you chose the wrong surgery");
			}

			// 9. Displaying the Result to the user 
			Console.WriteLine($"The result of your action This: {result}.");

		}
	}
}