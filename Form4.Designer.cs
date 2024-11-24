
namespace Project_2
{
    partial class Form4
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tBresvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBHotelDataSet = new Project_2.DBHotelDataSet();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBresvTableAdapter = new Project_2.DBHotelDataSetTableAdapters.TBresvTableAdapter();
            this.tBresvBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBresvBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dBHotelDataSet2 = new Project_2.DBHotelDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.tBresvBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tBresvBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dBHotelDataSet1 = new Project_2.DBHotelDataSet1();
            this.tBresvBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tBresvTableAdapter1 = new Project_2.DBHotelDataSet1TableAdapters.TBresvTableAdapter();
            this.tBresvTableAdapter2 = new Project_2.DBHotelDataSet2TableAdapters.TBresvTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(413, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 30);
            this.textBox2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(46, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "회원번호";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(130, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 30);
            this.textBox1.TabIndex = 33;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(346, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "회원명";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(654, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 40;
            this.button2.Text = "조  회";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(127, 446);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 30);
            this.textBox3.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(16, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "총 결제 금액";
            // 
            // tBresvTableAdapter
            // 
            this.tBresvTableAdapter.ClearBeforeFill = true;
            // 
            // tBresvBindingSource1
            // 
            this.tBresvBindingSource1.DataMember = "TBresv";
            this.tBresvBindingSource1.DataSource = this.dBHotelDataSet;
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
            this.dataGridView1.DataSource = this.tBresvBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(24, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(744, 251);
            this.dataGridView1.TabIndex = 44;
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
            // tBresvBindingSource5
            // 
            this.tBresvBindingSource5.DataMember = "TBresv";
            this.tBresvBindingSource5.DataSource = this.dBHotelDataSet2;
            // 
            // dBHotelDataSet2
            // 
            this.dBHotelDataSet2.DataSetName = "DBHotelDataSet2";
            this.dBHotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(676, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 45;
            this.button1.Text = "종  료";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBresvBindingSource2
            // 
            this.tBresvBindingSource2.DataMember = "TBresv";
            this.tBresvBindingSource2.DataSource = this.dBHotelDataSet;
            // 
            // tBresvBindingSource3
            // 
            this.tBresvBindingSource3.DataMember = "TBresv";
            this.tBresvBindingSource3.DataSource = this.dBHotelDataSet;
            // 
            // dBHotelDataSet1
            // 
            this.dBHotelDataSet1.DataSetName = "DBHotelDataSet1";
            this.dBHotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBresvBindingSource4
            // 
            this.tBresvBindingSource4.DataMember = "TBresv";
            this.tBresvBindingSource4.DataSource = this.dBHotelDataSet1;
            // 
            // tBresvTableAdapter1
            // 
            this.tBresvTableAdapter1.ClearBeforeFill = true;
            // 
            // tBresvTableAdapter2
            // 
            this.tBresvTableAdapter2.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(565, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 46;
            this.button3.Text = "확 인";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LemonChiffon;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(144, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(481, 32);
            this.label11.TabIndex = 53;
            this.label11.Text = "호텔 예약 프로그램 - 회원별 예약내역 조회";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(404, 448);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 30);
            this.textBox4.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(293, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 54;
            this.label4.Text = "총 이용 횟수";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Name = "Form4";
            this.Text = "회원별 이용 내역 조회";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBresvBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private DBHotelDataSet dBHotelDataSet;
        private System.Windows.Forms.BindingSource tBresvBindingSource;
        private DBHotelDataSetTableAdapters.TBresvTableAdapter tBresvTableAdapter;
        private System.Windows.Forms.BindingSource tBresvBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tBresvBindingSource3;
        private System.Windows.Forms.BindingSource tBresvBindingSource2;
        private DBHotelDataSet1 dBHotelDataSet1;
        private System.Windows.Forms.BindingSource tBresvBindingSource4;
        private DBHotelDataSet1TableAdapters.TBresvTableAdapter tBresvTableAdapter1;
        private DBHotelDataSet2 dBHotelDataSet2;
        private System.Windows.Forms.BindingSource tBresvBindingSource5;
        private DBHotelDataSet2TableAdapters.TBresvTableAdapter tBresvTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adult;
        private System.Windows.Forms.DataGridViewTextBoxColumn kidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idate;
        private System.Windows.Forms.DataGridViewTextBoxColumn odate;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}