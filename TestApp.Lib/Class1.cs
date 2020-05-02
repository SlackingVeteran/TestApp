using System;
using System.Linq;
using System.Text;

namespace TestApp.Lib
{
    public class Class1
    {
        public int GetARandomInt()
        {
            return new Random().Next();
        }

        public string GetARandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
