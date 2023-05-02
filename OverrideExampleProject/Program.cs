namespace OverrideExampleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine(a.MakeSound());
            Person p = new Person();
            Console.WriteLine(p.MakeSound());
        }
    }
}