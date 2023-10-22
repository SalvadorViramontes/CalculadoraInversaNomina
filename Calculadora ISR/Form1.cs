using System;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using CalculadoraNomina.Models;
using CalculadoraNomina.Models.Enums;
using CalculadoraNomina.Models.Managers;

namespace Calculadora_ISR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            botonCalcular.Select();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            var premios = new List<Premio>();
            if (checkBoxAsistencia.Checked) 
                premios.Add(new Premio { Tipo = TipoPremio.Asistencia, Porcentaje = Convert.ToDouble(numericUpDownAsistencia.Value)/100 });
            if (checkBoxPuntualidad.Checked)
                premios.Add(new Premio { Tipo = TipoPremio.Puntualidad, Porcentaje = Convert.ToDouble(numericUpDownPuntualidad.Value)/100 });

            var periodoPago = (PeriodicidadPago)Enum.Parse(typeof(PeriodicidadPago), comboBoxPeriodoPago.SelectedItem.ToString());
            var salarioNeto = Convert.ToDouble(numericUpDownSalarioNeto.Value);

            var baseCalculo = BaseCalculoDespensa.nulo;
            if (checkBoxValesDespensa.Checked)
            {
                if(radioButtonSBC.Checked) baseCalculo = BaseCalculoDespensa.SBC;
                if(radioButtonUMA.Checked) baseCalculo = BaseCalculoDespensa.UMA;
            }

            var calculadora = new CalculadoraContableManager(periodoPago, DateTime.Now, baseCalculo, premios);
            var salarioBruto = calculadora.CalculoInversoSalarioBrutoIsr(salarioNeto);
            double salarioBrutoDoble = Convert.ToDouble(salarioBruto);
            var isr = calculadora.CalculoIsr(salarioBrutoDoble);
            var subsidio = calculadora.CalculoSubsidioEmpleo(salarioBrutoDoble);
            textBoxSubsidio.Enabled = subsidio > 0;
            var despensa = calculadora.CalculoValesDespensa();
            var puntualidad = calculadora.CalculoPremioPuntualidad(salarioBrutoDoble);
            var asistencia = calculadora.CalculoPremioAsistencia(salarioBrutoDoble);

            textBoxSalarioBruto.Text = salarioBruto.ToString("C", CultureInfo.CurrentCulture);
            textBoxIsr.Text = isr.ToString("C", CultureInfo.CurrentCulture);
            textBoxSubsidio.Text = subsidio.ToString("C", CultureInfo.CurrentCulture);
            textBoxValesDespensa.Text = despensa.ToString("C", CultureInfo.CurrentCulture);
            textBoxPuntualidad.Text = puntualidad.ToString("C", CultureInfo.CurrentCulture);
            textBoxAsistencia.Text = asistencia.ToString("C", CultureInfo.CurrentCulture);
        }

        private void ValidateForm()
        {
            var bool1 = comboBoxPeriodoPago.SelectedItem != null;
            var bool2 = numericUpDownSalarioNeto.Value > 0;
            botonCalcular.Enabled = bool1 && bool2;
        }

        private void comboBoxPeriodoPago_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void numericUpDownSalarioNeto_ValueChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void checkBoxPuntualidad_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPuntualidad.Enabled = checkBoxPuntualidad.Checked;
        }

        private void checkBoxAsistencia_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAsistencia.Enabled = checkBoxAsistencia.Checked;
        }

        private void checkBoxValesDespensa_CheckedChanged(object sender, EventArgs e)
        {
            textBoxValesDespensa.Enabled = checkBoxValesDespensa.Checked;
        }
    }
}
