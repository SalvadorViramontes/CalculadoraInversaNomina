namespace Calculadora_ISR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonCalcular = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.labelPorcientoAsistencia = new System.Windows.Forms.Label();
            this.labelPorcientoPuntualidad = new System.Windows.Forms.Label();
            this.textBoxSalarioBruto = new System.Windows.Forms.TextBox();
            this.comboBoxPeriodoPago = new System.Windows.Forms.ComboBox();
            this.labelTipoPeriodo = new System.Windows.Forms.Label();
            this.labelInfoPorcentajes = new System.Windows.Forms.Label();
            this.labelSalarioBruto = new System.Windows.Forms.Label();
            this.textBoxPuntualidad = new System.Windows.Forms.TextBox();
            this.labelPremioPuntualidad = new System.Windows.Forms.Label();
            this.textBoxAsistencia = new System.Windows.Forms.TextBox();
            this.labelPremioAsistencia = new System.Windows.Forms.Label();
            this.textBoxIsr = new System.Windows.Forms.TextBox();
            this.textBoxSubsidio = new System.Windows.Forms.TextBox();
            this.labelImpuestoRenta = new System.Windows.Forms.Label();
            this.labelSubsidioEmpleo = new System.Windows.Forms.Label();
            this.labelSalarioNeto = new System.Windows.Forms.Label();
            this.checkBoxPuntualidad = new System.Windows.Forms.CheckBox();
            this.checkBoxAsistencia = new System.Windows.Forms.CheckBox();
            this.numericUpDownSalarioNeto = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPuntualidad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAsistencia = new System.Windows.Forms.NumericUpDown();
            this.textBoxValesDespensa = new System.Windows.Forms.TextBox();
            this.labelValesDespensa = new System.Windows.Forms.Label();
            this.radioButtonUMA = new System.Windows.Forms.RadioButton();
            this.radioButtonSBC = new System.Windows.Forms.RadioButton();
            this.groupBoxValesDespensa = new System.Windows.Forms.GroupBox();
            this.checkBoxValesDespensa = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalarioNeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPuntualidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAsistencia)).BeginInit();
            this.groupBoxValesDespensa.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonCalcular
            // 
            this.botonCalcular.Enabled = false;
            this.botonCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonCalcular.Location = new System.Drawing.Point(576, 390);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(84, 35);
            this.botonCalcular.TabIndex = 0;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Titulo.Location = new System.Drawing.Point(103, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(611, 37);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "Calculadora Inversa de Salario Bruto sobre ISR";
            // 
            // labelPorcientoAsistencia
            // 
            this.labelPorcientoAsistencia.AutoSize = true;
            this.labelPorcientoAsistencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPorcientoAsistencia.Location = new System.Drawing.Point(306, 132);
            this.labelPorcientoAsistencia.Name = "labelPorcientoAsistencia";
            this.labelPorcientoAsistencia.Size = new System.Drawing.Size(34, 21);
            this.labelPorcientoAsistencia.TabIndex = 5;
            this.labelPorcientoAsistencia.Text = "% *";
            // 
            // labelPorcientoPuntualidad
            // 
            this.labelPorcientoPuntualidad.AutoSize = true;
            this.labelPorcientoPuntualidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPorcientoPuntualidad.Location = new System.Drawing.Point(306, 92);
            this.labelPorcientoPuntualidad.Name = "labelPorcientoPuntualidad";
            this.labelPorcientoPuntualidad.Size = new System.Drawing.Size(34, 21);
            this.labelPorcientoPuntualidad.TabIndex = 5;
            this.labelPorcientoPuntualidad.Text = "% *";
            // 
            // textBoxSalarioBruto
            // 
            this.textBoxSalarioBruto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSalarioBruto.Location = new System.Drawing.Point(639, 68);
            this.textBoxSalarioBruto.Name = "textBoxSalarioBruto";
            this.textBoxSalarioBruto.ReadOnly = true;
            this.textBoxSalarioBruto.Size = new System.Drawing.Size(121, 29);
            this.textBoxSalarioBruto.TabIndex = 6;
            this.textBoxSalarioBruto.Text = "$0.00";
            this.textBoxSalarioBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxPeriodoPago
            // 
            this.comboBoxPeriodoPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPeriodoPago.FormatString = "C2";
            this.comboBoxPeriodoPago.FormattingEnabled = true;
            this.comboBoxPeriodoPago.Items.AddRange(new object[] {
            "Diario",
            "Semanal",
            "Quincenal",
            "Mensual"});
            this.comboBoxPeriodoPago.Location = new System.Drawing.Point(233, 342);
            this.comboBoxPeriodoPago.Name = "comboBoxPeriodoPago";
            this.comboBoxPeriodoPago.Size = new System.Drawing.Size(138, 29);
            this.comboBoxPeriodoPago.TabIndex = 7;
            this.comboBoxPeriodoPago.SelectedValueChanged += new System.EventHandler(this.comboBoxPeriodoPago_SelectedValueChanged);
            // 
            // labelTipoPeriodo
            // 
            this.labelTipoPeriodo.AutoSize = true;
            this.labelTipoPeriodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTipoPeriodo.Location = new System.Drawing.Point(28, 346);
            this.labelTipoPeriodo.Name = "labelTipoPeriodo";
            this.labelTipoPeriodo.Size = new System.Drawing.Size(199, 21);
            this.labelTipoPeriodo.TabIndex = 8;
            this.labelTipoPeriodo.Text = "Tipo de Periodo de Nómina";
            // 
            // labelInfoPorcentajes
            // 
            this.labelInfoPorcentajes.AutoSize = true;
            this.labelInfoPorcentajes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelInfoPorcentajes.Location = new System.Drawing.Point(90, 172);
            this.labelInfoPorcentajes.Name = "labelInfoPorcentajes";
            this.labelInfoPorcentajes.Size = new System.Drawing.Size(213, 19);
            this.labelInfoPorcentajes.TabIndex = 9;
            this.labelInfoPorcentajes.Text = "* Porcentajes sobre salario bruto";
            // 
            // labelSalarioBruto
            // 
            this.labelSalarioBruto.AutoSize = true;
            this.labelSalarioBruto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelSalarioBruto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSalarioBruto.Location = new System.Drawing.Point(461, 70);
            this.labelSalarioBruto.Name = "labelSalarioBruto";
            this.labelSalarioBruto.Size = new System.Drawing.Size(172, 21);
            this.labelSalarioBruto.TabIndex = 10;
            this.labelSalarioBruto.Text = "Salario Bruto Calculado";
            // 
            // textBoxPuntualidad
            // 
            this.textBoxPuntualidad.Enabled = false;
            this.textBoxPuntualidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPuntualidad.Location = new System.Drawing.Point(639, 113);
            this.textBoxPuntualidad.Name = "textBoxPuntualidad";
            this.textBoxPuntualidad.ReadOnly = true;
            this.textBoxPuntualidad.Size = new System.Drawing.Size(121, 29);
            this.textBoxPuntualidad.TabIndex = 6;
            this.textBoxPuntualidad.Text = "$0.00";
            this.textBoxPuntualidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPremioPuntualidad
            // 
            this.labelPremioPuntualidad.AutoSize = true;
            this.labelPremioPuntualidad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelPremioPuntualidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPremioPuntualidad.Location = new System.Drawing.Point(461, 115);
            this.labelPremioPuntualidad.Name = "labelPremioPuntualidad";
            this.labelPremioPuntualidad.Size = new System.Drawing.Size(168, 21);
            this.labelPremioPuntualidad.TabIndex = 10;
            this.labelPremioPuntualidad.Text = "Premio de Puntualidad";
            // 
            // textBoxAsistencia
            // 
            this.textBoxAsistencia.Enabled = false;
            this.textBoxAsistencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAsistencia.Location = new System.Drawing.Point(639, 156);
            this.textBoxAsistencia.Name = "textBoxAsistencia";
            this.textBoxAsistencia.ReadOnly = true;
            this.textBoxAsistencia.Size = new System.Drawing.Size(121, 29);
            this.textBoxAsistencia.TabIndex = 6;
            this.textBoxAsistencia.Text = "$0.00";
            this.textBoxAsistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPremioAsistencia
            // 
            this.labelPremioAsistencia.AutoSize = true;
            this.labelPremioAsistencia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelPremioAsistencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPremioAsistencia.Location = new System.Drawing.Point(461, 158);
            this.labelPremioAsistencia.Name = "labelPremioAsistencia";
            this.labelPremioAsistencia.Size = new System.Drawing.Size(154, 21);
            this.labelPremioAsistencia.TabIndex = 10;
            this.labelPremioAsistencia.Text = "Premio de Asistencia";
            // 
            // textBoxIsr
            // 
            this.textBoxIsr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIsr.Location = new System.Drawing.Point(639, 241);
            this.textBoxIsr.Name = "textBoxIsr";
            this.textBoxIsr.ReadOnly = true;
            this.textBoxIsr.Size = new System.Drawing.Size(121, 29);
            this.textBoxIsr.TabIndex = 6;
            this.textBoxIsr.Text = "$0.00";
            this.textBoxIsr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSubsidio
            // 
            this.textBoxSubsidio.Enabled = false;
            this.textBoxSubsidio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSubsidio.Location = new System.Drawing.Point(639, 286);
            this.textBoxSubsidio.Name = "textBoxSubsidio";
            this.textBoxSubsidio.ReadOnly = true;
            this.textBoxSubsidio.Size = new System.Drawing.Size(121, 29);
            this.textBoxSubsidio.TabIndex = 6;
            this.textBoxSubsidio.Text = "$0.00";
            this.textBoxSubsidio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelImpuestoRenta
            // 
            this.labelImpuestoRenta.AutoSize = true;
            this.labelImpuestoRenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelImpuestoRenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImpuestoRenta.Location = new System.Drawing.Point(461, 243);
            this.labelImpuestoRenta.Name = "labelImpuestoRenta";
            this.labelImpuestoRenta.Size = new System.Drawing.Size(33, 21);
            this.labelImpuestoRenta.TabIndex = 10;
            this.labelImpuestoRenta.Text = "ISR";
            // 
            // labelSubsidioEmpleo
            // 
            this.labelSubsidioEmpleo.AutoSize = true;
            this.labelSubsidioEmpleo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelSubsidioEmpleo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubsidioEmpleo.Location = new System.Drawing.Point(461, 288);
            this.labelSubsidioEmpleo.Name = "labelSubsidioEmpleo";
            this.labelSubsidioEmpleo.Size = new System.Drawing.Size(142, 21);
            this.labelSubsidioEmpleo.TabIndex = 10;
            this.labelSubsidioEmpleo.Text = "Subsidio al Empleo";
            // 
            // labelSalarioNeto
            // 
            this.labelSalarioNeto.AutoSize = true;
            this.labelSalarioNeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSalarioNeto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalarioNeto.Location = new System.Drawing.Point(461, 345);
            this.labelSalarioNeto.Name = "labelSalarioNeto";
            this.labelSalarioNeto.Size = new System.Drawing.Size(105, 21);
            this.labelSalarioNeto.TabIndex = 10;
            this.labelSalarioNeto.Text = "Salario Neto";
            // 
            // checkBoxPuntualidad
            // 
            this.checkBoxPuntualidad.AutoSize = true;
            this.checkBoxPuntualidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPuntualidad.Location = new System.Drawing.Point(28, 90);
            this.checkBoxPuntualidad.Name = "checkBoxPuntualidad";
            this.checkBoxPuntualidad.Size = new System.Drawing.Size(187, 25);
            this.checkBoxPuntualidad.TabIndex = 11;
            this.checkBoxPuntualidad.Text = "Premio de Puntualidad";
            this.checkBoxPuntualidad.UseVisualStyleBackColor = true;
            this.checkBoxPuntualidad.CheckedChanged += new System.EventHandler(this.checkBoxPuntualidad_CheckedChanged);
            // 
            // checkBoxAsistencia
            // 
            this.checkBoxAsistencia.AutoSize = true;
            this.checkBoxAsistencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAsistencia.Location = new System.Drawing.Point(28, 128);
            this.checkBoxAsistencia.Name = "checkBoxAsistencia";
            this.checkBoxAsistencia.Size = new System.Drawing.Size(173, 25);
            this.checkBoxAsistencia.TabIndex = 11;
            this.checkBoxAsistencia.Text = "Premio de Asistencia";
            this.checkBoxAsistencia.UseVisualStyleBackColor = true;
            this.checkBoxAsistencia.CheckedChanged += new System.EventHandler(this.checkBoxAsistencia_CheckedChanged);
            // 
            // numericUpDownSalarioNeto
            // 
            this.numericUpDownSalarioNeto.DecimalPlaces = 2;
            this.numericUpDownSalarioNeto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownSalarioNeto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownSalarioNeto.Location = new System.Drawing.Point(639, 343);
            this.numericUpDownSalarioNeto.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownSalarioNeto.Name = "numericUpDownSalarioNeto";
            this.numericUpDownSalarioNeto.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownSalarioNeto.TabIndex = 12;
            this.numericUpDownSalarioNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSalarioNeto.ValueChanged += new System.EventHandler(this.numericUpDownSalarioNeto_ValueChanged);
            // 
            // numericUpDownPuntualidad
            // 
            this.numericUpDownPuntualidad.DecimalPlaces = 2;
            this.numericUpDownPuntualidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownPuntualidad.Location = new System.Drawing.Point(233, 90);
            this.numericUpDownPuntualidad.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.numericUpDownPuntualidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPuntualidad.Name = "numericUpDownPuntualidad";
            this.numericUpDownPuntualidad.Size = new System.Drawing.Size(67, 29);
            this.numericUpDownPuntualidad.TabIndex = 13;
            this.numericUpDownPuntualidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPuntualidad.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownAsistencia
            // 
            this.numericUpDownAsistencia.DecimalPlaces = 2;
            this.numericUpDownAsistencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownAsistencia.Location = new System.Drawing.Point(233, 127);
            this.numericUpDownAsistencia.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.numericUpDownAsistencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownAsistencia.Name = "numericUpDownAsistencia";
            this.numericUpDownAsistencia.Size = new System.Drawing.Size(67, 29);
            this.numericUpDownAsistencia.TabIndex = 13;
            this.numericUpDownAsistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAsistencia.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBoxValesDespensa
            // 
            this.textBoxValesDespensa.Enabled = false;
            this.textBoxValesDespensa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValesDespensa.Location = new System.Drawing.Point(639, 198);
            this.textBoxValesDespensa.Name = "textBoxValesDespensa";
            this.textBoxValesDespensa.ReadOnly = true;
            this.textBoxValesDespensa.Size = new System.Drawing.Size(121, 29);
            this.textBoxValesDespensa.TabIndex = 6;
            this.textBoxValesDespensa.Text = "$0.00";
            this.textBoxValesDespensa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelValesDespensa
            // 
            this.labelValesDespensa.AutoSize = true;
            this.labelValesDespensa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelValesDespensa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValesDespensa.Location = new System.Drawing.Point(461, 200);
            this.labelValesDespensa.Name = "labelValesDespensa";
            this.labelValesDespensa.Size = new System.Drawing.Size(138, 21);
            this.labelValesDespensa.TabIndex = 10;
            this.labelValesDespensa.Text = "Vales de Despensa";
            // 
            // radioButtonUMA
            // 
            this.radioButtonUMA.AutoSize = true;
            this.radioButtonUMA.Checked = true;
            this.radioButtonUMA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonUMA.Location = new System.Drawing.Point(18, 28);
            this.radioButtonUMA.Name = "radioButtonUMA";
            this.radioButtonUMA.Size = new System.Drawing.Size(141, 25);
            this.radioButtonUMA.TabIndex = 14;
            this.radioButtonUMA.TabStop = true;
            this.radioButtonUMA.Text = "40% sobre UMA";
            this.radioButtonUMA.UseVisualStyleBackColor = true;
            // 
            // radioButtonSBC
            // 
            this.radioButtonSBC.AutoSize = true;
            this.radioButtonSBC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonSBC.Location = new System.Drawing.Point(18, 59);
            this.radioButtonSBC.Name = "radioButtonSBC";
            this.radioButtonSBC.Size = new System.Drawing.Size(134, 25);
            this.radioButtonSBC.TabIndex = 15;
            this.radioButtonSBC.Text = "40% sobre SBC";
            this.radioButtonSBC.UseVisualStyleBackColor = true;
            // 
            // groupBoxValesDespensa
            // 
            this.groupBoxValesDespensa.Controls.Add(this.radioButtonSBC);
            this.groupBoxValesDespensa.Controls.Add(this.radioButtonUMA);
            this.groupBoxValesDespensa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.groupBoxValesDespensa.Location = new System.Drawing.Point(49, 218);
            this.groupBoxValesDespensa.Name = "groupBoxValesDespensa";
            this.groupBoxValesDespensa.Size = new System.Drawing.Size(240, 96);
            this.groupBoxValesDespensa.TabIndex = 16;
            this.groupBoxValesDespensa.TabStop = false;
            this.groupBoxValesDespensa.Text = "Cálculo de Vales de Despensa";
            // 
            // checkBoxValesDespensa
            // 
            this.checkBoxValesDespensa.AutoSize = true;
            this.checkBoxValesDespensa.Location = new System.Drawing.Point(28, 224);
            this.checkBoxValesDespensa.Name = "checkBoxValesDespensa";
            this.checkBoxValesDespensa.Size = new System.Drawing.Size(15, 14);
            this.checkBoxValesDespensa.TabIndex = 17;
            this.checkBoxValesDespensa.UseVisualStyleBackColor = true;
            this.checkBoxValesDespensa.CheckedChanged += new System.EventHandler(this.checkBoxValesDespensa_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(449, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 264);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.checkBoxValesDespensa);
            this.Controls.Add(this.numericUpDownAsistencia);
            this.Controls.Add(this.numericUpDownPuntualidad);
            this.Controls.Add(this.numericUpDownSalarioNeto);
            this.Controls.Add(this.checkBoxAsistencia);
            this.Controls.Add(this.checkBoxPuntualidad);
            this.Controls.Add(this.labelSalarioNeto);
            this.Controls.Add(this.labelSubsidioEmpleo);
            this.Controls.Add(this.labelValesDespensa);
            this.Controls.Add(this.labelPremioAsistencia);
            this.Controls.Add(this.labelImpuestoRenta);
            this.Controls.Add(this.labelPremioPuntualidad);
            this.Controls.Add(this.labelSalarioBruto);
            this.Controls.Add(this.labelInfoPorcentajes);
            this.Controls.Add(this.textBoxValesDespensa);
            this.Controls.Add(this.textBoxAsistencia);
            this.Controls.Add(this.textBoxSubsidio);
            this.Controls.Add(this.labelTipoPeriodo);
            this.Controls.Add(this.textBoxPuntualidad);
            this.Controls.Add(this.textBoxIsr);
            this.Controls.Add(this.comboBoxPeriodoPago);
            this.Controls.Add(this.textBoxSalarioBruto);
            this.Controls.Add(this.labelPorcientoPuntualidad);
            this.Controls.Add(this.labelPorcientoAsistencia);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.groupBoxValesDespensa);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculadora ISR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalarioNeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPuntualidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAsistencia)).EndInit();
            this.groupBoxValesDespensa.ResumeLayout(false);
            this.groupBoxValesDespensa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label labelPorcientoAsistencia;
        private System.Windows.Forms.Label labelPorcientoPuntualidad;
        private System.Windows.Forms.TextBox textBoxSalarioBruto;
        private System.Windows.Forms.ComboBox comboBoxPeriodoPago;
        private System.Windows.Forms.Label labelTipoPeriodo;
        private System.Windows.Forms.Label labelInfoPorcentajes;
        private System.Windows.Forms.Label labelSalarioBruto;
        private System.Windows.Forms.TextBox textBoxPuntualidad;
        private System.Windows.Forms.Label labelPremioPuntualidad;
        private System.Windows.Forms.TextBox textBoxAsistencia;
        private System.Windows.Forms.Label labelPremioAsistencia;
        private System.Windows.Forms.TextBox textBoxIsr;
        private System.Windows.Forms.TextBox textBoxSubsidio;
        private System.Windows.Forms.Label labelImpuestoRenta;
        private System.Windows.Forms.Label labelSubsidioEmpleo;
        private System.Windows.Forms.Label labelSalarioNeto;
        private System.Windows.Forms.CheckBox checkBoxPuntualidad;
        private System.Windows.Forms.CheckBox checkBoxAsistencia;
        private System.Windows.Forms.NumericUpDown numericUpDownSalarioNeto;
        private System.Windows.Forms.NumericUpDown numericUpDownPuntualidad;
        private System.Windows.Forms.NumericUpDown numericUpDownAsistencia;
        private System.Windows.Forms.TextBox textBoxValesDespensa;
        private System.Windows.Forms.Label labelValesDespensa;
        private System.Windows.Forms.RadioButton radioButtonUMA;
        private System.Windows.Forms.RadioButton radioButtonSBC;
        private System.Windows.Forms.GroupBox groupBoxValesDespensa;
        private System.Windows.Forms.CheckBox checkBoxValesDespensa;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

