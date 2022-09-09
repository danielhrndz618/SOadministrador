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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LblPorRAM = new MetroFramework.Controls.MetroLabel();
            this.LblPorCPU = new MetroFramework.Controls.MetroLabel();
            this.ProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.LblNombreRam = new MetroFramework.Controls.MetroLabel();
            this.ProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.LblNombreCPU = new MetroFramework.Controls.MetroLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proceso)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.Grafico);
            this.panel3.Controls.Add(this.LblPorRAM);
            this.panel3.Controls.Add(this.LblPorCPU);
            this.panel3.Controls.Add(this.ProgressBarRAM);
            this.panel3.Controls.Add(this.LblNombreRam);
            this.panel3.Controls.Add(this.ProgressBarCPU);
            this.panel3.Controls.Add(this.LblNombreCPU);
            this.panel3.Controls.Add(this.dgv_Proceso);
            this.panel3.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // Grafico
            // 
            this.Grafico.BackColor = System.Drawing.Color.Transparent;
            this.Grafico.BackSecondaryColor = System.Drawing.Color.White;
            this.Grafico.BorderlineWidth = 0;
            this.Grafico.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.Grafico.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grafico.Legends.Add(legend1);
            resources.ApplyResources(this.Grafico, "Grafico");
            this.Grafico.Name = "Grafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series2.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.Grafico.Series.Add(series1);
            this.Grafico.Series.Add(series2);
            // 
            // LblPorRAM
            // 
            resources.ApplyResources(this.LblPorRAM, "LblPorRAM");
            this.LblPorRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.LblPorRAM.Name = "LblPorRAM";
            this.LblPorRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LblPorCPU
            // 
            resources.ApplyResources(this.LblPorCPU, "LblPorCPU");
            this.LblPorCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.LblPorCPU.Name = "LblPorCPU";
            this.LblPorCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ProgressBarRAM
            // 
            resources.ApplyResources(this.ProgressBarRAM, "ProgressBarRAM");
            this.ProgressBarRAM.Name = "ProgressBarRAM";
            this.ProgressBarRAM.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // LblNombreRam
            // 
            resources.ApplyResources(this.LblNombreRam, "LblNombreRam");
            this.LblNombreRam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.LblNombreRam.Name = "LblNombreRam";
            this.LblNombreRam.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ProgressBarCPU
            // 
            resources.ApplyResources(this.ProgressBarCPU, "ProgressBarCPU");
            this.ProgressBarCPU.Name = "ProgressBarCPU";
            this.ProgressBarCPU.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // LblNombreCPU
            // 
            resources.ApplyResources(this.LblNombreCPU, "LblNombreCPU");
            this.LblNombreCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.LblNombreCPU.Name = "LblNombreCPU";
            this.LblNombreCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgv_Proceso
            // 
            this.dgv_Proceso.AllowUserToAddRows = false;
            this.dgv_Proceso.AllowUserToDeleteRows = false;
            this.dgv_Proceso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgv_Proceso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Proceso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Proceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Proceso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Proceso.EnableHeadersVisualStyles = false;
            this.dgv_Proceso.GridColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.dgv_Proceso, "dgv_Proceso");
            this.dgv_Proceso.Name = "dgv_Proceso";
            this.dgv_Proceso.ReadOnly = true;
            this.dgv_Proceso.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Hack NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgv_Proceso.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proceso)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico;
        private MetroFramework.Controls.MetroLabel LblPorRAM;
        private MetroFramework.Controls.MetroLabel LblPorCPU;
        private MetroFramework.Controls.MetroProgressBar ProgressBarRAM;
        private MetroFramework.Controls.MetroLabel LblNombreRam;
        private MetroFramework.Controls.MetroProgressBar ProgressBarCPU;
        private MetroFramework.Controls.MetroLabel LblNombreCPU;
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
    }
}

