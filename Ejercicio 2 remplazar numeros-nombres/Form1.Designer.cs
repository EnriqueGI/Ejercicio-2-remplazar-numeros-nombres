
namespace Ejercicio_2_remplazar_numeros_nombres
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txMensaje = new System.Windows.Forms.TextBox();
            this.labeMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(306, 148);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(116, 37);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txMensaje
            // 
            this.txMensaje.Location = new System.Drawing.Point(306, 102);
            this.txMensaje.Name = "txMensaje";
            this.txMensaje.Size = new System.Drawing.Size(100, 26);
            this.txMensaje.TabIndex = 1;
            // 
            // labeMensaje
            // 
            this.labeMensaje.AutoSize = true;
            this.labeMensaje.Location = new System.Drawing.Point(302, 215);
            this.labeMensaje.Name = "labeMensaje";
            this.labeMensaje.Size = new System.Drawing.Size(51, 20);
            this.labeMensaje.TabIndex = 2;
            this.labeMensaje.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeMensaje);
            this.Controls.Add(this.txMensaje);
            this.Controls.Add(this.btnConvertir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txMensaje;
        private System.Windows.Forms.Label labeMensaje;
    }
}

