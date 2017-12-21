namespace KvalitetaZrakaForm
{
    partial class Form1
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mEASUREMENTSTATIONIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEASUREMENTSTATIONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airQualitymeasurementstationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotNetDataSet = new KvalitetaZrakaForm.DotNetDataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pOLLUTANTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOLLUTANTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airQualitypollutantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotNetDataSet1 = new KvalitetaZrakaForm.DotNetDataSet1();
            this.airQuality_measurement_stationsTableAdapter = new KvalitetaZrakaForm.DotNetDataSetTableAdapters.AirQuality_measurement_stationsTableAdapter();
            this.airQuality_pollutantsTableAdapter = new KvalitetaZrakaForm.DotNetDataSet1TableAdapters.AirQuality_pollutantsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airQualitymeasurementstationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNetDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airQualitypollutantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNetDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 288);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mjerni rezultati";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(520, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mjerne postaje";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mEASUREMENTSTATIONIDDataGridViewTextBoxColumn,
            this.mEASUREMENTSTATIONNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.airQualitymeasurementstationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // mEASUREMENTSTATIONIDDataGridViewTextBoxColumn
            // 
            this.mEASUREMENTSTATIONIDDataGridViewTextBoxColumn.DataPropertyName = "MEASUREMENT_STATION_ID";
            this.mEASUREMENTSTATIONIDDataGridViewTextBoxColumn.HeaderText = "ID Stanice";
            this.mEASUREMENTSTATIONIDDataGridViewTextBoxColumn.Name = "mEASUREMENTSTATIONIDDataGridViewTextBoxColumn";
            this.mEASUREMENTSTATIONIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // mEASUREMENTSTATIONNAMEDataGridViewTextBoxColumn
            // 
            this.mEASUREMENTSTATIONNAMEDataGridViewTextBoxColumn.DataPropertyName = "MEASUREMENT_STATION_NAME";
            this.mEASUREMENTSTATIONNAMEDataGridViewTextBoxColumn.HeaderText = "Naziv stanice";
            this.mEASUREMENTSTATIONNAMEDataGridViewTextBoxColumn.Name = "mEASUREMENTSTATIONNAMEDataGridViewTextBoxColumn";
            this.mEASUREMENTSTATIONNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // airQualitymeasurementstationsBindingSource
            // 
            this.airQualitymeasurementstationsBindingSource.DataMember = "AirQuality_measurement_stations";
            this.airQualitymeasurementstationsBindingSource.DataSource = this.dotNetDataSet;
            // 
            // dotNetDataSet
            // 
            this.dotNetDataSet.DataSetName = "DotNetDataSet";
            this.dotNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(520, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Onečišćujuće tvari";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pOLLUTANTIDDataGridViewTextBoxColumn,
            this.pOLLUTANTNAMEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.airQualitypollutantsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(524, 262);
            this.dataGridView2.TabIndex = 0;
            // 
            // pOLLUTANTIDDataGridViewTextBoxColumn
            // 
            this.pOLLUTANTIDDataGridViewTextBoxColumn.DataPropertyName = "POLLUTANT_ID";
            this.pOLLUTANTIDDataGridViewTextBoxColumn.HeaderText = "ID polutanta";
            this.pOLLUTANTIDDataGridViewTextBoxColumn.Name = "pOLLUTANTIDDataGridViewTextBoxColumn";
            this.pOLLUTANTIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOLLUTANTNAMEDataGridViewTextBoxColumn
            // 
            this.pOLLUTANTNAMEDataGridViewTextBoxColumn.DataPropertyName = "POLLUTANT_NAME";
            this.pOLLUTANTNAMEDataGridViewTextBoxColumn.HeaderText = "Naziv polutanta";
            this.pOLLUTANTNAMEDataGridViewTextBoxColumn.Name = "pOLLUTANTNAMEDataGridViewTextBoxColumn";
            this.pOLLUTANTNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // airQualitypollutantsBindingSource
            // 
            this.airQualitypollutantsBindingSource.DataMember = "AirQuality_pollutants";
            this.airQualitypollutantsBindingSource.DataSource = this.dotNetDataSet1;
            // 
            // dotNetDataSet1
            // 
            this.dotNetDataSet1.DataSetName = "DotNetDataSet1";
            this.dotNetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airQuality_measurement_stationsTableAdapter
            // 
            this.airQuality_measurement_stationsTableAdapter.ClearBeforeFill = true;
            // 
            // airQuality_pollutantsTableAdapter
            // 
            this.airQuality_pollutantsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 313);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Kvaliteta Zraka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airQualitymeasurementstationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNetDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airQualitypollutantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNetDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private DotNetDataSet dotNetDataSet;
        private System.Windows.Forms.BindingSource airQualitymeasurementstationsBindingSource;
        private DotNetDataSetTableAdapters.AirQuality_measurement_stationsTableAdapter airQuality_measurement_stationsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DotNetDataSet1 dotNetDataSet1;
        private System.Windows.Forms.BindingSource airQualitypollutantsBindingSource;
        private DotNetDataSet1TableAdapters.AirQuality_pollutantsTableAdapter airQuality_pollutantsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEASUREMENTSTATIONIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEASUREMENTSTATIONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOLLUTANTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOLLUTANTNAMEDataGridViewTextBoxColumn;
    }
}

