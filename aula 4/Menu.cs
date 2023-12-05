using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Write();

            var opcao = short.Parse(Console.ReadLine());
            HandleOption(opcao);
        }

        public static void Draw()
        {
            Console.Write("+");
            for (int i = 0; i <=30; i++)
            {
                Console.Write("-");

            }
            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 15; lines++)
            {
                Console.Write("");

                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                    

                }
               
                Console.Write("|");
                Console.Write("\n");


            }
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");

            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void Write() 
        {
            Console.SetCursorPosition(3,2);// escolhe a posicao dos caracters desejaveis 
            Console.WriteLine("EditorHTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opcao");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Criar Novo arquivo ");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir Arquivo ");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair ");
            Console.SetCursorPosition(3, 11);
            Console.Write("Opcao:");
        }
        public static void HandleOption(short opcao)
        {
            switch(opcao)
            {
                case 1: Editor.Show();break;
                case 2: Console.WriteLine("View");break;
                case 0: Environment.Exit(0);break;
                default: Console.WriteLine("Opcao errada"); Show();break;
            }
        }
    }
    


    
}
