/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>

using System;

namespace Design_Patterns.Structural.Compsite.StructrualCode
{
	/// <summary>
	/// The 'Leaf' class
	/// </summary>
	public class Leaf : Component
    {
        // Constructor
        public Leaf(string name)
            : base(name)
        {
        }
        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }
        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
