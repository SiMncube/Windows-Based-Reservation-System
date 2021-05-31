
namespace WindowsFormsApp1
{
    partial class Form7
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDatabase1 = new WindowsFormsApp1.fullDatabase();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.summaryIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfNightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingSummaryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bookedRoomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new WindowsFormsApp1.fullDatabaseTableAdapters.CustomerTableAdapter();
            this.paymentTableAdapter1 = new WindowsFormsApp1.fullDatabaseTableAdapters.PaymentTableAdapter();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingSummaryTableAdapter1 = new WindowsFormsApp1.fullDatabaseTableAdapters.BookingSummaryTableAdapter();
            this.bookingSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookedRoomTableAdapter1 = new WindowsFormsApp1.fullDatabaseTableAdapters.BookedRoomTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDatabase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingSummaryBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingSummaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(427, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Number *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expiry date *";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(297, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(297, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 26);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CVV *";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(297, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_back_arrow_30;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 33);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(77, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 276);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(293, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Card has expired!";
            this.label6.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(297, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(315, 26);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Card Holder as it appear on the card*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Payment Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentIDDataGridViewTextBoxColumn,
            this.dateOfPaymentDataGridViewTextBoxColumn,
            this.amountDueDataGridViewTextBoxColumn,
            this.summaryIDDataGridViewTextBoxColumn,
            this.typeOfPaymentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(753, 461);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 267);
            this.dataGridView1.TabIndex = 26;
            // 
            // paymentIDDataGridViewTextBoxColumn
            // 
            this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "paymentID";
            this.paymentIDDataGridViewTextBoxColumn.HeaderText = "paymentID";
            this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
            this.paymentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfPaymentDataGridViewTextBoxColumn
            // 
            this.dateOfPaymentDataGridViewTextBoxColumn.DataPropertyName = "dateOfPayment";
            this.dateOfPaymentDataGridViewTextBoxColumn.HeaderText = "dateOfPayment";
            this.dateOfPaymentDataGridViewTextBoxColumn.Name = "dateOfPaymentDataGridViewTextBoxColumn";
            // 
            // amountDueDataGridViewTextBoxColumn
            // 
            this.amountDueDataGridViewTextBoxColumn.DataPropertyName = "amountDue";
            this.amountDueDataGridViewTextBoxColumn.HeaderText = "amountDue";
            this.amountDueDataGridViewTextBoxColumn.Name = "amountDueDataGridViewTextBoxColumn";
            // 
            // summaryIDDataGridViewTextBoxColumn
            // 
            this.summaryIDDataGridViewTextBoxColumn.DataPropertyName = "summaryID";
            this.summaryIDDataGridViewTextBoxColumn.HeaderText = "summaryID";
            this.summaryIDDataGridViewTextBoxColumn.Name = "summaryIDDataGridViewTextBoxColumn";
            // 
            // typeOfPaymentDataGridViewTextBoxColumn
            // 
            this.typeOfPaymentDataGridViewTextBoxColumn.DataPropertyName = "typeOfPayment";
            this.typeOfPaymentDataGridViewTextBoxColumn.HeaderText = "typeOfPayment";
            this.typeOfPaymentDataGridViewTextBoxColumn.Name = "typeOfPaymentDataGridViewTextBoxColumn";
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.fullDatabase1;
            // 
            // fullDatabase1
            // 
            this.fullDatabase1.DataSetName = "fullDatabase";
            this.fullDatabase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.summaryIDDataGridViewTextBoxColumn1,
            this.bookingStatusDataGridViewTextBoxColumn,
            this.amountDueDataGridViewTextBoxColumn1,
            this.emailIDDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.dateOutDataGridViewTextBoxColumn,
            this.bookingMethodDataGridViewTextBoxColumn,
            this.numberOfNightsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bookingSummaryBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(77, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 203);
            this.dataGridView2.TabIndex = 27;
            // 
            // summaryIDDataGridViewTextBoxColumn1
            // 
            this.summaryIDDataGridViewTextBoxColumn1.DataPropertyName = "summaryID";
            this.summaryIDDataGridViewTextBoxColumn1.HeaderText = "summaryID";
            this.summaryIDDataGridViewTextBoxColumn1.Name = "summaryIDDataGridViewTextBoxColumn1";
            this.summaryIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bookingStatusDataGridViewTextBoxColumn
            // 
            this.bookingStatusDataGridViewTextBoxColumn.DataPropertyName = "bookingStatus";
            this.bookingStatusDataGridViewTextBoxColumn.HeaderText = "bookingStatus";
            this.bookingStatusDataGridViewTextBoxColumn.Name = "bookingStatusDataGridViewTextBoxColumn";
            // 
            // amountDueDataGridViewTextBoxColumn1
            // 
            this.amountDueDataGridViewTextBoxColumn1.DataPropertyName = "amountDue";
            this.amountDueDataGridViewTextBoxColumn1.HeaderText = "amountDue";
            this.amountDueDataGridViewTextBoxColumn1.Name = "amountDueDataGridViewTextBoxColumn1";
            // 
            // emailIDDataGridViewTextBoxColumn
            // 
            this.emailIDDataGridViewTextBoxColumn.DataPropertyName = "emailID";
            this.emailIDDataGridViewTextBoxColumn.HeaderText = "emailID";
            this.emailIDDataGridViewTextBoxColumn.Name = "emailIDDataGridViewTextBoxColumn";
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "dateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "dateIn";
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            // 
            // dateOutDataGridViewTextBoxColumn
            // 
            this.dateOutDataGridViewTextBoxColumn.DataPropertyName = "dateOut";
            this.dateOutDataGridViewTextBoxColumn.HeaderText = "dateOut";
            this.dateOutDataGridViewTextBoxColumn.Name = "dateOutDataGridViewTextBoxColumn";
            // 
            // bookingMethodDataGridViewTextBoxColumn
            // 
            this.bookingMethodDataGridViewTextBoxColumn.DataPropertyName = "bookingMethod";
            this.bookingMethodDataGridViewTextBoxColumn.HeaderText = "bookingMethod";
            this.bookingMethodDataGridViewTextBoxColumn.Name = "bookingMethodDataGridViewTextBoxColumn";
            // 
            // numberOfNightsDataGridViewTextBoxColumn
            // 
            this.numberOfNightsDataGridViewTextBoxColumn.DataPropertyName = "numberOfNights";
            this.numberOfNightsDataGridViewTextBoxColumn.HeaderText = "numberOfNights";
            this.numberOfNightsDataGridViewTextBoxColumn.Name = "numberOfNightsDataGridViewTextBoxColumn";
            // 
            // bookingSummaryBindingSource1
            // 
            this.bookingSummaryBindingSource1.DataMember = "BookingSummary";
            this.bookingSummaryBindingSource1.DataSource = this.fullDatabase1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(77, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 207);
            this.panel2.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(133, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Payment Successful";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(133, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "Amount Paid :  R";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(133, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Amount Due : ";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookedRoomIDDataGridViewTextBoxColumn,
            this.dateIDDataGridViewTextBoxColumn,
            this.summaryIDDataGridViewTextBoxColumn2,
            this.roomIDDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.bookedRoomBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(848, 39);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(432, 203);
            this.dataGridView3.TabIndex = 29;
            // 
            // bookedRoomIDDataGridViewTextBoxColumn
            // 
            this.bookedRoomIDDataGridViewTextBoxColumn.DataPropertyName = "bookedRoomID";
            this.bookedRoomIDDataGridViewTextBoxColumn.HeaderText = "bookedRoomID";
            this.bookedRoomIDDataGridViewTextBoxColumn.Name = "bookedRoomIDDataGridViewTextBoxColumn";
            this.bookedRoomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateIDDataGridViewTextBoxColumn
            // 
            this.dateIDDataGridViewTextBoxColumn.DataPropertyName = "dateID";
            this.dateIDDataGridViewTextBoxColumn.HeaderText = "dateID";
            this.dateIDDataGridViewTextBoxColumn.Name = "dateIDDataGridViewTextBoxColumn";
            // 
            // summaryIDDataGridViewTextBoxColumn2
            // 
            this.summaryIDDataGridViewTextBoxColumn2.DataPropertyName = "summaryID";
            this.summaryIDDataGridViewTextBoxColumn2.HeaderText = "summaryID";
            this.summaryIDDataGridViewTextBoxColumn2.Name = "summaryIDDataGridViewTextBoxColumn2";
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "roomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "roomID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            // 
            // bookedRoomBindingSource
            // 
            this.bookedRoomBindingSource.DataMember = "BookedRoom";
            this.bookedRoomBindingSource.DataSource = this.fullDatabase1;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.fullDatabase1;
            // 
            // bookingSummaryTableAdapter1
            // 
            this.bookingSummaryTableAdapter1.ClearBeforeFill = true;
            // 
            // bookingSummaryBindingSource
            // 
            this.bookingSummaryBindingSource.DataMember = "BookingSummary";
            this.bookingSummaryBindingSource.DataSource = this.fullDatabase1;
            // 
            // bookedRoomTableAdapter1
            // 
            this.bookedRoomTableAdapter1.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(261, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(347, 27);
            this.label10.TabIndex = 34;
            this.label10.Text = "Booking summary database";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(937, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 27);
            this.label11.TabIndex = 35;
            this.label11.Text = "Payment database";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(922, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 27);
            this.label12.TabIndex = 36;
            this.label12.Text = "BookedRoom database";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.stack_clean_towels_bathrobe_table_73344_6251;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 749);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDatabase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingSummaryBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingSummaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private fullDatabase fullDatabase1;
        private fullDatabaseTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private fullDatabaseTableAdapters.PaymentTableAdapter paymentTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label label6;
        private fullDatabaseTableAdapters.BookingSummaryTableAdapter bookingSummaryTableAdapter1;
        private System.Windows.Forms.BindingSource bookingSummaryBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bookingSummaryBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfNightsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private fullDatabaseTableAdapters.BookedRoomTableAdapter bookedRoomTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedRoomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookedRoomBindingSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}