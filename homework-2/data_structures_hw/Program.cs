using System.Collections.Generic;
using System.Globalization;
using System;
using System.Collections;

class Program
{
    
    static void ArrayImplementation()
    {
        // Implementazione dell'array
        int[] array = new int[] { 1, 2, 3, 4, 5 };

        // Accesso agli elementi
        foreach(int elem in array)
        {
            Console.WriteLine(elem);
        }

        // Metodo di AGGIUNTA non presente, l'array ha una grandezza fissa non modificabile. Al massimo si può modificare un elemento dell'array

        // Metodo di RIMOZIONE non presente, l'array ha una grandezza fissa non modificabile. Al massimo si può modificare un elemento dell'array

        // Get di elemento di un array | Syntax: array[index]
        int elem2 = array[1]; // ottengo il secondo elemento dell'array

        // Set di un elemento di un array
        array[1] = 6; // setto il secondo elemento a 6

        // Ricerca in un array
        int element_to_found = 3;
        foreach (int elem3 in array)
        {
            if (elem3 == element_to_found)
            {
                Console.WriteLine("Trovato");
            }
        }
    }

    static void ListImplementation()
    {
        // Implementazione dell'array
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };

        // Accesso agli elementi
        foreach (int elem in list)
        {
            Console.WriteLine(elem);
        }

        // Metodo di AGGIUNTA 
        list.Add(7);
        // Metodo di RIMOZIONE
        list.Remove(4);

        // Get di elemento di una lista 
        int elem2 = list.ElementAt(3); // ottengo il quarto elemento dell'array

        // Set di un elemento di una lista
        list[1] = 6; // setto il secondo elemento a 6

        // Ricerca in un array
        Console.WriteLine(list.Contains(7));
    }

    static void DictImplementation()
    {
        // Implementazione dell'array
        Dictionary<string, int> dict = new Dictionary<string, int>
        {
            {"Hello", 3},
            {"world", 4},
            {"italy", 7}
        };

        // Accesso agli elementi
        foreach (var pair in dict)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        // Metodo di AGGIUNTA 
        dict.Add("New",6);
        // Metodo di RIMOZIONE
        dict.Remove("Hello");

        // Get di elemento di un dizionario 
        var elem2 = dict["New"];

        // Set di un elemento di un dizionario
        dict["New"] = 12;

        // Ricerca in un array
        Console.WriteLine(dict.ContainsKey("New"));
    }

    static void SortedListImplementation()
    {
        // Implementazione dell'array
        SortedList<int, string> sortedList = new SortedList<int, string>
        {
            {3, "Three"},
            {1, "One"},
            {2, "Two"}
        };

        //Accesso agli elementi
        foreach (var pair in sortedList)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        // Metodo di AGGIUNTA 
        sortedList.Add(6, "New");

        // Metodo di RIMOZIONE
        sortedList.Remove(6);

        // Get di elemento di una sorted list 
        var elem = sortedList[1];

        // Set di un elemento di una sorted list 
        sortedList[1] = "Modified";

        // Ricerca in un array
        Console.WriteLine(sortedList.ContainsKey(4));
    }

    static void HashsetImplementation()
    {
        // Implementazione dell'array
        HashSet<int> hashSet = new HashSet<int> { 1, 2, 3, 4, 5 };

        //Accesso agli elementi
        foreach (int item in hashSet)
        {
            Console.WriteLine(item);
        }

        // Metodo di AGGIUNTA 
        hashSet.Add(6);

        // Metodo di RIMOZIONE
        hashSet.Remove(3);

        // Get di elemento di un hashset è impossibile, si può solo controllare la sua esistenza
        // Si potrebbe iterare alla ricerca del valore che si vuole e metterlo in una variabile? Certamente, ma non si potrebbe
        // fare molto in quanto non si può accedere direttamente ai dati quindi, a questo punto, meglio assegnare direttamente il valore
        // voluto alla variabile voluta magari controllando l'esistenza di quel valore nell'hashset

        // Set di un elemento di un hashset è impossibile in quanto i suoi elementi sono UNICI ed IMMUTABILI
        // si potrebbe rimuovere un elemento e aggiungere quello voluto, MA NON SAREBBE UNA MODIFICA DEL VALORE DI UN ELEMENTO DELL'HASHSET

        // Ricerca in un array
        Console.WriteLine(hashSet.Contains(4));
    }

    static void SortedsetImplementation()
    {
        // Implementazione
        SortedSet<int> sortedSet = new SortedSet<int> { 5, 2, 8, 1, 3 };

        // Iterazione
        foreach (int item in sortedSet)
        {
            Console.WriteLine(item);
        }

        // Metodo di AGGIUNTA 
        sortedSet.Add(6);

        // Metodo di RIMOZIONE
        sortedSet.Remove(3);

        // Get di elemento di un sorted set è impossibile, si possono solo ottenere i valori massimi e minimi
        // ed il primo e l'ultimo valore

        // Set di un elemento di un hashset è impossibile in quanto i suoi elementi sono UNICI ed IMMUTABILI.
        // si potrebbe rimuovere un elemento e aggiungere quello voluto. MA NON SAREBBE UNA MODIFICA DEL VALORE DI UN ELEMENTO
        // DELLA SORTED LIST

        // Ricerca in un sorted set
        Console.WriteLine(sortedSet.Contains(4));
    }

    static void QueueImplementation()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);

        while (queue.Count > 0)
        {
            int item = queue.Dequeue();
            Console.WriteLine(item);
        }

        // Metodo di AGGIUNTA 
        queue.Enqueue(6);

        // Metodo di RIMOZIONE
        queue.Dequeue();

        // Get di elemento di una queue senza rimozione
        queue.Peek();

        // Set di un elemento di una queue è impossibile in quanto non si può accedere ai suoi elementi.
        // Si potrebbe svuotare la lista fino all'elemento da modificare (elemento compreso), aggiungere l'elemento voluto
        // e reinserire nella lista gli elementi rimossi, MA NON SAREBBE UNA MODIFICA DEL VALORE DI UN ELEMENTO DELLA QUEUE

        // Ricerca in un sorted set
        Console.WriteLine(queue.Contains(2));
    }

    static void StackImplementation()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);

        while (stack.Count > 0)
        {
            int item = stack.Pop();
            Console.WriteLine(item);
        }

        // Metodo di AGGIUNTA 
        stack.Push(3);

        // Metodo di RIMOZIONE
        stack.Pop();

        // Get di elemento di una queue senza rimozione
        stack.Peek();

        // Set di un elemento di uno stack è impossibile in quanto non si può accedere ai suoi elementi.
        // Si potrebbe svuotare lo stack fino all'elemento da modificare (elemento compreso), aggiungere l'elemento voluto
        // e reinserire nella lista gli elementi rimossi, MA NON SAREBBE UNA MODIFICA DEL VALORE DI UN ELEMENTO DELLO STACK

        // Ricerca in un sorted set
        Console.WriteLine(stack.Contains(2));
    }

    static void LinkedListImplementation()
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);

        foreach (int item in linkedList)
        {
            Console.WriteLine(item);
        }

        // Metodo di AGGIUNTA 
        linkedList.AddLast(3);

        // Metodo di RIMOZIONE
        linkedList.Remove(3);

        // Get di elemento di una queue senza rimozione
        linkedList.First();

        // Set del primo elemento di una linked non si può fare. Al suo posto si potrebbe aggiungere
        // un nuovo nodo con il valore voluto di fianco al nodo da modificare ed eliminare il nodo da modificare
        // MA NON SAREBBE UNA MODIFICA DEL VALORE DI UN ELEMENTO DELLA LINKED LIST


        // Ricerca in un sorted set
        Console.WriteLine(linkedList.Contains(2));
    }

    static void Main(string[] args)
    {
        //-loop (break/continue)
        //-add / remove / get / set / check the existence of key/ value

        //data structures:
        // array, list, dictionary, sorted list, hashset, sortedset, queue, stack, linkedlis



    }
}
