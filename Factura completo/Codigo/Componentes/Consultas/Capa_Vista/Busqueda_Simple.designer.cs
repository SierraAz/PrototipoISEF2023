﻿
namespace Capa_VistaConsultas
{
    partial class Busqueda_Simple
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
            this.dgvDato = new System.Windows.Forms.DataGridView();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lbl_cadena = new System.Windows.Forms.Label();
            this.cbox_columnas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_BuscaPor = new System.Windows.Forms.TextBox();
            this.bnt_buscaPor = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SalirBA = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).BeginInit();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDato
            // 
            this.dgvDato.AllowUserToAddRows = false;
            this.dgvDato.AllowUserToDeleteRows = false;
            this.dgvDato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDato.Location = new System.Drawing.Point(14, 101);
            this.dgvDato.Name = "dgvDato";
            this.dgvDato.RowHeadersWidth = 51;
            this.dgvDato.Size = new System.Drawing.Size(638, 147);
            this.dgvDato.TabIndex = 0;
            this.dgvDato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDato_CellContentClick);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.panelResultado.Controls.Add(this.lbl_cadena);
            this.panelResultado.Controls.Add(this.cbox_columnas);
            this.panelResultado.Controls.Add(this.label5);
            this.panelResultado.Controls.Add(this.txt_BuscaPor);
            this.panelResultado.Controls.Add(this.bnt_buscaPor);
            this.panelResultado.Controls.Add(this.label1);
            this.panelResultado.Controls.Add(this.btn_SalirBA);
            this.panelResultado.Controls.Add(this.label3);
            this.panelResultado.Controls.Add(this.dgvDato);
            this.panelResultado.Location = new System.Drawing.Point(12, 12);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(670, 321);
            this.panelResultado.TabIndex = 11;
            this.panelResultado.Visible = false;
            this.panelResultado.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResultado_Paint);
            // 
            // lbl_cadena
            // 
            this.lbl_cadena.AutoSize = true;
            this.lbl_cadena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadena.Location = new System.Drawing.Point(10, 289);
            this.lbl_cadena.Name = "lbl_cadena";
            this.lbl_cadena.Size = new System.Drawing.Size(75, 16);
            this.lbl_cadena.TabIndex = 40;
            this.lbl_cadena.Text = "Buscando :";
            // 
            // cbox_columnas
            // 
            this.cbox_columnas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_columnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_columnas.FormattingEnabled = true;
            this.cbox_columnas.Location = new System.Drawing.Point(400, 60);
            this.cbox_columnas.Name = "cbox_columnas";
            this.cbox_columnas.Size = new System.Drawing.Size(153, 24);
            this.cbox_columnas.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Buscar Por :";
            // 
            // txt_BuscaPor
            // 
            this.txt_BuscaPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscaPor.Location = new System.Drawing.Point(121, 63);
            this.txt_BuscaPor.Name = "txt_BuscaPor";
            this.txt_BuscaPor.Size = new System.Drawing.Size(161, 22);
            this.txt_BuscaPor.TabIndex = 36;
            // 
            // bnt_buscaPor
            // 
            this.bnt_buscaPor.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bnt_buscaPor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.bnt_buscaPor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bnt_buscaPor.IconSize = 60;
            this.bnt_buscaPor.Location = new System.Drawing.Point(588, 19);
            this.bnt_buscaPor.Name = "bnt_buscaPor";
            this.bnt_buscaPor.Size = new System.Drawing.Size(64, 68);
            this.bnt_buscaPor.TabIndex = 34;
            this.bnt_buscaPor.Text = "Buscar";
            this.bnt_buscaPor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnt_buscaPor.UseVisualStyleBackColor = true;
            this.bnt_buscaPor.Click += new System.EventHandler(this.bnt_buscaPor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Buscar :";
            // 
            // btn_SalirBA
            // 
            this.btn_SalirBA.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowRight;
            this.btn_SalirBA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btn_SalirBA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SalirBA.IconSize = 60;
            this.btn_SalirBA.Location = new System.Drawing.Point(588, 254);
            this.btn_SalirBA.Name = "btn_SalirBA";
            this.btn_SalirBA.Size = new System.Drawing.Size(64, 68);
            this.btn_SalirBA.TabIndex = 34;
            this.btn_SalirBA.Text = "Salir";
            this.btn_SalirBA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SalirBA.UseVisualStyleBackColor = true;
            this.btn_SalirBA.Click += new System.EventHandler(this.btn_SalirBA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Busqueda Simple Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Busqueda_Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(695, 346);
            this.Controls.Add(this.panelResultado);
            this.Name = "Busqueda_Simple";
            this.Text = "Consulta Usuario Simple";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDato;
        private System.Windows.Forms.Panel panelResultado;
        private FontAwesome.Sharp.IconButton btn_SalirBA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BuscaPor;
        private FontAwesome.Sharp.IconButton bnt_buscaPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_columnas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_cadena;
    }
}