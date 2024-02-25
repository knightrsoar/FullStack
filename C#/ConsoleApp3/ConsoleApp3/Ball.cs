namespace COnsoleApp3;

public class Ball
{
    public int Size { get; private set; }
    public Color Color { get; set; }
    private int throwCount;

    public Ball(Color color, int size)
    {
        Color = color;
        Size = size;
    }

    public void Pop() => Size = 0;

    public void Throw()
    {
        if (Size > 0) throwCount++;
    }

    public int GetThrowCount() => throwCount;
}