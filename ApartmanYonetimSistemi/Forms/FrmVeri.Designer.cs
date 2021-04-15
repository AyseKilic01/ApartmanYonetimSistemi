namespace ApartmanYonetimSistemi.Forms
{
    partial class FrmVeri
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
            this.listBorc = new System.Windows.Forms.ListView();
            this.clmAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBorc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listBorc
            // 
            this.listBorc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmAd,
            this.clmSoyad,
            this.clmBorc});
            this.listBorc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBorc.HideSelection = false;
            this.listBorc.Location = new System.Drawing.Point(0, 0);
            this.listBorc.Name = "listBorc";
            this.listBorc.Size = new System.Drawing.Size(800, 450);
            this.listBorc.TabIndex = 0;
            this.listBorc.UseCompatibleStateImageBehavior = false;
            this.listBorc.View = System.Windows.Forms.View.Details;
            // 
            // clmAd
            // 
            this.clmAd.Text = "Ad";
            this.clmAd.Width = 221;
            // 
            // clmSoyad
            // 
            this.clmSoyad.Text = "Soyad";
            this.clmSoyad.Width = 223;
            // 
            // clmBorc
            // 
            this.clmBorc.Text = "Borç";
            this.clmBorc.Width = 229;
            // 
            // FrmVeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBorc);
            this.Name = "FrmVeri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borçlar";
            this.Load += new System.EventHandler(this.FrmVeri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listBorc;
        private System.Windows.Forms.ColumnHeader clmAd;
        private System.Windows.Forms.ColumnHeader clmSoyad;
        private System.Windows.Forms.ColumnHeader clmBorc;
    }
}