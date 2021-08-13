/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Compsite.Sample
{
	/// <summary>
	/// The 'Component' Treenode
	/// </summary>
	public abstract class DrawingElement
    {
        protected string name;
        // Constructor
        public DrawingElement(string name)
        {
            this.name = name;
        }
        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);
    }
}
