using GeometryExam;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for <see cref="Polygon"/>.
    /// 
    /// Note: geometric tests use require lower precision in this class than other test classes due to increased floating point error during calculations.
    /// </summary>
    public class PolygonTests
    {
        /// <summary>
        /// A <see cref="Polygon"/> under test.
        /// </summary>
        Polygon polygon1;

        /// <summary>
        /// Another <see cref="Polygon"/> under test.
        /// </summary>
        Polygon polygon2;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public PolygonTests()
        {
            polygon1 = new Polygon()
            {
                Id = 9,
                XCoordinates = new double[] {
                  136.726,
                  494.272,
                  478.728,
                  381.482,
                  228.604,
                  190.502,
                  136.726
                },
                YCoordinates = new double[] {
                  453.549,
                  321.349,
                  252.565,
                  15.197,
                  73.413,
                  171.571,
                  453.549
                }
            };

            polygon2 = new Polygon()
            {
                Id = 10,
                XCoordinates = new double[] {
                  97.457,
                  412.712,
                  429.11,
                  312.433,
                  97.457
                },
                YCoordinates = new double[] {
                  439.096,
                  367.699,
                  339.875,
                  109.203,
                  439.096
                }
            };
        }

        /// <summary>
        /// Test <see cref="Polygon.Area"/>.
        /// </summary>
        [Fact]
        public void Area()
        {
            Assert.Equal(92802.3130010731, polygon1.Area, 2);
            Assert.Equal(47840.3766543106, polygon2.Area, 2);
        }

        /// <summary>
        /// Test <see cref="Polygon.Perimeter"/>.
        /// </summary>
        [Fact]
        public void Perimeter()
        {
            Assert.Equal(1264.17855076496, polygon1.Perimeter, 2);
            Assert.Equal(1007.79325769393, polygon2.Perimeter, 2);
        }

        /// <summary>
        /// Test <see cref="Polygon.Centroid"/>.
        /// </summary>
        [Fact]
        public void Centroid()
        {
            Assert.Equal(309.677699364237, polygon1.Centroid.X, 2);
            Assert.Equal(237.888370259305, polygon1.Centroid.Y, 2);
            Assert.Equal(282.322058285915, polygon2.Centroid.X, 2);
            Assert.Equal(302.902987984084, polygon2.Centroid.Y, 2);
        }
    }
}
