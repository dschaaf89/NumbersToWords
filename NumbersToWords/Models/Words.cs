using System;
using System.Numerics;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
    public class Words
    {
    static Dictionary <BigInteger,string> firstDictionary = new Dictionary<BigInteger, string>(){
        {0 , ""},
        {1 , " one"},
        {2 , " two"},
        {3 , " three"},
        {4, " four"},
        {5," five"},
        {6 , " six"},
        {7," seven"},
        {8," eight"},
        {9," nine"},
        {10, " ten"},
        {11," eleven"},
        {12," twelve"},
        {13," thirteen"},
        {14," fourteen"},
        {15," fifteen"},
        {16," sixteen"},
        {17," seventeen"},
        {18," eightteen"},
        {19," nineteen"}
    };
    //25
    static Dictionary <BigInteger,string> tens = new Dictionary<BigInteger, string>(){
        {0 , ""},
        {1 , ""},
        {2 , "twenty"},
        {3 , "thirty"},
        {4, "forty"},
        {5,"fifty"},
        {6 , "sixty"},
        {7,"seventy"},
        {8,"eighty"},
        {9,"ninety"}
    };


    

        public static string getNumWord(BigInteger number){
           string result = "";
            //125
            if(number >= 1000 && number < 100000)
            {
                if(number/1000 >=  20)
                {
                    result += Words.tens[number/10000] + " thousand ";
                    number %=  1000;
                    //Words.getNumWord(number)
                }
                else
                {
                    result += Words.firstDictionary[number/1000] + " thousand ";
                    number %=  1000;
                }
            }
            if(number >= 100 && number < 1000)
            {
                Console.WriteLine(number/100);
                result += Words.firstDictionary[number/100] + " hundred ";
                number %=  100;
            }
            if(number > 19 && number < 100){
                result += Words.tens[number/10];
                number %=  10;
            }
            if(number <= 19) {
                result += Words.firstDictionary[number];
            }
           Console.WriteLine(result);
            return result;
            
        }

        public static string getNumWordRecursive(BigInteger number){
           string result = "";
           if (number == 0) {
                return "zero";     
           } 
            if((number / 1000000000000) > 0){
                result += getNumWordRecursive(number/1000000000000) + " trillion ";
                number%= 1000000000000;

            }  
           if((number / 1000000000) > 0){
                result += getNumWordRecursive(number/1000000000) + " billion ";
                number%= 1000000000;

            }  
            if((number / 1000000) > 0){
                result += getNumWordRecursive(number/1000000) + " million ";
                number%= 1000000;

            }  
            if ((number / 1000) > 0)  
            {  
                result += getNumWordRecursive(number / 1000) + " thousand ";  
                number %= 1000;  
            }  
            if ((number / 100) > 0)  
            {  
                result += getNumWordRecursive(number / 100) + " hundred ";  
                number %= 100;  
            }  
            if (number > 0)  
                if(number < 20)
                {
                    result += Words.firstDictionary[number];
                }
                else{
                    result += Words.tens[number/10];
                    if ((number%10) > 0)
                    {
                        result += " " + Words.firstDictionary[number%10];
                    }
                }
                return result; 
            }  
             

            public static string translateNum( BigInteger num, string modifier)
        {
            
            if(num == 0)//may not be needed
            {
                return "";
            }
            if(num <= 19) {
                return  Words.firstDictionary[num] + modifier;
            }
            if(num > 19 &&  num < 100)
            {
                return  Words.tens[num / 10] + Words.firstDictionary[num % 10] + modifier;
            }
            if(num > 100) 
            {
                return Words.firstDictionary[num / 100] + " hundred " +  Words.tens[((num % 100) / 10)] + Words.firstDictionary[num % 10] + modifier;
            }
            return "";
        }
        public static string test(BigInteger number)
        {
            string[] modArry = {"", " thousand", " million", " billion", " trillion", " quadrillion", " quintrillion", " sextillion", " septillion", " octillion", " nonillion", " decillion", " undecillion", " duodecillion", " tredecillion", " quattuordecillion", " quindecillion", " sexdecillion", " septemdecillion", " octodecillion", " novemdecillion", " vigintillion"  };
            string result = "";//123456
            BigInteger n = number ;
            if(number == 0)
            {
                return "zero";
            }
            for(int i = 0; n > 0; i++)
            {
                result  = translateNum(n % 1000, modArry[i]) + result;
                n /= 1000;
            }
            return result;
        }


        }
        





   
    }
