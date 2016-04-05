using System.Collections.Generic;
using System.IO;

namespace WorkshopApp1
{
    public class TelephoneDirectory
    {
        // Variables for storing the phonebook filepath and a personList
        private const string filePathAndName = "C:/testfiles/phonebook.dat";
        private static List<Person> personList = new List<Person>();
        
        // Put person in a list
        public static void SavePersonToList(Person person)
        {
            personList.Add(person);
        }

        // Get person from list
        public static List<Person> LoadPersonFromList()
        {
            return personList;
        }

        // Save person data in file
        public static void CreateOrOpenTelephoneDirectory(Person person)
        {
            TextWriter phoneBookFileStream = new StreamWriter(filePathAndName, true);
            phoneBookFileStream.WriteLine(person.ToString());
            phoneBookFileStream.Close();
        }

        // Load person data from file
        public static string[] ListPersonsFromPhoneBook()
        {
            string[] lines = File.ReadAllLines(filePathAndName);
            return lines;
        }
    }
}