/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Bridge.StructrualCode
{
	/// <summary>
	/// The 'Abstraction' class
	/// </summary>
	public class Abstraction
    {
        protected Implementor implementor;
        public Implementor Implementor
        {
            set { implementor = value; }
        }
        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
