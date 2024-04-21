namespace app_movil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_max = new System.Windows.Forms.PictureBox();
            this.btn_min = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lb_logout = new System.Windows.Forms.LinkLabel();
            this.txt_area = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_consulta = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_doctor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_registrar_cita = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hora = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_fecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_seguro = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.SpringGreen;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.pictureBox4);
            this.panel_top.Controls.Add(this.btn_max);
            this.panel_top.Controls.Add(this.btn_min);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(800, 37);
            this.panel_top.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Área de la Salud";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // btn_max
            // 
            this.btn_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.Image")));
            this.btn_max.Location = new System.Drawing.Point(727, 3);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(32, 32);
            this.btn_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_max.TabIndex = 1;
            this.btn_max.TabStop = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_min
            // 
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(689, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(32, 32);
            this.btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_min.TabIndex = 3;
            this.btn_min.TabStop = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(765, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 32);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Centro de  Salud (Consulta)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(370, 76);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(72, 72);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // lb_logout
            // 
            this.lb_logout.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_logout.AutoSize = true;
            this.lb_logout.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_logout.LinkColor = System.Drawing.Color.DarkGreen;
            this.lb_logout.Location = new System.Drawing.Point(661, 54);
            this.lb_logout.Name = "lb_logout";
            this.lb_logout.Size = new System.Drawing.Size(127, 19);
            this.lb_logout.TabIndex = 46;
            this.lb_logout.TabStop = true;
            this.lb_logout.Text = "Cerrar Sesión";
            this.lb_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_logout_LinkClicked);
            // 
            // txt_area
            // 
            this.txt_area.BorderColor = System.Drawing.Color.Black;
            this.txt_area.BorderRadius = 15;
            this.txt_area.BorderThickness = 3;
            this.txt_area.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_area.DefaultText = "";
            this.txt_area.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_area.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_area.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_area.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_area.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_area.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_area.ForeColor = System.Drawing.Color.Black;
            this.txt_area.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_area.Location = new System.Drawing.Point(37, 260);
            this.txt_area.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_area.Name = "txt_area";
            this.txt_area.PasswordChar = '\0';
            this.txt_area.PlaceholderText = "";
            this.txt_area.SelectedText = "";
            this.txt_area.Size = new System.Drawing.Size(185, 35);
            this.txt_area.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Área:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tipo de Consulta:";
            // 
            // txt_consulta
            // 
            this.txt_consulta.BorderColor = System.Drawing.Color.Black;
            this.txt_consulta.BorderRadius = 15;
            this.txt_consulta.BorderThickness = 3;
            this.txt_consulta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_consulta.DefaultText = "";
            this.txt_consulta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_consulta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_consulta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_consulta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_consulta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_consulta.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_consulta.ForeColor = System.Drawing.Color.Black;
            this.txt_consulta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_consulta.Location = new System.Drawing.Point(282, 260);
            this.txt_consulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_consulta.Name = "txt_consulta";
            this.txt_consulta.PasswordChar = '\0';
            this.txt_consulta.PlaceholderText = "";
            this.txt_consulta.SelectedText = "";
            this.txt_consulta.Size = new System.Drawing.Size(185, 35);
            this.txt_consulta.TabIndex = 50;
            // 
            // txt_doctor
            // 
            this.txt_doctor.BorderColor = System.Drawing.Color.Black;
            this.txt_doctor.BorderRadius = 15;
            this.txt_doctor.BorderThickness = 3;
            this.txt_doctor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_doctor.DefaultText = "";
            this.txt_doctor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_doctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_doctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_doctor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_doctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_doctor.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor.ForeColor = System.Drawing.Color.Black;
            this.txt_doctor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_doctor.Location = new System.Drawing.Point(536, 260);
            this.txt_doctor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_doctor.Name = "txt_doctor";
            this.txt_doctor.PasswordChar = '\0';
            this.txt_doctor.PlaceholderText = "";
            this.txt_doctor.SelectedText = "";
            this.txt_doctor.Size = new System.Drawing.Size(185, 35);
            this.txt_doctor.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(532, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "Doctor/a:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 23);
            this.label6.TabIndex = 53;
            this.label6.Text = "Programar un Cita";
            // 
            // btn_registrar_cita
            // 
            this.btn_registrar_cita.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_registrar_cita.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_cita.Location = new System.Drawing.Point(641, 408);
            this.btn_registrar_cita.Name = "btn_registrar_cita";
            this.btn_registrar_cita.Size = new System.Drawing.Size(147, 30);
            this.btn_registrar_cita.TabIndex = 54;
            this.btn_registrar_cita.Text = "Registrar Cita";
            this.btn_registrar_cita.UseVisualStyleBackColor = false;
            this.btn_registrar_cita.Click += new System.EventHandler(this.btn_registrar_cita_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 56;
            this.label7.Text = "Día:";
            // 
            // txt_hora
            // 
            this.txt_hora.BorderColor = System.Drawing.Color.Black;
            this.txt_hora.BorderRadius = 15;
            this.txt_hora.BorderThickness = 3;
            this.txt_hora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hora.DefaultText = "";
            this.txt_hora.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_hora.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_hora.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hora.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hora.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hora.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hora.ForeColor = System.Drawing.Color.Black;
            this.txt_hora.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hora.Location = new System.Drawing.Point(301, 343);
            this.txt_hora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.PasswordChar = '\0';
            this.txt_hora.PlaceholderText = "";
            this.txt_hora.SelectedText = "";
            this.txt_hora.Size = new System.Drawing.Size(203, 35);
            this.txt_hora.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 19);
            this.label8.TabIndex = 58;
            this.label8.Text = "Hora de Consulta:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.BorderRadius = 15;
            this.dtp_fecha.BorderThickness = 3;
            this.dtp_fecha.Checked = true;
            this.dtp_fecha.FillColor = System.Drawing.Color.SpringGreen;
            this.dtp_fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_fecha.Location = new System.Drawing.Point(37, 343);
            this.dtp_fecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(242, 35);
            this.dtp_fecha.TabIndex = 59;
            this.dtp_fecha.Value = new System.DateTime(2024, 4, 20, 20, 45, 25, 403);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(532, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 19);
            this.label9.TabIndex = 60;
            this.label9.Text = "Pago con Seguro? S/N";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_seguro
            // 
            this.txt_seguro.BorderColor = System.Drawing.Color.Black;
            this.txt_seguro.BorderRadius = 15;
            this.txt_seguro.BorderThickness = 3;
            this.txt_seguro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_seguro.DefaultText = "";
            this.txt_seguro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_seguro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_seguro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_seguro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_seguro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_seguro.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seguro.ForeColor = System.Drawing.Color.Black;
            this.txt_seguro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_seguro.Location = new System.Drawing.Point(536, 343);
            this.txt_seguro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_seguro.Name = "txt_seguro";
            this.txt_seguro.PasswordChar = '\0';
            this.txt_seguro.PlaceholderText = "";
            this.txt_seguro.SelectedText = "";
            this.txt_seguro.Size = new System.Drawing.Size(223, 35);
            this.txt_seguro.TabIndex = 61;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel_top;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_seguro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_registrar_cita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_doctor);
            this.Controls.Add(this.txt_consulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.lb_logout);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btn_max;
        private System.Windows.Forms.PictureBox btn_min;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.LinkLabel lb_logout;
        private Guna.UI2.WinForms.Guna2TextBox txt_area;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_consulta;
        private Guna.UI2.WinForms.Guna2TextBox txt_doctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_registrar_cita;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_hora;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txt_seguro;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}