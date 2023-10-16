class Punto : IGrafico{
    public int x {get; private set;}
    public int y {get; private set;}

    public Punto(int x, int y){
        this.x = x;
        this.y = y;
    }

    public bool Mover(){
        return true;
    }
    public bool dibujar(){
        return true;
    }
}