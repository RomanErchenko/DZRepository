using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZ2
{
    public  class Spider
    {

        private Web field=new Web();

        public void SetWeb()
        {
            char symbol;
            Console.WriteLine("Введите 'r' (червоний), 'b' (блакитний), 'w' (білий), 'y' (жовтий) или 'q' (вихід):");
            do
            {
                symbol = char.ToLower(Console.ReadKey(true).KeyChar);
                switch (symbol)
                {
                    case 'r':
                        field.ChangeWebColor("red");
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 'b':
                        field.ChangeWebColor("blue");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case 'w':
                        field.ChangeWebColor("white");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 'y':
                        field.ChangeWebColor("yellow");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 'q':
                        Console.WriteLine("Exit from programm...");
                        break;
                    default:
                        Console.WriteLine("Color is epsoned");
                        break;
                }
                Console.WriteLine($"Павутиння {field.WebColor} кольору");
                Console.ResetColor();
            } while (symbol != 'q');
           // Console.WriteLine($"Павутиння {field.WebColor} кольору");
        }



    }
}
