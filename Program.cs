using System;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Seal_Voci_Lernen
{
    class Program
    {
        static void Main(string[] args)
        {
            string inPath = @"C:\Schule\Lernatelier\Gruppenprojekte\Seal Voci Lernen\Vokabeln.csv";
            string text = File.ReadAllText(inPath);

            string[] lines = text.Split("\r\n");
            int words = lines.Length;
            string[] english = new string[words];
            string[] german = new string[words];


            for (int line = 0; line < lines.Length - 1; line++)
            {
                string[] items = lines[line].Split(',');
                english[line] = items[0];
                german[line] = items[1].Replace("\"", string.Empty); ;
            }

            string titel = @"
███████████████████████████████████████████████████████████████████████████████████████████████████
█▄─█─▄█─▄▄─█─▄▄▄─██▀▄─██▄─▄─▀█▄─██─▄█▄─▄████▀▄─██▄─▄▄▀█▄─█─▄███─▄─▄─█▄─▄▄─█─▄▄▄▄█─▄─▄─█▄─▄▄─█▄─▄▄▀█
██▄▀▄██─██─█─███▀██─▀─███─▄─▀██─██─███─██▀██─▀─███─▄─▄██▄─▄██████─████─▄█▀█▄▄▄▄─███─████─▄█▀██─▄─▄█
▀▀▀▄▀▀▀▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▀▄▄▄▀▀▀▀▀▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀▄▄▀▄▄▀
";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(titel);
            Console.ForegroundColor = ConsoleColor.Gray;

            WriteLine("Welcome to the vocabulary tester.\r\nAvailable languages:\r\n[1] German\r\n[2] English\r\n\nWhich language should be asked for? ^.^ ");
            int userInput;
            int language = -1;
            while (language == -1)
            {
                try
                {
                    userInput = Convert.ToInt32(ReadLine());
                    if (userInput != 1 && userInput != 2)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        if (userInput == 1)
                        {
                            language = 1;
                        }
                        else
                        {
                            language = 2;
                        }
                    }
                }
                catch
                {
                    WriteLine("Wrong input!-_-");
                }
            }
            Clear();

            if (language == 1)
            {
                try
                {
                    for (int i = 0; i < 20; i++)
                    {
                        if (english[i] != "")
                        {
                            WriteLine("Enter the translation of " + english[i] + ". (~ ° w°)~");
                            string input = ReadLine();
                            if (input == german[i])
                            {
                                WriteLine("Right. Enter to continue.(^.^)/ ");

                                ReadLine();
                                Clear();
                            }
                            else
                            {
                                ForegroundColor = ConsoleColor.Red;
                                WriteLine("False. π.π The right answer is " + german[i]+". Enter to continue.");

                                ReadLine();
                                Clear();
                                ForegroundColor = ConsoleColor.Gray;
                            }
                        }
                        else
                        {

                        }
                    }
                }
                catch
                {

                }
            }
            if (language == 2)
            {
                try
                {
                    for (int i = 0; i < 20; i++)
                    {
                        if (german[i] != "")
                        {
                            WriteLine("Enter the translation of " + german[i] + ".");
                            string input = ReadLine();
                            if (input == english[i])
                            {
                                WriteLine("Right. Enter to continue.(^o^)/");
                                ReadLine();
                                Clear();
                            }
                            else
                            {
                                ForegroundColor = ConsoleColor.Red;
                                WriteLine("False.(π.π\") The right answer is " + english[i] + ". Enter to continue.");
                                ReadLine();
                                Clear();
                                ForegroundColor = ConsoleColor.Gray;
                            }
                        }
                        else
                        {

                        }

                    }
                }
                catch
                {

                }
            }
        }
    }
}