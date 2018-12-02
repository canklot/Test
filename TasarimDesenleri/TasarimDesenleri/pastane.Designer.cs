namespace TasarimDesenleri
{
    partial class pastane
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
            this.yuvarlakres = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.yuvarlakkap = new System.Windows.Forms.Button();
            this.kakotus = new System.Windows.Forms.Button();
            this.cikolattus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yuvarlakres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // yuvarlakres
            // 
            this.yuvarlakres.BackgroundImage = global::TasarimDesenleri.Properties.Resources.Başlıksız;
            this.yuvarlakres.Location = new System.Drawing.Point(243, 229);
            this.yuvarlakres.Name = "yuvarlakres";
            this.yuvarlakres.Size = new System.Drawing.Size(85, 85);
            this.yuvarlakres.TabIndex = 0;
            this.yuvarlakres.TabStop = false;
            this.yuvarlakres.Visible = false;
            this.yuvarlakres.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TasarimDesenleri.Properties.Resources.yuvarlak_crop;
            this.pictureBox2.Location = new System.Drawing.Point(493, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 87);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TasarimDesenleri.Properties.Resources.yuvarlakkek_crop;
            this.pictureBox3.Location = new System.Drawing.Point(366, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 89);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // yuvarlakkap
            // 
            this.yuvarlakkap.BackColor = System.Drawing.Color.Transparent;
            this.yuvarlakkap.Cursor = System.Windows.Forms.Cursors.Default;
            this.yuvarlakkap.FlatAppearance.BorderSize = 0;
            this.yuvarlakkap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.yuvarlakkap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.yuvarlakkap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakkap.Location = new System.Drawing.Point(224, 347);
            this.yuvarlakkap.Name = "yuvarlakkap";
            this.yuvarlakkap.Size = new System.Drawing.Size(75, 23);
            this.yuvarlakkap.TabIndex = 3;
            this.yuvarlakkap.UseVisualStyleBackColor = false;
            this.yuvarlakkap.Click += new System.EventHandler(this.yuvarlakkap_Click);
            // 
            // kakotus
            // 
            this.kakotus.BackColor = System.Drawing.Color.Transparent;
            this.kakotus.FlatAppearance.BorderSize = 0;
            this.kakotus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.kakotus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.kakotus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kakotus.Location = new System.Drawing.Point(352, 347);
            this.kakotus.Name = "kakotus";
            this.kakotus.Size = new System.Drawing.Size(75, 23);
            this.kakotus.TabIndex = 4;
            this.kakotus.UseVisualStyleBackColor = false;
            this.kakotus.Click += new System.EventHandler(this.kakotus_Click);
            // 
            // cikolattus
            // 
            this.cikolattus.BackColor = System.Drawing.Color.Transparent;
            this.cikolattus.FlatAppearance.BorderSize = 0;
            this.cikolattus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cikolattus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cikolattus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikolattus.Location = new System.Drawing.Point(483, 347);
            this.cikolattus.Name = "cikolattus";
            this.cikolattus.Size = new System.Drawing.Size(75, 23);
            this.cikolattus.TabIndex = 5;
            this.cikolattus.UseVisualStyleBackColor = false;
            this.cikolattus.Click += new System.EventHandler(this.cikolattus_Click);
            // 
            // pastane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TasarimDesenleri.Properties.Resources.pasta_edited_orta;
            this.ClientSize = new System.Drawing.Size(996, 570);
            this.Controls.Add(this.cikolattus);
            this.Controls.Add(this.kakotus);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.yuvarlakres);
            this.Controls.Add(this.yuvarlakkap);
            this.Name = "pastane";
            this.Text = "pastane";
            ((System.ComponentModel.ISupportInitialize)(this.yuvarlakres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox yuvarlakres;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button yuvarlakkap;
        private System.Windows.Forms.Button kakotus;
        private System.Windows.Forms.Button cikolattus;
        
    }
}