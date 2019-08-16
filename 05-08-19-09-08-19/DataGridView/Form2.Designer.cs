namespace DataGridView
{
    partial class Form2
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
            this.Adicionar = new System.Windows.Forms.Button();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.querysInnerJoinDataSet1 = new DataGridView.QuerysInnerJoinDataSet1();
            this.marcasTableAdapter = new DataGridView.QuerysInnerJoinDataSet1TableAdapters.MarcasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.querysInnerJoinDataSet11 = new DataGridView.QuerysInnerJoinDataSet1();
            this.marcasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(256, 7);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(235, 47);
            this.Adicionar.TabIndex = 1;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.querysInnerJoinDataSet1;
            // 
            // querysInnerJoinDataSet1
            // 
            this.querysInnerJoinDataSet1.DataSetName = "QuerysInnerJoinDataSet1";
            this.querysInnerJoinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.usuIncDataGridViewTextBoxColumn,
            this.usuAltDataGridViewTextBoxColumn,
            this.datIncDataGridViewTextBoxColumn,
            this.datAltDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.marcasBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(5, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 377);
            this.dataGridView1.TabIndex = 2;
            // 
            // querysInnerJoinDataSet11
            // 
            this.querysInnerJoinDataSet11.DataSetName = "QuerysInnerJoinDataSet1";
            this.querysInnerJoinDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasBindingSource1
            // 
            this.marcasBindingSource1.DataMember = "Marcas";
            this.marcasBindingSource1.DataSource = this.querysInnerJoinDataSet11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // usuIncDataGridViewTextBoxColumn
            // 
            this.usuIncDataGridViewTextBoxColumn.DataPropertyName = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn.HeaderText = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuIncDataGridViewTextBoxColumn.Name = "usuIncDataGridViewTextBoxColumn";
            this.usuIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuAltDataGridViewTextBoxColumn
            // 
            this.usuAltDataGridViewTextBoxColumn.DataPropertyName = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn.HeaderText = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuAltDataGridViewTextBoxColumn.Name = "usuAltDataGridViewTextBoxColumn";
            this.usuAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // datIncDataGridViewTextBoxColumn
            // 
            this.datIncDataGridViewTextBoxColumn.DataPropertyName = "DatInc";
            this.datIncDataGridViewTextBoxColumn.HeaderText = "DatInc";
            this.datIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datIncDataGridViewTextBoxColumn.Name = "datIncDataGridViewTextBoxColumn";
            this.datIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // datAltDataGridViewTextBoxColumn
            // 
            this.datAltDataGridViewTextBoxColumn.DataPropertyName = "DatAlt";
            this.datAltDataGridViewTextBoxColumn.HeaderText = "DatAlt";
            this.datAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datAltDataGridViewTextBoxColumn.Name = "datAltDataGridViewTextBoxColumn";
            this.datAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Adicionar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Adicionar;
        private QuerysInnerJoinDataSet1 querysInnerJoinDataSet1;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private QuerysInnerJoinDataSet1TableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuerysInnerJoinDataSet1 querysInnerJoinDataSet11;
        private System.Windows.Forms.BindingSource marcasBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datAltDataGridViewTextBoxColumn;
    }
}