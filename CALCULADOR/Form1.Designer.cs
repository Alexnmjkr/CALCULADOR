using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CALCULADOR
{
    partial class Form1
    {
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            buttonSumar = new Button();
            buttonRestar = new Button();
            buttonMultiplicar = new Button();
            buttonDividir = new Button();
            labelResultado = new Label();
            textBoxNumero1 = new TextBox();
            textBoxNumero2 = new TextBox();
            buttonLimpiar = new Button();
            buttonSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonSumar
            // 
            buttonSumar.Location = new Point(92, 126);
            buttonSumar.Name = "buttonSumar";
            buttonSumar.Size = new Size(100, 23);
            buttonSumar.TabIndex = 0;
            buttonSumar.Text = "Sumar";
            buttonSumar.UseVisualStyleBackColor = true;
            buttonSumar.Click += buttonSumar_Click;
            // 
            // buttonRestar
            // 
            buttonRestar.Location = new Point(92, 155);
            buttonRestar.Name = "buttonRestar";
            buttonRestar.Size = new Size(100, 23);
            buttonRestar.TabIndex = 1;
            buttonRestar.Text = "Restar";
            buttonRestar.UseVisualStyleBackColor = true;
            buttonRestar.Click += buttonRestar_Click;
            // 
            // buttonMultiplicar
            // 
            buttonMultiplicar.Location = new Point(92, 184);
            buttonMultiplicar.Name = "buttonMultiplicar";
            buttonMultiplicar.Size = new Size(100, 23);
            buttonMultiplicar.TabIndex = 2;
            buttonMultiplicar.Text = "Multiplicar";
            buttonMultiplicar.UseVisualStyleBackColor = true;
            buttonMultiplicar.Click += buttonMultiplicar_Click;
            // 
            // buttonDividir
            // 
            buttonDividir.Location = new Point(92, 215);
            buttonDividir.Name = "buttonDividir";
            buttonDividir.Size = new Size(100, 23);
            buttonDividir.TabIndex = 3;
            buttonDividir.Text = "Dividir";
            buttonDividir.UseVisualStyleBackColor = true;
            buttonDividir.Click += buttonDividir_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(101, 87);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(65, 15);
            labelResultado.TabIndex = 4;
            labelResultado.Text = "Resultado:";
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(92, 61);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(100, 23);
            textBoxNumero1.TabIndex = 5;
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(92, 32);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(100, 23);
            textBoxNumero2.TabIndex = 6;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(92, 263);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(100, 26);
            buttonLimpiar.TabIndex = 7;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(92, 295);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(100, 23);
            buttonSalir.TabIndex = 8;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 14);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 9;
            label1.Text = "Ingresa los numeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 108);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 10;
            label2.Text = "**************************";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 241);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 11;
            label3.Text = "**************************";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(284, 353);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonLimpiar);
            Controls.Add(textBoxNumero2);
            Controls.Add(textBoxNumero1);
            Controls.Add(labelResultado);
            Controls.Add(buttonDividir);
            Controls.Add(buttonMultiplicar);
            Controls.Add(buttonRestar);
            Controls.Add(buttonSumar);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Purple;
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSumar;
        private Button buttonRestar;
        private Button buttonMultiplicar;
        private Button buttonDividir;
        private Label labelResultado;
        private TextBox textBoxNumero1;
        private TextBox textBoxNumero2;
        private Button buttonLimpiar;
        private Button buttonSalir;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
