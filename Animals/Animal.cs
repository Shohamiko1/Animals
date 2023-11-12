using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Animal
    {
        private bool IsEating = false;
        protected string Name;

        public void Speak(string words)
        {
            if (IsEating)
            {
                StopEating();
            }
            Console.WriteLine("I am a " + Name + " and I say: " + words);
        }
        public virtual void Speak() { }
        public void StartEating()
        {
            IsEating = true;
        }
        public void StopEating()
        {
            IsEating = false;
        }
    }
}
