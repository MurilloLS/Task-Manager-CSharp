namespace DayThree.TaskContext
{
  public class Task
  {
    public string Description { get; set; }
    public bool IsHighPriority { get; set; }

    public Task(string description, bool isHighPriority)
    {
      Description = description;
      IsHighPriority = isHighPriority;
    }

    public override string ToString()
    {
      return $"{Description} (Priority: {(IsHighPriority ? "High" : "Normal")})";
    }
  }
}