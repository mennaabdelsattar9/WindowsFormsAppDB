using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Services;
using Patagames.Ocr;


namespace WindowsFormsAppDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                //select query
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("select * from DOCTOR", sqlcon);
                DataTable datatable = new DataTable();
                sqldataadapter.Fill(datatable);
                dataGridView1.DataSource = datatable;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();


                
                //select all query with parameter
                SqlCommand command = new SqlCommand("SELECT * FROM DRUG" + " WHERE [DRUG_CODE] = @drugcode", sqlcon);
                // Add parameters and values to SelectCommand .
                command.Parameters.Add("@drugcode", SqlDbType.VarChar).Value = textBox6.Text;

                //specify command type [text or stored procedure]
                command.CommandType = CommandType.Text;
                //pass command to new instance of sqlDataAdapter 
                SqlDataAdapter adp = new SqlDataAdapter(command);
                //create dataTable to store the retrieved data
                DataTable dataTable2 = new DataTable();
                //fill retrieved data to data table
                adp.Fill(dataTable2);
                //bind data to grid view

                if (dataTable2.Rows.Count != 0)
                    label9.Text = "Drug Found";
                else
                    label9.Text = "Drug not Found";
                
            }

           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myclinicDataSet1.DRUG' table. You can move, or remove it, as needed.
            this.dRUGTableAdapter1.Fill(this.myclinicDataSet1.DRUG);
            // TODO: This line of code loads data into the 'myclinicDataSet.DRUG' table. You can move, or remove it, as needed.
            this.dRUGTableAdapter.Fill(this.myclinicDataSet.DRUG);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.PAT_ID = textBox1.Text;
            patient.PAT_FNAME = textBox2.Text;
            patient.PAT_LNAME = textBox3.Text;
            patient.PAT_NationalID = textBox4.Text;
            patient.PAT_PHONE = textBox5.Text;
            patient.PAT_DOB = dateTimePicker1.Value;

            //Patient Validation
            ValidationContext validationContext = new ValidationContext(patient);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(patient, validationContext, errors, true))
            {
                foreach (var item in errors)
                {
                    switch (item.MemberNames.First())
                    {
                        case "PAT_ID":
                            Lbl_IDError.Text = item.ErrorMessage;
                            Lbl_IDError.ForeColor = Color.Red;
                            break;
                        case "PAT_NationalID":
                            Lbl_NIDError.Text = item.ErrorMessage;
                            break;
                        case "PAT_FNAME":
                            Lbl_FNameError.Text = item.ErrorMessage;
                            break;
                        case "PAT_LNAME":
                            Lbl_LNameError.Text = item.ErrorMessage;
                            break;
                        case "PAT_PHONE":
                            Lbl_DoBError.Text = item.ErrorMessage;
                            break;
                        default:

                            MessageBox.Show(item.ErrorMessage);
                            break;
                    }
                }
            }
            else
            {
                string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

                using (SqlConnection sqlcon = new SqlConnection(conStr))
                {
                    sqlcon.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO PATIENT (PAT_ID,[PAT_NationalID],PAT_FNAME,PAT_LNAME, PAT_DOB,PAT_PHONE)" + "VALUES( @PAT_ID, @PAT_NationalID, @PAT_FNAME, @PAT_LNAME , @PAT_DOB , @PAT_PHONE)", sqlcon);
                        command.Parameters.Add("@PAT_ID", SqlDbType.Int).Value = patient.PAT_ID.ToString();
                        command.Parameters.Add("@PAT_NationalID", SqlDbType.Int).Value = patient.PAT_NationalID.ToString();
                        command.Parameters.Add("@PAT_FNAME", SqlDbType.VarChar).Value = patient.PAT_FNAME;
                        command.Parameters.Add("@PAT_LNAME", SqlDbType.VarChar).Value = patient.PAT_LNAME;
                        command.Parameters.Add("@PAT_DOB", SqlDbType.DateTime).Value = patient.PAT_DOB;
                        command.Parameters.Add("@PAT_PHONE", SqlDbType.VarChar).Value = patient.PAT_PHONE;

                        SqlDataAdapter adp = new SqlDataAdapter();
                        adp.InsertCommand = command;
                        adp.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Patient Inserted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }
                }

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            using(var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.Arabic);
                string plainText = objOcr.GetTextFromImage(pictureBox1.ImageLocation);
                textBox7.Text = plainText;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\lenovo\source\repos\WindowsFormsAppDB\WindowsFormsAppDB\img\out1.jpg";
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
