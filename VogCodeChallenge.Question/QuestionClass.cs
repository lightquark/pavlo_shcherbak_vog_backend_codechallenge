using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.Question
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "jeffrey"
        };

        public static void TestQuestion()
        {
            // Original version
            using (var enumerator = NamesList.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }

            // There are several options to write the similar code in the different way

            // 1. classic for
            for(int i = 0; i < NamesList.Count; i++)
            {
                Console.WriteLine(NamesList[i]);
            }

            // 2. foreach
            foreach (string name in NamesList)
            {
                Console.WriteLine(name);
            }

            // 3. linq
            NamesList.ForEach(name => Console.WriteLine(name));
        }
    }
}
