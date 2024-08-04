using DayThree.TaskContext;

namespace DayThree
{
  static class Program
  {
    static void Main()
    {
      TaskManager taskManager = new TaskManager();

      while (true)
      {
        Console.WriteLine("\nTask Manager");
        Console.WriteLine("1. Add Task");
        Console.WriteLine("2. Process Task");
        Console.WriteLine("3. View Tasks");
        Console.WriteLine("4. Exit");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            System.Console.WriteLine();
            Console.Write("Enter task description: ");
            string description = Console.ReadLine();
            Console.Write("Is this a high-priority task? (yes/no): ");
            string priorityInput = Console.ReadLine();
            bool isHighPriority = priorityInput?.ToLower() == "yes";
            taskManager.AddTask(description, isHighPriority);
            break;

          case "2":
            System.Console.WriteLine();
            taskManager.ProcessTask();
            break;

          case "3":
            System.Console.WriteLine();
            taskManager.ViewTasks();
            break;

          case "4":
            System.Console.WriteLine();
            return;

          default:
            System.Console.WriteLine();
            Console.WriteLine("Invalid option. Please try again.");
            break;
        }
      }
    }
  }
}