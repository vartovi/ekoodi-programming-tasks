using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referencenumber_fi
{
    class Program
    {
        static void Main(string[] args)
        {
            String userInput;
            String userChoice;
            int howMany;
            while (true)
            {
                Console.WriteLine("Do you want to: \n1 = check a reference number \n2 = create a reference number \n3 = generate multiple reference numbers");
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.Write("\nWrite a reference number: ");
                    userInput = Console.ReadLine();

                    if (userInput.Length >= 4 && userInput.Length <= 20)
                    {
                        int addition = 0;
                        int total = 0;
                        int count = 7;
                        string number;

                        for (int i = (userInput.Length - 2); i >= 0; i--)
                        {

                            number = Convert.ToString(userInput[i]);

                            if (count == 1)
                            {
                                addition = Convert.ToInt32(number) * count;
                                count = 4;
                            }

                            if (count == 3)
                            {
                                addition = Convert.ToInt32(number) * count;
                                count = 1;
                            }

                            if (count == 7)
                            {
                                addition = Convert.ToInt32(number) * count;
                                count = 3;
                            }
                            if (count == 4)
                            {
                                count = 7;
                            }

                            total = total + addition;
                        }

                        total = 10 - (total % 10);

                        if (total != Convert.ToInt32(userInput.Substring(userInput.Length - 1)))
                        {
                            Console.WriteLine("Checksum doesn't match");
                            Console.WriteLine("Last number of your reference number = " + userInput.Substring(userInput.Length - 1) + " checksum = " + total + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Your reference number is correct\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid reference number");
                    }
                }
                if (userChoice == "2")
                {
                    Console.Write("\nWrite a reference number: ");
                    userInput = Console.ReadLine();

                    if (userInput.Length >= 3 && userInput.Length <= 20)
                    {
                        int addition = 0;
                        int total = 0;
                        int count = 7;
                        string number;

                        for (int i = (userInput.Length - 1); i >= 0; i--)
                        {

                            number = Convert.ToString(userInput[i]);

                            if (count == 1)
                            {
                                addition = Convert.ToInt32(number) * count;
                                count = 4;
                            }

                            if (count == 3)
                            {
                                addition = Convert.ToInt32(number) * count;
                                count = 1;
                            }

                            if (count == 7)
                            {
                                addition = Convert.ToInt32(number) * count;
                                count = 3;
                            }
                            if (count == 4)
                            {
                                count = 7;
                            }

                            total = total + addition;
                        }

                        total = 10 - (total % 10);

                        Console.WriteLine("Your reference number is : " + userInput + total + "\n");

                    }
                    else
                    {
                        Console.WriteLine("Invalid reference number");
                    }
                }

                if (userChoice == "3")
                {
                    Console.Write("\nWrite a reference number base: ");
                    userInput = Console.ReadLine();

                    Console.Write("How many reference numbers you want to generate: ");
                    howMany = Convert.ToInt32(Console.ReadLine());
                    
                    string refNumbers;

                    for (int i = 0; i < howMany; i++)
                    {
                        refNumbers = userInput + (i+1);

                        int addition = 0;
                        int total = 0;
                        int count = 7;
                        string number;

                        for (int j = (refNumbers.Length - 1); j >= 0; j--)
                        {

                            number = Convert.ToString(refNumbers[j]);

                            if (count == 1)
                            {
                                addition = Convert.ToInt32(number) * count;
                                count = 4;
                            }

                            if (count == 3)
                            {
                                addition = Convert.ToInt32(number) * count;
                                count = 1;
                            }

                            if (count == 7)
                            {
                                addition = Convert.ToInt32(number) * count;
                                count = 3;
                            }
                            if (count == 4)
                            {
                                count = 7;
                            }

                            total = total + addition;
                        }

                        total = 10 - (total % 10);
                        if (total == 10)
                        {
                            total = 0;
                        }

                        Console.WriteLine((i+1) + ": " + refNumbers + total);

                    }
                    Console.WriteLine("\n");

                }

                
            }
            Console.ReadKey();
        }
        
    }
}
