namespace GeometryExam
{
    /// <summary>
    /// A polygon.
    /// </summary>
    public class Polygon : Shape
    {
        /// <summary>
        /// X components of the polygon's vertices. Elements in this array are matched pairwise with those in <see cref="YCoordinates"/>.
        /// </summary>
        public double[] XCoordinates { get; set; }

        /// <summary>
        /// Y components of the polygon's vertices. Elements in this array are matched pairwise with those in <see cref="XCoordinates"/>.
        /// </summary>
        public double[] YCoordinates { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Polygon()
        {
            XCoordinates = Array.Empty<double>();
            YCoordinates = Array.Empty<double>();
        }

        /// <summary>
        /// Backing field for <see cref="SignedArea"/>.
        /// </summary>
        private double? _signedArea;

        /// <summary>
        /// Signed area of the polygon.
        /// </summary>
        public double SignedArea
        {
            get
            {
                if (!_signedArea.HasValue)
                {
                    ValidatePoints();

                    double area = Det(XCoordinates[^1], XCoordinates[0], YCoordinates[^1], YCoordinates[0]);

                    for (int i = 0; i < XCoordinates.Length - 1; i++)
                    {
                        area += Det(XCoordinates[i], XCoordinates[i + 1], YCoordinates[i], YCoordinates[i + 1]);
                    }

                    _signedArea = area / 2;
                }

                return _signedArea.Value;
            }
        }

        /// <summary>
        /// Area of the polygon. Always non-negative.
        /// </summary>
        public override double Area => Math.Abs(SignedArea);

        /// <summary>
        /// Backing field for <see cref="Perimeter"/>.
        /// </summary>
        private double? _perimeter;

        /// <summary>
        /// The polygon's perimeter.
        /// </summary>
        public override double Perimeter
        {
            get
            {
                if (!_perimeter.HasValue)
                {
                    ValidatePoints();

                    double len = SegmentLength(XCoordinates[0], YCoordinates[0], XCoordinates[^1], YCoordinates[^1]);

                    for (int i = 0; i < XCoordinates.Length - 1; i++)
                    {
                        len += SegmentLength(XCoordinates[i], YCoordinates[i], XCoordinates[i + 1], YCoordinates[i + 1]);
                    }

                    _perimeter = len;
                }

                return _perimeter.Value;
            }
        }

        /// <summary>
        /// Backing field for <see cref="Centroid"/>.
        /// </summary>
        private Point? _centroid;

        /// <summary>
        /// The polygon's centroid.
        /// </summary>
        public override Point Centroid
        {
            get
            {
                if (_centroid == null)
                {
                    ValidatePoints();

                    double cx = 0;
                    double cy = 0;
                    double term1 = 1.0 / (6 * SignedArea);

                    for (int i = 0; i < XCoordinates.Length - 1; i++)
                    {
                        double term2 = XCoordinates[i] * YCoordinates[i + 1] - XCoordinates[i + 1] * YCoordinates[i];

                        cx += (XCoordinates[i] + XCoordinates[i + 1]) * term2;
                        cy += (YCoordinates[i] + YCoordinates[i + 1]) * term2;
                    }

                    _centroid = new Point(cx * term1, cy * term1);
                }

                return _centroid;
            }
        }

        /// <summary>
        /// Validates the <see cref="XCoordinates"/> and <see cref="YCoordinates"/> arrays.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if the coordinate arrays do not form a valid polygon.</exception>
        private void ValidatePoints()
        {
            if (XCoordinates.Length != YCoordinates.Length)
            {
                throw new InvalidOperationException("Coordinate array length mismatch");
            }

            if (XCoordinates.Length < 3)
            {
                throw new InvalidOperationException("Too few points to form polygon");
            }
        }

        /// <summary>
        /// Computes the length of a line segment.
        /// </summary>
        /// <param name="x1">X component of the first point.</param>
        /// <param name="y1">Y component of the first point.</param>
        /// <param name="x2">X component of the second point.</param>
        /// <param name="y2">Y component of the second point.</param>
        /// <returns>Length of the line segment.</returns>
        private static double SegmentLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        /// <summary>
        /// Computes the determinant of a 2x2 matrix.
        /// </summary>
        /// <param name="a">Element 1,1.</param>
        /// <param name="b">Element 2,1.</param>
        /// <param name="c">Element 1,2.</param>
        /// <param name="d">Element 2,2.</param>
        /// <returns>Determinant of the 2x2 matrix.</returns>
        private static double Det(double a, double b, double c, double d)
        {
            return a * d - b * c;
        }
    }
}
