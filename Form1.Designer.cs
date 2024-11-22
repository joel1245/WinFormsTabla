namespace WinFormsTabla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            labelNombre = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.Info;
            panelPrincipal.Controls.Add(labelNombre);
            panelPrincipal.Controls.Add(richTextBoxResultados);
            panelPrincipal.Controls.Add(buttonVer);
            panelPrincipal.Controls.Add(textBoxNum);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(14, 7);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(774, 431);
            panelPrincipal.TabIndex = 0;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxResultados.ForeColor = SystemColors.HotTrack;
            richTextBoxResultados.Location = new Point(538, 115);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(144, 253);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.BackColor = SystemColors.GradientActiveCaption;
            buttonVer.Location = new Point(236, 201);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(94, 29);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver tabla";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.BackColor = SystemColors.ButtonHighlight;
            textBoxNum.BorderStyle = BorderStyle.FixedSingle;
            textBoxNum.Location = new Point(311, 119);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(125, 27);
            textBoxNum.TabIndex = 2;
            textBoxNum.TextAlign = HorizontalAlignment.Center;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumero.Location = new Point(85, 119);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(193, 22);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿Cual tabla quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.Red;
            labelTitulo.Location = new Point(275, 27);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(242, 28);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de Multiplicar";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.ForeColor = Color.FromArgb(0, 192, 0);
            labelNombre.Location = new Point(156, 302);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(220, 26);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Joel Narvaez Martinez";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelNumero;
        private Label labelTitulo;
        private Button buttonVer;
        private TextBox textBoxNum;
        private RichTextBox richTextBoxResultados;
        private Label labelNombre;
    }
}
