/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Memento.StucturalCode
{
	public class Originator
    {
        string state;
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State = " + state);
            }
        }
        // Creates memento 
        public Memento CreateMemento()
        {
            return (new Memento(state));
        }
        // Restores original state
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }
}
