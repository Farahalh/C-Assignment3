namespace C_Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("What is your first name?");
            person.FName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            person.LName = Console.ReadLine();
            person.DisplayFullName();

            Console.WriteLine("How old are you?");
            person.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your height?");
            person.Height = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your weight?");
            person.Weight = int.Parse(Console.ReadLine());
            person.DisplayPersonAttributes();
        }
    }
}