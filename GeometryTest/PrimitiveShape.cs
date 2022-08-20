namespace GeometryExam
{
    /// <summary>
    /// A primitive shape specified by its center and various additional properties.
    /// </summary>
    public abstract class PrimitiveShape : Shape
    {
        /// <summary>
        /// X component of the shape's center point.
        /// </summary>
        public double CenterX { get; set; }

        /// <summary>
        /// Y component of the shape's center point.
        /// </summary>
        public double CenterY { get; set; }

        /// <summary>
        /// The shape's centroid. This matches its center point, by definition.
        /// </summary>
        public override Point Centroid => new(CenterX, CenterY);
    }
}
