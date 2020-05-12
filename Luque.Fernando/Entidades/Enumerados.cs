using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public enum Eturno
    {
        mañana, tarde
    }

    public enum ECargo
    {
        Porteria = 100,
        Cocina = 110,
        Secretaria = 140,
        Tesoreria = 240,
        Direccion = 180

    }

    public enum EColores
    {
        Naranja, Rojo, Amarillo, Verde
    }

    public enum EParentesco
    {
        Madre=0, Padre=1, Tia=2, Tio=3, Abuela=4, Abuelo=5, Otro=6
    }
    
}
