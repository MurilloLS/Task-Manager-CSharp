namespace DayThree.TaskContext
{
  public class TaskManager
  {
    private readonly Stack<Task> highPriorityTasks = new Stack<Task>();
    private readonly Queue<Task> normalPriorityTasks = new Queue<Task>();

    public void AddTask(string description, bool isHighPriority)
    {
      Task newTask = new Task(description, isHighPriority);
      if (isHighPriority)
      {
        highPriorityTasks.Push(newTask);
      }
      else
      {
        normalPriorityTasks.Enqueue(newTask);
      }
      Console.WriteLine($"Added: {newTask}");
    }

    public void ProcessTask()
    {
      if (highPriorityTasks.Count > 0)
      {
        Task task = highPriorityTasks.Pop();
        Console.WriteLine($"Processed High-Priority Task: {task}");
      }
      else if (normalPriorityTasks.Count > 0)
      {
        Task task = normalPriorityTasks.Dequeue();
        Console.WriteLine($"Processed Normal-Priority Task: {task}");
      }
      else
      {
        Console.WriteLine("No tasks to process.");
      }
    }

    public void ViewTasks()
    {
      Console.WriteLine("High-Priority Tasks:");
      foreach (Task task in highPriorityTasks)
      {
        Console.WriteLine(task);
      }

      Console.WriteLine("\nNormal-Priority Tasks:");
      foreach (Task task in normalPriorityTasks)
      {
        Console.WriteLine(task);
      }
    }
  }
}