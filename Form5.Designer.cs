
namespace Project_2
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBresvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBHotelDataSet = new Project_2.DBHotelDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dBHotelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBresvTableAdapter = new Project_2.DBHotelDataSetTableAdapters.TBresvTableAdapter();
            this.dBHotelDataSet2 = new Project_2.DBHotelDataSet2();
            this.tBresvBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBresvTableAdapter1 = new Project_2.DBHotelDataSet2TableAdapters.TBresvTableAdapter();
            this.ridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdate = new System.Windows.Forms.MaskedTextBox();
            this.edate = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ridDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.name,
            this.phone,
            this.adult,
            this.kidDataGridViewTextBoxColumn,
            this.idate,
            this.odate,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBresvBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(36, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(799, 252);
            this.dataGridView1.TabIndex = 42;
            // 
            // tBresvBindingSource
            // 
            this.tBresvBindingSource.DataMember = "TBresv";
            this.tBresvBindingSource.DataSource = this.dBHotelDataSet;
            // 
            // dBHotelDataSet
            // 
            this.dBHotelDataSet.DataSetName = "DBHotelDataSet";
            this.dBHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(53, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "날 짜 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(344, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "~";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(648, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 47;
            this.button2.Text = "조  회";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dBHotelDataSetBindingSource
            // 
            this.dBHotelDataSetBindingSource.DataSource = this.dBHotelDataSet;
            this.dBHotelDataSetBindingSource.Position = 0;
            // 
            // tBresvTableAdapter
            // 
            this.tBresvTableAdapter.ClearBeforeFill = true;
            // 
            // dBHotelDataSet2
            // 
            this.dBHotelDataSet2.DataSetName = "DBHotelDataSet2";
            this.dBHotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBresvBindingSource1
            // 
            this.tBresvBindingSource1.DataMember = "TBresv";
            this.tBresvBindingSource1.DataSource = this.dBHotelDataSet2;
            // 
            // tBresvTableAdapter1
            // 
            this.tBresvTableAdapter1.ClearBeforeFill = true;
            // 
            // ridDataGridViewTextBoxColumn
            // 
            this.ridDataGridViewTextBoxColumn.DataPropertyName = "rid";
            this.ridDataGridViewTextBoxColumn.HeaderText = "rid";
            this.ridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ridDataGridViewTextBoxColumn.Name = "ridDataGridViewTextBoxColumn";
            this.ridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            // 
            // adult
            // 
            this.adult.DataPropertyName = "adult";
            this.adult.HeaderText = "adult";
            this.adult.MinimumWidth = 6;
            this.adult.Name = "adult";
            // 
            // kidDataGridViewTextBoxColumn
            // 
            this.kidDataGridViewTextBoxColumn.DataPropertyName = "kid";
            this.kidDataGridViewTextBoxColumn.HeaderText = "kid";
            this.kidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kidDataGridViewTextBoxColumn.Name = "kidDataGridViewTextBoxColumn";
            // 
            // idate
            // 
            this.idate.DataPropertyName = "idate";
            this.idate.HeaderText = "idate";
            this.idate.MinimumWidth = 6;
            this.idate.Name = "idate";
            // 
            // odate
            // 
            this.odate.DataPropertyName = "odate";
            this.odate.HeaderText = "odate";
            this.odate.MinimumWidth = 6;
            this.odate.Name = "odate";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // sdate
            // 
            this.sdate.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sdate.Location = new System.Drawing.Point(143, 96);
            this.sdate.Mask = "0000-00-00";
            this.sdate.Name = "sdate";
            this.sdate.Size = new System.Drawing.Size(176, 30);
            this.sdate.TabIndex = 52;
            this.sdate.ValidatingType = typeof(System.DateTime);
            // 
            // edate
            // 
            this.edate.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.edate.Location = new System.Drawing.Point(391, 96);
            this.edate.Mask = "0000-00-00";
            this.edate.Name = "edate";
            this.edate.Size = new System.Drawing.Size(176, 30);
            this.edate.TabIndex = 53;
            this.edate.ValidatingType = typeof(System.DateTime);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(127, 440);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 30);
            this.textBox3.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(19, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 23);
            this.label10.TabIndex = 54;
            this.label10.Text = "예약 객실 수";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(434, 441);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 30);
            this.textBox1.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(326, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "사용 고객수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(454, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "어른";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(555, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 59;
            this.label5.Text = "아이";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(536, 441);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 30);
            this.textBox2.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(648, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 61;
            this.button1.Text = "조  회";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(760, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 62;
            this.button3.Text = "종 료";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LemonChiffon;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(312, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 32);
            this.label11.TabIndex = 63;
            this.label11.Text = "기간별 예약 내역 조회";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 493);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.edate);
            this.Controls.Add(this.sdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "기간별 조회";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource dBHotelDataSetBindingSource;
        private DBHotelDataSet dBHotelDataSet;
        private System.Windows.Forms.BindingSource tBresvBindingSource;
        private DBHotelDataSetTableAdapters.TBresvTableAdapter tBresvTableAdapter;
        private DBHotelDataSet2 dBHotelDataSet2;
        private System.Windows.Forms.BindingSource tBresvBindingSource1;
        private DBHotelDataSet2TableAdapters.TBresvTableAdapter tBresvTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adult;
        private System.Windows.Forms.DataGridViewTextBoxColumn kidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idate;
        private System.Windows.Forms.DataGridViewTextBoxColumn odate;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox sdate;
        private System.Windows.Forms.MaskedTextBox edate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
    }
}