using System;
using System.Linq;
using TestArray.Entities;

namespace TestArray
{
	public static class Program
	{
		private const int NumbersCount = 20;
		private const int ValueLengthStart = 1;
		private const int ValueLengthEnd = 5;
		private static readonly Random Random = new();

		public static void Main()
		{
			var array = Enumerable.Range(0, NumbersCount)
				.Select(_ => new Item
				{
					Number = Random.Next(10),
					Value = new string('x', Random.Next(ValueLengthStart, ValueLengthEnd + 1))
				})
				.ToArray();

			array = array.OrderBy(x => x.Number).ToArray();

			Console.WriteLine(string.Join(", ", array.Select(i => $"{i.Number} - {i.Value}")));

			Console.ReadKey();
		}
	}
}