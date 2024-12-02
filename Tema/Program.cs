// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello,");


Console.WriteLine("Please input your First name:");
string FirstName = Console.ReadLine() ;
Console.WriteLine("\n");

Console.WriteLine("Please input your Last name:");
string LastName = Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine("Please input your age:");
int Age = int.Parse (Console.ReadLine());
int CalculateAge = Age + 20;
Console.WriteLine("\n");

Console.WriteLine("Please input your gender:");
string Gender = Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine("Your details are as folows:");
Console.WriteLine(" - First Name: " + FirstName);
Console.WriteLine(" - Last Name: " + LastName);
Console.WriteLine(" - Gender: " + Gender);
Console.WriteLine("You will be " + CalculateAge + " years old in 20 years");