using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml
{
    public static class Menu
    {
       public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Draw();
        }

        public static void Draw()
        {
            Console.Write("+");
            for (int i = 0; i <=30; i++)
            {
                Console.Write("-");

            }
            Console.Write("+");
        }
    }


    
}
