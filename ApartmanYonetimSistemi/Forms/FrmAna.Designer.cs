namespace ApartmanYonetimSistemi.Forms
{
    partial class FrmAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAna));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnKapa = new DevExpress.XtraEditors.SimpleButton();
            this.btnInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnFoto = new DevExpress.XtraEditors.SimpleButton();
            this.btnVeriler = new DevExpress.XtraEditors.SimpleButton();
            this.btnCRUD = new DevExpress.XtraEditors.SimpleButton();
            this.btnDaireler = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.AutoSize = true;
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.btnKapa);
            this.panelControl1.Controls.Add(this.btnInfo);
            this.panelControl1.Controls.Add(this.btnFoto);
            this.panelControl1.Controls.Add(this.btnVeriler);
            this.panelControl1.Controls.Add(this.btnCRUD);
            this.panelControl1.Controls.Add(this.btnDaireler);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(496, 481);
            this.panelControl1.TabIndex = 0;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(157, 45);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(174, 96);
            this.pictureEdit1.TabIndex = 8;
            // 
            // btnKapa
            // 
            this.btnKapa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapa.Appearance.Options.UseFont = true;
            this.btnKapa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapa.ImageOptions.Image")));
            this.btnKapa.Location = new System.Drawing.Point(401, 447);
            this.btnKapa.Name = "btnKapa";
            this.btnKapa.Size = new System.Drawing.Size(83, 29);
            this.btnKapa.TabIndex = 5;
            this.btnKapa.Text = "Çıkış";
            this.btnKapa.Click += new System.EventHandler(this.btnKapa_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInfo.Appearance.Options.UseFont = true;
            this.btnInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.ImageOptions.Image")));
            this.btnInfo.Location = new System.Drawing.Point(12, 447);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(163, 29);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Hakkımızda";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFoto.Appearance.Options.UseFont = true;
            this.btnFoto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFoto.ImageOptions.Image")));
            this.btnFoto.Location = new System.Drawing.Point(267, 271);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(140, 29);
            this.btnFoto.TabIndex = 3;
            this.btnFoto.Text = "Fotoğraflar";
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // btnVeriler
            // 
            this.btnVeriler.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriler.Appearance.Options.UseFont = true;
            this.btnVeriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVeriler.ImageOptions.Image")));
            this.btnVeriler.Location = new System.Drawing.Point(267, 194);
            this.btnVeriler.Name = "btnVeriler";
            this.btnVeriler.Size = new System.Drawing.Size(140, 29);
            this.btnVeriler.TabIndex = 2;
            this.btnVeriler.Text = "Veriler";
            this.btnVeriler.Click += new System.EventHandler(this.btnVeriler_Click);
            // 
            // btnCRUD
            // 
            this.btnCRUD.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCRUD.Appearance.Options.UseFont = true;
            this.btnCRUD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCRUD.ImageOptions.Image")));
            this.btnCRUD.Location = new System.Drawing.Point(77, 271);
            this.btnCRUD.Name = "btnCRUD";
            this.btnCRUD.Size = new System.Drawing.Size(140, 29);
            this.btnCRUD.TabIndex = 1;
            this.btnCRUD.Text = "Kayıt İşlemleri";
            this.btnCRUD.Click += new System.EventHandler(this.btnCRUD_Click);
            // 
            // btnDaireler
            // 
            this.btnDaireler.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDaireler.Appearance.Options.UseFont = true;
            this.btnDaireler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDaireler.ImageOptions.Image")));
            this.btnDaireler.Location = new System.Drawing.Point(77, 194);
            this.btnDaireler.Name = "btnDaireler";
            this.btnDaireler.Size = new System.Drawing.Size(140, 29);
            this.btnDaireler.TabIndex = 0;
            this.btnDaireler.Text = "Daireler";
            this.btnDaireler.Click += new System.EventHandler(this.btnDaireler_Click);
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 481);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapa;
        private DevExpress.XtraEditors.SimpleButton btnInfo;
        private DevExpress.XtraEditors.SimpleButton btnFoto;
        private DevExpress.XtraEditors.SimpleButton btnVeriler;
        private DevExpress.XtraEditors.SimpleButton btnCRUD;
        private DevExpress.XtraEditors.SimpleButton btnDaireler;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}