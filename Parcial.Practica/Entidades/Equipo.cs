using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Equipo
    {
        const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set { directorTecnico = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }
        

        private Equipo() { }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre equipo:" + e.nombre);
            if (e.directorTecnico.Mostrar() != null)
            {
                sb.Append("DT: " + e.directorTecnico.Mostrar());
            }
            else
            {
                sb.Append("DT: Sin DT asignado");
            }

            for (int i = 0; i < e.jugadores.Count(); i++)
            {
                sb.Append(e.jugadores[i].Mostrar()+"\n");
            }
            
            return "a";
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            bool ret = false;
            return ret;
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            Equipo e2;
            return  e2;
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool ret = false;
            return ret;
        }
    }
}
