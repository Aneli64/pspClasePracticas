class Circulo : Punto{
    public int radio {get; private set;}

    public Circulo(int x, int y, int radio) : base(x, y){
        this.radio = radio;
    }
}