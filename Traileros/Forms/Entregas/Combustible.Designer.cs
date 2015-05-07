namespace Traileros.Forms.Entregas
{
    partial class Combustible
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCosto = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txbRendimiento = new System.Windows.Forms.TextBox();
            this.txbLitros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 128;
            this.label6.Text = "Litros de combustible:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "Costo del combustible:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Rendimiento por litro de combustible:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "Precio por litro:";
            // 
            // txbCosto
            // 
            this.txbCosto.Location = new System.Drawing.Point(300, 199);
            this.txbCosto.MaxLength = 10;
            this.txbCosto.Name = "txbCosto";
            this.txbCosto.Size = new System.Drawing.Size(184, 20);
            this.txbCosto.TabIndex = 124;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(300, 77);
            this.txbPrecio.MaxLength = 30;
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(184, 20);
            this.txbPrecio.TabIndex = 122;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(414, 302);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpiar.TabIndex = 131;
            this.btnLimpiar.Text = "Eliminar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(520, 302);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 35);
            this.btnSiguiente.TabIndex = 130;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // txbRendimiento
            // 
            this.txbRendimiento.Location = new System.Drawing.Point(300, 112);
            this.txbRendimiento.MaxLength = 30;
            this.txbRendimiento.Name = "txbRendimiento";
            this.txbRendimiento.Size = new System.Drawing.Size(184, 20);
            this.txbRendimiento.TabIndex = 132;
            // 
            // txbLitros
            // 
            this.txbLitros.Location = new System.Drawing.Point(300, 156);
            this.txbLitros.MaxLength = 30;
            this.txbLitros.Name = "txbLitros";
            this.txbLitros.Size = new System.Drawing.Size(184, 20);
            this.txbLitros.TabIndex = 133;
            // 
            // Combustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.txbLitros);
            this.Controls.Add(this.txbRendimiento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCosto);
            this.Controls.Add(this.txbPrecio);
            this.Name = "Combustible";
            this.Text = "Combustible";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCosto;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txbRendimiento;
        private System.Windows.Forms.TextBox txbLitros;
    }
}