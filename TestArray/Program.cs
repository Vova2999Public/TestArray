using System;
using System.Linq;
using TestArray.Entities;
using TestArray.Extensions;

namespace TestArray
{
	public static class Program
	{
		private const int NumbersCount = 20;
		private const int NumbersStart = 0;
		private const int NumbersEnd = 99;
		private const int ValueLengthStart = 1;
		private const int ValueLengthEnd = 5;
		private static readonly Random Random = new();

		public static void Main()
		{
			var array = Enumerable.Range(0, NumbersCount)
				.Select(_ => new Item
				{
					Number = Random.Next(NumbersStart, NumbersEnd + 1),
					Value = new string('x', Random.Next(ValueLengthStart, ValueLengthEnd + 1))
				})
				.ToArray();

			array = array.OrderBy(x => x.Number).ToArray();

			array.Select((value, index) => $"{index,2}: {i.Number,2} - {i.Value}").ForEach(Console.WriteLine);

			Console.ReadKey();
		}
	}
}