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
using System.Configuration;

namespace gw2r_HMS
{
    public partial class frmPatReg : Form
    {
        int Id;
        SqlCommand cmd;
        SqlDataAdapter da;
        public frmPatReg()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ARCHIE\Desktop\gw2r_HMS\gw2r_HMS\slqexpress.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add new patient
            string query = "INSERT INTO [Patients] (Firstname,Lastname,Age,Gender,Ethnicity,Blood,Weight,Disability,Address,Telephone,Email,NextofKin,KinTelephone) VALUES ('"+txtfname.Text+"','"+txtlname.Text+"','"+txtage.Text+"','"+cbsex.Text+"','"+cbEhnicity.Text+"','"+cbblood.Text+"','"+txtweight.Text+"','"+cbdisability.Text+"','"+txtAddress.Text+"','"+txtTelephone.Text+"','"+txtEmail.Text+"','"+txtKin.Text+"','"+txtKinTel.Text+"')";
            crud.createCon();
            crud.insertData(query);
            crud.updateCon();  
            clearData();
        }
        private void clearData()
        {
            //clear data after patient creation
            txtfname.Text = "";
            txtlname.Text = "";
            txtage.Text = "";
            cbsex.Text = "";
            cbEhnicity.Text = "";
            cbblood.Text = "";
            txtweight.Text = "";
            cbdisability.Text = "";
            txtAddress.Text = "";
            txtTelephone.Text = "";
            txtEmail.Text = "";
            txtKin.Text = "";
            txtKinTel.Text = "";
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //display patient records
            populateDvg();
        }
        private void populateDvg()
        {
            string query = "SELECT * FROM Patients";
            crud.createCon();
            DataTable dt = crud.readData(query);
            crud.updateCon();
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Patients WHERE Pat_Id = '" + Id + "'";
            crud.createCon();
            crud.deleteData(query);
            crud.updateCon();
            populateDvg();
            clearData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //update patient record
            string query = "UPDATE [Patients] SET [Firstname]='" + txtfname.Text + "',[Lastname]='" + txtlname.Text + "',[Age]='" + txtage.Text + "',[Gender]='" + cbsex.Text + "',[Ethnicity]='" + cbEhnicity.Text + "',[Blood]='" + cbblood.Text + "',[Weight]='" + txtweight.Text + "',[Disability]='" + cbdisability.Text + "',[Address]='" + txtAddress.Text + "',[Telephone]='" + txtTelephone.Text + "',[Email]='" + txtEmail.Text + "',[NextofKin]='" + txtKin.Text + "',[KinTelephone]='" + txtKinTel.Text + "' WHERE Pat_Id='" + Id + "'";
            crud.createCon();
            crud.updateData(query);
            crud.createCon();
            populateDvg();
            clearData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Patients WHERE Firstname = '" +txtsearch.Text + "'";
            crud.createCon();
            DataTable dt = crud.readData(query);
            crud.updateCon();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            Id = Convert.ToInt32(selectedRow.Cells["Pat_Id"].Value);
            txtfname.Text = Convert.ToString(selectedRow.Cells["Firstname"].Value);
            txtlname.Text = Convert.ToString(selectedRow.Cells["Lastname"].Value);
            txtage.Text = Convert.ToString(selectedRow.Cells["Age"].Value);
            cbsex.Text = Convert.ToString(selectedRow.Cells["Gender"].Value);
            cbEhnicity.Text = Convert.ToString(selectedRow.Cells["Ethnicity"].Value);
            cbblood.Text = Convert.ToString(selectedRow.Cells["Blood"].Value);
            txtweight.Text = Convert.ToString(selectedRow.Cells["Weight"].Value);
            cbdisability.Text = Convert.ToString(selectedRow.Cells["Disability"].Value);
            txtAddress.Text = Convert.ToString(selectedRow.Cells["Address"].Value);
            txtTelephone.Text = Convert.ToString(selectedRow.Cells["Telephone"].Value);
            txtEmail.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
            txtKin.Text = Convert.ToString(selectedRow.Cells["NextofKin"].Value);
            txtKinTel.Text = Convert.ToString(selectedRow.Cells["KinTelephone"].Value);
        }
    }
}