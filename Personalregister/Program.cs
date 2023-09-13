namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            // Create dialog.

            while (true)
            {
                Console.Clear(); // Clear console
                Console.WriteLine("\n\t\tVälkommen till Personalregister\n\nVänligen navigera genom menyn genom att skriva en siffra \n(1, 2, 0) som du väljer" // Ask user to navigate through the menu.
                    + "\n\n0. Avsluta dialogen"
                    + "\n1. Lägg till ny medarbetare"
                    + "\n2. Visa anställda");

                char input = ' '; 

                try
                {
                    Console.Write("Ditt val: ");
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, I ask the users for some input.
                {
                    Console.WriteLine("Vänligen ange någon inmatning eller 0 för att avsluta applikationen! Tryck på valfri tangent för att fortsätta.");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (input > '2') // Check if the user has entered a value greater than the number of options available in dialog.
                {
                    Console.WriteLine("Du måste välja ett alternativ! Tryck på valfri tangent för att fortsätta.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    switch (input) // Using switch to call appropriate method depending on user input.
                    {
                        case '0':     //End the dialog.
                            return;
                        case '1':
                            AddEmployee();
                            break;
                        case '2':     
                            DisplayEmployees();
                            break;
                        default:
                            break;
                    }
                }
            }

            void AddEmployee()
            {
                try
                {
                    Console.WriteLine("Ange medarbetarens namn");
                    string name = Console.ReadLine();

                    Console.WriteLine("Ange medarbetarens lön");
                    int salary = int.Parse(Console.ReadLine());

                    Employee employee = new Employee(name, salary);
                    employees.Add(employee);
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine(ex.ToString()); 
                }                
            }

            void DisplayEmployees()
            {
                foreach (Employee employee in employees) 
                {
                    Console.WriteLine(employee.DisplayEmployee());
                }
                
                Console.ReadLine();
            }
        }
    }
}