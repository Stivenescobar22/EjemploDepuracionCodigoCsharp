namespace EjemploDepuracionCodigoCsharp
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lvnumeros = new System.Windows.Forms.ListView();
            this.btnrellenar = new System.Windows.Forms.Button();
            this.lvvalores = new System.Windows.Forms.ListBox();
            this.btnfibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(16, 22);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(214, 17);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Consecutivo con ciclo mientras";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(33, 77);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(110, 15);
            this.lblvalor.TabIndex = 1;
            this.lblvalor.Text = "Ingrese un valor:";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(44, 95);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(80, 20);
            this.txtvalor.TabIndex = 2;
            // 
            // lvnumeros
            // 
            this.lvnumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvnumeros.Location = new System.Drawing.Point(12, 187);
            this.lvnumeros.Name = "lvnumeros";
            this.lvnumeros.Size = new System.Drawing.Size(97, 173);
            this.lvnumeros.TabIndex = 3;
            this.lvnumeros.UseCompatibleStateImageBehavior = false;
            // 
            // btnrellenar
            // 
            this.btnrellenar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrellenar.Location = new System.Drawing.Point(36, 121);
            this.btnrellenar.Name = "btnrellenar";
            this.btnrellenar.Size = new System.Drawing.Size(88, 31);
            this.btnrellenar.TabIndex = 4;
            this.btnrellenar.Text = "Rellenar";
            this.btnrellenar.UseVisualStyleBackColor = true;
            this.btnrellenar.Click += new System.EventHandler(this.btnrellenar_Click);
            // 
            // lvvalores
            // 
            this.lvvalores.FormattingEnabled = true;
            this.lvvalores.Location = new System.Drawing.Point(124, 187);
            this.lvvalores.Name = "lvvalores";
            this.lvvalores.Size = new System.Drawing.Size(98, 173);
            this.lvvalores.TabIndex = 5;
            // 
            // btnfibonacci
            // 
            this.btnfibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfibonacci.Location = new System.Drawing.Point(130, 105);
            this.btnfibonacci.Name = "btnfibonacci";
            this.btnfibonacci.Size = new System.Drawing.Size(92, 47);
            this.btnfibonacci.TabIndex = 6;
            this.btnfibonacci.Text = "Fibonacci";
            this.btnfibonacci.UseVisualStyleBackColor = true;
            this.btnfibonacci.Click += new System.EventHandler(this.btnfibonacci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 388);
            this.Controls.Add(this.btnfibonacci);
            this.Controls.Add(this.lvvalores);
            this.Controls.Add(this.btnrellenar);
            this.Controls.Add(this.lvnumeros);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ListView lvnumeros;
        private System.Windows.Forms.Button btnrellenar;
        private System.Windows.Forms.ListBox lvvalores;
        private System.Windows.Forms.Button btnfibonacci;
    }
}

