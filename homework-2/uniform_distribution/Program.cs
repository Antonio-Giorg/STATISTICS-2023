class Program
{

    static void Main(string[] args)
    {
        Random random = new Random();
        List<double> variables = new List<double>();
        double lowerBound = 0.0;
        double upperBound = 0.0;

        Console.WriteLine("Inserisci il numero di variabili ->");
        int numberOfN = Convert.ToInt32(Console.ReadLine());

        for(int _=0; _ < numberOfN; _++){
            variables.Add(random.NextDouble());
        }

        int kNumber = 1;
        int count = 1;
        do
        {
            Console.WriteLine("Inserisci il numero k: -> (Inserisci 0 per fermare)");
            kNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kNumber; i++)
            {
                lowerBound = (double)i / kNumber;
                upperBound = (double)(i + 1) / kNumber;

                Console.WriteLine($"From {lowerBound} to {upperBound}\n");

                foreach (double num in variables)
                {
                    
                    if ((num >= lowerBound) && (num < upperBound))
                    {
                        Console.WriteLine($"{count} - {num}");
                        count++;
                    }

                }

                count = 1;
                Console.WriteLine("\n ================================================================ \n\n");
            }

        } while (kNumber != 0);
        
    }

}
