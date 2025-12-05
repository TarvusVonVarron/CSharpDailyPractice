using System;
using System.Collections.Generic;

namespace IntefracesAbstractions.Task3
{
    public static class ShapeScaler
    {
        public static void ScaleAll(IEnumerable<Shape> shapes, double factor)
        {
            if (shapes == null)
                throw new ArgumentNullException(nameof(shapes));

            foreach (var shape in shapes)
            {
                if (shape is IResizable resizable)
                {
                    resizable.Resize(factor);
                }
            }
        }
    }
}
