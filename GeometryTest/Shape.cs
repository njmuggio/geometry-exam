namespace GeometryExam
{
    /// <summary>
    /// A simple 2D point.
    /// </summary>
    public class Point
    {
        /// <summary>
        /// X component.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y component.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Default constructor. Produces a point representing the origin.
        /// </summary>
        public Point()
        {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Construct a point.
        /// </summary>
        /// <param name="x">X component.</param>
        /// <param name="y">Y component.</param>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    /// <summary>
    /// Specifies basic properties of all shapes.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Shape ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The shape's area. Derived from other shape properties.
        /// </summary>
        public abstract double Area { get; }

        /// <summary>
        /// The shape's perimeter. Derived from other shape properties.
        /// </summary>
        public abstract double Perimeter { get; }

        /// <summary>
        /// The shape's centroid. Derived from other shape properties.
        /// </summary>
        public abstract Point Centroid { get; }
    }
}
