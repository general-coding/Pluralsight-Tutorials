using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Document : IStorable, ISpeak
    {
        public void Reformat()
        {
            Console.WriteLine("Reformatting the document");
        }

        public void Read(string nameOfFile)
        {
            Console.WriteLine("Reading from: {0}", nameOfFile);
        }

        public void Write(string fileName)
        {
            Console.WriteLine("Writing to: {0}", fileName);
        }

        public double DurationOfSpeech {
            get
            {
                return 42;
            }
        }

        public void Speak()
        {
            Console.WriteLine("Speak...");
        }
    }
}
