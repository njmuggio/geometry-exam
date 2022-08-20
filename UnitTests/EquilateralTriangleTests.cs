using GeometryExam;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for <see cref="EquilateralTriangle"/>.
    /// </summary>
    public class EquilateralTriangleTests
    {
        /// <summary>
        /// An <see cref="EquilateralTriangle"/> under test.
        /// </summary>
        EquilateralTriangle triangle1;

        /// <summary>
        /// Another <see cref="EquilateralTriangle"/> under test.
        /// </summary>
        EquilateralTriangle triangle2;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public EquilateralTriangleTests()
        {
            triangle1 = new EquilateralTriangle()
            {
                Id = 7,
                CenterX = 349.971,
                CenterY = 263.142,
                SideLength = 93.402,
                Orientation = 4.32
            };

            triangle2 = new EquilateralTriangle()
            {
                Id = 8,
                CenterX = 273.408,
                CenterY = 40.555,
                SideLength = 18.712,
                Orientation = 2.848
            };
        }

        /// <summary>
        /// Test <see cref="EquilateralTriangle.Area"/>.
        /// </summary>
        [Fact]
        public void Area()
        {
            Assert.Equal(3777.57406099637, triangle1.Area, 5);
            Assert.Equal(151.614610179128, triangle2.Area, 5);
        }

        /// <summary>
        /// Test <see cref="EquilateralTriangle.Perimeter"/>.
        /// </summary>
        [Fact]
        public void Perimeter()
        {
            Assert.Equal(280.206, triangle1.Perimeter, 5);
            Assert.Equal(56.136, triangle2.Perimeter, 5);
        }
    }
}
