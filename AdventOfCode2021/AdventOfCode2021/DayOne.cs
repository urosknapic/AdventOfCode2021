namespace AdventOfCode2021
{
  public class DayOne
  {
    public int GetLargerMeasurments(List<int> depthList)
    {
      var measurmentResult = 0;
      if (depthList == null || depthList.Count == 0)
      {
        return measurmentResult;
      }

      var depth = depthList[0];

      for (var i = 1; i < depthList.Count; i++)
      {
        if (depthList[i] > depth)
        {
          measurmentResult++;
        }
        depth = depthList[i];
      }

      return measurmentResult;
    }

    public int GetLargerMeasurmentsByThree(List<int> depthList)
    {
      var measurmentResult = 0;
      if (depthList == null || depthList.Count == 0 || depthList.Count <= 2)
      {
        return measurmentResult;
      }

      var depthOne = depthList[0];
      var depthTwo = depthList[1];
      var depthThree = depthList[2];
      var sumDepth = depthOne + depthTwo + depthThree;

      for (var i = 3; i < depthList.Count; i++)
      {
        if (GetSumOfDepths(depthList, i) > sumDepth)
        {
          measurmentResult++;
        }
        sumDepth = GetSumOfDepths(depthList, i);
      }

      return measurmentResult;
    }

    private int GetSumOfDepths(List<int> depthList, int index)
    {
      return depthList[index - 2] + depthList[index - 1] + depthList[index];
    }
  }
}
