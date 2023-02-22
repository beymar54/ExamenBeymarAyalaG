using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenBeymarAyalaG
{
    internal interface IPoligono
    {
        public double area(double valor1, double valor2);

    }
    public class Triangulo : FiguraGeometrica, IPoligono
    {
        double BaseT { get; set; }  
        double AlturaT { get; set; }

        public double area(double ibaseT, double ialturaT)
        {
            double CalcularArea = (ibaseT * ialturaT) / 2;
            return CalcularArea;
        }
        public Triangulo(double baseT, double alturaT, string nombreT)
        {
            BaseT = baseT;
            AlturaT = alturaT;
            nombre = nombreT;
        }
        public override string ToString()
        {
            double Area=area(BaseT, AlturaT);
            string AreaNombre=Area.ToString()+" "+nombre;
            return AreaNombre;
        }

    }
    public class Rectangulo : FiguraGeometrica, IPoligono
    {
        double LargoR { get; set; }
        double AnchoR { get; set; }
        public double area(double ilargoR, double ianchoR)
        {
            double CalcularArea= ilargoR* ianchoR;
            return CalcularArea;
        }
        public Rectangulo(double largoR, double anchoR, string nombreR)
        {
            LargoR = largoR;
            AnchoR = anchoR;
            nombre = nombreR;
        }
        public override string ToString() 
        { 
            double Area=area(LargoR, AnchoR);
            string AreaNombre= Area.ToString()+" "+nombre;
            return AreaNombre;
        }
    }
    public class Paralelogramo : FiguraGeometrica, IPoligono
    {
        double BaseP { get; set; }
        double AlturaP { get; set; }
        public double area(double ibaseP, double ialturaP)
        {
            double CalcularArea=ibaseP* ialturaP;
            return CalcularArea;
        }
        public Paralelogramo(double baseP, double alturaP, string nombreP)
        {
            BaseP = baseP;
            AlturaP = alturaP;
            nombre=nombreP;
        }
        public override string ToString()
        {
            double Area=area(BaseP, AlturaP);
            string AreaNombre=Area.ToString()+" "+nombre;
            return AreaNombre;
        }
    }
}
