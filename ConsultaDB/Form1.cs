using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaDB
{
    public partial class Form1 : Form
    {
        Connection conection = new Connection();
        List<String> info = new List<string>();
        List<String> info2 = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }


        public void buscar()
        {
            SqlConnection conn = conection.NewConection();
            string Consulta = "SELECT * FROM Employee;";
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            try
            {
               
                da = new SqlDataAdapter(Consulta, conn);
                da.Fill(dt);
                SqlCommand cmd = new SqlCommand(Consulta, conn);
                SqlDataReader dr = cmd.ExecuteReader();
               
                if (dt != null)
                {
                    while (dr.Read())
                    {
                        info.Add(Convert.ToString(dr["Firt_name"]));                                                      
                        info2.Add(Convert.ToString(dr["Last_name"]));
                    }
                }

                foreach (string name in info)
                {                   
                    Content.Rows.Add(name);
                }
                foreach (string name2 in info2)
                {
                    Content2.Rows.Add(name2);
                }
                conn.Close();               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexion : " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }

       
    }
}
