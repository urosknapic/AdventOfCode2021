using AdventOfCode2021;
using NUnit.Framework;
using System.Collections.Generic;

namespace AdventOfCode2021Tests
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DayOne_WhenListOfDepthsEmpty_ReturnZero()
    {
      // Arrange
      var emptyDepthList = new List<int>();
      var dayOne = new DayOne();

      // Act
      var result = dayOne.GetLargerMeasurments(emptyDepthList);
      
      // Assert
      Assert.AreEqual(result, 0);
    }

    [Test]
    public void DayOne_WhenListOfdepthsWithSingleElement_ReturnZero()
    {
      var emptyDepthList = new List<int>() { 123 };
      var dayOne = new DayOne();

      var result = dayOne.GetLargerMeasurments(emptyDepthList);

      Assert.AreEqual(result, 0);
    }

    [Test]
    public void DayOne_WhenListOfdepthsWithTwoElementsAsc_ReturnOne()
    {
      var emptyDepthList = new List<int>() { 123, 125};
      var dayOne = new DayOne();

      var result = dayOne.GetLargerMeasurments(emptyDepthList);

      Assert.AreEqual(result, 1);
    }
  }
}