using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
	[TestFixture]
	public class NumberConverterTest
	{

		[Test]
		public void ItShouldConvertOneIntoI()
		{
			Assert.AreEqual(NumberConverter.Convert(1), "I");
		}
		
		[Test]
		public void ItShouldConvertTwoIntoII()
		{
			Assert.AreEqual(NumberConverter.Convert(2), "II");
		}

		[Test]
		public void ItShouldConvertThreeIntoIII()
		{
			Assert.AreEqual(NumberConverter.Convert(3), "III");
		}

		[Test]
		public void ItShouldConvertFourIntoIV()
		{
			Assert.AreEqual(NumberConverter.Convert(4), "IV");
		}

		[Test]
		public void ItShouldConvertFiveIntoV()
		{
			Assert.AreEqual(NumberConverter.Convert(5), "V");
		}

		[Test]
		public void ItShouldConvertSixIntoVI()
		{
			Assert.AreEqual(NumberConverter.Convert(6), "VI");
		}

		[Test]
		public void ItShouldConvertSevenIntoVII()
		{
			Assert.AreEqual(NumberConverter.Convert(7), "VII");
		}

		[Test]
		public void ItShouldConvertEightIntoVIII()
		{
			Assert.AreEqual(NumberConverter.Convert(8), "VIII");
		}

		[Test]
		public void ItShouldConvertNineIntoIX()
		{
			Assert.AreEqual(NumberConverter.Convert(9), "IX");
		}

		[Test]
		public void ItShouldConvertTenIntoX()
		{
			Assert.AreEqual(NumberConverter.Convert(10), "X");
		}

		[Test]
		public void ItShouldConvertFIftyIntoL()
		{
			Assert.AreEqual(NumberConverter.Convert(50), "L");
		}

		[Test]
		public void ItShouldConvertOneThousandIntoM()
		{
			Assert.AreEqual(NumberConverter.Convert(1000), "M");
		}

		[Test]
		public void ItShouldConvertfFiveThousandIntoVM()
		{
			Assert.AreEqual(NumberConverter.Convert(3000), "MMM");
		}
	}
}