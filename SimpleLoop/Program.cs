
//create a program that prints the first 'n' even numbers where 'n' is taken from the user

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Enter the value of n: ");

        int n = Convert.ToInt32(Console.ReadLine());

        for (int i =2; i<=2*n; i += 2)
        {
            Console.WriteLine(i+ " ");
        }
    }
}