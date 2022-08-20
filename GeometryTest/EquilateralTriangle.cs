namespace GeometryExam
{
    /// <summary>
    /// An equilateral triangle.
    /// </summary>
    public class EquilateralTriangle : PrimitiveShape
    {
        /// <summary>
        /// Length of each side.
        /// </summary>
        public double SideLength { get; set; }

        /// <summary>
        /// Rotation of one of the sides, in radians.
        /// 
        /// Note: This orientation is ambiguous; there are two possible orientations for every rotation as specified.
        /// </summary>
        public double Orientation { get; set; }

        /// <summary>
        /// The triangle's area.
        /// </summary>
        public override double Area => Math.Sqrt(3) / 4 * SideLength * SideLength;

        /// <summary>
        /// The triangle's perimeter.
        /// </summary>
        public override double Perimeter => SideLength * 3;
    }
}
