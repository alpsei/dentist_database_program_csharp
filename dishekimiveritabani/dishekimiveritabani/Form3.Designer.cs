namespace dishekimiveritabani
{
    partial class Form3
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
            this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muayenetarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muayenesaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sikayetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muayeneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishekimiveriDataSet = new dishekimiveritabani.dishekimiveriDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.muayeneTableAdapter = new dishekimiveritabani.dishekimiveriDataSetTableAdapters.muayeneTableAdapter();
            this.hastaid = new System.Windows.Forms.TextBox();
            this.personelid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muayeneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishekimiveriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn,
            this.hastaidDataGridViewTextBoxColumn,
            this.muayenetarDataGridViewTextBoxColumn,
            this.muayenesaatDataGridViewTextBoxColumn,
            this.sikayetDataGridViewTextBoxColumn,
            this.sonucDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.pidDataGridViewTextBoxColumn,
            this.islemnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.muayeneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(942, 120);
            this.dataGridView1.TabIndex = 0;
            // 
            // midDataGridViewTextBoxColumn
            // 
            this.midDataGridViewTextBoxColumn.DataPropertyName = "mid";
            this.midDataGridViewTextBoxColumn.HeaderText = "Muayene ID";
            this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
            // 
            // hastaidDataGridViewTextBoxColumn
            // 
            this.hastaidDataGridViewTextBoxColumn.DataPropertyName = "hastaid";
            this.hastaidDataGridViewTextBoxColumn.HeaderText = "Hasta ID";
            this.hastaidDataGridViewTextBoxColumn.Name = "hastaidDataGridViewTextBoxColumn";
            // 
            // muayenetarDataGridViewTextBoxColumn
            // 
            this.muayenetarDataGridViewTextBoxColumn.DataPropertyName = "muayenetar";
            this.muayenetarDataGridViewTextBoxColumn.HeaderText = "Muayene Tarihi";
            this.muayenetarDataGridViewTextBoxColumn.Name = "muayenetarDataGridViewTextBoxColumn";
            // 
            // muayenesaatDataGridViewTextBoxColumn
            // 
            this.muayenesaatDataGridViewTextBoxColumn.DataPropertyName = "muayenesaat";
            this.muayenesaatDataGridViewTextBoxColumn.HeaderText = "Muayene Saati";
            this.muayenesaatDataGridViewTextBoxColumn.Name = "muayenesaatDataGridViewTextBoxColumn";
            // 
            // sikayetDataGridViewTextBoxColumn
            // 
            this.sikayetDataGridViewTextBoxColumn.DataPropertyName = "sikayet";
            this.sikayetDataGridViewTextBoxColumn.HeaderText = "Şikayet";
            this.sikayetDataGridViewTextBoxColumn.Name = "sikayetDataGridViewTextBoxColumn";
            // 
            // sonucDataGridViewTextBoxColumn
            // 
            this.sonucDataGridViewTextBoxColumn.DataPropertyName = "sonuc";
            this.sonucDataGridViewTextBoxColumn.HeaderText = "Sonuç";
            this.sonucDataGridViewTextBoxColumn.Name = "sonucDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "Personel ID";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            // 
            // islemnoDataGridViewTextBoxColumn
            // 
            this.islemnoDataGridViewTextBoxColumn.DataPropertyName = "islemno";
            this.islemnoDataGridViewTextBoxColumn.HeaderText = "İşlem No";
            this.islemnoDataGridViewTextBoxColumn.Name = "islemnoDataGridViewTextBoxColumn";
            // 
            // muayeneBindingSource
            // 
            this.muayeneBindingSource.DataMember = "muayene";
            this.muayeneBindingSource.DataSource = this.dishekimiveriDataSet;
            // 
            // dishekimiveriDataSet
            // 
            this.dishekimiveriDataSet.DataSetName = "dishekimiveriDataSet";
            this.dishekimiveriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hasta ID\'sine Göre Arama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(258, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(901, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ana Menüye Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // muayeneTableAdapter
            // 
            this.muayeneTableAdapter.ClearBeforeFill = true;
            // 
            // hastaid
            // 
            this.hastaid.Location = new System.Drawing.Point(365, 236);
            this.hastaid.Name = "hastaid";
            this.hastaid.Size = new System.Drawing.Size(100, 20);
            this.hastaid.TabIndex = 5;
            // 
            // personelid
            // 
            this.personelid.Location = new System.Drawing.Point(365, 263);
            this.personelid.Name = "personelid";
            this.personelid.Size = new System.Drawing.Size(100, 20);
            this.personelid.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(258, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Personel ID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(483, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Personel ID\'sine Göre Arama";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(362, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 55);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sorgulama";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personelid);
            this.Controls.Add(this.hastaid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Sorgu";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muayeneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishekimiveriDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private dishekimiveriDataSet dishekimiveriDataSet;
        private System.Windows.Forms.BindingSource muayeneBindingSource;
        private dishekimiveriDataSetTableAdapters.muayeneTableAdapter muayeneTableAdapter;
        private System.Windows.Forms.TextBox hastaid;
        private System.Windows.Forms.TextBox personelid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muayenetarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muayenesaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sikayetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}