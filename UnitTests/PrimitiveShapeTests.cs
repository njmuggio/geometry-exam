using GeometryExam;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for <see cref="PrimitiveShape"/>.
    /// </summary>
    public class PrimitiveShapeTests
    {
        /// <summary>
        /// Test <see cref="PrimitiveShape.Centroid"/>.
        /// </summary>
        [Fact]
        public void Centroid()
        {
            Circle circle = new()
            {
                Id = 42,
                CenterX = 568.156,
                CenterY = -456.758,
                Radius = 73.927
            };

            Assert.Equal(568.156, circle.Centroid.X, 5);
            Assert.Equal(-456.758, circle.Centroid.Y, 5);
        }
    }
}
