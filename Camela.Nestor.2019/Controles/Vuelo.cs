using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Controles
{
    public partial class Vuelo : UserControl, IAvion
    {
        private Avion avion;
        public Vuelo(int horasVuelo)
        {
            
            InitializeComponent();
            avion = new Avion(horasVuelo);
            avion.ReportarEstado += MoverAvion;

            
        }

        public Avion.EstadoVuelo Estado => throw new NotImplementedException();

        public void Despegar()
        {
            this.picAvion.Visible = true;
        }

        public void Estrellar()
        {

        }

        public int MoverAvion(int horasTotales, int horasRestantes)
        {
            if (this.picAvion.InvokeRequired)
            {
                ReporteDeEstado d = new ReporteDeEstado(MoverAvion);
                this.Invoke(d, new object[] { horasTotales, horasRestantes });
                return 1;
            }
            else
            {
                int porcentajeCompletado = 100 - (horasRestantes * 100) / horasTotales;
                // 664 es 100% entonces X es el porcentajeCompletado
                int ejeX = (664 * porcentajeCompletado) / 100;
                if (ejeX > 664)
                    ejeX = 664;

                this.picAvion.Location = new Point(ejeX + 58, this.picAvion.Location.Y);

                return porcentajeCompletado;
            }
        }
    }
}
