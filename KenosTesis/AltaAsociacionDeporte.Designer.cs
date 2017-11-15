namespace KenosTesis
{
    partial class AltaAsociacionDeporte
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.deporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilarSportClubDataSet24 = new KenosTesis.pilarSportClubDataSet24();
            this.deporteTableAdapter = new KenosTesis.pilarSportClubDataSet24TableAdapters.deporteTableAdapter();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Categoria = new KenosTesis.DS_Categoria();
            this.categoriaTableAdapter = new KenosTesis.DS_CategoriaTableAdapters.categoriaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deporteBindingSource, "idDeporte", true));
            this.comboBox1.DataSource = this.deporteBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "idDeporte";
            // 
            // deporteBindingSource
            // 
            this.deporteBindingSource.DataMember = "deporte";
            this.deporteBindingSource.DataSource = this.pilarSportClubDataSet24;
            // 
            // pilarSportClubDataSet24
            // 
            this.pilarSportClubDataSet24.DataSetName = "pilarSportClubDataSet24";
            this.pilarSportClubDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deporteTableAdapter
            // 
            this.deporteTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.dS_Categoria;
            // 
            // dS_Categoria
            // 
            this.dS_Categoria.DataSetName = "DS_Categoria";
            this.dS_Categoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Visible = false;
            // 
            // AltaAsociacionDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "AltaAsociacionDeporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaAsociacionDeporte";
            this.Load += new System.EventHandler(this.AltaAsociacionDeporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilarSportClubDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private pilarSportClubDataSet24 pilarSportClubDataSet24;
        private System.Windows.Forms.BindingSource deporteBindingSource;
        private pilarSportClubDataSet24TableAdapters.deporteTableAdapter deporteTableAdapter;
        private DS_Categoria dS_Categoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DS_CategoriaTableAdapters.categoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}