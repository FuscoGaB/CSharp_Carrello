namespace CarrelloLista
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
            aggiungi = new Button();
            rimuovi = new Button();
            svuota = new Button();
            textBox1 = new TextBox();
            ListaCarrello = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // aggiungi
            // 
            aggiungi.Location = new Point(279, 182);
            aggiungi.Name = "aggiungi";
            aggiungi.Size = new Size(242, 36);
            aggiungi.TabIndex = 0;
            aggiungi.Text = "aggiungi";
            aggiungi.UseVisualStyleBackColor = true;
            aggiungi.Click += aggiungi_Click;
            // 
            // rimuovi
            // 
            rimuovi.Location = new Point(279, 224);
            rimuovi.Name = "rimuovi";
            rimuovi.Size = new Size(242, 34);
            rimuovi.TabIndex = 1;
            rimuovi.Text = "rimuovi";
            rimuovi.UseVisualStyleBackColor = true;
            rimuovi.Click += rimuovi_Click;
            // 
            // svuota
            // 
            svuota.Location = new Point(279, 264);
            svuota.Name = "svuota";
            svuota.Size = new Size(242, 33);
            svuota.TabIndex = 2;
            svuota.Text = "svuota";
            svuota.UseVisualStyleBackColor = true;
            svuota.Click += svuota_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(279, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ListaCarrello
            // 
            ListaCarrello.FormattingEnabled = true;
            ListaCarrello.ItemHeight = 15;
            ListaCarrello.Location = new Point(592, 26);
            ListaCarrello.Name = "ListaCarrello";
            ListaCarrello.Size = new Size(196, 409);
            ListaCarrello.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 76);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 5;
            label1.Text = "Inserisci prodotto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ListaCarrello);
            Controls.Add(textBox1);
            Controls.Add(svuota);
            Controls.Add(rimuovi);
            Controls.Add(aggiungi);
            Name = "Form1";
            Text = "Carrello";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button aggiungi;
        private Button rimuovi;
        private Button svuota;
        private TextBox textBox1;
        private ListBox ListaCarrello;
        private Label label1;
    }
}
