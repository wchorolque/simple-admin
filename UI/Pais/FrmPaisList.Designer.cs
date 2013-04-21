namespace UI.Pais
{
    partial class FrmPaisList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaisList));
            this.bindingSourcePais = new System.Windows.Forms.BindingSource(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBtnClose = new System.Windows.Forms.ToolStripButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePais)).BeginInit();
            this.topPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourcePais
            // 
            this.bindingSourcePais.DataSource = typeof(ViewModel.PaisViewModel);
            // 
            // topPanel
            // 
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topPanel.Controls.Add(this.toolStrip1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(496, 30);
            this.topPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnAdd,
            this.toolStripSeparator1,
            this.tSBtnDelete,
            this.toolStripSeparator2,
            this.tSBtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(492, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBtnAdd
            // 
            this.tSBtnAdd.AutoSize = false;
            this.tSBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnAdd.Image")));
            this.tSBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnAdd.Name = "tSBtnAdd";
            this.tSBtnAdd.Size = new System.Drawing.Size(70, 22);
            this.tSBtnAdd.Text = "Agregar";
            this.tSBtnAdd.Click += new System.EventHandler(this.tSBtnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSBtnDelete
            // 
            this.tSBtnDelete.AutoSize = false;
            this.tSBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnDelete.Image")));
            this.tSBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnDelete.Name = "tSBtnDelete";
            this.tSBtnDelete.Size = new System.Drawing.Size(70, 22);
            this.tSBtnDelete.Text = "Borrar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tSBtnClose
            // 
            this.tSBtnClose.AutoSize = false;
            this.tSBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnClose.Image")));
            this.tSBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnClose.Name = "tSBtnClose";
            this.tSBtnClose.Size = new System.Drawing.Size(70, 22);
            this.tSBtnClose.Text = "Cerrar";
            this.tSBtnClose.Click += new System.EventHandler(this.tSBtnClose_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.dataGridView);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(496, 194);
            this.mainPanel.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnDescripcion});
            this.dataGridView.DataSource = this.bindingSourcePais;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(494, 192);
            this.dataGridView.TabIndex = 0;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.DataPropertyName = "Codigo";
            this.ColumnCodigo.HeaderText = "CÓDIGO";
            this.ColumnCodigo.Name = "ColumnCodigo";
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.DataPropertyName = "Descripcion";
            this.ColumnDescripcion.HeaderText = "DESCRIPCIÓN";
            this.ColumnDescripcion.Name = "ColumnDescripcion";
            // 
            // FrmPaisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 224);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "FrmPaisList";
            this.Text = "Listado de Paises Registrados";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePais)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourcePais;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tSBtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tSBtnClose;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcion;
    }
}