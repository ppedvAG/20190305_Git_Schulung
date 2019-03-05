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
            this.components = new System.ComponentModel.Container();
            this.bt_todoSpeichern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_todoTitel = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rtbtodoBeschreibung = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bt_todoSpeichern
            // 
            this.bt_todoSpeichern.AutoSize = true;
            this.bt_todoSpeichern.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_todoSpeichern.Location = new System.Drawing.Point(724, 382);
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
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titel";
            // 
            // tb_todoTitel
            // 
            this.tb_todoTitel.Location = new System.Drawing.Point(80, 25);
            this.tb_todoTitel.Name = "tb_todoTitel";
            this.tb_todoTitel.Size = new System.Drawing.Size(364, 20);
            this.tb_todoTitel.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rtbtodoBeschreibung
            // 
            this.rtbtodoBeschreibung.Location = new System.Drawing.Point(80, 51);
            this.rtbtodoBeschreibung.Name = "rtbtodoBeschreibung";
            this.rtbtodoBeschreibung.Size = new System.Drawing.Size(697, 326);
            this.rtbtodoBeschreibung.TabIndex = 7;
            this.rtbtodoBeschreibung.Text = "";
            // 
            // Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbtodoBeschreibung);
            this.Controls.Add(this.tb_todoTitel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_todoSpeichern);
            this.Name = "Todo";
            this.Size = new System.Drawing.Size(814, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_todoSpeichern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_todoTitel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox rtbtodoBeschreibung;
    }
}
