using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using ProjCharGenerator;

namespace generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator genChar = new BigrammChar();
            Generator genWord = new BigrammWord();
            Generator genPairWords = new BigrammPairWord();

            string charStr = genChar.GetText();
            string wordStr = genWord.GetText();
            string pairWordStr = genPairWords.GetText();

            Console.WriteLine("Generated sequence of letters: ");
            Console.WriteLine(charStr);

            Console.WriteLine("\nGenerated sequence of words: ");
            Console.WriteLine(wordStr);

            Console.WriteLine("\nGenerated sequence of word pairs: ");
            Console.WriteLine(pairWordStr);

            string pathSave = "result\\";
            FileSave(pathSave + "CharGenerated.txt", charStr);
            FileSave(pathSave + "WordGenerated.txt", wordStr);
            FileSave(pathSave + "PairWordGenerated.txt", pairWordStr);

            Console.ReadLine();
        }

        static void FileSave(string path, string text)
        {
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(text);
            sw.Close();
        }
    }
}

