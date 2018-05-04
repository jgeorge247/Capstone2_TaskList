using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2_TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create my list
            List<Task> TaskList = new List<Task>();
            TaskList.Add(new Task("Mike", "Run", new DateTime(2018, 5, 24)));
            TaskList.Add(new Task("Tom", "Bike", new DateTime(2018,5,24)));
            TaskList.Add(new Task("Steph", "Laugh", new DateTime(2018, 5, 24)));
            TaskList.Add(new Task("Larry", "Breathe", new DateTime(2018, 5, 24)));
            TaskList.Add(new Task("Joe", "Try", new DateTime(2018, 5, 24)));

            Console.WriteLine("Welcome to the Task Manager!");
            Menu();

            Console.WriteLine("Enter an option between 1-5: ");
            string Response = Console.ReadLine();
            int NumResponse;
            bool valid = int.TryParse(Response, out NumResponse);
            while (!valid)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Response = Console.ReadLine();
                valid = int.TryParse(Response, out NumResponse);
            }
            while (NumResponse != 5)
            {

                if (NumResponse == 1)
                {
                    string Bk2menu = "N";
                    while (Bk2menu == "N")
                    {
                        Console.WriteLine("Task Lists");
                        //List tasks
                        foreach (Task t in TaskList)
                        {
                            Console.WriteLine($"User: {t.TaskOwner}");
                            Console.WriteLine($"Description: {t.TaskName}");
                            Console.WriteLine($"Due Date: {t.DueDate}");
                            Console.WriteLine($"Completed?: {t.Completed}\n");
                        }

                        Console.WriteLine("Back to the main menu. (Y/N)");
                        Bk2menu = Console.ReadLine().ToUpper();

                    }
                    Menu();
                    Console.WriteLine("Enter an option between 1-5: ");
                    Response = Console.ReadLine();
                    valid = int.TryParse(Response, out NumResponse);

                }
                else if (NumResponse == 2)
                {
                    string Bk2menu = "N";
                    while (Bk2menu == "N")
                    {
                        Console.WriteLine("Add a task: ");
                        Console.WriteLine("Enter user");
                        string input1 = Console.ReadLine();
                        Console.WriteLine("Enter task");
                        string input2 = Console.ReadLine();
                        Console.WriteLine("Enter due date");
                        string input3 = Console.ReadLine();

                        DateTime NewDate;
                        bool validDate = DateTime.TryParse(input3, out NewDate);
                        while (!validDate)
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            input3 = Console.ReadLine();
                            validDate = DateTime.TryParse(input3, out NewDate);
                        }

                        TaskList.Add(new Task(input1, input2, NewDate));
                        Console.WriteLine("Task created!");

                        Console.WriteLine("Back to the main menu. (Y/N)");
                        Bk2menu = Console.ReadLine().ToUpper();
                    }
                    Menu();
                    Console.WriteLine("Enter an option between 1-5: ");
                    Response = Console.ReadLine();
                    valid = int.TryParse(Response, out NumResponse);
                }
                else if (NumResponse == 3)
                {
                    string Bk2menu = "N";
                    while (Bk2menu == "N")
                    {
                        Console.WriteLine("Delete Task");
                        Console.WriteLine($"Which task would you like to delete? (1-{TaskList.Count})");
                        string DeleteTask = Console.ReadLine();

                        //validate that it's within bounds
                        int DeleteNumber;
                        bool ValidDelete = int.TryParse(DeleteTask, out DeleteNumber);
                        while (!ValidDelete || DeleteNumber < 0 || DeleteNumber > TaskList.Count)
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            DeleteTask = Console.ReadLine();
                            ValidDelete = int.TryParse(DeleteTask, out DeleteNumber);
                        }

                        TaskList.RemoveAt(DeleteNumber - 1);
                        Console.WriteLine("Congrats! Task deleted!");

                        Console.WriteLine("Back to the main menu. (Y/N)");
                        Bk2menu = Console.ReadLine().ToUpper();
                    }
                    Menu();
                    Console.WriteLine("Enter an option between 1-5: ");
                    Response = Console.ReadLine();
                    valid = int.TryParse(Response, out NumResponse);
                }
                else if (NumResponse == 4)
                {
                    string Bk2menu = "N";
                    while (Bk2menu == "N")
                    {
                        Console.WriteLine("Mark task complete! (Almost there, buddy)");
                        Console.WriteLine($"Which task would you like to complete? 1-{TaskList.Count})");
                        string TaskComplete = Console.ReadLine();

                        //validate that it's within bounds
                        int CompleteNum;
                        bool Completed = int.TryParse(TaskComplete, out CompleteNum);
                        while (!Completed || CompleteNum < 0 || CompleteNum > TaskList.Count)
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            TaskComplete = Console.ReadLine();
                            Completed = int.TryParse(TaskComplete, out CompleteNum);
                        }
                        TaskList[CompleteNum - 1].Completed = true;
                        Console.WriteLine("Task marked completed!");

                        Console.WriteLine("Back to the main menu. (Y/N)");
                        Bk2menu = Console.ReadLine().ToUpper();
                    }
                    Menu();
                    Console.WriteLine("Enter an option between 1-5: ");
                    Response = Console.ReadLine();
                    valid = int.TryParse(Response, out NumResponse);
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("\n1. List tasks");
            Console.WriteLine("2. Add task");
            Console.WriteLine("3. Delete task");
            Console.WriteLine("4. Mark task complete");
            Console.WriteLine("5. Quit");
        }
    }
}
