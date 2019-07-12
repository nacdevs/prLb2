using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Entidades
{
    public class Avion: IAvion
    {
        private int horasVuelo;
        private Thread vuelo;       
        public event ReporteDeEstado ReportarEstado;
        private EstadoVuelo estado;
        private int horasDeVuelo;

        public EstadoVuelo Estado { get => estado; }
        public int HorasDeVuelo { get => horasDeVuelo; }

        public Avion(int horasVuelo) {
            if (vuelo == null)
            {
                estado = EstadoVuelo.Programado;
            }
            else {
                if (vuelo != null)
                {
                    if (vuelo.IsAlive) {
                        estado = EstadoVuelo.Volando;
                    }
                    else
                    {
                        estado = EstadoVuelo.Aterrizado;
                    }
                }
            }
        }

        public void Despegar() {
            vuelo = new Thread(Volar);
        }

        public void Estrellar() {
            if (vuelo.IsAlive)
            {
                vuelo.Abort();
            }
        }

        public void Volar()
        {
            Thread.Sleep(1000);
            int horasRestantes = this.horasVuelo - 1 ;
            int porcentajeCompletado = 100;
            while (porcentajeCompletado <= 100)
            {
                ReportarEstado(horasDeVuelo, horasRestantes);
            }
            
        }
        public enum EstadoVuelo {
            Programado,Volando,Aterrizado
        }
    }
}
