
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.Desconectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Celsius = new System.Windows.Forms.RadioButton();
            this.Farenheit = new System.Windows.Forms.RadioButton();
            this.numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Conectar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Desconectar
            // 
            this.Desconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desconectar.Location = new System.Drawing.Point(29, 329);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(147, 53);
            this.Desconectar.TabIndex = 16;
            this.Desconectar.Text = "desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Celsius);
            this.groupBox1.Controls.Add(this.Farenheit);
            this.groupBox1.Controls.Add(this.numero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(27, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 202);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Location = new System.Drawing.Point(175, 100);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(114, 17);
            this.Celsius.TabIndex = 7;
            this.Celsius.TabStop = true;
            this.Celsius.Text = "Celsius a Farenheit";
            this.Celsius.UseVisualStyleBackColor = true;
            // 
            // Farenheit
            // 
            this.Farenheit.AutoSize = true;
            this.Farenheit.Location = new System.Drawing.Point(175, 77);
            this.Farenheit.Name = "Farenheit";
            this.Farenheit.Size = new System.Drawing.Size(114, 17);
            this.Farenheit.TabIndex = 8;
            this.Farenheit.TabStop = true;
            this.Farenheit.Text = "Farenheit a Celsius";
            this.Farenheit.UseVisualStyleBackColor = true;
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(175, 39);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(164, 20);
            this.numero.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Grados";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Conectar
            // 
            this.Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conectar.Location = new System.Drawing.Point(29, 37);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(149, 31);
            this.Conectar.TabIndex = 14;
            this.Conectar.Text = "conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Conectar);
            this.Name = "Form2";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Celsius;
        private System.Windows.Forms.RadioButton Farenheit;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Conectar;
    }
}