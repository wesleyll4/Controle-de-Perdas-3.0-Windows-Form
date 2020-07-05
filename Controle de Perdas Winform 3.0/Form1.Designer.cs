namespace Controle_de_Perdas_Winform_3._0
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPerdido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maquina,
            this.TBL,
            this.Endereço,
            this.PN,
            this.Quantidade,
            this.PickUp,
            this.Recog,
            this.TotalPerdido,
            this.Porcentagem,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.Size = new System.Drawing.Size(1342, 569);
            this.dataGridView1.TabIndex = 0;
            // 
            // Maquina
            // 
            this.Maquina.DataPropertyName = "Maquina";
            this.Maquina.HeaderText = "Maquina";
            this.Maquina.Name = "Maquina";
            this.Maquina.ReadOnly = true;
            // 
            // TBL
            // 
            this.TBL.DataPropertyName = "Tbl";
            this.TBL.HeaderText = "TBL";
            this.TBL.Name = "TBL";
            this.TBL.ReadOnly = true;
            // 
            // Endereço
            // 
            this.Endereço.DataPropertyName = "Endereço";
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.ReadOnly = true;
            // 
            // PN
            // 
            this.PN.DataPropertyName = "PN";
            this.PN.HeaderText = "Part Number";
            this.PN.Name = "PN";
            this.PN.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "TotalMontado";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // PickUp
            // 
            this.PickUp.DataPropertyName = "TotalPickupError";
            this.PickUp.HeaderText = "PickUp";
            this.PickUp.Name = "PickUp";
            this.PickUp.ReadOnly = true;
            // 
            // Recog
            // 
            this.Recog.DataPropertyName = "TotalRecogError";
            this.Recog.HeaderText = "Recog";
            this.Recog.Name = "Recog";
            this.Recog.ReadOnly = true;
            // 
            // TotalPerdido
            // 
            this.TotalPerdido.DataPropertyName = "TotalPerdido";
            this.TotalPerdido.HeaderText = "Total Perdido";
            this.TotalPerdido.Name = "TotalPerdido";
            this.TotalPerdido.ReadOnly = true;
            // 
            // Porcentagem
            // 
            this.Porcentagem.DataPropertyName = "Porcentagem";
            this.Porcentagem.HeaderText = "   %   ";
            this.Porcentagem.Name = "Porcentagem";
            this.Porcentagem.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 400;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 569);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn PN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recog;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPerdido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        }
    }

