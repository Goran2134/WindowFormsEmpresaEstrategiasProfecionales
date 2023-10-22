namespace WindowFormsEmpresaEstrategiasProfecionales
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerra = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtApelli = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.cbAfp = new System.Windows.Forms.ComboBox();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHorasTra = new System.Windows.Forms.TextBox();
            this.txtHorasExtra = new System.Windows.Forms.TextBox();
            this.txtSueldoBru = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSueldoLiqui = new System.Windows.Forms.TextBox();
            this.btnModi = new System.Windows.Forms.Button();
            this.btnElimi = new System.Windows.Forms.Button();
            this.btnGuar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horastrabajada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horasextra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerra
            // 
            this.btnCerra.Location = new System.Drawing.Point(1024, 23);
            this.btnCerra.Name = "btnCerra";
            this.btnCerra.Size = new System.Drawing.Size(161, 77);
            this.btnCerra.TabIndex = 3;
            this.btnCerra.Text = "Cerrar";
            this.btnCerra.UseVisualStyleBackColor = true;
            this.btnCerra.Click += new System.EventHandler(this.btnCerra_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rut,
            this.Nombre,
            this.Apellidos,
            this.Direccion,
            this.Horastrabajada,
            this.Horasextra,
            this.SueldoL});
            this.dgvEmpleados.Location = new System.Drawing.Point(56, 407);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(988, 224);
            this.dgvEmpleados.TabIndex = 4;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rut:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Direccion:";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(189, 12);
            this.txtRut.MaxLength = 10;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(286, 22);
            this.txtRut.TabIndex = 1;
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(189, 46);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(286, 22);
            this.txtNom.TabIndex = 2;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtApelli
            // 
            this.txtApelli.Location = new System.Drawing.Point(189, 84);
            this.txtApelli.Name = "txtApelli";
            this.txtApelli.Size = new System.Drawing.Size(286, 22);
            this.txtApelli.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(189, 112);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(286, 22);
            this.txtDireccion.TabIndex = 4;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(535, 84);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(142, 60);
            this.btnLimpiarCampos.TabIndex = 10;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // cbAfp
            // 
            this.cbAfp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAfp.FormattingEnabled = true;
            this.cbAfp.Items.AddRange(new object[] {
            "Cuprum7%",
            "Modelo9%",
            "Capital12%",
            "Provida13%"});
            this.cbAfp.Location = new System.Drawing.Point(354, 159);
            this.cbAfp.Name = "cbAfp";
            this.cbAfp.Size = new System.Drawing.Size(121, 24);
            this.cbAfp.TabIndex = 11;
            this.cbAfp.SelectedIndexChanged += new System.EventHandler(this.cbAfp_SelectedIndexChanged);
            // 
            // cbMedico
            // 
            this.cbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Items.AddRange(new object[] {
            "Fonasa12%",
            "Consalud13%",
            "Masvida14%",
            "Banmedica15%"});
            this.cbMedico.Location = new System.Drawing.Point(354, 207);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(121, 24);
            this.cbMedico.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Horas trabajadas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Horas Extra:";
            // 
            // txtHorasTra
            // 
            this.txtHorasTra.Location = new System.Drawing.Point(184, 161);
            this.txtHorasTra.Name = "txtHorasTra";
            this.txtHorasTra.Size = new System.Drawing.Size(160, 22);
            this.txtHorasTra.TabIndex = 5;
            this.txtHorasTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasTra_KeyPress);
            // 
            // txtHorasExtra
            // 
            this.txtHorasExtra.Location = new System.Drawing.Point(184, 207);
            this.txtHorasExtra.Name = "txtHorasExtra";
            this.txtHorasExtra.Size = new System.Drawing.Size(160, 22);
            this.txtHorasExtra.TabIndex = 6;
            // 
            // txtSueldoBru
            // 
            this.txtSueldoBru.Location = new System.Drawing.Point(189, 269);
            this.txtSueldoBru.Name = "txtSueldoBru";
            this.txtSueldoBru.Size = new System.Drawing.Size(121, 22);
            this.txtSueldoBru.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sueldo Bruto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sueldo Liquido:";
            // 
            // txtSueldoLiqui
            // 
            this.txtSueldoLiqui.Location = new System.Drawing.Point(189, 327);
            this.txtSueldoLiqui.Name = "txtSueldoLiqui";
            this.txtSueldoLiqui.Size = new System.Drawing.Size(121, 22);
            this.txtSueldoLiqui.TabIndex = 15;
            // 
            // btnModi
            // 
            this.btnModi.Location = new System.Drawing.Point(1062, 525);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(154, 79);
            this.btnModi.TabIndex = 17;
            this.btnModi.Text = "Modificar";
            this.btnModi.UseVisualStyleBackColor = true;
            this.btnModi.Click += new System.EventHandler(this.btnModi_Click);
            // 
            // btnElimi
            // 
            this.btnElimi.Location = new System.Drawing.Point(1062, 407);
            this.btnElimi.Name = "btnElimi";
            this.btnElimi.Size = new System.Drawing.Size(154, 81);
            this.btnElimi.TabIndex = 17;
            this.btnElimi.Text = "Eliminar";
            this.btnElimi.UseVisualStyleBackColor = true;
            this.btnElimi.Click += new System.EventHandler(this.btnElimi_Click);
            // 
            // btnGuar
            // 
            this.btnGuar.Location = new System.Drawing.Point(354, 318);
            this.btnGuar.Name = "btnGuar";
            this.btnGuar.Size = new System.Drawing.Size(121, 58);
            this.btnGuar.TabIndex = 7;
            this.btnGuar.Text = "Guardar";
            this.btnGuar.UseVisualStyleBackColor = true;
            this.btnGuar.Click += new System.EventHandler(this.btnGuar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(354, 253);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 59);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.MinimumWidth = 6;
            this.Rut.Name = "Rut";
            this.Rut.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 125;
            // 
            // Horastrabajada
            // 
            this.Horastrabajada.HeaderText = "Horas Trabajadas";
            this.Horastrabajada.MinimumWidth = 6;
            this.Horastrabajada.Name = "Horastrabajada";
            this.Horastrabajada.Width = 125;
            // 
            // Horasextra
            // 
            this.Horasextra.HeaderText = "Horas Extra";
            this.Horasextra.MinimumWidth = 6;
            this.Horasextra.Name = "Horasextra";
            this.Horasextra.Width = 125;
            // 
            // SueldoL
            // 
            this.SueldoL.HeaderText = "Sueldo Liquido";
            this.SueldoL.MinimumWidth = 6;
            this.SueldoL.Name = "SueldoL";
            this.SueldoL.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 652);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnGuar);
            this.Controls.Add(this.btnElimi);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSueldoLiqui);
            this.Controls.Add(this.txtSueldoBru);
            this.Controls.Add(this.txtHorasExtra);
            this.Controls.Add(this.txtHorasTra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMedico);
            this.Controls.Add(this.cbAfp);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApelli);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnCerra);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerra;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtApelli;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ComboBox cbAfp;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHorasTra;
        private System.Windows.Forms.TextBox txtHorasExtra;
        private System.Windows.Forms.TextBox txtSueldoBru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSueldoLiqui;
        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.Button btnElimi;
        private System.Windows.Forms.Button btnGuar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horastrabajada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horasextra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoL;
    }
}