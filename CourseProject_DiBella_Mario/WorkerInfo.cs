using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectMEP
{
    public partial class WorkerInfo : BaseForm

    {
        public WorkerInfo()
        {
            InitializeComponent();
        }
          
       
        private string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mario\source\repos\CourseProject_DiBella_Mario\CourseProject_DiBella_Mario\App_Data\EmployeeBasic.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection con;
        private SqlCommand cmd;
        private void WorkerInfo_Load(object sender, EventArgs e)
        {

            //string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mario\source\repos\FinalProjectMEP\FinalProjectMEP\App_Data\EmployeeBasic.mdf;Integrated Security=True";
            using (con = new SqlConnection(constr))
            {

                StringBuilder baseSelect = new StringBuilder("Select * From EmployeeInfo Where emp_name = ");
                baseSelect.Append("'" + Profile.RandomWorker + "'");

                using (cmd = new SqlCommand(baseSelect.ToString()))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        labelID.Text = sdr["emp_id"].ToString();
                        pictureBox1.ImageLocation = sdr["emp_pic"].ToString();
                        labelName.Text = sdr["emp_name"].ToString();
                        labelAge.Text = sdr["emp_age"].ToString();
                        labelBirthdate.Text = sdr["emp_birth"].ToString();
                        labelPosition.Text = sdr["emp_position"].ToString();
                        labelSalary.Text = sdr["emp_salary"].ToString();
                    }
                }
                con.Close();
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            using (con = new SqlConnection(constr))
            {
                con.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = @"INSERT INTO EmployeePersonal(emp_id,emp_name,emp_married,emp_childrenOrPEts,emp_numberOfChildrenOrPets,emp_faminfo,emp_hobbies,emp_stress,emp_feedback)
                                                  Values('" + labelID.Text + "','" +
                                                          labelName.Text + "','" +
                                                          listBoxMarried.SelectedItem.ToString() + "','" +
                                                          listBoxChildrenOrNone.SelectedItem.ToString() + "','" +
                                                          listBoxNumberOfChildrenOrPets.SelectedItem.ToString() + "','" +
                                                          textBoxFamInfo.Text + "','" +
                                                          textBoxHobbies.Text + "','" +
                                                          textBoxStress.Text + "','" +
                                                          textBoxFeedback.Text + "');";

                    cmd.ExecuteNonQuery();

                }
            }
            con.Close();
        }

        private void listBoxMarried_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMarried.SelectedIndex == 0)
            {
                petsOrKidsLabel.Text = "Any kids?";
                petsOrKidsLabel.Visible = true;
                listBoxChildrenOrNone.Visible = true;
            }
            if (listBoxMarried.SelectedIndex == 1)
            {
                petsOrKidsLabel.Text = "Any pets?";
                petsOrKidsLabel.Visible = true;
                listBoxChildrenOrNone.Visible = true;
            }
        }

        private void listBoxChildrenOrNone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxChildrenOrNone.SelectedIndex == 0)
            {
                numberPetsOrChildrenLabel.Visible = true;
                listBoxNumberOfChildrenOrPets.Visible = true;
                
            }
        }
        Bitmap bitmap;
        private void printButton_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap,
                     (e.PageBounds.Width - bitmap.Width) / 2,
                     (e.PageBounds.Height - bitmap.Height) / 2,
                     bitmap.Width,
                     bitmap.Height);
        }
    }
    
}
