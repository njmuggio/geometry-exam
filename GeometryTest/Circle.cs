namespace GeometryExam
{
    /// <summary>
    /// A circle.
    /// </summary>
    public class Circle : PrimitiveShape
    {
        /// <summary>
        /// The circle's radius.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// The circle's area.
        /// </summary>
        public override double Area => Math.PI * Radius * Radius;

        /// <summary>
        /// The circle's circumference.
        /// </summary>
        public override double Perimeter => Math.PI * Radius * 2;
    }
}
