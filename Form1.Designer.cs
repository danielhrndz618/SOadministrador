namespace Simulacion_Procesos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progress_ram = new CircularProgressBar.CircularProgressBar();
            this.progress_cpu = new CircularProgressBar.CircularProgressBar();
            this.dgv_Proceso = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.lbl_Contador = new System.Windows.Forms.Label();
            this.BtnGrafica = new System.Windows.Forms.Button();
            this.cpu_perf = new System.Diagnostics.PerformanceCounter();
            this.ram_perf = new System.Diagnostics.PerformanceCounter();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cpu_l = new System.Windows.Forms.Label();
            this.ram_l = new System.Windows.Forms.Label();
            this.disk_l = new System.Windows.Forms.Label();
            this.progress_disk = new CircularProgressBar.CircularProgressBar();
            this.disk_perf = new System.Diagnostics.PerformanceCounter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proceso)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpu_perf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram_perf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk_perf)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Simulacion_Procesos.Properties.Resources.procesamiento_por_lotes;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = global::Simulacion_Procesos.Properties.Resources.icons8_close_window_32;
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.Name = "btn_close";
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Simulacion_Procesos.Properties.Resources.grupo_de_usuarios;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Simulacion_Procesos.Properties.Resources.numero_6;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.disk_l);
            this.panel3.Controls.Add(this.progress_disk);
            this.panel3.Controls.Add(this.ram_l);
            this.panel3.Controls.Add(this.cpu_l);
            this.panel3.Controls.Add(this.progress_ram);
            this.panel3.Controls.Add(this.progress_cpu);
            this.panel3.Controls.Add(this.dgv_Proceso);
            this.panel3.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // progress_ram
            // 
            this.progress_ram.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progress_ram.AnimationSpeed = 500;
            this.progress_ram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            resources.ApplyResources(this.progress_ram, "progress_ram");
            this.progress_ram.ForeColor = System.Drawing.Color.White;
            this.progress_ram.InnerColor = System.Drawing.Color.Empty;
            this.progress_ram.InnerMargin = 2;
            this.progress_ram.InnerWidth = -1;
            this.progress_ram.MarqueeAnimationSpeed = 2000;
            this.progress_ram.Maximum = 12288;
            this.progress_ram.Name = "progress_ram";
            this.progress_ram.OuterColor = System.Drawing.Color.DodgerBlue;
            this.progress_ram.OuterMargin = -25;
            this.progress_ram.OuterWidth = 26;
            this.progress_ram.ProgressColor = System.Drawing.Color.AliceBlue;
            this.progress_ram.ProgressWidth = 25;
            this.progress_ram.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progress_ram.StartAngle = 270;
            this.progress_ram.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress_ram.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress_ram.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progress_ram.SubscriptText = "";
            this.progress_ram.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress_ram.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progress_ram.SuperscriptText = "";
            this.progress_ram.TextMargin = new System.Windows.Forms.Padding(0);
            this.progress_ram.Value = 12288;
            // 
            // progress_cpu
            // 
            this.progress_cpu.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progress_cpu.AnimationSpeed = 500;
            this.progress_cpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            resources.ApplyResources(this.progress_cpu, "progress_cpu");
            this.progress_cpu.ForeColor = System.Drawing.Color.White;
            this.progress_cpu.InnerColor = System.Drawing.Color.Empty;
            this.progress_cpu.InnerMargin = 2;
            this.progress_cpu.InnerWidth = -1;
            this.progress_cpu.MarqueeAnimationSpeed = 1000;
            this.progress_cpu.Maximum = 200;
            this.progress_cpu.Name = "progress_cpu";
            this.progress_cpu.OuterColor = System.Drawing.Color.Honeydew;
            this.progress_cpu.OuterMargin = -25;
            this.progress_cpu.OuterWidth = 26;
            this.progress_cpu.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progress_cpu.ProgressWidth = 25;
            this.progress_cpu.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progress_cpu.StartAngle = 270;
            this.progress_cpu.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress_cpu.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress_cpu.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progress_cpu.SubscriptText = "";
            this.progress_cpu.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress_cpu.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progress_cpu.SuperscriptText = "";
            this.progress_cpu.TextMargin = new System.Windows.Forms.Padding(0);
            // 
            // dgv_Proceso
            // 
            this.dgv_Proceso.AllowUserToAddRows = false;
            this.dgv_Proceso.AllowUserToDeleteRows = false;
            this.dgv_Proceso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgv_Proceso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Proceso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Proceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Proceso.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Proceso.EnableHeadersVisualStyles = false;
            this.dgv_Proceso.GridColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.dgv_Proceso, "dgv_Proceso");
            this.dgv_Proceso.Name = "dgv_Proceso";
            this.dgv_Proceso.ReadOnly = true;
            this.dgv_Proceso.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgv_Proceso.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Proceso.RowTemplate.Height = 24;
            this.dgv_Proceso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Proceso_MouseClick);
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.BtnActualizar);
            this.panel2.Controls.Add(this.lbl_Contador);
            this.panel2.Controls.Add(this.BtnGrafica);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Name = "panel2";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.BtnActualizar, "BtnActualizar");
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Image = global::Simulacion_Procesos.Properties.Resources.icons8_align_text_left_321;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click_1);
            // 
            // lbl_Contador
            // 
            resources.ApplyResources(this.lbl_Contador, "lbl_Contador");
            this.lbl_Contador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Contador.ForeColor = System.Drawing.Color.White;
            this.lbl_Contador.Name = "lbl_Contador";
            // 
            // BtnGrafica
            // 
            this.BtnGrafica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrafica.FlatAppearance.BorderSize = 0;
            this.BtnGrafica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.BtnGrafica, "BtnGrafica");
            this.BtnGrafica.ForeColor = System.Drawing.Color.White;
            this.BtnGrafica.Image = global::Simulacion_Procesos.Properties.Resources.icons8_line_chart_321;
            this.BtnGrafica.Name = "BtnGrafica";
            this.BtnGrafica.UseVisualStyleBackColor = false;
            this.BtnGrafica.Click += new System.EventHandler(this.BtnGrafica_Click);
            // 
            // cpu_perf
            // 
            this.cpu_perf.CategoryName = "Processor";
            this.cpu_perf.CounterName = "% Processor Time";
            this.cpu_perf.InstanceName = "_Total";
            // 
            // ram_perf
            // 
            this.ram_perf.CategoryName = "Memory";
            this.ram_perf.CounterName = "Available MBytes";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cpu_l
            // 
            resources.ApplyResources(this.cpu_l, "cpu_l");
            this.cpu_l.Name = "cpu_l";
            // 
            // ram_l
            // 
            resources.ApplyResources(this.ram_l, "ram_l");
            this.ram_l.Name = "ram_l";
            // 
            // disk_l
            // 
            resources.ApplyResources(this.disk_l, "disk_l");
            this.disk_l.Name = "disk_l";
            // 
            // progress_disk
            // 
            this.progress_disk.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progress_disk.AnimationSpeed = 500;
            this.progress_disk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            resources.ApplyResources(this.progress_disk, "progress_disk");
            this.progress_disk.ForeColor = System.Drawing.Color.White;
            this.progress_disk.InnerColor = System.Drawing.Color.Empty;
            this.progress_disk.InnerMargin = 2;
            this.progress_disk.InnerWidth = -1;
            this.progress_disk.MarqueeAnimationSpeed = 1000;
            this.progress_disk.Maximum = 930;
            this.progress_disk.Name = "progress_disk";
            this.progress_disk.OuterColor = System.Drawing.Color.DodgerBlue;
            this.progress_disk.OuterMargin = -25;
            this.progress_disk.OuterWidth = 26;
            this.progress_disk.ProgressColor = System.Drawing.Color.AliceBlue;
            this.progress_disk.ProgressWidth = 25;
            this.progress_disk.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progress_disk.StartAngle = 270;
            this.progress_disk.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress_disk.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress_disk.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progress_disk.SubscriptText = "";
            this.progress_disk.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress_disk.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progress_disk.SuperscriptText = "";
            this.progress_disk.TextMargin = new System.Windows.Forms.Padding(0);
            // 
            // disk_perf
            // 
            this.disk_perf.CategoryName = "LogicalDisk";
            this.disk_perf.CounterName = "% Free Space";
            this.disk_perf.InstanceName = "_Total";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simulacion_Procesos.Properties.Resources._711093;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proceso)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpu_perf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram_perf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk_perf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label lbl_Contador;
        private System.Windows.Forms.Button BtnGrafica;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CircularProgressBar.CircularProgressBar progress_ram;
        private CircularProgressBar.CircularProgressBar progress_cpu;
        private System.Diagnostics.PerformanceCounter cpu_perf;
        private System.Diagnostics.PerformanceCounter ram_perf;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label ram_l;
        private System.Windows.Forms.Label cpu_l;
        private System.Windows.Forms.Label disk_l;
        private CircularProgressBar.CircularProgressBar progress_disk;
        private System.Diagnostics.PerformanceCounter disk_perf;
    }
}

