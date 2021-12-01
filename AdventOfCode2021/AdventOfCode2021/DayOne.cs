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
        if(depthList[i] > depth)
        {
          measurmentResult++;
        }
        depth = depthList[i];
      }

      return measurmentResult;
    }
  }
}
