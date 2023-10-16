class Rectangulo : Punto{
    
    public int ancho {get; private set;}
    public int alto {get; private set;}
    public Rectangulo(int x, int y, int ancho, int alto) : base(x,y){
        this.ancho = ancho;
        this.alto = alto;

    }
}