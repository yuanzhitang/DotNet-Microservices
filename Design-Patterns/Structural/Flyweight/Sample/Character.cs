/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>


namespace Design_Patterns.Structural.Flyweight.Sample
{
	/// <summary>
	/// The 'Flyweight' abstract class
	/// </summary>
	public abstract class Character
    {
        protected char symbol;
        protected int width;
        protected int height;
        protected int ascent;
        protected int descent;
        protected int pointSize;
        public abstract void Display(int pointSize);
    }
}
