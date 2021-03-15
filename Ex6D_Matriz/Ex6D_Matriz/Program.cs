using System;

namespace Ex6D_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter the number of Lines: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please, enter the number of Rows: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];  //Creating Matrix

            //----------< Reading the Matrix Numbers ]
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine("\nEnter the #" + ((i + 1) * (j + 1)) + " value (Line " + (i + 1) + ", Row " + (j + 1) + ")");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //----------< Printing the Matrix ]
            Console.WriteLine("\n--------------------");
            Console.WriteLine("Your Matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--------------------");
            Console.Write("Choose one number of the matriz, then we'll show you the surrounding others: ");
            int number = int.Parse(Console.ReadLine());
            int lineNumber = 0;
            int rowNumber = 0;

            //----------< Finding the number]            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(matrix[i,j] == number)
                    {
                        lineNumber = i;
                        rowNumber = j;
                    }                    
                }                
            }

            //----------< Printing the Surround numbers]

            Console.WriteLine("--------------------\n");
            //----------<North Number:
            Console.WriteLine("Nort Number: " + matrix[(lineNumber - 1), rowNumber]);
            Console.WriteLine("East Number: " + matrix[lineNumber, (rowNumber + 1)]);
            Console.WriteLine("South Number: " + matrix[(lineNumber + 1), rowNumber]);
            Console.WriteLine("West Number: " + matrix[lineNumber, (rowNumber - 1)]);

            Console.WriteLine("\nGraphic Visualization: \n");
            Console.WriteLine("  " + matrix[(lineNumber - 1), rowNumber]);
            Console.WriteLine(matrix[lineNumber, (rowNumber - 1)] + " " + matrix[lineNumber, rowNumber] + " " + matrix[lineNumber, (rowNumber + 1)]);
            Console.WriteLine("  " + matrix[(lineNumber + 1), rowNumber]);

        }
    }
}
