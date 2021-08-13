/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>


namespace Design_Patterns.Behavioral.Memento.StucturalCode
{
	/// <summary>
	/// The 'Memento' class
	/// </summary>
	public class Memento
    {
        string state;
        // Constructor
        public Memento(string state)
        {
            this.state = state;
        }
        public string State
        {
            get { return state; }
        }
    }
}
