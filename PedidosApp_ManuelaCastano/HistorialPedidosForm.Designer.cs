namespace PedidosApp_ManuelaCastano
{
    partial class HistorialPedidosForm
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
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrgente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(55, 95);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(201, 28);
            this.comboBoxFiltro.TabIndex = 0;
            this.comboBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltro_SelectedIndexChanged);
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCliente,
            this.colProducto,
            this.colPeso,
            this.colDistancia,
            this.colUrgente,
            this.colMetodoEntrega,
            this.colCosto});
            this.dataGridViewPedidos.Location = new System.Drawing.Point(342, 72);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.RowHeadersWidth = 62;
            this.dataGridViewPedidos.RowTemplate.Height = 28;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(502, 444);
            this.dataGridViewPedidos.TabIndex = 1;
            // 
            // colCliente
            // 
            this.colCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCliente.DataPropertyName = "Cliente";
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 8;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colProducto
            // 
            this.colProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProducto.DataPropertyName = "Producto";
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 8;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colPeso
            // 
            this.colPeso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPeso.DataPropertyName = "Peso";
            this.colPeso.HeaderText = "Peso";
            this.colPeso.MinimumWidth = 8;
            this.colPeso.Name = "colPeso";
            this.colPeso.ReadOnly = true;
            // 
            // colDistancia
            // 
            this.colDistancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDistancia.DataPropertyName = "Distancia";
            this.colDistancia.HeaderText = "Distancia";
            this.colDistancia.MinimumWidth = 8;
            this.colDistancia.Name = "colDistancia";
            this.colDistancia.ReadOnly = true;
            // 
            // colUrgente
            // 
            this.colUrgente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUrgente.DataPropertyName = "Urgente";
            this.colUrgente.HeaderText = "Urgente";
            this.colUrgente.MinimumWidth = 8;
            this.colUrgente.Name = "colUrgente";
            this.colUrgente.ReadOnly = true;
            // 
            // colMetodoEntrega
            // 
            this.colMetodoEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMetodoEntrega.DataPropertyName = "MetodoEntrega.TipoEntrega()";
            this.colMetodoEntrega.HeaderText = "Metodo de Entrega";
            this.colMetodoEntrega.MinimumWidth = 8;
            this.colMetodoEntrega.Name = "colMetodoEntrega";
            this.colMetodoEntrega.ReadOnly = true;
            // 
            // colCosto
            // 
            this.colCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCosto.DataPropertyName = "ObtenerCosto()";
            this.colCosto.HeaderText = "Costo $";
            this.colCosto.MinimumWidth = 8;
            this.colCosto.Name = "colCosto";
            this.colCosto.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por:";
            // 
            // HistorialPedidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.comboBoxFiltro);
            this.Name = "HistorialPedidosForm";
            this.Text = "HistorialPedidosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrgente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCosto;
    }
}