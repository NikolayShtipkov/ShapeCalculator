namespace ShapeCalculator.Shapes
{
    public class Triangle
    {
        private readonly double _length;

        public Triangle(double length)
        {
            _length = length;
        }

        public double GetArea()
        {
            double area = (Math.Sqrt(3) / 4) * _length * _length;

            return area;
        }

        public double GetCircumference()
        {
            double circumference = 3 * _length;

            return circumference;
        }
    }
}
