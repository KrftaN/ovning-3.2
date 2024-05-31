namespace övning_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? (j/n):");
            string graduated = Console.ReadLine().ToLower();

            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());

            if (graduated == "j" && age < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig.");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
            }
        }
    }
}
