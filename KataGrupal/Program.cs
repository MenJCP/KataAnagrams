using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;

namespace KataGrupal
{
     public class Program
    {
        public class Anagram
        {
            public Hashtable ListAnagrams;
            public Hashtable Index;
           
            public List<string> readTxt(string path)
            {
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                List<string> Words = new List<string>();
                int o = 0;
            
                while ((line = file.ReadLine()) != null)
                {
                    Words[o] = line;
                    o++;
                }
                return Words;
           }
           
           
            public void FindAnagrams(string[] words)
            {  
                ListAnagrams = new Hashtable();
                Index = new Hashtable();

                for (int i = 0; i < words.Count(); i++)
                {
                    string Word = new String(words[i].OrderBy(x => x).ToArray());

                    if (ListAnagrams.ContainsKey(Word))
                    {
                        ListAnagrams[Word] = (ListAnagrams[Word] + ", " + words[i]);

                        if (!Index.ContainsKey(Word)) 
                        {
                            Index.Add(Word, Word);
                        }
                    }
                    else
                    {
                        ListAnagrams.Add(Word, words[i]);
                    }
                }
                
                 //IMPRIMIR
                int a = 0;
                foreach (DictionaryEntry item in Index)
                {
                    a++;
                    Console.WriteLine(ListAnagrams[item.Value]);
                }
                ConsoleWriteLine("cantidad " + a);
            }
        }
            
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    
}
}
