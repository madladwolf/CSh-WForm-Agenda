namespace CSh_WForm_Agenda
{
    partial class Listar
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
            this.lst_agenda = new System.Windows.Forms.ListBox();
            this.btb_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_agenda
            // 
            this.lst_agenda.FormattingEnabled = true;
            this.lst_agenda.Location = new System.Drawing.Point(12, 12);
            this.lst_agenda.Name = "lst_agenda";
            this.lst_agenda.Size = new System.Drawing.Size(186, 225);
            this.lst_agenda.TabIndex = 0;
            // 
            // btb_voltar
            // 
            this.btb_voltar.Location = new System.Drawing.Point(204, 214);
            this.btb_voltar.Name = "btb_voltar";
            this.btb_voltar.Size = new System.Drawing.Size(75, 23);
            this.btb_voltar.TabIndex = 1;
            this.btb_voltar.Text = "Voltar";
            this.btb_voltar.UseVisualStyleBackColor = true;
            this.btb_voltar.Click += new System.EventHandler(this.btb_voltar_Click);
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 248);
            this.Controls.Add(this.btb_voltar);
            this.Controls.Add(this.lst_agenda);
            this.Name = "Listar";
            this.Text = "Listagem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_agenda;
        private System.Windows.Forms.Button btb_voltar;
    }
}