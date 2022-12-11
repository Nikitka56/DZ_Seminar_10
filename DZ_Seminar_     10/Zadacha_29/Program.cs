int[] array = new int[8];
 
            Random random = new Random();
 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 8);
 
                Console.WriteLine(array[i]);
            }
 
            Console.ReadKey();