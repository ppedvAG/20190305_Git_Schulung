namespace ProjektEins
{
    partial class Todo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_todoSpeichern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_todoTitel = new System.Windows.Forms.TextBox();
            this.rtbtodoBeschreibung = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_todoTelefon = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_todoSpeichern
            // 
            this.bt_todoSpeichern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_todoSpeichern.AutoSize = true;
            this.bt_todoSpeichern.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_todoSpeichern.Location = new System.Drawing.Point(763, 398);
            this.bt_todoSpeichern.Margin = new System.Windows.Forms.Padding(2);
            this.bt_todoSpeichern.Name = "bt_todoSpeichern";
            this.bt_todoSpeichern.Size = new System.Drawing.Size(65, 23);
            this.bt_todoSpeichern.TabIndex = 3;
            this.bt_todoSpeichern.Text = "Speichern";
            this.bt_todoSpeichern.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titel";
            // 
            // tb_todoTitel
            // 
            this.tb_todoTitel.Location = new System.Drawing.Point(52, 3);
            this.tb_todoTitel.Name = "tb_todoTitel";
            this.tb_todoTitel.Size = new System.Drawing.Size(364, 20);
            this.tb_todoTitel.TabIndex = 5;
            // 
            // rtbtodoBeschreibung
            // 
            this.rtbtodoBeschreibung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbtodoBeschreibung.Location = new System.Drawing.Point(52, 29);
            this.rtbtodoBeschreibung.Name = "rtbtodoBeschreibung";
            this.rtbtodoBeschreibung.Size = new System.Drawing.Size(775, 338);
            this.rtbtodoBeschreibung.TabIndex = 7;
            this.rtbtodoBeschreibung.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbtodoBeschreibung, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_todoTitel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_todoTelefon, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_todoSpeichern, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 423);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefon";
            // 
            // tb_todoTelefon
            // 
            this.tb_todoTelefon.Location = new System.Drawing.Point(52, 373);
            this.tb_todoTelefon.Name = "tb_todoTelefon";
            this.tb_todoTelefon.Size = new System.Drawing.Size(364, 20);
            this.tb_todoTelefon.TabIndex = 9;
            // 
            // Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Todo";
            this.Size = new System.Drawing.Size(814, 423);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_todoSpeichern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_todoTitel;
        private System.Windows.Forms.RichTextBox rtbtodoBeschreibung;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_todoTelefon;
    }
}
