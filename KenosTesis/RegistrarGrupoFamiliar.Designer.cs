namespace KenosTesis
{
    partial class RegistrarGrupoFamiliar
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buscarSociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilarSportClubDataSet7 = new KenosTesis.pilarSportClubDataSet7();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buscarSociosTableAdapter = new KenosTesis.pilarSportClubDataSet7TableAdapters.buscarSociosTableAdapter();
            this.idSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarSociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSocio,
            this.Nombre,
            this.Apellido,
            this.Dni,
            this.Quitar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(556, 157);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Generar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSocioDataGridViewTextBoxColumn,
            this.nombreSocioDataGridViewTextBoxColumn,
            this.apellidoSocioDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.dataGridViewButtonColumn1});
            this.dataGridView2.DataSource = this.buscarSociosBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(556, 157);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // buscarSociosBindingSource
            // 
            this.buscarSociosBindingSource.DataMember = "buscarSocios";
            this.buscarSociosBindingSource.DataSource = this.pilarSportClubDataSet7;
            // 
            // pilarSportClubDataSet7
            // 
            this.pilarSportClubDataSet7.DataSetName = "pilarSportClubDataSet7";
            this.pilarSportClubDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buscarSociosTableAdapter
            // 
            this.buscarSociosTableAdapter.ClearBeforeFill = true;
            // 
            // idSocio
            // 
            this.idSocio.HeaderText = "ID Socio";
            this.idSocio.Name = "idSocio";
            this.idSocio.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Quitar
            // 
            this.Quitar.HeaderText = "Accion";
            this.Quitar.Name = "Quitar";
            this.Quitar.ReadOnly = true;
            this.Quitar.Text = "Quitar";
            this.Quitar.UseColumnTextForButtonValue = true;
            // 
            // idSocioDataGridViewTextBoxColumn
            // 
            this.idSocioDataGridViewTextBoxColumn.DataPropertyName = "idSocio";
            this.idSocioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idSocioDataGridViewTextBoxColumn.Name = "idSocioDataGridViewTextBoxColumn";
            this.idSocioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreSocioDataGridViewTextBoxColumn
            // 
            this.nombreSocioDataGridViewTextBoxColumn.DataPropertyName = "nombreSocio";
            this.nombreSocioDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreSocioDataGridViewTextBoxColumn.Name = "nombreSocioDataGridViewTextBoxColumn";
            this.nombreSocioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoSocioDataGridViewTextBoxColumn
            // 
            this.apellidoSocioDataGridViewTextBoxColumn.DataPropertyName = "apellidoSocio";
            this.apellidoSocioDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoSocioDataGridViewTextBoxColumn.Name = "apellidoSocioDataGridViewTextBoxColumn";
            this.apellidoSocioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "agregar";
            this.dataGridViewButtonColumn1.HeaderText = "Accion";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Agregar";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // RegistrarGrupoFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 488);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistrarGrupoFamiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarGrupoFamiliar";
            this.Load += new System.EventHandler(this.RegistrarGrupoFamiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarSociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private pilarSportClubDataSet7 pilarSportClubDataSet7;
        private System.Windows.Forms.BindingSource buscarSociosBindingSource;
        private pilarSportClubDataSet7TableAdapters.buscarSociosTableAdapter buscarSociosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewButtonColumn Quitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}