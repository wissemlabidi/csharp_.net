// Three Basic Arrays

    // Create an array to hold integer values 0 through 9
        int[] arr1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        foreach(int number in arr1)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

    // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
        string[] arr2 = { "Tim", "Martin", "Nikki", "Sara" };
        foreach(string name in arr2)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();

    // Create an array of length 10 that alternates between true and false values, starting with true
        bool[] arr3 = new bool[10];
        bool input = true;
        for (int i = 0; i < arr3.Length; i++)
        {
            arr3[i] = input;
            if (input == true)
            {
                input = false;
            }
            else
            {
                input = true;
            }
        }
        foreach(bool value in arr3)
        {
            Console.WriteLine(value);
        }


//List of Flavors

    // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
        List<string> IceCreamFlavors = new List<string>();
        IceCreamFlavors.Add("Chocolate");
        IceCreamFlavors.Add("Peanut Butter");
        IceCreamFlavors.Add("Strawberry");
        IceCreamFlavors.Add("Orange");
        IceCreamFlavors.Add("Watermelon");

        foreach (string flavor in IceCreamFlavors)
        {
            Console.WriteLine(flavor);
        }

        Console.WriteLine();

    // Output the length of this list after building it
        Console.WriteLine(IceCreamFlavors.Count);

    // Output the third flavor in the list, then remove this value
        Console.WriteLine(IceCreamFlavors[2]);
        IceCreamFlavors.Remove(IceCreamFlavors[2]);

    // Output the new length of the list (It should just be one fewer!)
        Console.WriteLine(IceCreamFlavors.Count);


//User Info Dictionary

    // Create a dictionary that will store both string keys as well as string values
        Dictionary<string, string> NamesAndFlavors = new Dictionary<string, string>();

    // Add key/value pairs to this dictionary where:
        // each key is a name from your names array
        // each value is a randomly select a flavor from your flavors list.
        for (int i=0; i<arr2.Length; i++)
        {
            NamesAndFlavors[arr2[i]] = IceCreamFlavors[i];
        }
        foreach (KeyValuePair<string,string> entry in NamesAndFlavors)
        {
            Console.WriteLine(entry.Key + " - " + entry.Value);
        }
            
