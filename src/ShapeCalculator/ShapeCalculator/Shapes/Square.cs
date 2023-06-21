namespace ShapeCalculator.Shapes
{
    public class Square
    {
        private readonly double _length;

        public Square(double length)
        {
            _length = length;
        }

        public double GetArea()
        {
            double area = _length * _length;

            return area;
        }

        public double GetCircumference()
        {
            double circumference = 4 * _length;

            return circumference;
        }
    }
}
