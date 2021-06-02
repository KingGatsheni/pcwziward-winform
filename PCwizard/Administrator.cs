using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCwizard
{
    public partial class Administrator : Form
    {
        private string[,] repairs, orders;
        private DataTable dt1, dt2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private int count;

        public Administrator()
        {
            InitializeComponent();
            dt1 = new DataTable();
            dt2 = new DataTable();
            loadReports();
            loadDT();
            count = 0;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, -5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1291, 1059);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1283, 1021);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1283, 1021);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Repairs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Administrator
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1278, 1050);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                dataGridView1.DataSource = dt1;
                count++;
            }
            else
            {
                dataGridView1.DataSource = dt2;
                count--;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
        private void loadReports()
        {
            repairs = new string[6, 9];
            orders = new string[6, 7];
            repairs[0, 0] = "repairID";
            repairs[0, 1] = "productName";
            repairs[0, 2] = "modNummber";
            repairs[0, 3] = "itemFault";
            repairs[0, 4] = "bookedFor";
            repairs[0, 5] = "bookedOn";
            repairs[0, 6] = "RepairPrice";
            repairs[0, 7] = "repairStatus";
            repairs[0, 8] = "CustomerName";
            for (int i = 1; i < 6; i++)
            {
                repairs[i, 0] = "1233";
                repairs[i, 1] = "dell laptop";
                repairs[i, 2] = "342";
                repairs[i, 3] = "hinge problem";
                repairs[i, 4] = "Nombuso";
                repairs[i, 5] = "02/05/21";
                repairs[i, 6] = "300";
                repairs[i, 7] = "ready for pick up";
                repairs[i, 8] = "Anele";
            }
            orders[0, 0] = "orderID";
            orders[0, 1] = "customerID";
            orders[0, 2] = "employeeId";
            orders[0, 3] = "orderDate";
            orders[0, 4] = "orderTotal";
            orders[0, 5] = "discount";
            orders[0, 6] = "orderStatus";
            for (int i = 1; i < 6; i++)
            {
                orders[i, 0] = "876";
                orders[i, 1] = "Nombuso12";
                orders[i, 2] = "mngunto1";
                orders[i, 3] = "2/2/21";
                orders[i, 4] = "700";
                orders[i, 5] = "0";
                orders[i, 6] = "ready for pick up";
            }


        }
        private void loadDT()
        {
            for (int i = 0; i < 9; i++)
            {
                dt1.Columns.Add(repairs[0, i]);
            }
            for (int i = 1; i < 6; i++)
            {
                dt1.Rows.Add(repairs[i, 0], repairs[i, 1], repairs[i, 2], repairs[i, 3], repairs[i, 4],
                    repairs[i, 5], repairs[i, 6], repairs[i, 7], repairs[i, 8]);
            }
            for (int i = 0; i < 7; i++)
            {
                dt2.Columns.Add(orders[0, i]);
            }
            for (int i = 1; i < 6; i++)
            {
                dt2.Rows.Add(orders[i, 0], orders[i, 1], orders[i, 2], orders[i, 3], orders[i, 4],
                    orders[i, 5], orders[i, 6]);
            }
        }
    }
}
