using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystem_Conversion
{

	/// <summary>
	/// Unrefactored code for converting number systems
	/// </summary>
	public class NumberSystemConversion
	{
		public static void Conversion()
		{
			var check = new NumberSystemChecker();
			while (true)
			{
				string input, output = "";

				Console.WriteLine("\nNUMBER SYSTEM CONVERSION\n");
				Console.WriteLine("B = Binary");
				Console.WriteLine("O = Octal");
				Console.WriteLine("D = Decimal");
				Console.WriteLine("H = Hexadecimal");
				Console.WriteLine("");
				Console.Write("Enter chosen letter: ");
				char letterChosen = Console.ReadKey().KeyChar;
				Console.WriteLine("");


				if (letterChosen != 'B' && letterChosen != 'O' && letterChosen != 'D' && letterChosen != 'H')
				{
					Console.Write("Please choose valid Number System!");
					continue;
				}

				if (letterChosen == 'B') Console.Write("Binary ");
				else if (letterChosen == 'O') Console.Write("Octal ");
				else if (letterChosen == 'D') Console.Write("Decimal ");
				else if (letterChosen == 'H') Console.Write("Hexadecimal ");
				Console.Write("convert to ");
				ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
				char letterToConvertTo = keyInfo.KeyChar;


				if (letterToConvertTo == letterChosen)
				{
					Console.WriteLine("Please choose a number system that is not the same as the chosen number system to convert.");
					continue;
				}
				if (letterToConvertTo == 'B')
				{
					Console.WriteLine("Binary\n");
					Console.Write("Input: ");
					input = Console.ReadLine();
					if (letterChosen == 'D') //Decimal to Binary
					{
						if(check.DecimalChecker(input)== true) //check if input is decimal
						{
							output = Convert.ToString(int.Parse(input), 2);
						}
						else
						{
							Console.WriteLine("Invalid input.");
							break;
						}
					}
					else if (letterChosen == 'O') //Octal to Binary
					{
						if (check.OctalChecker(input) == true) //check if input is octal
						{
							output = Convert.ToString(Convert.ToInt32(input, 8), 2);
						}
						else
						{
							Console.WriteLine("Invalid input.");
							break;
						}
					}
					else if (letterChosen == 'H') //Hexadecimal to Binary
					{
						if (check.HexadecimalChecker(input) == true) //check if input is hexadecimal
						{
							output = Convert.ToString(Convert.ToInt32(input, 16), 2);
						}
						else
						{
							Console.WriteLine("Invalid input.");
							break;
						}
					}
				}
				else if (letterToConvertTo == 'O')
				{
					Console.WriteLine("Octal\n");
					Console.Write("Input: ");
					input = Console.ReadLine();

					if (letterChosen == 'D') //Decimal to Octal
					{
						if (check.DecimalChecker(input) == true) //check if input is decimal
						{
							output = Convert.ToString(int.Parse(input), 8);
						}
						else
						{
							Console.WriteLine("Invalid input.");
							break;
						}
					}
					else if (letterChosen == 'B') //Binary to Octal
					{
						if (check.BinaryChecker(input) == true) //check if input is binary
						{
							output = Convert.ToString(Convert.ToInt32(input, 2), 8);
						}
						else
						{
							Console.WriteLine("Invalid input.");
							break;
						}
					}
					else if (letterChosen == 'H') //Hexadecimal to Octal
					{
						if (check.HexadecimalChecker(input) == true) //check if input is hexadecimal
						{
							output = Convert.ToString(Convert.ToInt32(input, 16), 8);
						}
						else
						{
							Console.WriteLine("Invalid input.");
							break;
						}
					}
				}
				else if (letterToConvertTo == 'D')
				{
					Console.WriteLine("Decimal\n");
					Console.Write("Input: ");
					input = Console.ReadLine();
					if (letterChosen == 'B') // Binary to Decimal
					{
						if (check.BinaryChecker(input) == true) //check if input is binary
						{
							output = Convert.ToInt32(input, 2).ToString();
						}
						else
						{
							Console.WriteLine("Invalid input.");
							break;
						}
					}
					else if (letterChosen == 'O') // Octal to Decimal
					{
						if (check.OctalChecker(input) == true) //check if input is octal
						{
							output = Convert.ToInt32(input, 8).ToString();
						}
						else
						{
							Console.WriteLine("Invalid input.");
							break;
						}
					}
					else if (letterChosen == 'H') // Hexadecimal to Decimal
					{
						if (check.HexadecimalChecker(input) == true) //check if input is hexadecimal
						{
							output = Convert.ToInt32(input, 16).ToString();
						}
						else
						{
							Console.WriteLine("Invalid input.");
							break;
						}
					}
				}
				else if (letterToConvertTo == 'H')
				{
					Console.WriteLine("Hexadecimal\n");
					Console.Write("Input: ");
					input = Console.ReadLine();

					if (letterChosen == 'D') //Decimal to Hexadecimal
					{
						if (check.DecimalChecker(input) == true) //check if input is decimal
						{
							output = Convert.ToInt32(input).ToString("X");
						}
						else
						{
							Console.WriteLine("Invalid input.");
							break;
						}
					}
					else if (letterChosen == 'O') //Octal to Hexadecimal
					{
						if (check.OctalChecker(input) == true) //check if input is octal
						{
							output = Convert.ToInt32(input, 8).ToString("X");
						}
						else
						{
							Console.WriteLine("Invalid input.");
							break;
						}
					}
					else if (letterChosen == 'B') //Binary to Hexadecimal
					{
						if (check.BinaryChecker(input) == true) //check if input is binary
						{
							output = (Convert.ToInt32(input, 2)).ToString("X");
						}
						else
						{
							Console.WriteLine("Invalid input.");
							break;
						}
					}
				}
				else Console.WriteLine("\nPlease choose valid Number System!");

				Console.WriteLine($"Output: {output}");

				Console.Write("\nConvert again (C) or Exit (E)? ");
				char choice = Console.ReadKey().KeyChar;
				if (choice == 'E')
				{
					break;
				}
				else if (choice != 'C' && choice != 'E')
				{
					Console.WriteLine("\nInvalid choice. Exiting program...\n");
					break;
				}
			}

		}
	}
}
