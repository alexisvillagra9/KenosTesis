namespace KenosTesis
{
    partial class InformesEstadisticos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.informeGraficoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graficoCircularEstadosSocios = new KenosTesis.GraficoCircularEstadosSocios();
            this.informeGraficoTableAdapter = new KenosTesis.GraficoCircularEstadosSociosTableAdapters.InformeGraficoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeGraficoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCircularEstadosSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 40;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.informeGraficoBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(118, 29);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Transparent;
            series1.Label = "#PERCENT";
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.LegendText = "#VALXs";
            series1.MarkerColor = System.Drawing.Color.Transparent;
            series1.MarkerImageTransparentColor = System.Drawing.Color.Transparent;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.XValueMember = "descripcion";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValueMembers = "cant";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(293, 183);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // informeGraficoBindingSource
            // 
            this.informeGraficoBindingSource.DataMember = "InformeGrafico";
            this.informeGraficoBindingSource.DataSource = this.graficoCircularEstadosSocios;
            // 
            // graficoCircularEstadosSocios
            // 
            this.graficoCircularEstadosSocios.DataSetName = "GraficoCircularEstadosSocios";
            this.graficoCircularEstadosSocios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informeGraficoTableAdapter
            // 
            this.informeGraficoTableAdapter.ClearBeforeFill = true;
            // 
            // InformesEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 379);
            this.Controls.Add(this.chart1);
            this.Name = "InformesEstadisticos";
            this.Text = "InformesEstadisticos";
            this.Load += new System.EventHandler(this.InformesEstadisticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeGraficoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCircularEstadosSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GraficoCircularEstadosSocios graficoCircularEstadosSocios;
        private System.Windows.Forms.BindingSource informeGraficoBindingSource;
        private GraficoCircularEstadosSociosTableAdapters.InformeGraficoTableAdapter informeGraficoTableAdapter;
    }
}