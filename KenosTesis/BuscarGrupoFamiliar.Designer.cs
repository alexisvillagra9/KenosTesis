namespace KenosTesis
{
    partial class BuscarGrupoFamiliar
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buscarSociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilarSportClubDataSet1 = new KenosTesis.pilarSportClubDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.buscarSociosTableAdapter = new KenosTesis.pilarSportClubDataSet1TableAdapters.buscarSociosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarSociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Por favor, seleccione a un integrante del grupo familiar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check});
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(419, 225);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // buscarSociosBindingSource
            // 
            this.buscarSociosBindingSource.DataMember = "buscarSocios";
            this.buscarSociosBindingSource.DataSource = this.pilarSportClubDataSet1;
            // 
            // pilarSportClubDataSet1
            // 
            this.pilarSportClubDataSet1.DataSetName = "pilarSportClubDataSet1";
            this.pilarSportClubDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscarSociosTableAdapter
            // 
            this.buscarSociosTableAdapter.ClearBeforeFill = true;
            // 
            // BuscarGrupoFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "BuscarGrupoFamiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarGrupoFamiliar";
            this.Load += new System.EventHandler(this.BuscarGrupoFamiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarSociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private pilarSportClubDataSet1 pilarSportClubDataSet1;
        private System.Windows.Forms.BindingSource buscarSociosBindingSource;
        private pilarSportClubDataSet1TableAdapters.buscarSociosTableAdapter buscarSociosTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}