namespace AdventOfCode2021
{
  public class DayTwo_PartTwo : DayTwo
  {
    public override int GetSubmarinePosition(List<string> commands)
    {
      /*
          "forward 5",
          "down 5",
          "forward 8",
          "up 3",
          "down 8",
          "forward 2"
       */
      var horizontalPosition = 0;
      var depthPosition = 0;
      var aim = 0;

      foreach (var command in commands)
      {
        var direction = command.Split(" ")[0];
        var units = int.Parse(command.Split(" ")[1]);

        if (direction == "forward")
        {
          horizontalPosition += units;
          depthPosition += aim * units;
        }

        if (direction == "down")
          aim += units;

        if (direction == "up")
          aim -= units;
      }
      return horizontalPosition * depthPosition;
    }
  }
}
