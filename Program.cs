using System;
class Program{
        static void Main(string[] args) {
            Console.WriteLine("Please enter a 6-digit number: ");
            int number = int.Parse(Console.ReadLine());
    
            int[] digits = new int[6];
            for (int i = 5; i >= 0; i--){
                digits[i] = number % 10;
                number /= 10;
            }
            Console.WriteLine("Please enter a 3-letter string: ");
            string letters = Console.ReadLine();
    
            bool isFBI = letters == "FBI";
            bool isCIA = letters == "CIA";
            bool isNSA = letters == "NSA";
    
            Console.WriteLine("You entered the following: ");
            Console.WriteLine("Number: ");
            foreach (int digit in digits) {
                Console.WriteLine(digit + " ");
            }
            Console.WriteLine();
    
            if (isFBI) {
                if(digits[0] > 3 && digits[0] < 8 && digits[3] % 2 == 0 && digits[3] !=6 && digits[1] % 2 == 1) {
                    Console.WriteLine("True");
                }
                else {
                    Console.WriteLine("False");
                }
            }
            else if (isCIA) {
                if(digits[5] % 3 == 0 && digits[4] != 1 && digits[4] != 3 && digits[4] != 5 && digits[2] > 6 && digits[2] != 8) {
                    Console.WriteLine("True");
                }
                else {
                    Console.WriteLine("False");
                }
            }
            else if (isNSA) {
                if(digits[5] % 30 == 0 && digits[3] / 3 >= 1 && digits[3] % 2 != 0)  
                    for (int i = 0; i <= 5; i++) {
                
                if (digits [i] == 7) {
                break;
                    }
                }
                 Console.WriteLine("True");
                }else {
                 Console.WriteLine("False");
                }
        }
    }