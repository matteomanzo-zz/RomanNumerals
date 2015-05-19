using NUnit.Framework;
using System;

namespace RomanNumerals2
{
	[TestFixture ()]
	public class NumberConverterTest
	{
		RomanNumerals2.NumberConverter number;

		[SetUp]
		public void init()
		{
			number = new RomanNumerals2.NumberConverter();
		}

		[Test]
		public void ItShouldConvertOneIntoI()
		{
			Assert.AreEqual(number.Convert(1), "I");
		}

		[Test]
		public void ItShouldConvertTwoIntoII()
		{
			Assert.AreEqual(number.Convert(2), "II");
		}

		[Test]
		public void ItShouldConvertThreeIntoIII()
		{
			Assert.AreEqual(number.Convert(3), "III");
		}

		[Test]
		public void ItShouldConvertFourIntoIV()
		{
			Assert.AreEqual(number.Convert(4), "IV");
		}

		[Test]
		public void ItShouldConvertFiveIntoV()
		{
			Assert.AreEqual(number.Convert(5), "V");
		}

		[Test]
		public void ItShouldConvertSixIntoVI()
		{
			Assert.AreEqual(number.Convert(6), "VI");
		}

		[Test]
		public void ItShouldConvertSevenIntoVII()
		{
			Assert.AreEqual(number.Convert(7), "VII");
		}

		[Test]
		public void ItShouldConvertEightIntoVIII()
		{
			Assert.AreEqual(number.Convert(8), "VIII");
		}

		[Test]
		public void ItShouldConvertNineIntoIX()
		{
			Assert.AreEqual(number.Convert(9), "IX");
		}

		[Test]
		public void ItShouldConvertTenIntoX()
		{
			Assert.AreEqual(number.Convert(10), "X");
		}

		[Test]
		public void ItShouldConvertFIftyIntoL()
		{
			Assert.AreEqual(number.Convert(50), "L");
		}

		[Test]
		public void ItShouldConvertOneThousandIntoM()
		{
			Assert.AreEqual(number.Convert(1000), "M");
		}
	}
}

