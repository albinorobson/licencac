namespace WindowsFormsApplication1
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
            this.dtcliente = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.datagrid1 = new WindowsFormsApplication1.Classes.datagrid();
            this.idparceiroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeparceiroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdParceiro = new System.Windows.Forms.BindingSource(this.components);
            this.bdCliente = new System.Windows.Forms.BindingSource(this.components);
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialnumberhdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlastverifyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atualizadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacriadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdParceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtcliente
            // 
            this.dtcliente.AllowUserToAddRows = false;
            this.dtcliente.AllowUserToDeleteRows = false;
            this.dtcliente.AllowUserToResizeRows = false;
            this.dtcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtcliente.AutoGenerateColumns = false;
            this.dtcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.serialnumberhdDataGridViewTextBoxColumn,
            this.dtlastverifyDataGridViewTextBoxColumn,
            this.atualizadoDataGridViewCheckBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.datacriadoDataGridViewTextBoxColumn});
            this.dtcliente.DataSource = this.bdCliente;
            this.dtcliente.Location = new System.Drawing.Point(12, 189);
            this.dtcliente.Name = "dtcliente";
            this.dtcliente.ReadOnly = true;
            this.dtcliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtcliente.RowHeadersVisible = false;
            this.dtcliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtcliente.RowTemplate.ReadOnly = true;
            this.dtcliente.Size = new System.Drawing.Size(835, 291);
            this.dtcliente.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datagrid1
            // 
            this.datagrid1.AllowUserToAddRows = false;
            this.datagrid1.AllowUserToResizeRows = false;
            this.datagrid1.AutoGenerateColumns = false;
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idparceiroDataGridViewTextBoxColumn1,
            this.nomeparceiroDataGridViewTextBoxColumn1});
            this.datagrid1.DataSource = this.bdParceiro;
            this.datagrid1.Location = new System.Drawing.Point(607, 12);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.ReadOnly = true;
            this.datagrid1.RowHeadersVisible = false;
            this.datagrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid1.Size = new System.Drawing.Size(240, 150);
            this.datagrid1.TabIndex = 2;
            // 
            // idparceiroDataGridViewTextBoxColumn1
            // 
            this.idparceiroDataGridViewTextBoxColumn1.DataPropertyName = "Id_parceiro";
            this.idparceiroDataGridViewTextBoxColumn1.HeaderText = "Código";
            this.idparceiroDataGridViewTextBoxColumn1.Name = "idparceiroDataGridViewTextBoxColumn1";
            this.idparceiroDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeparceiroDataGridViewTextBoxColumn1
            // 
            this.nomeparceiroDataGridViewTextBoxColumn1.DataPropertyName = "Nome_parceiro";
            this.nomeparceiroDataGridViewTextBoxColumn1.HeaderText = "Nome Parceiro";
            this.nomeparceiroDataGridViewTextBoxColumn1.Name = "nomeparceiroDataGridViewTextBoxColumn1";
            this.nomeparceiroDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bdParceiro
            // 
            this.bdParceiro.DataSource = typeof(WindowsFormsApplication1.Classes.ClsParceiro);
            // 
            // bdCliente
            // 
            this.bdCliente.DataSource = typeof(WindowsFormsApplication1.Classes.ClsCliente);
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "Id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "Id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialnumberhdDataGridViewTextBoxColumn
            // 
            this.serialnumberhdDataGridViewTextBoxColumn.DataPropertyName = "Serialnumberhd";
            this.serialnumberhdDataGridViewTextBoxColumn.HeaderText = "Serialnumberhd";
            this.serialnumberhdDataGridViewTextBoxColumn.Name = "serialnumberhdDataGridViewTextBoxColumn";
            this.serialnumberhdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtlastverifyDataGridViewTextBoxColumn
            // 
            this.dtlastverifyDataGridViewTextBoxColumn.DataPropertyName = "Dtlastverify";
            this.dtlastverifyDataGridViewTextBoxColumn.HeaderText = "Dtlastverify";
            this.dtlastverifyDataGridViewTextBoxColumn.Name = "dtlastverifyDataGridViewTextBoxColumn";
            this.dtlastverifyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atualizadoDataGridViewCheckBoxColumn
            // 
            this.atualizadoDataGridViewCheckBoxColumn.DataPropertyName = "Atualizado";
            this.atualizadoDataGridViewCheckBoxColumn.HeaderText = "Atualizado";
            this.atualizadoDataGridViewCheckBoxColumn.Name = "atualizadoDataGridViewCheckBoxColumn";
            this.atualizadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datacriadoDataGridViewTextBoxColumn
            // 
            this.datacriadoDataGridViewTextBoxColumn.DataPropertyName = "Datacriado";
            this.datacriadoDataGridViewTextBoxColumn.HeaderText = "Datacriado";
            this.datacriadoDataGridViewTextBoxColumn.Name = "datacriadoDataGridViewTextBoxColumn";
            this.datacriadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 492);
            this.Controls.Add(this.datagrid1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtcliente);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdParceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtcliente;
        private System.Windows.Forms.Button button1;
        private Classes.datagrid datagrid1;
        private System.Windows.Forms.BindingSource bdParceiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idparceiroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeparceiroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumberhdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlastverifyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn atualizadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacriadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdCliente;


    }
}

