using GeometryExam;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for <see cref="Square"/>.
    /// </summary>
    public class SquareTests
    {
        /// <summary>
        /// A <see cref="Square"/> under test.
        /// </summary>
        Square square1;

        /// <summary>
        /// Another <see cref="Square"/> under test.
        /// </summary>
        Square square2;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SquareTests()
        {
            square1 = new Square()
            {
                Id = 1,
                CenterX = 363.122,
                CenterY = 408.663,
                SideLength = 76.802,
                Orientation = 3.507
            };

            square2 = new Square()
            {
                Id = 2,
                CenterX = 103.017,
                CenterY = 279.442,
                SideLength = 90.603,
                Orientation = 2.778
            };
        }

        /// <summary>
        /// Test <see cref="Square.Area"/>.
        /// </summary>
        [Fact]
        public void Area()
        {
            Assert.Equal(5898.547204, square1.Area, 5);
            Assert.Equal(8208.903609, square2.Area, 5);
        }

        /// <summary>
        /// Test <see cref="Square.Perimeter"/>.
        /// </summary>
        [Fact]
        public void Perimeter()
        {
            Assert.Equal(307.208, square1.Perimeter, 5);
            Assert.Equal(362.412, square2.Perimeter, 5);
        }
    }
}
