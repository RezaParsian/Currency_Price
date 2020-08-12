namespace Currency_Price
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgcurrency = new System.Windows.Forms.ImageList(this.components);
            this.price_dollar_rl = new System.Windows.Forms.Button();
            this.price_eur = new System.Windows.Forms.Button();
            this.price_try = new System.Windows.Forms.Button();
            this.price_gbp = new System.Windows.Forms.Button();
            this.price_cny = new System.Windows.Forms.Button();
            this.price_rub = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // imgcurrency
            // 
            this.imgcurrency.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgcurrency.ImageStream")));
            this.imgcurrency.TransparentColor = System.Drawing.Color.Transparent;
            this.imgcurrency.Images.SetKeyName(0, "us.jpg");
            this.imgcurrency.Images.SetKeyName(1, "eu.jpg");
            this.imgcurrency.Images.SetKeyName(2, "gb.jpg");
            this.imgcurrency.Images.SetKeyName(3, "tr.jpg");
            this.imgcurrency.Images.SetKeyName(4, "cn.jpg");
            this.imgcurrency.Images.SetKeyName(5, "ru.jpg");
            // 
            // price_dollar_rl
            // 
            this.price_dollar_rl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.price_dollar_rl.Font = new System.Drawing.Font("Neon 80s", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_dollar_rl.ImageIndex = 0;
            this.price_dollar_rl.ImageList = this.imgcurrency;
            this.price_dollar_rl.Location = new System.Drawing.Point(13, 22);
            this.price_dollar_rl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.price_dollar_rl.Name = "price_dollar_rl";
            this.price_dollar_rl.Size = new System.Drawing.Size(60, 61);
            this.price_dollar_rl.TabIndex = 0;
            this.price_dollar_rl.Text = "0";
            this.price_dollar_rl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.price_dollar_rl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.price_dollar_rl, "USD");
            this.price_dollar_rl.UseVisualStyleBackColor = false;
            // 
            // price_eur
            // 
            this.price_eur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.price_eur.Font = new System.Drawing.Font("Neon 80s", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_eur.ImageIndex = 1;
            this.price_eur.ImageList = this.imgcurrency;
            this.price_eur.Location = new System.Drawing.Point(97, 22);
            this.price_eur.Margin = new System.Windows.Forms.Padding(4);
            this.price_eur.Name = "price_eur";
            this.price_eur.Size = new System.Drawing.Size(60, 61);
            this.price_eur.TabIndex = 1;
            this.price_eur.Text = "0";
            this.price_eur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.price_eur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.price_eur, "Euro");
            this.price_eur.UseVisualStyleBackColor = false;
            // 
            // price_try
            // 
            this.price_try.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.price_try.Font = new System.Drawing.Font("Neon 80s", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_try.ImageIndex = 3;
            this.price_try.ImageList = this.imgcurrency;
            this.price_try.Location = new System.Drawing.Point(265, 22);
            this.price_try.Margin = new System.Windows.Forms.Padding(4);
            this.price_try.Name = "price_try";
            this.price_try.Size = new System.Drawing.Size(60, 61);
            this.price_try.TabIndex = 3;
            this.price_try.Text = "0";
            this.price_try.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.price_try.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.price_try, "TRY");
            this.price_try.UseVisualStyleBackColor = false;
            // 
            // price_gbp
            // 
            this.price_gbp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.price_gbp.Font = new System.Drawing.Font("Neon 80s", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_gbp.ImageIndex = 2;
            this.price_gbp.ImageList = this.imgcurrency;
            this.price_gbp.Location = new System.Drawing.Point(181, 22);
            this.price_gbp.Margin = new System.Windows.Forms.Padding(4);
            this.price_gbp.Name = "price_gbp";
            this.price_gbp.Size = new System.Drawing.Size(60, 61);
            this.price_gbp.TabIndex = 2;
            this.price_gbp.Text = "0";
            this.price_gbp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.price_gbp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.price_gbp, "GBP");
            this.price_gbp.UseVisualStyleBackColor = false;
            // 
            // price_cny
            // 
            this.price_cny.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.price_cny.Font = new System.Drawing.Font("Neon 80s", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_cny.ImageIndex = 4;
            this.price_cny.ImageList = this.imgcurrency;
            this.price_cny.Location = new System.Drawing.Point(349, 22);
            this.price_cny.Margin = new System.Windows.Forms.Padding(4);
            this.price_cny.Name = "price_cny";
            this.price_cny.Size = new System.Drawing.Size(60, 61);
            this.price_cny.TabIndex = 4;
            this.price_cny.Text = "0";
            this.price_cny.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.price_cny.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.price_cny, "CNY");
            this.price_cny.UseVisualStyleBackColor = false;
            // 
            // price_rub
            // 
            this.price_rub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.price_rub.Font = new System.Drawing.Font("Neon 80s", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_rub.ImageIndex = 5;
            this.price_rub.ImageList = this.imgcurrency;
            this.price_rub.Location = new System.Drawing.Point(433, 22);
            this.price_rub.Margin = new System.Windows.Forms.Padding(4);
            this.price_rub.Name = "price_rub";
            this.price_rub.Size = new System.Drawing.Size(60, 61);
            this.price_rub.TabIndex = 5;
            this.price_rub.Text = "0";
            this.price_rub.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.price_rub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.price_rub, "RUB");
            this.price_rub.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 104);
            this.Controls.Add(this.price_rub);
            this.Controls.Add(this.price_cny);
            this.Controls.Add(this.price_gbp);
            this.Controls.Add(this.price_try);
            this.Controls.Add(this.price_eur);
            this.Controls.Add(this.price_dollar_rl);
            this.Font = new System.Drawing.Font("Neon 80s", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency_Price";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgcurrency;
        private System.Windows.Forms.Button price_dollar_rl;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button price_eur;
        private System.Windows.Forms.Button price_try;
        private System.Windows.Forms.Button price_gbp;
        private System.Windows.Forms.Button price_cny;
        private System.Windows.Forms.Button price_rub;
    }
}

