using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputOutputLecture.Models;
using System.IO;
using System.Threading;

namespace InputOutputLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //var p = Person.GenerateListOfPeople();

            //var allAccountants = p.Where(x => x.Occupation.ToLower() == "accountant" && x.Age > 33);


            //string accountantString = "";

            //foreach (var acc in allAccountants)
            //{
            //    accountantString += $"Name: {acc.FirstName} {acc.LastName} Age: {acc.Age}" + Environment.NewLine + "-------------------------" + Environment.NewLine;
            //}

            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //File.WriteAllText(docPath + @"\accountants.txt", accountantString);

            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string docPath = location + @"\poem.txt";

            try
            {
                using (StreamReader sr = new StreamReader(docPath))
                {
                    string poem = sr.ReadToEnd();

                    foreach (char c in poem)
                    {
                        Console.Write(c);
                        Thread.Sleep(80);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message); 
            }

        }
    }
}
