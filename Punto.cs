using System.Reflection.Metadata.Ecma335;

class Punto : IGrafico{
    public int x {get; private set;}
    public int y {get; private set;}

    public Punto(int x, int y){
        this.x = x;
        this.y = y;
    }
    public bool mover(int x, int y) => x > 800 && y > 600;
    public string dibujar() => $"({x}x{y})";
}