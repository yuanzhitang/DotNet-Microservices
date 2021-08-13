/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>

using System;
using System.Collections.Generic;

namespace Design_Patterns.Structural.Compsite.Sample
{
	/// <summary>
	/// The 'Composite' class
	/// </summary>
	public class CompositeElement : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        // Constructor
        public CompositeElement(string name)
            : base(name)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) +
                "+ " + name);
            // Display each child element on this node
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
}
