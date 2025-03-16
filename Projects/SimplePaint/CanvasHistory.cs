using System;
using System.Collections.Generic;

namespace SimplePaint
{
    public class CanvasHistory
    {
        private Stack<Memento> history = new Stack<Memento>();

        public void SaveState(Memento memento)
        {
            history.Push(memento);
        }

        public Memento Undo()
        {
            if (history.Count > 0)
                return history.Pop();
            return null;
        }
    }
}
