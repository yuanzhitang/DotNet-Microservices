/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>


namespace Design_Patterns.Behavioral.Memento.StucturalCode
{
	/// <summary>
	/// The 'Caretaker' class
	/// </summary>
	public class Caretaker
    {
        Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
