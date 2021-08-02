/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>

using System;

namespace Design_Patterns.Structural.Flyweight.StructuralCode
{
	/// <summary>
	/// The 'ConcreteFlyweight' class
	/// </summary>
	public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
        }
    }
}
