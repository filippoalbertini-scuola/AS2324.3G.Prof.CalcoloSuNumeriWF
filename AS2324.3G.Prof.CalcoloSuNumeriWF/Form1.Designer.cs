namespace AS2324._3G.Prof.CalcoloSuNumeriWF
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
            btnAggiungi = new Button();
            txtNumero = new TextBox();
            label1 = new Label();
            lblSomma = new Label();
            lblConteggio = new Label();
            lblMedia = new Label();
            SuspendLayout();
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(356, 65);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(107, 40);
            btnAggiungi.TabIndex = 0;
            btnAggiungi.Text = "Add";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(225, 72);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 79);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Numero";
            // 
            // lblSomma
            // 
            lblSomma.AutoSize = true;
            lblSomma.Location = new Point(225, 152);
            lblSomma.Name = "lblSomma";
            lblSomma.Size = new Size(67, 20);
            lblSomma.TabIndex = 2;
            lblSomma.Text = "Somma :";
            // 
            // lblConteggio
            // 
            lblConteggio.AutoSize = true;
            lblConteggio.Location = new Point(225, 186);
            lblConteggio.Name = "lblConteggio";
            lblConteggio.Size = new Size(86, 20);
            lblConteggio.TabIndex = 2;
            lblConteggio.Text = "Conteggio :";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(225, 225);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(58, 20);
            lblMedia.TabIndex = 2;
            lblMedia.Text = "Media :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 305);
            Controls.Add(lblMedia);
            Controls.Add(lblConteggio);
            Controls.Add(lblSomma);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(btnAggiungi);
            Name = "Form1";
            Text = "Prof;3G;21/03/24;Raccolta di numeri con calcolo di somma, conteggio e media";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAggiungi;
        private TextBox txtNumero;
        private Label label1;
        private Label lblSomma;
        private Label lblConteggio;
        private Label lblMedia;
    }
}
