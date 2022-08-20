using GeometryExam;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for <see cref="Circle"/>.
    /// </summary>
    public class CircleTests
    {
        /// <summary>
        /// A <see cref="Circle"/> under test.
        /// </summary>
        Circle circle1;

        /// <summary>
        /// Another <see cref="Circle"/> under test.
        /// </summary>
        Circle circle2;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public CircleTests()
        {
            circle1 = new Circle()
            {
                Id = 5,
                CenterX = 338.591,
                CenterY = 157.296,
                Radius = 40.845
            };

            circle2 = new Circle()
            {
                Id = 6,
                CenterX = 424.026,
                CenterY = 495.951,
                Radius = 1.631
            };
        }

        /// <summary>
        /// Test <see cref="Circle.Area"/>.
        /// </summary>
        [Fact]
        public void Area()
        {
            Assert.Equal(5241.16308482082, circle1.Area, 5);
            Assert.Equal(8.35714225496608, circle2.Area, 5);
        }

        /// <summary>
        /// Test <see cref="Circle.Perimeter"/>.
        /// </summary>
        [Fact]
        public void Perimeter()
        {
            Assert.Equal(256.63670387175, circle1.Perimeter, 5);
            Assert.Equal(10.2478752360099, circle2.Perimeter, 5);
        }
    }
}
