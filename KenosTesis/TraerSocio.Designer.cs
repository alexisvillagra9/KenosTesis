namespace KenosTesis
{
    partial class TraerSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraerSocio));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarPorTodoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pilarSportClubDataSet5 = new KenosTesis.pilarSportClubDataSet5();
            this.buscarPorTodoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pilarSportClubDataSet4 = new KenosTesis.pilarSportClubDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pilarSportClubDataSet3 = new KenosTesis.pilarSportClubDataSet3();
            this.buscarPorTodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarPorTodoTableAdapter = new KenosTesis.pilarSportClubDataSet3TableAdapters.buscarPorTodoTableAdapter();
            this.buscarPorTodoTableAdapter1 = new KenosTesis.pilarSportClubDataSet4TableAdapters.buscarPorTodoTableAdapter();
            this.buscarPorTodoTableAdapter2 = new KenosTesis.pilarSportClubDataSet5TableAdapters.buscarPorTodoTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarPorTodoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarPorTodoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarPorTodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccion,
            this.idSocioDataGridViewTextBoxColumn,
            this.nombreSocioDataGridViewTextBoxColumn,
            this.apellidoSocioDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buscarPorTodoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(24, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(391, 157);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // seleccion
            // 
            this.seleccion.HeaderText = "seleccion";
            this.seleccion.Name = "seleccion";
            this.seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.seleccion.Width = 30;
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
            // 
            // apellidoSocioDataGridViewTextBoxColumn
            // 
            this.apellidoSocioDataGridViewTextBoxColumn.DataPropertyName = "apellidoSocio";
            this.apellidoSocioDataGridViewTextBoxColumn.HeaderText = "apellidoSocio";
            this.apellidoSocioDataGridViewTextBoxColumn.Name = "apellidoSocioDataGridViewTextBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // buscarPorTodoBindingSource2
            // 
            this.buscarPorTodoBindingSource2.DataMember = "buscarPorTodo";
            this.buscarPorTodoBindingSource2.DataSource = this.pilarSportClubDataSet5;
            // 
            // pilarSportClubDataSet5
            // 
            this.pilarSportClubDataSet5.DataSetName = "pilarSportClubDataSet5";
            this.pilarSportClubDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarPorTodoBindingSource1
            // 
            this.buscarPorTodoBindingSource1.DataMember = "buscarPorTodo";
            this.buscarPorTodoBindingSource1.DataSource = this.pilarSportClubDataSet4;
            // 
            // pilarSportClubDataSet4
            // 
            this.pilarSportClubDataSet4.DataSetName = "pilarSportClubDataSet4";
            this.pilarSportClubDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el Socio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pilarSportClubDataSet3
            // 
            this.pilarSportClubDataSet3.DataSetName = "pilarSportClubDataSet3";
            this.pilarSportClubDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarPorTodoBindingSource
            // 
            this.buscarPorTodoBindingSource.DataMember = "buscarPorTodo";
            this.buscarPorTodoBindingSource.DataSource = this.pilarSportClubDataSet3;
            // 
            // buscarPorTodoTableAdapter
            // 
            this.buscarPorTodoTableAdapter.ClearBeforeFill = true;
            // 
            // buscarPorTodoTableAdapter1
            // 
            this.buscarPorTodoTableAdapter1.ClearBeforeFill = true;
            // 
            // buscarPorTodoTableAdapter2
            // 
            this.buscarPorTodoTableAdapter2.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(347, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(379, 235);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(26, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Visible = false;
            // 
            // TraerSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 268);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraerSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.TraerSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarPorTodoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarPorTodoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarPorTodoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource buscarPorTodoBindingSource;
        private pilarSportClubDataSet3 pilarSportClubDataSet3;
        private pilarSportClubDataSet3TableAdapters.buscarPorTodoTableAdapter buscarPorTodoTableAdapter;
        private System.Windows.Forms.BindingSource buscarPorTodoBindingSource1;
        private pilarSportClubDataSet4 pilarSportClubDataSet4;
        private pilarSportClubDataSet4TableAdapters.buscarPorTodoTableAdapter buscarPorTodoTableAdapter1;
        private pilarSportClubDataSet5 pilarSportClubDataSet5;
        private System.Windows.Forms.BindingSource buscarPorTodoBindingSource2;
        private pilarSportClubDataSet5TableAdapters.buscarPorTodoTableAdapter buscarPorTodoTableAdapter2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
    }
}