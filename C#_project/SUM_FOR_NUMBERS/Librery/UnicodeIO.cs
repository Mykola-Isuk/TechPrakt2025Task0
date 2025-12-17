using System;
using System.Text;

namespace Library
{
    public class UnicodeIO
    {
        public void SetupUnicode()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
        }
    }
}
