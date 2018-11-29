using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Presentacion
{
    public class Utiles
    {
        public static void FillListView(ListView LST, DataTable vDataTable)
        {
            try
            {

                int vAncho = 0;

                vAncho = 210;

                LST.Columns.Clear();
                LST.Items.Clear();
                LST.View = View.Details;
                LST.FullRowSelect = true;
                LST.MultiSelect = false;
                LST.GridLines = true;

                DataSet ds = new DataSet();

                ds.Tables.Add(vDataTable);

                foreach (DataColumn c in ds.Tables[0].Columns)
                {
                    //Incluye las columnas
                    ColumnHeader Columna = new ColumnHeader();

                    Columna.Text = c.ColumnName;
                    Columna.Width = vAncho;
                    LST.Columns.Add(Columna);
                }

                DataTable dt = ds.Tables[0];
                string[] str = new string[ds.Tables[0].Columns.Count + 1];

                //Incluye las filas al Listview
                foreach (DataRow row in dt.Rows)
                {
                    for (int col = 0; col <= ds.Tables[0].Columns.Count - 1; col++)
                    {
                        str[col] = row[col].ToString();
                    }
                    ListViewItem Lista = new ListViewItem(str);
                    LST.Items.Add(Lista);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
