﻿namespace Tugas_Besar_PBO.View
{
    partial class Form_data_transaksi_pembelian
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
            this.Jasa_joki = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Jasa_joki)).BeginInit();
            this.SuspendLayout();
            // 
            // Jasa_joki
            // 
            this.Jasa_joki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Jasa_joki.Location = new System.Drawing.Point(101, 68);
            this.Jasa_joki.Name = "Jasa_joki";
            this.Jasa_joki.RowHeadersWidth = 62;
            this.Jasa_joki.RowTemplate.Height = 28;
            this.Jasa_joki.Size = new System.Drawing.Size(240, 150);
            this.Jasa_joki.TabIndex = 0;
            // 
            // Form_data_transaksi_pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Jasa_joki);
            this.Name = "Form_data_transaksi_pembelian";
            this.Text = "Form_data_transaksi_pembelian";
            ((System.ComponentModel.ISupportInitialize)(this.Jasa_joki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Jasa_joki;
    }
}