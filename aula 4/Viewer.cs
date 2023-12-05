using EditorHtml;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace aula_4
{
   public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("MODO VISUALIZACAO");
            Console.WriteLine("-----------------");
            Visualizar(text);
            Console.WriteLine("-----------------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Visualizar(string text)
        {

            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>"); //o @ verifica td como string
            var words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Write(

                        words[i].Substring(
                            words[i].IndexOf(">") + 1,
                            (
                            (words[i].LastIndexOf("<") - 1) -
                            words[i].IndexOf(">")

                            )

                            )


                        );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                    }
                        

                        
                       
                
                }
            }
                        

                        
                }
            }
            
        
    

