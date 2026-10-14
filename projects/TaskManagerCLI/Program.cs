Console.WriteLine("=================================");
Console.WriteLine("Task Manager");
Console.WriteLine("=================================");
Console.WriteLine();
Console.WriteLine("1. Create Task");
Console.WriteLine("2. List Tasks");
Console.WriteLine("3. Exit");
Console.WriteLine();
Console.Write("Select Option: ");

if(int.TryParse(Console.ReadLine(), out int option))
{
    Console.WriteLine($"You selected: {option}");
}
else{
    Console.WriteLine("Invalid input.");
}