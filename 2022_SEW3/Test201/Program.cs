using System;

namespace Test201
{
    class Program
    {
        static void Main(string[] args)
        {
            Vocabulary test = new Vocabulary();
            /*test.AddWord("Haus", "house");
            test.AddWord("Weihnachten", "christmas");
            test.AddWord("Beamer", "BMW");
            test.AddWord("Hund", "dog");*/
            test.LoadVocabulary("D:\\Git\\2022_SEW3_Johannes_Werner\\2022_SEW3\\Test201\\saves.txt");
            test.AllVocabulary();
            test.Train(10);
            test.SaveVocabulary("D:\\Git\\2022_SEW3_Johannes_Werner\\2022_SEW3\\Test201\\saves.txt");
        }
    }
}
