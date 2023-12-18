class Circulo : Punto{
    private int _radio;

    public int radio
    {
        get { return _radio; }
        private set
        {
            if (value >= 0) _radio = value;
        }
    }

    public Circulo(int x, int y, int radio) : base(x, y){
        this.radio = radio;
    }
}