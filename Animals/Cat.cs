using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Cat:Animal
    {
        public Cat() {
            Name = "Cat";
        }
        public override void Speak()
        {
            Speak("Miauuuuuuuuuu!");
        }
    }
}
