using Lab3.Contracts;
using System;

namespace Lab3.Services
{
    public class StringService : IStringRepository
    {
        string[] people = { "Tom", "Sam", "Andrey"};

        public string[] SortByAscending()
        {
            Array.Sort(people);
            return people;
        }

        public string SortByAscii()
        {
            string text = "Some text";
            char[] chars = text.ToCharArray();
            Array.Sort(chars);
            text = new string(chars);
            return text;
        }

        public string[] SortByDescending()
        {
            Array.Sort(people);
            Array.Reverse(people);
            return people;
        }
    }
}
