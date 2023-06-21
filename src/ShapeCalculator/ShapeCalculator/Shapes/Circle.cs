namespace ShapeCalculator.Shapes
{
    public class Circle
    {
        private readonly double _radius;

        public Circle(double radius) 
        {
            _radius = radius;
        }

        public double GetArea()
        {
            double area = Math.PI * _radius * _radius;

            return area;
        }

        public double GetCircumference()
        {
            double circumference = 2 * Math.PI * _radius;

            return circumference;
        }
    }
}
