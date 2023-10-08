
class Program
    {
        // Random Array
        // Create a function called RandomArray() that returns an integer array
        public static int[] RandomArray()
        {
            // Place 10 random integer values between 5-25 into the array
            int[] array = new int[10];
            Random rand = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(5, 26);
                Console.WriteLine(array[i]);
            }
            // Print the min and max values of the array
            // Print the sum of all the values
            int max = array[0];
            int min = array[0];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
                sum += array[i];
            }
            Console.WriteLine($"The maximum value is {max}");
            Console.WriteLine($"The minimum value is {min}");
            Console.WriteLine($"The sum is {sum}");
            return array;
        }

        //Coin Flip
        // Create a function called TossCoin() that returns a string
        public static string TossCoin()
        {
            // Have the function print "Tossing a Coin!"
            Console.WriteLine("Tossing a Coin!");
            // Randomize a coin toss with a result signaling either side of the coin 
            Random rand = new Random();
            int result = rand.Next(1,3);
            Console.WriteLine($"The result is {result}");

            // Have the function print either "Heads" or "Tails"
            // Finally, return the result
            if(result == 1)
            {   
                Console.WriteLine("Heads");
                return "Heads";
            }
            else
            {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }
        //Names
        // Build a function Names that returns a list of strings.  In this function:
        public static List<string> Names()
        {
            List<string> listOfNames = new List<string>();
            // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            listOfNames.Add("Todd");
            listOfNames.Add("Tiffany");
            listOfNames.Add("Charlie");
            listOfNames.Add("Geneva");
            listOfNames.Add("Sydney");
            // Shuffle the list and print the values in the new order
            Random rand = new Random();
            List<string> newListOfNames = new List<string>();
            for(int i = 0; i < 5; i++)
            {
                int idx = rand.Next(0,listOfNames.Count);
                newListOfNames.Add(listOfNames[idx]);
                listOfNames.RemoveAt(idx);
                Console.WriteLine(newListOfNames[i]);
            }
            // Return a list that only includes names longer than 5 characters
            for (int i = 0; i < newListOfNames.Count; i++)
            {
                if (newListOfNames[i].Length < 5)
                {
                    newListOfNames.RemoveAt(i);
                }
            }
            Console.WriteLine("New List: ");
            for (int i = 0; i < newListOfNames.Count; i++)
            {
                Console.WriteLine(newListOfNames[i]);
            }
            return newListOfNames;
        }
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            Names();
        }
    }
