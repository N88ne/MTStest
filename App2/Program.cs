using System;
using System.Globalization;

class Program
{
	static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

	class Number
	{
		readonly int _number;

		public Number(int number)
		{
			_number = number;
		}

		public override string ToString()
		{
			return _number.ToString(_ifp);
		}
		//Здесь моё решение - это переписать оператор "+"
		public static string operator +(Number num1, string str2)
		{

			return (num1._number + int.Parse(str2)).ToString();
		}
	}

	static void Main(string[] args)
	{
		int someValue1 = 15;
		int someValue2 = 5;

		string result = new Number(someValue1) + someValue2.ToString(_ifp);
		Console.WriteLine(result);
		Console.ReadKey();
	}
}
