namespace Productos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btFacturar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProducto1 = new System.Windows.Forms.TextBox();
            this.tbProducto3 = new System.Windows.Forms.TextBox();
            this.tbProducto2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIVA = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbSub = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbIVA);
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Controls.Add(this.tbSub);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbProducto2);
            this.panel1.Controls.Add(this.tbProducto3);
            this.panel1.Controls.Add(this.tbProducto1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btLimpiar);
            this.panel1.Controls.Add(this.btFacturar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 238);
            this.panel1.TabIndex = 0;
            // 
            // btFacturar
            // 
            this.btFacturar.Location = new System.Drawing.Point(0, 212);
            this.btFacturar.Name = "btFacturar";
            this.btFacturar.Size = new System.Drawing.Size(75, 23);
            this.btFacturar.TabIndex = 0;
            this.btFacturar.Text = "Facturar";
            this.btFacturar.UseVisualStyleBackColor = true;
            this.btFacturar.Click += new System.EventHandler(this.btFacturar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(81, 212);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 1;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto 1";
            // 
            // tbProducto1
            // 
            this.tbProducto1.Location = new System.Drawing.Point(68, 3);
            this.tbProducto1.Name = "tbProducto1";
            this.tbProducto1.Size = new System.Drawing.Size(100, 20);
            this.tbProducto1.TabIndex = 3;
            // 
            // tbProducto3
            // 
            this.tbProducto3.Location = new System.Drawing.Point(68, 29);
            this.tbProducto3.Name = "tbProducto3";
            this.tbProducto3.Size = new System.Drawing.Size(100, 20);
            this.tbProducto3.TabIndex = 4;
            // 
            // tbProducto2
            // 
            this.tbProducto2.Location = new System.Drawing.Point(68, 55);
            this.tbProducto2.Name = "tbProducto2";
            this.tbProducto2.Size = new System.Drawing.Size(100, 20);
            this.tbProducto2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Producto 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "IVA";
            // 
            // tbIVA
            // 
            this.tbIVA.Location = new System.Drawing.Point(68, 127);
            this.tbIVA.Name = "tbIVA";
            this.tbIVA.ReadOnly = true;
            this.tbIVA.Size = new System.Drawing.Size(100, 20);
            this.tbIVA.TabIndex = 11;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(68, 153);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 10;
            // 
            // tbSub
            // 
            this.tbSub.Location = new System.Drawing.Point(68, 101);
            this.tbSub.Name = "tbSub";
            this.tbSub.ReadOnly = true;
            this.tbSub.Size = new System.Drawing.Size(100, 20);
            this.tbSub.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Subtotal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIVA;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbSub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProducto2;
        private System.Windows.Forms.TextBox tbProducto3;
        private System.Windows.Forms.TextBox tbProducto1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btFacturar;
    }
}

