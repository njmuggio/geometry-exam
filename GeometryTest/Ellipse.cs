namespace GeometryExam
{
    /// <summary>
    /// An ellipse.
    /// </summary>
    public class Ellipse : PrimitiveShape
    {
        /// <summary>
        /// Semimajor or semiminor axis.
        /// </summary>
        public double R1 { get; set; }
        
        /// <summary>
        /// Semiminor or semimajor axis. If <see cref="R1"/> contains the semimajor axis, this must contain the semiminor axis, and vice versa.
        /// </summary>
        public double R2 { get; set; }

        /// <summary>
        /// Rotation of R1, in radians.
        /// </summary>
        public double Orientation { get; set; }

        /// <summary>
        /// The ellipse's area.
        /// </summary>
        public override double Area => Math.PI * R1 * R2;

        /// <summary>
        /// The ellipse's approximate perimeter. This is estimated using Ramanujan's second approximation.
        /// </summary>
        public override double Perimeter
        {
            get
            {
                double h = Math.Pow((R1 - R2) / (R1 + R2), 2);
                return Math.PI * (R1 + R2) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
            }
        }
    }
}
