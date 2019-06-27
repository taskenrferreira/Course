using ShapeTest.Model.Enums;

namespace ShapeTest.Model.Entities {
    abstract class AbstractShape : IShape {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
