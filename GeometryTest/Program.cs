using System.Text.Json;

namespace GeometryExam
{
    internal class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        /// <returns>0 on success, anything else on failure.</returns>
        static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: GeometryExam.exe jsonInputPath csvOutputPath");
                return 1;
            }

            try
            {
                List<Shape> shapes = ParseShapesFile(args[0]);
                shapes = shapes.OrderBy(shape => shape.Id).ToList();
                WriteMetricsFile(shapes, args[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Parse a shapes JSON file.
        /// </summary>
        /// <param name="path">Path to the file.</param>
        /// <returns>List of shapes read from the file.</returns>
        private static List<Shape> ParseShapesFile(string path)
        {
            List<Shape> shapes = new();

            using (FileStream fs = File.OpenRead(path))
            {
                JsonDocument doc = JsonDocument.Parse(fs);
                
                shapes.AddRange(ParseShapeList<Square>(doc.RootElement.GetProperty("Squares")));
                shapes.AddRange(ParseShapeList<Ellipse>(doc.RootElement.GetProperty("Ellipses")));
                shapes.AddRange(ParseShapeList<Circle>(doc.RootElement.GetProperty("Circles")));
                shapes.AddRange(ParseShapeList<EquilateralTriangle>(doc.RootElement.GetProperty("EquilateralTriangles")));
                shapes.AddRange(ParseShapeList<Polygon>(doc.RootElement.GetProperty("Polygons")));
            }

            return shapes;
        }

        /// <summary>
        /// Parse a JSON array containing several shapes of a given type.
        /// </summary>
        /// <typeparam name="T">Type of shape to parse.</typeparam>
        /// <param name="element">JSON array to read.</param>
        /// <returns>List of shapes of the requested type.</returns>
        private static List<T> ParseShapeList<T>(JsonElement element)
        {
            return element.Deserialize<List<T>>() ?? new List<T>();
        }

        /// <summary>
        /// Write the shape metrics file.
        /// </summary>
        /// <param name="shapes">List of shapes to process and output.</param>
        /// <param name="path">Path to the output file.</param>
        private static void WriteMetricsFile(List<Shape> shapes, string path)
        {
            using StreamWriter stream = File.CreateText(path);

            stream.WriteLine("Id,Area,Perimeter,CentroidX,CentroidY");

            foreach (Shape shape in shapes)
            {
                stream.WriteLine("{0},{1},{2},{3},{4}", shape.Id, shape.Area, shape.Perimeter, shape.Centroid.X, shape.Centroid.Y);
            }
        }
    }
}