namespace pdfGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generate = new System.Windows.Forms.Button();
            this.adres_zlec_lbl = new System.Windows.Forms.Label();
            this.termin_lbl = new System.Windows.Forms.Label();
            this.miejsce_lbl = new System.Windows.Forms.Label();
            this.cena_lbl = new System.Windows.Forms.Label();
            this.zadatek_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zleceniodawca_lbl = new System.Windows.Forms.Label();
            this.data_txt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.zlece_txt = new System.Windows.Forms.TextBox();
            this.adr_zlece_txt = new System.Windows.Forms.TextBox();
            this.termin_txt = new System.Windows.Forms.TextBox();
            this.miejsce_txt = new System.Windows.Forms.TextBox();
            this.cena_txt = new System.Windows.Forms.TextBox();
            this.zadatek_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(150, 483);
            this.generate.Margin = new System.Windows.Forms.Padding(5);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(540, 69);
            this.generate.TabIndex = 0;
            this.generate.Text = "GENERUJ UMOWĘ";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // adres_zlec_lbl
            // 
            this.adres_zlec_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adres_zlec_lbl.AutoSize = true;
            this.adres_zlec_lbl.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adres_zlec_lbl.Location = new System.Drawing.Point(5, 89);
            this.adres_zlec_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.adres_zlec_lbl.Name = "adres_zlec_lbl";
            this.adres_zlec_lbl.Size = new System.Drawing.Size(247, 22);
            this.adres_zlec_lbl.TabIndex = 5;
            this.adres_zlec_lbl.Text = "Adres zleceniodawcy:";
            // 
            // termin_lbl
            // 
            this.termin_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.termin_lbl.AutoSize = true;
            this.termin_lbl.Location = new System.Drawing.Point(3, 129);
            this.termin_lbl.Name = "termin_lbl";
            this.termin_lbl.Size = new System.Drawing.Size(251, 22);
            this.termin_lbl.TabIndex = 6;
            this.termin_lbl.Text = "Termin wesela: ";
            // 
            // miejsce_lbl
            // 
            this.miejsce_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.miejsce_lbl.AutoSize = true;
            this.miejsce_lbl.Location = new System.Drawing.Point(3, 169);
            this.miejsce_lbl.Name = "miejsce_lbl";
            this.miejsce_lbl.Size = new System.Drawing.Size(251, 22);
            this.miejsce_lbl.TabIndex = 7;
            this.miejsce_lbl.Text = "Miejsce wesela: ";
            this.miejsce_lbl.UseMnemonic = false;
            // 
            // cena_lbl
            // 
            this.cena_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cena_lbl.AutoSize = true;
            this.cena_lbl.Location = new System.Drawing.Point(3, 209);
            this.cena_lbl.Name = "cena_lbl";
            this.cena_lbl.Size = new System.Drawing.Size(251, 22);
            this.cena_lbl.TabIndex = 8;
            this.cena_lbl.Text = "Cena: ";
            // 
            // zadatek_lbl
            // 
            this.zadatek_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zadatek_lbl.AutoSize = true;
            this.zadatek_lbl.Location = new System.Drawing.Point(3, 249);
            this.zadatek_lbl.Name = "zadatek_lbl";
            this.zadatek_lbl.Size = new System.Drawing.Size(251, 22);
            this.zadatek_lbl.TabIndex = 10;
            this.zadatek_lbl.Text = "Zadatek: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data: ";
            // 
            // zleceniodawca_lbl
            // 
            this.zleceniodawca_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zleceniodawca_lbl.AutoSize = true;
            this.zleceniodawca_lbl.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zleceniodawca_lbl.Location = new System.Drawing.Point(5, 49);
            this.zleceniodawca_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.zleceniodawca_lbl.Name = "zleceniodawca_lbl";
            this.zleceniodawca_lbl.Size = new System.Drawing.Size(247, 22);
            this.zleceniodawca_lbl.TabIndex = 5;
            this.zleceniodawca_lbl.Text = "Zleceniodawca: ";
            // 
            // data_txt
            // 
            this.data_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.data_txt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.data_txt.Location = new System.Drawing.Point(260, 5);
            this.data_txt.Name = "data_txt";
            this.data_txt.Size = new System.Drawing.Size(563, 30);
            this.data_txt.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.17647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.82353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.data_txt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.zleceniodawca_lbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.adres_zlec_lbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.termin_lbl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.miejsce_lbl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cena_lbl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.zlece_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.adr_zlece_txt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.termin_txt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.miejsce_txt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cena_txt, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.zadatek_lbl, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.zadatek_txt, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 184);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 291);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // zlece_txt
            // 
            this.zlece_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zlece_txt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zlece_txt.Location = new System.Drawing.Point(260, 45);
            this.zlece_txt.Name = "zlece_txt";
            this.zlece_txt.Size = new System.Drawing.Size(563, 30);
            this.zlece_txt.TabIndex = 14;
            // 
            // adr_zlece_txt
            // 
            this.adr_zlece_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adr_zlece_txt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adr_zlece_txt.Location = new System.Drawing.Point(260, 85);
            this.adr_zlece_txt.Name = "adr_zlece_txt";
            this.adr_zlece_txt.Size = new System.Drawing.Size(563, 30);
            this.adr_zlece_txt.TabIndex = 15;
            // 
            // termin_txt
            // 
            this.termin_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.termin_txt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.termin_txt.Location = new System.Drawing.Point(260, 125);
            this.termin_txt.Name = "termin_txt";
            this.termin_txt.Size = new System.Drawing.Size(563, 30);
            this.termin_txt.TabIndex = 16;
            // 
            // miejsce_txt
            // 
            this.miejsce_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.miejsce_txt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miejsce_txt.Location = new System.Drawing.Point(260, 165);
            this.miejsce_txt.Name = "miejsce_txt";
            this.miejsce_txt.Size = new System.Drawing.Size(563, 30);
            this.miejsce_txt.TabIndex = 17;
            // 
            // cena_txt
            // 
            this.cena_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cena_txt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cena_txt.Location = new System.Drawing.Point(260, 205);
            this.cena_txt.Name = "cena_txt";
            this.cena_txt.Size = new System.Drawing.Size(563, 30);
            this.cena_txt.TabIndex = 18;
            // 
            // zadatek_txt
            // 
            this.zadatek_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zadatek_txt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zadatek_txt.Location = new System.Drawing.Point(260, 245);
            this.zadatek_txt.Name = "zadatek_txt";
            this.zadatek_txt.Size = new System.Drawing.Size(563, 30);
            this.zadatek_txt.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.generate);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label adres_zlec_lbl;
        private System.Windows.Forms.Label termin_lbl;
        private System.Windows.Forms.Label miejsce_lbl;
        private System.Windows.Forms.Label cena_lbl;
        private System.Windows.Forms.Label zadatek_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zleceniodawca_lbl;
        private System.Windows.Forms.TextBox data_txt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox zlece_txt;
        private System.Windows.Forms.TextBox adr_zlece_txt;
        private System.Windows.Forms.TextBox termin_txt;
        private System.Windows.Forms.TextBox miejsce_txt;
        private System.Windows.Forms.TextBox cena_txt;
        private System.Windows.Forms.TextBox zadatek_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

