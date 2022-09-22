using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;



namespace Simulacion_Procesos
{
    public partial class Form1 : Form 
    {
        string Str_Obt_Proc;
        public ContextMenuStrip menu;
        public Process selected_process;
        public Form1()
        {
            InitializeComponent();
            ActualizarTabla();
            timer1.Enabled = true;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint ="SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void ActualizarTabla()
        {
            progress_cpu.Visible = false;
            progress_ram.Visible = false;
            ram_l.Visible = false;
            cpu_l.Visible = false;
            disk_l.Visible = false;
            progress_disk.Visible = false;
            dgv_Proceso.Rows.Clear();
            dgv_Proceso.Columns[0].Name = "Num. Procesos";
            dgv_Proceso.Columns[1].Name = "Procesos";
            dgv_Proceso.Columns[2].Name = "Prioridad Proceso";
            dgv_Proceso.Columns[3].Name = "ID";
            dgv_Proceso.Columns[4].Name = "Memoria Fisica";
            dgv_Proceso.Columns[5].Name = "Memoria Virtual";
            dgv_Proceso.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgv_Proceso.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
           
            dgv_Proceso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Proceso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Proceso.MultiSelect = false;
            int Int_Cant_Proc = 1;

            foreach (Process Proc_Proceso in Process.GetProcesses())
            {
                dgv_Proceso.Rows.Add(Int_Cant_Proc, Proc_Proceso.ProcessName, Proc_Proceso.BasePriority, Proc_Proceso.Id, Proc_Proceso.WorkingSet64,
                    Proc_Proceso.VirtualMemorySize64);
                Int_Cant_Proc += 1;
            }
            lbl_Contador.Text = "Procesos Actuales: " + (Int_Cant_Proc - 1);    //  cant de procesos   
        }

        private void showTable(){
            progress_cpu.Visible = false;
            progress_ram.Visible = false;
            ram_l.Visible = false;
            cpu_l.Visible = false;
            disk_l.Visible = false;
            progress_disk.Visible = false;
            dgv_Proceso.Visible = true;
            ActualizarTabla(); 
        }


        public Process getProcess(String ProcessName)
        {
            try 
            {
                foreach(Process proceso in Process.GetProcesses())
                {
		    if(proceso.ProcessName == ProcessName) return proceso;
                }
            }
            catch (Exception x) 
            {
                MessageBox.Show("No se ha seleccionado ningun proceso para detener." + x, "Error al Detener Proceso", MessageBoxButtons.OK);
            }
            return new Process();
        }

           private void Btn_Detener_Click(object sender, EventArgs e){
            dgv_Proceso.Visible = true;

            try 
            {
                foreach(Process proceso in Process.GetProcesses())
                {
                    if (proceso.ProcessName == Str_Obt_Proc)
                    {
                        proceso.Kill();
                        ActualizarTabla();
                    }
                }
            }
            catch (Exception x) 
            {
                MessageBox.Show("No se ha seleccionado ningun proceso para detener." + x, "Error al Detener Proceso", MessageBoxButtons.OK);
            }
        }


        private void dgv_Proceso_MouseClick_1(object sender, MouseEventArgs e)
        {
            Str_Obt_Proc = dgv_Proceso.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e){
            timer.Start();
        }
        
        private void showGraphics(){
            dgv_Proceso.Visible = false;
            progress_ram.Visible = true;
            ram_l.Visible = true;
            disk_l.Visible = true;
            cpu_l.Visible = true;
            progress_disk.Visible = true;
            progress_cpu.Visible = true;
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Proceso_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
            }
            else
            {
                this.menu = new System.Windows.Forms.ContextMenuStrip();
                int mousePosition = dgv_Proceso.HitTest(e.X, e.Y).RowIndex;
                var hti = dgv_Proceso.HitTest(e.X, e.Y);
                dgv_Proceso.ClearSelection();
                dgv_Proceso.Rows[hti.RowIndex].Selected = true;
                if(mousePosition >= 0)
                {
                    this.menu.Items.Add("Finalizar Proceso").Name = "Delete";
                    this.menu.Items.Add("Ver Detalles").Name = "Details";
                    this.menu.Items.Add("Abrir Ubicacion").Name = "Location";
                }
                this.menu.Show(dgv_Proceso, new Point(e.X, e.Y));
                this.menu.ItemClicked += Menu_ItemClicked;

                String nameProcess = dgv_Proceso.SelectedRows[0].Cells[1].Value.ToString();
                this.selected_process = this.getProcess(nameProcess);
            }

        }


        public void killProcess(Process proc)
        {
            proc.Kill();
            this.ActualizarTabla();
            MessageBox.Show("Proceso: " + proc.ProcessName + " finalizado");
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.menu.Visible = false;
            switch (e.ClickedItem.Name.ToString())
            {
                case "Delete":
                    this.killProcess(this.selected_process);
                    break;
                case "Location":
                    MessageBox.Show("Mostraremos la ubicacion");
                    break;
                case "Details":
                    MessageBox.Show("Detalles de la aplicacion");
                    break;
                default:
                    MessageBox.Show("La opcion seleccionada no es valida");
                    break;
            }
        }

        private void BtnGrafica_Click(object sender, EventArgs e)
        {
            this.showGraphics();
        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            this.showTable();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progress_cpu.Value = (int)cpu_perf.NextValue();
            cpu_l.Text = "CPU: " + progress_cpu.Value.ToString() + " %";
            progress_ram.Value = (int)ram_perf.NextValue();
            float val = (float) ram_perf.NextValue()/1024;
            val = 16- val;
            ram_l.Text = "CPU: " + val.ToString("0.00") + " GB";

            progress_disk.Value = (int)disk_perf.NextValue();
            disk_l.Text = "Disk Used: " + progress_disk.Value.ToString() + " GB";
        }
    }
}
