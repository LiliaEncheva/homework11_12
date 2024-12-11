using homework11_12;


class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[]
        {
            new Circle(),
            new Rectangle(),
            new Triangle()
        };

        // Извикване на метода Draw за всяка фигура чрез полиморфизъм
        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}