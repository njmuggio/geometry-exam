namespace GeometryExam
{
    /// <summary>
    /// A square.
    /// </summary>
    public class Square : PrimitiveShape
    {
        /// <summary>
        /// The square's side lengths.
        /// </summary>
        public double SideLength { get; set; }

        /// <summary>
        /// Rotation of the square, in radians..
        /// </summary>
        public double Orientation { get; set; }

        /// <summary>
        /// The square's area.
        /// </summary>
        public override double Area => SideLength * SideLength;

        /// <summary>
        /// The square's perimeter.
        /// </summary>
        public override double Perimeter => SideLength * 4;
    }
}
