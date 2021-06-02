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
    public partial class Manager : Form
    {
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button5;
        private Panel panel3;
        private GroupBox groupBox1;
        private Button button1;
        private string[,] employee, repairs, orders, inventory;
        private TextBox textBox2;
        private Label SearchButton;
        Administrator admini = new Administrator();
        private DataTable dT, dT2, dT3, dT4;
        private bool buttonManageAcc, buttonInventory, buttonReports;
        private DataGridView dataGridView1;
        private int count;

        public Manager()
        {
            InitializeComponent();
            dT = new DataTable();
            dT2 = new DataTable();
            dT3 = new DataTable();
            dT4 = new DataTable();
            count = 0;
            loadEmployees();
            loadInventory();
            loadReports();
            loadDT();

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 150);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1277, 902);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1044, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 103);
            this.button3.TabIndex = 6;
            this.button3.Text = "Manage accounts";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(818, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 103);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reports";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AliceBlue;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(592, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 103);
            this.button5.TabIndex = 4;
            this.button5.Text = "Inventory";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(366, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "login as\r\n admin";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.SearchButton);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(2, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1277, 902);
            this.panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(911, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(353, 31);
            this.textBox2.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.Location = new System.Drawing.Point(843, 18);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(62, 25);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1278, 934);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tables";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-25, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1268, 823);
            this.dataGridView1.TabIndex = 0;
            // 
            // Manager
            // 
            this.ClientSize = new System.Drawing.Size(1278, 1050);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (count == 0)
            {
                dataGridView1.DataSource = dT2;
                count++;
            }
            else
            {
                dataGridView1.DataSource = dT3;
                count--;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dT4;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admini.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void loadEmployees() {
            employee = new string[6, 8];
            employee[0, 0] = "employee Id";
            employee[0, 1] = "employee name";
            employee[0, 2] = "ID no";
            employee[0, 3] = "cellNumber";
            employee[0, 4] = "employee Email";
            employee[0, 5] = "employee Last name";
            employee[0, 6] = "Role";
            employee[0, 7] = "Physical Adress";
            for ( int i = 1; i < 6; i++)
            {
                employee[i, 0] = "mngunto1";
                employee[i, 1] = "ntokozo";
                employee[i, 2] = "Mnguni";
                employee[i, 3] = "76092912345081";
                employee[i, 4] = "076 087 0980";
                employee[i, 5] = "123msenti@gmail.com";
                employee[i, 6] = "Mr D delivery";
                employee[i, 7] = "Mr D delivery";
            }
            

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
        private void loadInventory()
        {
            inventory = new string[6, 7];
            inventory[0, 0] = "inventoryID";
            inventory[0, 1] = "productName";
            inventory[0, 2] = "categoryName";
            inventory[0, 3] = "costPrice";
            inventory[0, 4] = "sellingPrice";
            inventory[0, 5] = "quantityAvailable";
            inventory[0, 6] = "minQuantity";
            for (int i = 1; i < 6; i++)
            {
                inventory[i, 0] = "earphone12";
                inventory[i, 1] = "earphones";
                inventory[i, 2] = "accesory";
                inventory[i, 3] = "14";
                inventory[i, 4] = "21";
                inventory[i, 5] = "15";
                inventory[i, 6] = "3";
            }
        }

        private void loadDT()
        {
            for (int i = 0; i < 8; i++)
            {
                dT.Columns.Add(employee[0, i]);
            }
            for (int i = 1; i < 6; i++)
            {
                dT.Rows.Add(employee[i, 0], employee[i, 1], employee[i, 2], employee[i, 3], employee[i, 4],
                    employee[i, 5], employee[i, 6], employee[i, 7]);
            }
        
            for (int i = 0; i < 9; i++)
            {
                dT2.Columns.Add(repairs[0, i]);
            }
            for (int i = 1; i < 6; i++)
            {
                dT2.Rows.Add(repairs[i, 0], repairs[i, 1], repairs[i, 2], repairs[i, 3], repairs[i, 4],
                    repairs[i, 5], repairs[i, 6], repairs[i, 7], repairs[i,8]);
            }
            for (int i = 0; i < 7; i++)
            {
                dT3.Columns.Add(orders[0, i]);
            }
            for (int i = 1; i < 6; i++)
            {
                dT3.Rows.Add(orders[i, 0], orders[i, 1], orders[i, 2], orders[i, 3], orders[i, 4],
                    orders[i, 5], orders[i, 6]);
            }
            for (int i = 0; i < 7; i++)
            {
                dT4.Columns.Add(inventory[0, i]);
            }
            for (int i = 1; i < 6; i++)
            {
                dT4.Rows.Add(inventory[i, 0], inventory[i, 1], inventory[i, 2], inventory[i, 3], inventory[i, 4],
                    inventory[i, 5], inventory[i, 6]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dT;
        }
    }
    
}
