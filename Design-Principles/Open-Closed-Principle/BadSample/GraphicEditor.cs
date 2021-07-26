using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Open_Closed_Principle.BadSample
{
	public class GraphicEditor
	{
		public void DrawAllShapes(IList<Shape> shapes)
		{
			foreach(var shape in shapes)
			{
				if(shape.Type == ShapeType.Circle)
				{
					DrawCircle(shape);
				}
				else if(shape.Type == ShapeType.Square)
				{
					DrawSquare(shape);
				}
				//else if(shape.Type == ShapeType.Triangle)
				//{
				//	DrawTriangle(shape);
				//}
			}
		}

		private void DrawSquare(Shape shape)
		{
			//throw new NotImplementedException();
		}

		private void DrawCircle(Shape shape)
		{
			//throw new NotImplementedException();
		}
	}
}
