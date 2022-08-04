using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_FINAL
{
    public partial class Form1 : Form
    {
        int numero;
        int numeroHijos;
        string empleado;
        string area, condicion;
        double sueldoBase, movilidad, asignacion, descuentos, netoaCobrar;
        DateTime fecha;
        int cVentas, cMarketing, cLogistica, cPrestamos;
        public Form1()
        {
            InitializeComponent();
        }
        public bool validar(string valor1, string valor2, string valor3, string valor4)
        {

            if (valor1.Length == 0 || valor2.Length == 0 || valor3.Length==0 || valor4.Length==0)
            {
                MessageBox.Show("Faltan Datos");
                txtEmpleado.Focus();
                return false;
            }
            return true;

        }
        private void capturarDatos()
        {
            numeroHijos = Convert.ToInt16(txtNumHIjos.Text);
            empleado = txtEmpleado.Text;
            area = cbxArea.Text;
            condicion = cbxCondicion.Text;
            fecha = DateTime.Parse(dtFecha.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numero++;
        }

        void registrar(int numero, string empleado, int numerodHijos, string area, string condicion, DateTime fecha, double sueldoBase, 
            double movilidad, double asignacion, double descuentos, double netoCobrar) 
        { 
            ListViewItem lista = new ListViewItem(Convert.ToString(numero));
            lista.SubItems.Add(empleado);
            lista.SubItems.Add(numerodHijos.ToString());
            lista.SubItems.Add(area);
            lista.SubItems.Add(condicion);
            lista.SubItems.Add(fecha.ToString("d"));
            lista.SubItems.Add(sueldoBase.ToString());
            lista.SubItems.Add(movilidad.ToString());
            lista.SubItems.Add(asignacion.ToString());
            lista.SubItems.Add(descuentos.ToString());
            lista.SubItems.Add(netoCobrar.ToString());
            lvListar.Items.Add(lista);

        }
        void contadorPuesto(string puesto)
        {
            switch (puesto)
            {
                case "Ventas": cVentas++; break;
                case "Marketing": cMarketing++; break;
                case "Logistica": cLogistica++; break;
                case "Prestamo": cPrestamos++; break;
            }

            lvDetalles.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            elementosFila[0] = "Total de Personal de Area de Ventas";
            elementosFila[1] = cVentas.ToString();
            row = new ListViewItem(elementosFila);
            lvDetalles.Items.Add(row);

            elementosFila[0] = "Total de Personal de Area de Marketing";
            elementosFila[1] = cMarketing.ToString();
            row = new ListViewItem(elementosFila);
            lvDetalles.Items.Add(row);

            elementosFila[0] = "Total de Personal de Area de Logistica";
            elementosFila[1] = cLogistica.ToString();
            row = new ListViewItem(elementosFila);
            lvDetalles.Items.Add(row);

            elementosFila[0] = "Total de Personal de Area de Prestamos";
            elementosFila[1] = cPrestamos.ToString();
            row = new ListViewItem(elementosFila);
            lvDetalles.Items.Add(row);
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            capturarDatos();
            SueldoYmovilidad();
            if (validar(empleado, numeroHijos.ToString(), area, condicion)) {
                registrar(numero, empleado, numeroHijos, area, condicion,fecha,sueldoBase,movilidad,asignacion,descuentos,netoaCobrar);
                contadorPuesto(area);
                numero++;
            }
        }

        void SueldoYmovilidad() 
        {
            if (cbxCondicion.Text == "Personal")
            {
                sueldoBase = 2500;
                movilidad = 2500 * 0.10;
                asignacion = 20 * numeroHijos;
                descuentos = 2500 * 0.17;
                netoaCobrar = sueldoBase + movilidad + asignacion - descuentos;
            }
            if (cbxCondicion.Text == "Comisión")
            {
                sueldoBase = 1100;
                movilidad = 1100 * 0.10;
                asignacion = 20 * numeroHijos;
                descuentos = 1100 * 0.17;
                netoaCobrar = sueldoBase + movilidad + asignacion - descuentos;
            }
        }
    }
}
