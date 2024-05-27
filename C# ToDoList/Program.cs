//Following this tutorial => https://youtu.be/_jMyX1FnTys?si=CaT_SAAnAL6kdr0x

namespace C__ToDoList
{
    //Remove internal from the class name!
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To Do List program!");
            List<string> taskList = new List<string>();
            string option = "";

            while (option.ToLower() != "x")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Please select...\n\n1) Add Task\n2) Remove Task\n3) View List\nX) Exit\n\n");

                option = Console.ReadLine();
                Console.Clear();

                if (option == "1")
                {
                    Console.WriteLine("Please enter the name of the task to add to the list.\n");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("\nTask Added to To Do List!\n");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
                else if (option == "2")
                {
                    Console.WriteLine("To Do List :\n\n");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " - " + taskList[i] + "\n");
                    }

                    Console.WriteLine("Please enter the number of the task to remove from the list.\n");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());

                    taskList.RemoveAt(taskNumber);
                    Console.WriteLine("\nTask Removed from To Do List!\n");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
                else if (option == "3")
                {
                    Console.WriteLine("To Do List :\n\n");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{taskList[i]}\n");
                    }
                    Console.WriteLine("Press any key to return to main menu...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option.ToLower() == "x")
                {
                    Console.WriteLine("Exiting To Do List");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            }

            Console.WriteLine("Thank you for using the To Do List program!");
        }
    }
}
