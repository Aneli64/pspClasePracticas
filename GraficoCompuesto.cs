using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class GraficoCompuesto : IGrafico{

    public List<Punto> puntos;

    public bool mover(int x, int y)
{
    if (x >= 0 && x <= 800 && y >= 0 && y <= 600)
    {
        return true;
    }
    return false;
}
    public string dibujar(){
        var salida = "";
        for (int i =0; i<= puntos.Count; i++ ){
            salida += $"({puntos[i].x}x{puntos[i].y})\n";
        }
        return salida;
    }

}