using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class GraficoCompuesto : IGrafico{

    public List<Punto> puntos;

    public bool mover(int x, int y) => x > 800 && y > 600;
    public string dibujar(){
        var salida = "";
        for (int i =0; i<= puntos.Count; i++ ){
            salida += $"({puntos[i].x}x{puntos[i].y})";
        }
        return salida;
    }

}