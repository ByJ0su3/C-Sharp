using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace app_movil
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lb_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.FormClosed += (s, args) => this.Show();
            form1.ShowDialog();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            System.Windows.Forms.Application.Exit();
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrar_cita_Click(object sender, EventArgs e)
        {
            if (txt_area.Text == "" && txt_consulta.Text == "" && txt_doctor.Text == "" && dtp_fecha.Text == "" && txt_hora.Text == "" && txt_seguro.Text == "")
            {
                MessageBox.Show("Debe ingresar la Información Completa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else if (txt_area.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txt_consulta.Text == "")
            {
                MessageBox.Show("Debe ingresar el tipo de consulta!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txt_doctor.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del doctor!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (dtp_fecha.Value.Date == DateTime.Today)
            {
                MessageBox.Show("Debe seleccionar una fecha distinta de hoy!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txt_hora.Text == "")
            {
                MessageBox.Show("Debe ingresar la hora de la consulta!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txt_seguro.Text == "")
            {
                MessageBox.Show("Debe ingresar los detalles del seguro!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            else
            {
               
                string areaSeleccionada = txt_area.Text;
                string consultaSeleccionado = txt_consulta.Text;
                string doctorSeleccionada = txt_doctor.Text;
                string fechaSeleccionada = dtp_fecha.Text;
                string horaSeleccionada = txt_hora.Text;
                string seguroSeleccionado = txt_seguro.Text;

          
                MessageBox.Show($"Área Registrada: {areaSeleccionada}\nConsulta Registrada Tipo: {consultaSeleccionado}\nDoctor/a Registrado: {doctorSeleccionada}\nFecha Registrada: {fechaSeleccionada}\nHora Registrada: {horaSeleccionada}\nPago con seguro confirmado. Usted dijo que: {seguroSeleccionado}", "Datos Registrados Completos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_area.Clear();
                txt_consulta.Clear();
                txt_doctor.Clear();
                dtp_fecha.Value = DateTime.Now;
                txt_hora.Clear();
                txt_seguro.Clear();


            }
        }

    }
}
