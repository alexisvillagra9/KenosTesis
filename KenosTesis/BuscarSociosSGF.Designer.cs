namespace KenosTesis
{
    partial class BuscarSociosSGF
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilarSportClubDataSet6 = new KenosTesis.pilarSportClubDataSet6();
            this.label1 = new System.Windows.Forms.Label();
            this.socioTableAdapter = new KenosTesis.pilarSportClubDataSet6TableAdapters.socioTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pilarSportClubDataSet9 = new KenosTesis.pilarSportClubDataSet9();
            this.buscarSociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarSociosTableAdapter = new KenosTesis.pilarSportClubDataSet9TableAdapters.buscarSociosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarSociosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.idSocioDataGridViewTextBoxColumn,
            this.nombreSocioDataGridViewTextBoxColumn,
            this.apellidoSocioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buscarSociosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(419, 228);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idSocioDataGridViewTextBoxColumn
            // 
            this.idSocioDataGridViewTextBoxColumn.DataPropertyName = "idSocio";
            this.idSocioDataGridViewTextBoxColumn.HeaderText = "idSocio";
            this.idSocioDataGridViewTextBoxColumn.Name = "idSocioDataGridViewTextBoxColumn";
            this.idSocioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreSocioDataGridViewTextBoxColumn
            // 
            this.nombreSocioDataGridViewTextBoxColumn.DataPropertyName = "nombreSocio";
            this.nombreSocioDataGridViewTextBoxColumn.HeaderText = "nombreSocio";
            this.nombreSocioDataGridViewTextBoxColumn.Name = "nombreSocioDataGridViewTextBoxColumn";
            this.nombreSocioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoSocioDataGridViewTextBoxColumn
            // 
            this.apellidoSocioDataGridViewTextBoxColumn.DataPropertyName = "apellidoSocio";
            this.apellidoSocioDataGridViewTextBoxColumn.HeaderText = "apellidoSocio";
            this.apellidoSocioDataGridViewTextBoxColumn.Name = "apellidoSocioDataGridViewTextBoxColumn";
            this.apellidoSocioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataMember = "socio";
            this.socioBindingSource.DataSource = this.pilarSportClubDataSet6;
            // 
            // pilarSportClubDataSet6
            // 
            this.pilarSportClubDataSet6.DataSetName = "pilarSportClubDataSet6";
            this.pilarSportClubDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Por favor, seleeccione el o los socio/s para el grupo familiar.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // socioTableAdapter
            // 
            this.socioTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pilarSportClubDataSet9
            // 
            this.pilarSportClubDataSet9.DataSetName = "pilarSportClubDataSet9";
            this.pilarSportClubDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarSociosBindingSource
            // 
            this.buscarSociosBindingSource.DataMember = "buscarSocios";
            this.buscarSociosBindingSource.DataSource = this.pilarSportClubDataSet9;
            // 
            // buscarSociosTableAdapter
            // 
            this.buscarSociosTableAdapter.ClearBeforeFill = true;
            // 
            // BuscarSociosSGF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 365);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "BuscarSociosSGF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarSociosSGF";
            this.Load += new System.EventHandler(this.BuscarSociosSGF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarSociosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private pilarSportClubDataSet6 pilarSportClubDataSet6;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private pilarSportClubDataSet6TableAdapters.socioTableAdapter socioTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private pilarSportClubDataSet9 pilarSportClubDataSet9;
        private System.Windows.Forms.BindingSource buscarSociosBindingSource;
        private pilarSportClubDataSet9TableAdapters.buscarSociosTableAdapter buscarSociosTableAdapter;
    }
}