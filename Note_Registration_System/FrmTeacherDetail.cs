using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Note_Registration_System
{
    public partial class FrmTeacherDetail : Form
    {

        public FrmTeacherDetail()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-K0B0HR9\SQLEXPRESS;Initial Catalog=DbNoteReg;Integrated Security=True");

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTeacherDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNoteRegDataSet.Tbl_Lesson' table. You can move, or remove it, as needed.
            this.tbl_LessonTableAdapter.Fill(this.dbNoteRegDataSet.Tbl_Lesson);
            // TODO: This line of code loads data into the 'dbNoteRegDataSet2.Tbl_Lesson' table. You can move, or remove it, as needed.
            this.tbl_LessonTableAdapter3.Fill(this.dbNoteRegDataSet2.Tbl_Lesson);
            // TODO: This line of code loads data into the 'dbNoteRegDataSet3.Tbl_Lesson' table. You can move, or remove it, as needed.
            this.tbl_LessonTableAdapter2.Fill(this.dbNoteRegDataSet3.Tbl_Lesson);
            // TODO: This line of code loads data into the 'dbNoteRegDataSet1.Tbl_Lesson' table. You can move, or remove it, as needed.
            this.tbl_LessonTableAdapter1.Fill(this.dbNoteRegDataSet1.Tbl_Lesson);
            // TODO: This line of code loads data into the 'dbNoteRegDataSet.Tbl_Lesson' table. You can move, or remove it, as needed.
            this.tbl_LessonTableAdapter.Fill(this.dbNoteRegDataSet.Tbl_Lesson);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand command =
                new SqlCommand("insert into Tbl_Lesson (STDNUMBER, STDNAME, STDSURNAME) values (@P1,@P2,@P3)",
                    _connection);
            command.Parameters.AddWithValue("@p1", mskNumber.Text);
            command.Parameters.AddWithValue("@p2", mskName.Text);
            command.Parameters.AddWithValue("@p3", mskSurname.Text);
            command.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Student Added to the System");
            this.tbl_LessonTableAdapter.Fill(this.dbNoteRegDataSet.Tbl_Lesson);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose = dataGridView1.SelectedCells[0].RowIndex;
            mskNumber.Text = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            mskName.Text = dataGridView1.Rows[choose].Cells[2].Value.ToString();
            mskSurname.Text = dataGridView1.Rows[choose].Cells[3].Value.ToString();

            txtE1.Text = dataGridView1.Rows[choose].Cells[4].Value.ToString();
            txtE2.Text = dataGridView1.Rows[choose].Cells[5].Value.ToString();
            txtE3.Text = dataGridView1.Rows[choose].Cells[6].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double avg, e1, e2, e3;
            string situ;

            e1 = Convert.ToDouble(txtE1.Text);
            e2 = Convert.ToDouble(txtE1.Text);
            e3 = Convert.ToDouble(txtE1.Text);
            avg = (e1 + e2 + e3) / 3;
            lblAverage.Text = avg.ToString();

            lblPass.Text = dbNoteRegDataSet3.Tbl_Lesson.Count(x => x.SITUATION == true).ToString();

            if (avg >= 50)
            {
                situ = "True";
            }
            else
            {
                situ = "False";
            }
            _connection.Open();
            SqlCommand command = new SqlCommand("update Tbl_Lesson set STDE1=@P1, STDE2=@P2, STDE3=@P3, AVERAGE=@p4, SITUATION=@p5 where STDNUMBER=@p6", _connection);

            command.Parameters.AddWithValue("@p1", txtE1.Text);
            command.Parameters.AddWithValue("@p2", txtE1.Text);
            command.Parameters.AddWithValue("@p3", txtE1.Text);
            command.Parameters.AddWithValue("@p4", decimal.Parse(lblAverage.Text));
            command.Parameters.AddWithValue("@P5", situ);
            command.Parameters.AddWithValue("@p6", mskNumber.Text);
            command.ExecuteNonQuery();
            _connection.Close();
            MessageBox.Show("Student grades updated!");
            

       //     this.tbl_LessonTableAdapter.Fill(this.dbNoteRegDataSet.Tbl_Lesson);

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void lblAverage_Click(object sender, EventArgs e)
        {

        }

        private void lblPass_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblRema_Click(object sender, EventArgs e)
        {

        }
    }
}
