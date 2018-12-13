using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class F_Acceso_Manual_Usuario : Form
    {
        public F_Acceso_Manual_Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
               /* string pdfpath = Path.Combine(Application.StartupPath, "Manual de usuario\\UNDP-LAC-Country Offices Directory-7September2018");
                Process.Start(pdfpath);*/
            
            }
            catch
            {
                MessageBox.Show("No se pudo encontrar el archivo");
            }
            
        }
    }
}
