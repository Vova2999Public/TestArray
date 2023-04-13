using System;
using System.Linq;

namespace TestArray
{
	public static class Program
	{
		private const int NumbersCount = 20;
		private const int NumbersStart = 0;
		private const int NumbersEnd = 99;
		private static readonly Random Random = new();

		public static void Main()
		{
			var array = Enumerable.Range(0, NumbersCount)
				.Select(_ => Random.Next(NumbersStart, NumbersEnd + 1))
				.ToArray();

			array = array.OrderBy(x => x).ToArray();

			Console.WriteLine(string.Join(", ", array));

			Console.ReadKey();
		}
	}
}
