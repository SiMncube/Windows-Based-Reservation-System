
namespace WindowsFormsApp1
{
    partial class adminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cellNumberTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addressLine2TextBox = new System.Windows.Forms.TextBox();
            this.addressLine1TextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firtNameTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingRefDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingInnerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fullDs1 = new WindowsFormsApp1.fullDatabase();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingInnerDGV = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingRefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingInnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDs = new WindowsFormsApp1.fullDatabase();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.customerTa = new WindowsFormsApp1.fullDatabaseTableAdapters.CustomerTableAdapter();
            this.paymentTa = new WindowsFormsApp1.fullDatabaseTableAdapters.PaymentTableAdapter();
            this.bookingInnerTa = new WindowsFormsApp1.fullDatabaseTableAdapters.BookingInnerTableAdapter();
            this.bookingSummaryTa = new WindowsFormsApp1.fullDatabaseTableAdapters.BookingSummaryTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInnerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDs1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInnerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(23, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1345, 744);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1337, 713);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create new customer profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.cellNumberTextBox);
            this.panel1.Controls.Add(this.IDTextBox);
            this.panel1.Controls.Add(this.postalCodeTextBox);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(this.addressLine2TextBox);
            this.panel1.Controls.Add(this.addressLine1TextBox);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.firtNameTextBox);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Location = new System.Drawing.Point(340, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 395);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register a new Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(42, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fill the registration form below to register a new customer ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label8.Location = new System.Drawing.Point(46, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 62;
            this.label8.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.icons8_user_24;
            this.pictureBox6.Location = new System.Drawing.Point(268, 219);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 61;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.icons8_envelope_24;
            this.pictureBox3.Location = new System.Drawing.Point(449, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.icons8_android_24;
            this.pictureBox2.Location = new System.Drawing.Point(522, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.SteelBlue;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(46, 315);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 35);
            this.cancelButton.TabIndex = 57;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Gray;
            this.emailTextBox.Location = new System.Drawing.Point(161, 267);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(314, 27);
            this.emailTextBox.TabIndex = 53;
            this.emailTextBox.Text = "Email";
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // cellNumberTextBox
            // 
            this.cellNumberTextBox.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellNumberTextBox.ForeColor = System.Drawing.Color.Gray;
            this.cellNumberTextBox.Location = new System.Drawing.Point(300, 218);
            this.cellNumberTextBox.Name = "cellNumberTextBox";
            this.cellNumberTextBox.Size = new System.Drawing.Size(248, 27);
            this.cellNumberTextBox.TabIndex = 52;
            this.cellNumberTextBox.Text = "Cell number";
            this.cellNumberTextBox.TextChanged += new System.EventHandler(this.cellNumberTextBox_TextChanged);
            this.cellNumberTextBox.Enter += new System.EventHandler(this.cellNumberTextBox_Enter);
            this.cellNumberTextBox.Leave += new System.EventHandler(this.cellNumberTextBox_Leave);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.IDTextBox.Location = new System.Drawing.Point(46, 218);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(248, 27);
            this.IDTextBox.TabIndex = 51;
            this.IDTextBox.Text = "ID number";
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            this.IDTextBox.Enter += new System.EventHandler(this.IDTextBox_Enter);
            this.IDTextBox.Leave += new System.EventHandler(this.IDTextBox_Leave);
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeTextBox.ForeColor = System.Drawing.Color.Gray;
            this.postalCodeTextBox.Location = new System.Drawing.Point(300, 184);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(248, 27);
            this.postalCodeTextBox.TabIndex = 50;
            this.postalCodeTextBox.Text = "Postal code";
            this.postalCodeTextBox.TextChanged += new System.EventHandler(this.postalCodeTextBox_TextChanged);
            this.postalCodeTextBox.Enter += new System.EventHandler(this.postalCodeTextBox_Enter);
            this.postalCodeTextBox.Leave += new System.EventHandler(this.postalCodeTextBox_Leave);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.ForeColor = System.Drawing.Color.Gray;
            this.cityTextBox.Location = new System.Drawing.Point(46, 184);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(248, 27);
            this.cityTextBox.TabIndex = 49;
            this.cityTextBox.Text = "City";
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            this.cityTextBox.Enter += new System.EventHandler(this.cityTextBox_Enter);
            this.cityTextBox.Leave += new System.EventHandler(this.cityTextBox_Leave);
            // 
            // addressLine2TextBox
            // 
            this.addressLine2TextBox.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLine2TextBox.ForeColor = System.Drawing.Color.Gray;
            this.addressLine2TextBox.Location = new System.Drawing.Point(46, 152);
            this.addressLine2TextBox.Name = "addressLine2TextBox";
            this.addressLine2TextBox.Size = new System.Drawing.Size(502, 27);
            this.addressLine2TextBox.TabIndex = 48;
            this.addressLine2TextBox.Text = "Street Address Line 2";
            this.addressLine2TextBox.TextChanged += new System.EventHandler(this.addressLine2TextBox_TextChanged);
            this.addressLine2TextBox.Enter += new System.EventHandler(this.addressLine2TextBox_Enter);
            this.addressLine2TextBox.Leave += new System.EventHandler(this.addressLine2TextBox_Leave);
            // 
            // addressLine1TextBox
            // 
            this.addressLine1TextBox.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLine1TextBox.ForeColor = System.Drawing.Color.Gray;
            this.addressLine1TextBox.Location = new System.Drawing.Point(46, 120);
            this.addressLine1TextBox.Name = "addressLine1TextBox";
            this.addressLine1TextBox.Size = new System.Drawing.Size(502, 27);
            this.addressLine1TextBox.TabIndex = 47;
            this.addressLine1TextBox.Text = "Street Address Line 1";
            this.addressLine1TextBox.TextChanged += new System.EventHandler(this.addressLine1TextBox_TextChanged);
            this.addressLine1TextBox.Enter += new System.EventHandler(this.addressLine1TextBox_Enter);
            this.addressLine1TextBox.Leave += new System.EventHandler(this.addressLine1TextBox_Leave);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.lastNameTextBox.Location = new System.Drawing.Point(300, 87);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(248, 27);
            this.lastNameTextBox.TabIndex = 46;
            this.lastNameTextBox.Text = "Last name";
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            this.lastNameTextBox.Enter += new System.EventHandler(this.lastNameTextBox_Enter);
            this.lastNameTextBox.Leave += new System.EventHandler(this.lastNameTextBox_Leave);
            // 
            // firtNameTextBox
            // 
            this.firtNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firtNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.firtNameTextBox.Location = new System.Drawing.Point(46, 87);
            this.firtNameTextBox.Name = "firtNameTextBox";
            this.firtNameTextBox.Size = new System.Drawing.Size(248, 27);
            this.firtNameTextBox.TabIndex = 41;
            this.firtNameTextBox.Text = "First name";
            this.firtNameTextBox.TextChanged += new System.EventHandler(this.firtNameTextBox_TextChanged);
            this.firtNameTextBox.Enter += new System.EventHandler(this.firtNameTextBox_Enter);
            this.firtNameTextBox.Leave += new System.EventHandler(this.firtNameTextBox_Leave);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(227, 248);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(179, 16);
            this.label23.TabIndex = 42;
            this.label23.Text = "Email already registered";
            this.label23.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(265, 248);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 16);
            this.label22.TabIndex = 41;
            this.label22.Text = "Email invalid";
            this.label22.Visible = false;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.SteelBlue;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(466, 315);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(82, 35);
            this.registerButton.TabIndex = 38;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1337, 713);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Make booking";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1337, 713);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modify booking";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1337, 713);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cancel booking";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(116, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1049, 303);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cancel booking(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(365, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Booking(s) successfully cancelled";
            this.label4.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(413, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel booking(s)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.iDNumberDataGridViewTextBoxColumn1,
            this.cellNumberDataGridViewTextBoxColumn1,
            this.bookingRefDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.bookingStatusDataGridViewTextBoxColumn1,
            this.amountPaidDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bookingInnerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(108, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(844, 128);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDNumberDataGridViewTextBoxColumn1
            // 
            this.iDNumberDataGridViewTextBoxColumn1.DataPropertyName = "ID Number";
            this.iDNumberDataGridViewTextBoxColumn1.HeaderText = "ID Number";
            this.iDNumberDataGridViewTextBoxColumn1.Name = "iDNumberDataGridViewTextBoxColumn1";
            this.iDNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cellNumberDataGridViewTextBoxColumn1
            // 
            this.cellNumberDataGridViewTextBoxColumn1.DataPropertyName = "cell Number";
            this.cellNumberDataGridViewTextBoxColumn1.HeaderText = "cell Number";
            this.cellNumberDataGridViewTextBoxColumn1.Name = "cellNumberDataGridViewTextBoxColumn1";
            this.cellNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bookingRefDataGridViewTextBoxColumn1
            // 
            this.bookingRefDataGridViewTextBoxColumn1.DataPropertyName = "Booking Ref";
            this.bookingRefDataGridViewTextBoxColumn1.HeaderText = "Booking Ref";
            this.bookingRefDataGridViewTextBoxColumn1.Name = "bookingRefDataGridViewTextBoxColumn1";
            this.bookingRefDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bookingStatusDataGridViewTextBoxColumn1
            // 
            this.bookingStatusDataGridViewTextBoxColumn1.DataPropertyName = "Booking status";
            this.bookingStatusDataGridViewTextBoxColumn1.HeaderText = "Booking status";
            this.bookingStatusDataGridViewTextBoxColumn1.Name = "bookingStatusDataGridViewTextBoxColumn1";
            this.bookingStatusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // amountPaidDataGridViewTextBoxColumn1
            // 
            this.amountPaidDataGridViewTextBoxColumn1.DataPropertyName = "Amount paid";
            this.amountPaidDataGridViewTextBoxColumn1.HeaderText = "Amount paid";
            this.amountPaidDataGridViewTextBoxColumn1.Name = "amountPaidDataGridViewTextBoxColumn1";
            this.amountPaidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bookingInnerBindingSource1
            // 
            this.bookingInnerBindingSource1.DataMember = "BookingInner";
            this.bookingInnerBindingSource1.DataSource = this.fullDs1;
            // 
            // fullDs1
            // 
            this.fullDs1.DataSetName = "fullDatabase";
            this.fullDs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bookingInnerDGV);
            this.panel2.Location = new System.Drawing.Point(116, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 296);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-5, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Search for booking(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(409, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Row is already added";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(242, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(601, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(275, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter booking ref, customer email or Customer name";
            // 
            // bookingInnerDGV
            // 
            this.bookingInnerDGV.AllowUserToAddRows = false;
            this.bookingInnerDGV.AllowUserToDeleteRows = false;
            this.bookingInnerDGV.AutoGenerateColumns = false;
            this.bookingInnerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingInnerDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.iDNumberDataGridViewTextBoxColumn,
            this.cellNumberDataGridViewTextBoxColumn,
            this.bookingRefDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.bookingStatusDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn});
            this.bookingInnerDGV.DataSource = this.bookingInnerBindingSource;
            this.bookingInnerDGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.bookingInnerDGV.Location = new System.Drawing.Point(108, 105);
            this.bookingInnerDGV.Name = "bookingInnerDGV";
            this.bookingInnerDGV.ReadOnly = true;
            this.bookingInnerDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bookingInnerDGV.Size = new System.Drawing.Size(844, 156);
            this.bookingInnerDGV.TabIndex = 0;
            this.bookingInnerDGV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bookingInnerDGV_RowHeaderMouseDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDNumberDataGridViewTextBoxColumn
            // 
            this.iDNumberDataGridViewTextBoxColumn.DataPropertyName = "ID Number";
            this.iDNumberDataGridViewTextBoxColumn.HeaderText = "ID Number";
            this.iDNumberDataGridViewTextBoxColumn.Name = "iDNumberDataGridViewTextBoxColumn";
            this.iDNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellNumberDataGridViewTextBoxColumn
            // 
            this.cellNumberDataGridViewTextBoxColumn.DataPropertyName = "cell Number";
            this.cellNumberDataGridViewTextBoxColumn.HeaderText = "cell Number";
            this.cellNumberDataGridViewTextBoxColumn.Name = "cellNumberDataGridViewTextBoxColumn";
            this.cellNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingRefDataGridViewTextBoxColumn
            // 
            this.bookingRefDataGridViewTextBoxColumn.DataPropertyName = "Booking Ref";
            this.bookingRefDataGridViewTextBoxColumn.HeaderText = "Booking Ref";
            this.bookingRefDataGridViewTextBoxColumn.Name = "bookingRefDataGridViewTextBoxColumn";
            this.bookingRefDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingStatusDataGridViewTextBoxColumn
            // 
            this.bookingStatusDataGridViewTextBoxColumn.DataPropertyName = "Booking status";
            this.bookingStatusDataGridViewTextBoxColumn.HeaderText = "Booking status";
            this.bookingStatusDataGridViewTextBoxColumn.Name = "bookingStatusDataGridViewTextBoxColumn";
            this.bookingStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount paid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "Amount paid";
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            this.amountPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingInnerBindingSource
            // 
            this.bookingInnerBindingSource.DataMember = "BookingInner";
            this.bookingInnerBindingSource.DataSource = this.fullDs;
            // 
            // fullDs
            // 
            this.fullDs.DataSetName = "fullDatabase";
            this.fullDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1337, 713);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "View booking";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // customerTa
            // 
            this.customerTa.ClearBeforeFill = true;
            // 
            // paymentTa
            // 
            this.paymentTa.ClearBeforeFill = true;
            // 
            // bookingInnerTa
            // 
            this.bookingInnerTa.ClearBeforeFill = true;
            // 
            // bookingSummaryTa
            // 
            this.bookingSummaryTa.ClearBeforeFill = true;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tabControl1);
            this.Name = "adminForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInnerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDs1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInnerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cellNumberTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox addressLine2TextBox;
        private System.Windows.Forms.TextBox addressLine1TextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firtNameTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button registerButton;
        private fullDatabase fullDs;
        private fullDatabaseTableAdapters.CustomerTableAdapter customerTa;
        private fullDatabaseTableAdapters.PaymentTableAdapter paymentTa;
        private fullDatabaseTableAdapters.BookingInnerTableAdapter bookingInnerTa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView bookingInnerDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingRefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookingInnerBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingRefDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bookingInnerBindingSource1;
        private fullDatabase fullDs1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private fullDatabaseTableAdapters.BookingSummaryTableAdapter bookingSummaryTa;
    }
}