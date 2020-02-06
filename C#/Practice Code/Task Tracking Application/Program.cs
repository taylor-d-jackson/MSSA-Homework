using System;
using System.Collections.Generic;
using System.IO;

namespace _4DayProject
{
    class Program
        //Console Application c
        //Task-Tracking application c
        //Hilight the selected item, use Reverse Video
        //Cross-out: Dark grey text
        //First item is always first unactioned item 
        //Every other other actioned item is kept and displayed
        //Newly added items to the end of the list c
        //items should be saved/persistent in a text file w/ hard coded name c
        //can assume that what user types in is what they want c
        //dont have to worry about exception handling c
        //Give the user the option to add tasks at any time 
        //Pagination, max 20 items/page
        //MArk Forster - Simple Scanning
        //Add task c
        //skip task
        //action item - can finish/mark off or re-enter
    {
        static void Main(string[] args)
        {

            List<string> taskList = new List<string>();
            
            String line;

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                
                StreamReader sr = new StreamReader("C:\\Users\\Rebelde\\source\\repos\\4DayProject\\4DayProject\\bin\\Debug\\netcoreapp3.1\\SavedList.txt");


                line = "";
                
                //Continue to read until you reach end of file
                
                while ((line = sr.ReadLine()) != null)
                {
                    taskList.Add(line);
                }

                //close the file
                
                sr.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Previous list Loaded.");
            }



            bool exitProgram = false;
            do
            {
                Console.WriteLine("To Display your current tasks Type: t \nTo Add a NEW task Type: n\nTo Exit Type: e");
                
                var operationTODO = Console.ReadKey().KeyChar;
                
                Console.Clear();

                if (operationTODO == 't')
                {
                    DisplayTaskList(taskList);
                }
                if (operationTODO == 'n')
                {
                    AddTask(taskList);
                }
                if (operationTODO == 'e')
                {
                    exitProgram = true;
                    
                    SaveList(taskList);
                }
            } while (exitProgram == false);


            
            
            
            
            


        }

        

        private static List<string> SaveList(List<string> taskList)
        {
            TextWriter savedList = new StreamWriter("SavedList.txt");

            foreach (String s in taskList)
            
            savedList.WriteLine(s);

            savedList.Close();
            
            return taskList;
        }

        private static (List<string>, int) SelectTask(List<string> taskList, string j)
        {
            char selection;
            
            int x = Int32.Parse(j);
            
            Console.Clear();

            Console.WriteLine($"You have selected task {j} - {taskList[x]}");

            Console.WriteLine($"Which action would you like to perform to task {j}?\n" +
                              $"To Remove the task Type: x\n" +
                              $"To Reenter the task Type: r\n" +
                              $"To go back to the previous menu Type: p\n");
            
            selection = Console.ReadKey().KeyChar;
            if (selection == 'r')
            {
                
                ReenterTask(taskList, j);
                
                return (taskList, x);
            }
            if (selection == 'x')
            {
                
                RemoveTask(taskList, j);
                
                return (taskList, x);
            }
            if (selection == 'p')
            {
                
                Console.Clear();
                
                DisplayTaskList(taskList);
                
                return (taskList, x);
            }
            return (taskList, x);

        }

        private static (List<string>, string) ReenterTask(List<string> taskList, string j)
        {
            
            int x = Int32.Parse(j);
            
            taskList.Add(taskList[x]);
            
            return (taskList, taskList[x]);

        }

        private static (List<string>, int) RemoveTask(List<string> taskList, string j)
        {
            int x = Int32.Parse(j);
            
            char selection;
            
            Console.Clear();

            Console.WriteLine($"You have selected task {j} - {taskList[x]}");

            Console.WriteLine($"Press y to confirm removal of {j}.\n" +
                              $"Press n to cancel");
            selection = Console.ReadKey().KeyChar;

                if (selection == 'y')
                {
                    Console.Clear();
                    
                    taskList.RemoveAt(x);
                    
                    return (taskList, x);
                }
                if (selection == 'n')
                {
                    return (taskList, x);
                }
                else
                {
                    throw new ArgumentException();
                }
            
        }

        static List<string> DisplayTaskList(List<string> taskList)
        {

            bool exitTaskList = false;

            string j;

            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine($"{i}. {taskList[i]}");
            }

            Console.WriteLine("\n" +
                              "\n" +
                              "To Select a task Type the number associated with the task and press Enter\n" +
                              "To add a NEW task Type: n\n" +
                              "To go back to the main menu Type: e\n");

            j = (Console.ReadLine());

            if (j == "n")
            {
                AddTask(taskList);

                return taskList;
            }

            if (j == "e")
            {
                return taskList;
            }



            if (int.Parse(j) >= 0)
            {

                do
                {
                    SelectTask(taskList, j);

                    exitTaskList = true;

                } while (exitTaskList == false);

            }
            return taskList;
        }        
            
        private static List<string> AddTask(List<string> taskList)
        {
            
            Console.Clear();
            
            Console.WriteLine("Please add a task :");

            var userInput = Console.ReadLine();

            taskList.Add(userInput);

            anotherTask(taskList);
            
            return taskList;
            
            static List<string> anotherTask(List<string> taskList)
            {

                bool nextInput = false;
                do
                {
                    Console.Clear();

                    Console.WriteLine("Would you like to add another task? If Yes, enter y. If No, enter n.");

                    var newTask = Console.ReadKey().KeyChar;

                    if (newTask == 'y')
                    {
                        Console.Clear();

                        //Asks the user to Add a task.

                        Console.Write("Please add a task :");

                        //Takes what the user entered in the console and saves it as userinput.

                        var userInput = Console.ReadLine();

                        //Adds what user entered as userinput and adds to the taskList.

                        taskList.Add(userInput);

                    }
                    if (newTask == 'n')
                    {
                        Console.Clear();

                        nextInput = true;

                    }
                } while (nextInput == false);

                return taskList;

            }
        }
    }
}
