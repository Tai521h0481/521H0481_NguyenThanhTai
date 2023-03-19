using iTextSharp.text.pdf;
using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("server=DESKTOP-DN8EH6I\\SQLEXPRESS;database=BTL;Trusted_Connection=true");
        SqlDataAdapter dt;
        SqlCommand cmd;
        DataTable tb;
        private void Form1_Load(object sender, EventArgs e)
        {
            string q = "delete from Ticket";
            cmd = new SqlCommand(q, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            btnChange.Enabled = false;
            btnSave.Enabled = false;
        }

        private void showGV()
        {
            string max_id_query = "SELECT MAX(Id) FROM Ticket UNION ALL SELECT 'T0000' WHERE NOT EXISTS (SELECT Id FROM Ticket)";
            cmd = new SqlCommand(max_id_query, cn);
            cn.Open();
            object result = cmd.ExecuteScalar();
            cn.Close();
            string new_id;

            if (result == DBNull.Value || result == null)
            {
                new_id = "T0001";
            }
            else
            {
                string max_id = (string)result;
                new_id = "T" + (int.Parse(max_id.Substring(1)) + 1).ToString("0000");
            }

            string insert_query = string.Format("INSERT INTO Ticket VALUES ('{0}', '{1}', '{2}')", new_id, txtDes.Text, DateTime.Now);
            cmd = new SqlCommand(insert_query, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            
            string q = "select * from Ticket";
            dt = new SqlDataAdapter(q, cn);
            tb = new DataTable();
            dt.Fill(tb);
            dtGV.DataSource = tb;
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDes.Text))
            {
                MessageBox.Show("Please select destination before paying");
                return;
            }
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (form2.Success)
            {
                showGV();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDes.Text))
            {
                MessageBox.Show("Please select destination before paying");
                return;
            }

            Form3 form3 = new Form3();
            form3.ShowDialog();
            if (form3.Success)
            {
                showGV();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dtGV.Columns.Count > 0)
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("ticket.pdf", FileMode.Create));
                document.Open();
                PdfPTable table = new PdfPTable(dtGV.Columns.Count);
                for (int j = 0; j < dtGV.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dtGV.Columns[j].HeaderText));
                }

                table.HeaderRows = 1;

                for (int i = 0; i < dtGV.Rows.Count; i++)
                {
                    for (int k = 0; k < dtGV.Columns.Count; k++)
                    {
                        if (dtGV[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(dtGV[k, i].Value.ToString()));
                        }
                    }
                }
                document.Add(table);
                document.Close();
                MessageBox.Show("Ticket issue successful");
            }
            else
            {
                MessageBox.Show("Please purchase tickets before");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtGV_Click(object sender, EventArgs e)
        {
            btnChange.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtGV.Focus();
            MessageBox.Show("Please select the new destination you want to change");
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string txtID = dtGV.CurrentRow.Cells[0].Value.ToString();
            if(txtID == null)
            {
                MessageBox.Show("Please select the ticket you want to change");
                return;
            }
            string q = String.Format("update Ticket Set Destination = '{0}', CreationTime = '{1}' where ID = '{2}'", txtDes.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), txtID);
            cmd = new SqlCommand(q, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Successfully changed");

            q = "select * from Ticket";
            dt = new SqlDataAdapter(q, cn);
            tb = new DataTable();
            dt.Fill(tb);
            dtGV.DataSource = tb;
        }
    }
}