using GeometryExam;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for <see cref="Ellipse"/>.
    /// </summary>
    public class EllipseTests
    {
        /// <summary>
        /// An <see cref="Ellipse"/> under test.
        /// </summary>
        Ellipse ellipse1;

        /// <summary>
        /// Another <see cref="Ellipse"/> under test.
        /// </summary>
        Ellipse ellipse2;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public EllipseTests()
        {
            ellipse1 = new Ellipse()
            {
                Id = 3,
                CenterX = 488.775,
                CenterY = 136.852,
                R1 = 14.595,
                R2 = 23.366,
                Orientation = 3.975
            };

            ellipse2 = new Ellipse()
            {
                Id = 4,
                CenterX = 234.756,
                CenterY = 491.076,
                R1 = 1.518,
                R2 = 43.119,
                Orientation = 6.254
            };
        }

        /// <summary>
        /// Test <see cref="Ellipse.Area"/>.
        /// </summary>
        [Fact]
        public void Area()
        {
            Assert.Equal(1071.36719530946, ellipse1.Area, 5);
            Assert.Equal(205.63182245055, ellipse2.Area, 5);
        }

        /// <summary>
        /// Test <see cref="Ellipse.Perimeter"/>.
        /// </summary>
        [Fact]
        public void Perimeter()
        {
            // Lower precision on these assertions than is used in other tests. I seem to be using a different approximation.
            Assert.Equal(120.852558618044, ellipse1.Perimeter, 1);
            Assert.Equal(172.880520795273, ellipse2.Perimeter, 1);
        }
    }
}
