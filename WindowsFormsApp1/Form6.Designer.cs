
namespace WindowsFormsApp1
{
    partial class Form6
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bookingSummaryTableAdapter1 = new WindowsFormsApp1.fullDatabaseTableAdapters.BookingSummaryTableAdapter();
            this.fullDatabase1 = new WindowsFormsApp1.fullDatabase();
            this.bookingSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullDatabase1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingSummaryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.summaryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfNightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullDatabase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDatabase1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingSummaryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check Booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Booking Reference *";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(205, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_back_arrow_30;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 33);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(85, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 213);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Check Booking";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(85, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 309);
            this.panel2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Booking Details";
            // 
            // bookingSummaryTableAdapter1
            // 
            this.bookingSummaryTableAdapter1.ClearBeforeFill = true;
            // 
            // fullDatabase1
            // 
            this.fullDatabase1.DataSetName = "fullDatabase";
            this.fullDatabase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingSummaryBindingSource
            // 
            this.bookingSummaryBindingSource.DataMember = "BookingSummary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(91, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Booking does not exist";
            this.label5.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.summaryIDDataGridViewTextBoxColumn,
            this.emailIDDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.dateOutDataGridViewTextBoxColumn,
            this.bookingMethodDataGridViewTextBoxColumn,
            this.bookingStatusDataGridViewTextBoxColumn,
            this.amountDueDataGridViewTextBoxColumn,
            this.numberOfNightsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingSummaryBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(569, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 484);
            this.dataGridView1.TabIndex = 27;
            // 
            // fullDatabase1BindingSource
            // 
            this.fullDatabase1BindingSource.DataSource = this.fullDatabase1;
            this.fullDatabase1BindingSource.Position = 0;
            // 
            // bookingSummaryBindingSource1
            // 
            this.bookingSummaryBindingSource1.DataMember = "BookingSummary";
            this.bookingSummaryBindingSource1.DataSource = this.fullDatabase1BindingSource;
            // 
            // summaryIDDataGridViewTextBoxColumn
            // 
            this.summaryIDDataGridViewTextBoxColumn.DataPropertyName = "summaryID";
            this.summaryIDDataGridViewTextBoxColumn.HeaderText = "summaryID";
            this.summaryIDDataGridViewTextBoxColumn.Name = "summaryIDDataGridViewTextBoxColumn";
            this.summaryIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bookingStatusDataGridViewTextBoxColumn
            // 
            this.bookingStatusDataGridViewTextBoxColumn.DataPropertyName = "bookingStatus";
            this.bookingStatusDataGridViewTextBoxColumn.HeaderText = "bookingStatus";
            this.bookingStatusDataGridViewTextBoxColumn.Name = "bookingStatusDataGridViewTextBoxColumn";
            // 
            // amountDueDataGridViewTextBoxColumn
            // 
            this.amountDueDataGridViewTextBoxColumn.DataPropertyName = "amountDue";
            this.amountDueDataGridViewTextBoxColumn.HeaderText = "amountDue";
            this.amountDueDataGridViewTextBoxColumn.Name = "amountDueDataGridViewTextBoxColumn";
            // 
            // numberOfNightsDataGridViewTextBoxColumn
            // 
            this.numberOfNightsDataGridViewTextBoxColumn.DataPropertyName = "numberOfNights";
            this.numberOfNightsDataGridViewTextBoxColumn.HeaderText = "numberOfNights";
            this.numberOfNightsDataGridViewTextBoxColumn.Name = "numberOfNightsDataGridViewTextBoxColumn";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form6";
            this.Text = "Booking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullDatabase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDatabase1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingSummaryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private fullDatabaseTableAdapters.BookingSummaryTableAdapter bookingSummaryTableAdapter1;
        private fullDatabase fullDatabase1;
        private System.Windows.Forms.BindingSource bookingSummaryBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfNightsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookingSummaryBindingSource1;
        private System.Windows.Forms.BindingSource fullDatabase1BindingSource;
    }
}