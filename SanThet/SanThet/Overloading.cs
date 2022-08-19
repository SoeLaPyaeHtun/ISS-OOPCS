using System;
namespace SanThet
{
	public class Overloading
	{
		public int numberOne;
		public int numberTwo;


		public Overloading()
		{
			numberOne = 9;
			numberTwo = 7;
		}

		public Overloading(int n, int m)
        {
			this.numberOne = n;
			this.numberTwo = m;
        }

		public int GetSum()
        {
			return numberOne + numberTwo;
        }

		public long Add(int a, int b)
        {
			return a + b;
        }

		public string Add(string a, string b)
        {
			return a + b;
        }
	}
}

