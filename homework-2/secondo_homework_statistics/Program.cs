using System;
using System.Collections;
using System.Collections.Generic;

class Program{
    
    static Dictionary<(string, string), int> CalculateJointDistribution(Dictionary<string, int> variable1, Dictionary<string, int> variable2)
    {
        Dictionary<(string, string), int> jointDistribution = new Dictionary<(string, string), int>();

        // Iterate through the dictionaries and calculate joint distribution
        foreach (var kvp1 in variable1)
        {
            foreach (var kvp2 in variable2)
            {
                if (kvp1.Key == kvp2.Key)
                {
                    var key = (kvp1.Key, kvp2.Key);

                    if (jointDistribution.ContainsKey(key))
                    {
                        jointDistribution[key] += kvp1.Value * kvp2.Value;
                    }
                    else
                    {
                        jointDistribution[key] = kvp1.Value * kvp2.Value;
                    }
                }
            }
        }

        return jointDistribution;
    }

    static Dictionary<string, int> GeneralJointDistribution(params Dictionary<string, int>[] variables)
    {
        Dictionary<string, int> jointDistribution = new Dictionary<string, int>();

        // Initialize joint distribution with the first variable
        foreach (var kvp in variables[0])
        {
            jointDistribution[kvp.Key] = kvp.Value;
        }

        // Calculate joint distribution for remaining variables
        for (int i = 1; i < variables.Length; i++)
        {
            Dictionary<string, int> currentVariable = variables[i];

            foreach (var kvp in jointDistribution.Keys.ToList())
            {
                // If the key exists in the current variable, multiply the counts
                if (currentVariable.ContainsKey(kvp))
                {
                    jointDistribution[kvp] *= currentVariable[kvp];
                }
                else
                {
                    // If the key doesn't exist in the current variable, remove it from joint distribution
                    jointDistribution.Remove(kvp);
                }
            }
        }

        return jointDistribution;
    }

    static void CalcoloFrequenze(Dictionary<String, int> data)
    {
        int totalLenght = 0;
        float frequency = 0.0f;

        foreach (KeyValuePair<string, int> data_pair in data)
        {
            Console.WriteLine($"Frequenza assoluta di: {data_pair.Key}, Valore: {data_pair.Value}");
            totalLenght += data_pair.Value;
        }

        Console.WriteLine();

        foreach (KeyValuePair<string, int> data_pair in data)
        {
            frequency = (float) data_pair.Value / totalLenght;
            Console.WriteLine($"Frequenza relativa di: {data_pair.Key}, Valore: {Math.Round(frequency,4)}" +
                $" In percentuale: {Math.Round((frequency*100), 2)}%");
            
        }

    }

    static void CalcoloFrequenzeQuantitativeContinue(Dictionary<String, int> data)
    {

        Console.WriteLine("Inserisci lower bound");
        float lowerBound = float.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci upper bound");
        float upperBound = float.Parse(Console.ReadLine());

        int totalLenght = 0;
        float frequency = 0.0f;

        foreach (KeyValuePair<string, int> data_pair in data)
        {
            if(!(data_pair.Key.Equals("None")) && (float.Parse(data_pair.Key) >= lowerBound) && (float.Parse(data_pair.Key) <= upperBound)){
                Console.WriteLine($"Frequenza assoluta di: {data_pair.Key}, Valore: {data_pair.Value}");
                totalLenght += data_pair.Value;
            }
            
        }

        Console.WriteLine();

        foreach (KeyValuePair<string, int> data_pair in data)
        {
            if (!(data_pair.Key.Equals("None")) && (float.Parse(data_pair.Key) >= lowerBound) && (float.Parse(data_pair.Key) <= upperBound))
            {
                frequency = (float)data_pair.Value / totalLenght;
                Console.WriteLine($"Frequenza relativa di: {data_pair.Key}, Valore: {Math.Round(frequency, 4)}" +
                    $" In percentuale: {Math.Round((frequency * 100), 2)}%");
            }

            

        }

    }

    static Dictionary<String, int> ConvertFileIntoVariable(String fileName)
    {
        Dictionary<String, int> result = new Dictionary<String, int>();

        try
        {
            // Leggi tutte le righe dal file .csv
            string[] lines = File.ReadAllLines(fileName);

            // Stampa tutte le righe
            foreach (string line in lines){

                string current = line.ToLower();

                if (current.Length == 0)
                {
                    if (result.ContainsKey("None"))
                    {
                        result["None"] = result["None"] + 1;
                    }
                    else
                    {
                        result.Add("None", 1);
                    }
                }
                else if(result.ContainsKey(current))
                {
                    result[current] = result[current] + 1;
                }
                else
                {
                    result.Add(current, 1);
                }
            }

        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File non trovato. Assicurati di specificare il percorso corretto del file .csv.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Si è verificato un errore: " + ex.Message);
        }

        return result;

    }

    static void Main(){

        // Variabile qualitativa -> Team Leader or Team player
        Dictionary<String, int> leader_or_player = ConvertFileIntoVariable("D:\\magistrale\\statistics\\homework-2\\leader_or_player.txt");

        // Variabile quantiativa continua -> heigth 
        Dictionary<String, int> height_value = ConvertFileIntoVariable("D:\\magistrale\\statistics\\homework-2\\height.txt");

        // Variabile quantiativa discreta -> hard worker 
        Dictionary<String, int> hard_work = ConvertFileIntoVariable("D:\\magistrale\\statistics\\homework-2\\hard_work.txt");

        CalcoloFrequenze(leader_or_player);
        Console.WriteLine();
        CalcoloFrequenzeQuantitativeContinue(height_value);
        Console.WriteLine();
        CalcoloFrequenze(hard_work);
        Console.WriteLine();

        Dictionary<(string, string), int> jointDistribution = CalculateJointDistribution(hard_work, leader_or_player);

        // 
        Console.WriteLine("Joint Distribution between height values and leader or player values:");
        foreach (var kvp in jointDistribution)
        {
            Console.WriteLine($"P({kvp.Key.Item1}, {kvp.Key.Item2}) = {kvp.Value / (double)height_value.Count}");
        }

        Dictionary<string, int> generalDistribution = GeneralJointDistribution(height_value, hard_work, leader_or_player);

        Console.WriteLine("General joint distribution:");
        foreach (var kvp in jointDistribution)
        {
            Console.WriteLine($"Variable: {kvp.Key}, Count: {kvp.Value}");
        }

    }

    
}
