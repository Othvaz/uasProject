using System;
using TodoLibrary;
using InputLibrary;

namespace todoList
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList todoList = new TodoList();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Todo List:");
                var items = todoList.GetItems();
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {items[i]}");
                }

                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add a new todo item");
                Console.WriteLine("2. Mark an item as completed");
                Console.WriteLine("3. Remove an item");
                Console.WriteLine("4. Exit");

                int choice = InputHandler.GetInt("Choose an option:");

                switch (choice)
                {
                    case 1:
                        string description = InputHandler.GetString("Enter the description of the new todo item:");
                        todoList.AddItem(new TodoItem(description));
                        break;
                    case 2:
                        int indexToComplete = InputHandler.GetInt("Enter the number of the item to mark as completed:") - 1;
                        if (indexToComplete >= 0 && indexToComplete < items.Count)
                        {
                            items[indexToComplete].MarkAsCompleted();
                        }
                        break;
                    case 3:
                        int indexToRemove = InputHandler.GetInt("Enter the number of the item to remove:") - 1;
                        todoList.RemoveItem(indexToRemove);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
