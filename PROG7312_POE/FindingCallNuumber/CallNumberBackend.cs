using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE //.FindingCallNuumber
{
    public class CallNumberBackend
    {
        private List<string> generatedCallNumbers = new List<string>();
        private List<string> usedAuthors = new List<string>();

        /*
        public CallNumberBackend(double classificationNum, string authorName)
        {
            this.ClassificationNum = classificationNum;
            this.AuthorName = authorName;
        }

        private Random randy;
        public CallNumberBackend()
        {
            randy = new Random();
            // Empty constructor so the class can be instantiated to use its methods.
        }
        */

        public List<string> GenerateCallNumbers()
        {
            // Clear previous data
            generatedCallNumbers.Clear();
            usedAuthors.Clear();

            // Generate 10 random call numbers with unique author names
            Random random = new Random();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < 10; i++)
            {
                string author = GenerateUniqueAuthorName(random, alphabet);
                string callNumber = $"{random.Next(1000, 9999)}.{random.Next(10, 99)} {author}";
                generatedCallNumbers.Add(callNumber);
            }

            // Return the generated call numbers list
            return generatedCallNumbers;
        }

        private string GenerateUniqueAuthorName(Random random, string alphabet)
        {
            string author;
            do
            {
                char[] surname = new char[3];
                for (int i = 0; i < 3; i++)
                {
                    surname[i] = alphabet[random.Next(alphabet.Length)];
                }
                author = new string(surname);
            } while (usedAuthors.Contains(author));

            usedAuthors.Add(author);
            return author;
        }

    }

    //------------------------------------------------------------------------END OF CODE-----------------------------------------------------------//
}
