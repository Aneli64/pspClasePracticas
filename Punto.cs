using System.Reflection.Metadata.Ecma335;

class Punto : IGrafico{
    public int x {get; private set;}
    public int y {get; private set;}

    public Punto(int x, int y){
        this.x = x;
        this.y = y;
    }

    public bool mover(int x, int y)
    {
        if (x >= 0 && x <= 800 && y >= 0 && y <= 600)
        {
            return true;
        }
        return false;
    }
    public string dibujar() => $"({x}x{y})";
}