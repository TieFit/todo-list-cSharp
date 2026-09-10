using System;
using System.Collections.Generic;


public class Program
{
	static List<string> tasks = new List<string>(); 
	
	public static void Main()
	{	
		while (true) {
			Console.WriteLine("1. Add Task\n2. View Tasks\n3. Remove Task\n4. Exit");
			Console.Write("Please enter what command you would like to do, 1-4: ");


			int userChoice = int.Parse(Console.ReadLine());


			while (userChoice < 1 || userChoice > 4) {
				Console.Write("Invalid command, please enter what command you would like to do, 1-4: ");
				userChoice = int.Parse(Console.ReadLine());
			}


			switch (userChoice) {
				case 1:
					AddTask();
					break;


				case 2:
					DisplayTasks();
					break;


				case 3:
					RemoveTask();
					break;


				case 4: 
					return;
			}
		}
	}
	
	public static void AddTask() {
		Console.Write("Enter the task to be added: ");
		tasks.Add(Console.ReadLine());
	}
	
	public static void DisplayTasks() {
		foreach (string task in tasks) {
			Console.WriteLine(task);
		}
	}
	
	public static void RemoveTask() {
		Console.Write("Enter the task to be removed: ");
		string taskToRemove = Console.ReadLine();
		
		foreach (string task in tasks) {
			if (task == taskToRemove) {
				tasks.Remove(task);
				Console.WriteLine($"'{task}' was successfully removed!");
				return;
			}
		}
		Console.WriteLine($"'{taskToRemove}' was not on your to-do list, so it cannot be removed");
	}
}