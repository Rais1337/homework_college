using System;
using System.Drawing;

namespace SimplePaint
{
    public class Memento
    {
        public Bitmap State { get; }

        public Memento(Bitmap state)
        {
            State = (Bitmap)state.Clone();
        }
    }
}
