/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>


namespace Design_Patterns.Behavioral.Memento.Sample
{
	/// <summary>
	/// The 'Caretaker' class
	/// </summary>
	public class ProspectMemory
    {
        Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
