using System;
using System.Runtime.CompilerServices;
namespace docso{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("So can doc la:");
            int So = Int16.Parse(Console.ReadLine());

            switch(So/100){
                case 1:
                Console.Write("one hundred and ");
                break;
                case 2:
                Console.Write("two hundred and ");
                break;
                case 3:
                Console.Write("three hundred and ");
                break;
                case 4:
                Console.Write("four hundred and ");
                break;
                case 5:
                Console.Write("five hundred and ");
                break;
                case 6:
                Console.Write("six hundred and ");
                break;
                case 7:
                Console.Write("seven hundred and ");
                break;
                case 8:
                Console.Write("eight hundred and ");
                break;
                case 9:
                Console.Write("nine hundred and ");
                break;
                default:
                Console.WriteLine("khong xac dinh ");
                break;
                }
            switch((So%100)/10){
                case 1:
                Console.Write("ten ");
                break;
                case 2:
                Console.Write("twenty ");
                break;
                case 3:
                Console.Write("thirty ");
                break;
                case 4:
                Console.Write("forty ");
                break;
                case 5:
                Console.Write("fifty ");
                break;
                case 6:
                Console.Write("sixty ");
                break;
                case 7:
                Console.Write("seventy ");
                break;
                case 8:
                Console.Write("eighty ");
                break;
                case 9:
                Console.Write("ninety ");
                break;
                default:
                Console.Write("404er ");
                break;
                
            }
            switch((So%100)%10){
            case 1:
            Console.Write("one");
                break;
            case 2:
            Console.Write("two");
                break;
            case 3:
            Console.Write("three");
                break;    
            case 4:
            Console.Write("four");
                break;    
            case 5:
            Console.Write("five");
                break; 
            case 6:
            Console.Write("six");
                break;  
            case 7:
            Console.Write("seven");
                break;   
            case 8:
            Console.Write("eight");
                break; 
            case 9:
            Console.Write("nine");
                break; 
            default:
            Console.Write("eror");
                break;
        }
        }
    }
}
