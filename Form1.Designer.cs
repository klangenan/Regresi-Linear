namespace RegresiLinear
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.listBoxUmur = new System.Windows.Forms.ListBox();
            this.listBoxBB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.btnPrediksi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHasilPrediksi = new System.Windows.Forms.Label();
            this.lblSumX = new System.Windows.Forms.Label();
            this.lblSumY = new System.Windows.Forms.Label();
            this.lblSumXSq = new System.Windows.Forms.Label();
            this.lblSumXY = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxUmur
            // 
            this.listBoxUmur.FormattingEnabled = true;
            this.listBoxUmur.ItemHeight = 14;
            this.listBoxUmur.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.listBoxUmur.Location = new System.Drawing.Point(12, 36);
            this.listBoxUmur.Name = "listBoxUmur";
            this.listBoxUmur.Size = new System.Drawing.Size(36, 564);
            this.listBoxUmur.TabIndex = 1;
            // 
            // listBoxBB
            // 
            this.listBoxBB.FormattingEnabled = true;
            this.listBoxBB.ItemHeight = 14;
            this.listBoxBB.Items.AddRange(new object[] {
            "50",
            "70",
            "90",
            "115",
            "140",
            "170",
            "200",
            "235",
            "270",
            "310",
            "350",
            "395",
            "440",
            "490",
            "540",
            "595",
            "650",
            "710",
            "770",
            "835",
            "900",
            "970",
            "1040",
            "1115",
            "1190",
            "1270",
            "1350",
            "1430",
            "1515",
            "1600",
            "1685",
            "1770",
            "1865",
            "1940",
            "2025",
            "2110",
            "2195",
            "2280",
            "2365",
            "2450"});
            this.listBoxBB.Location = new System.Drawing.Point(54, 36);
            this.listBoxBB.Name = "listBoxBB";
            this.listBoxBB.Size = new System.Drawing.Size(38, 564);
            this.listBoxBB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Masukkan Umur Ayam :";
            // 
            // txtUmur
            // 
            this.txtUmur.Location = new System.Drawing.Point(244, 32);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(58, 22);
            this.txtUmur.TabIndex = 4;
            // 
            // btnPrediksi
            // 
            this.btnPrediksi.Location = new System.Drawing.Point(121, 66);
            this.btnPrediksi.Name = "btnPrediksi";
            this.btnPrediksi.Size = new System.Drawing.Size(181, 34);
            this.btnPrediksi.TabIndex = 5;
            this.btnPrediksi.Text = "PREDIKSI";
            this.btnPrediksi.UseVisualStyleBackColor = true;
            this.btnPrediksi.Click += new System.EventHandler(this.btnPrediksi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasil Prediksi Berat Badan :";
            // 
            // lblHasilPrediksi
            // 
            this.lblHasilPrediksi.AutoSize = true;
            this.lblHasilPrediksi.Location = new System.Drawing.Point(118, 156);
            this.lblHasilPrediksi.Name = "lblHasilPrediksi";
            this.lblHasilPrediksi.Size = new System.Drawing.Size(42, 14);
            this.lblHasilPrediksi.TabIndex = 7;
            this.lblHasilPrediksi.Text = "label3";
            // 
            // lblSumX
            // 
            this.lblSumX.AutoSize = true;
            this.lblSumX.Location = new System.Drawing.Point(118, 202);
            this.lblSumX.Name = "lblSumX";
            this.lblSumX.Size = new System.Drawing.Size(46, 14);
            this.lblSumX.TabIndex = 8;
            this.lblSumX.Text = "SUM X :";
            // 
            // lblSumY
            // 
            this.lblSumY.AutoSize = true;
            this.lblSumY.Location = new System.Drawing.Point(118, 225);
            this.lblSumY.Name = "lblSumY";
            this.lblSumY.Size = new System.Drawing.Size(46, 14);
            this.lblSumY.TabIndex = 9;
            this.lblSumY.Text = "SUM Y :";
            // 
            // lblSumXSq
            // 
            this.lblSumXSq.AutoSize = true;
            this.lblSumXSq.Location = new System.Drawing.Point(118, 250);
            this.lblSumXSq.Name = "lblSumXSq";
            this.lblSumXSq.Size = new System.Drawing.Size(62, 14);
            this.lblSumXSq.TabIndex = 10;
            this.lblSumXSq.Text = "SUM X Sq :";
            // 
            // lblSumXY
            // 
            this.lblSumXY.AutoSize = true;
            this.lblSumXY.Location = new System.Drawing.Point(118, 276);
            this.lblSumXY.Name = "lblSumXY";
            this.lblSumXY.Size = new System.Drawing.Size(52, 14);
            this.lblSumXY.TabIndex = 11;
            this.lblSumXY.Text = "SUM XY :";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(329, 32);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(466, 232);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(329, 276);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(466, 300);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 610);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblSumXY);
            this.Controls.Add(this.lblSumXSq);
            this.Controls.Add(this.lblSumY);
            this.Controls.Add(this.lblSumX);
            this.Controls.Add(this.lblHasilPrediksi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrediksi);
            this.Controls.Add(this.txtUmur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxBB);
            this.Controls.Add(this.listBoxUmur);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Predisksi Berat Badan [Regresi Liniear]";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUmur;
        private System.Windows.Forms.ListBox listBoxBB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.Button btnPrediksi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHasilPrediksi;
        private System.Windows.Forms.Label lblSumX;
        private System.Windows.Forms.Label lblSumY;
        private System.Windows.Forms.Label lblSumXSq;
        private System.Windows.Forms.Label lblSumXY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;


    }
}

