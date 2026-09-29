/*
 * Practical 2
 * Information: Methods demo
 * Version 1
 * Author: Samantha Mitchell
 * Date: 29 September
*/

Main();
static void Main()
{
	int option;
	do
	{
		PrintMenu();
		option = InputOption();
		GetOption(option);
	} while (option != 0);

}

static void PrintMenu()
{
	Console.WriteLine("Please enter a valid option from below: \n1. Hello in French? \n2. Hello in Spanish? \n3. Hello in German? \n4. Hello in Italian? \n0. Exit application");

}

static int InputOption()
{
	int option = 0;
	try
	{
		option = Convert.ToInt32(Console.ReadLine());
		
	}
	catch (Exception ex)
	{
		Console.WriteLine($"Error: {ex.Message} Please enter a valid option");
	}

	return option;
}

static string GetOption(int option)
{
	string message = " ";
	switch (option)
	{
		case 0:
			message = "Goodbye";
			break;
        case 1:
            message = "Bonjour";
            break;
        case 2:
            message = "Ola";
            break;
        case 3:
            message = "Hallo";
            break;
        case 4:
            message = "Ciao";
            break;
        default:
            message = "Please enter a valid option";
            break;
	}

	Console.WriteLine(message);
	return message;
}



