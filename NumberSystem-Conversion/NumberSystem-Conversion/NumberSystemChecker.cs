using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystem_Conversion
{

	/// <summary>
	/// class for number system checker
	/// </summary>
	public class NumberSystemChecker
	{

		public bool BinaryChecker(string input)
		{
			foreach (char c in input)
			{
				if (c != '0' && c != '1')
				{
					return false;
				}
			}
			return true;
		}
		public bool OctalChecker(string input)
		{
			foreach (char c in input)
			{
				if (c < '0' || c > '7')
				{
					return false;
				}
			}
			return true;
		}
		public bool DecimalChecker(string input)
		{
			foreach (char c in input)
			{
				if (!char.IsDigit(c))
				{
					return false;
				}
			}
			return true;
		}
		public bool HexadecimalChecker(string input)
		{
			foreach (char c in input)
			{
				if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
				{
					return false; 
				}
			}
			return true;

		}
	}
}
