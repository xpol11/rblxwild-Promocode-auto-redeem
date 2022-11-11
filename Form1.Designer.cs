namespace RBLXex
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
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.Editor = new System.Windows.Forms.WebBrowser();
            this.AttachButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.TopBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(115)))));
            this.ExecuteButton.FlatAppearance.BorderSize = 0;
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteButton.Location = new System.Drawing.Point(0, 332);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(163, 34);
            this.ExecuteButton.TabIndex = 2;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = false;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // Editor
            // 
            this.Editor.Location = new System.Drawing.Point(0, 34);
            this.Editor.MinimumSize = new System.Drawing.Size(20, 20);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(650, 298);
            this.Editor.TabIndex = 10;
            // 
            // AttachButton
            // 
            this.AttachButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(38)))), ((int)(((byte)(77)))));
            this.AttachButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AttachButton.FlatAppearance.BorderSize = 0;
            this.AttachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttachButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachButton.ForeColor = System.Drawing.Color.White;
            this.AttachButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AttachButton.Location = new System.Drawing.Point(163, 332);
            this.AttachButton.Name = "AttachButton";
            this.AttachButton.Size = new System.Drawing.Size(162, 34);
            this.AttachButton.TabIndex = 5;
            this.AttachButton.Text = "Attach";
            this.AttachButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AttachButton.UseVisualStyleBackColor = false;
            this.AttachButton.Click += new System.EventHandler(this.AttachButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButton.Location = new System.Drawing.Point(325, 332);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(163, 34);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.OptionsButton.FlatAppearance.BorderSize = 0;
            this.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsButton.ForeColor = System.Drawing.Color.White;
            this.OptionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptionsButton.Location = new System.Drawing.Point(488, 332);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(162, 34);
            this.OptionsButton.TabIndex = 11;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OptionsButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(115)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(609, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 28);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.Paint += new System.Windows.Forms.PaintEventHandler(this.CloseButton_Paint);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SaveFileButton.FlatAppearance.BorderSize = 0;
            this.SaveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFileButton.ForeColor = System.Drawing.Color.White;
            this.SaveFileButton.Location = new System.Drawing.Point(357, 3);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(103, 28);
            this.SaveFileButton.TabIndex = 4;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = false;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            this.SaveFileButton.Paint += new System.Windows.Forms.PaintEventHandler(this.SaveFileButton_Paint);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.OpenFileButton.FlatAppearance.BorderSize = 0;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileButton.ForeColor = System.Drawing.Color.White;
            this.OpenFileButton.Location = new System.Drawing.Point(463, 3);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(102, 28);
            this.OpenFileButton.TabIndex = 3;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            this.OpenFileButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OpenFileButton_Paint);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(40, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(79, 25);
            this.Title.TabIndex = 6;
            this.Title.Text = "RBLXex";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(568, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(38, 28);
            this.MinimizeButton.TabIndex = 7;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.Paint += new System.Windows.Forms.PaintEventHandler(this.MinimizeButton_Paint);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(3, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(34, 34);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TopBar.Controls.Add(this.Logo);
            this.TopBar.Controls.Add(this.MinimizeButton);
            this.TopBar.Controls.Add(this.Title);
            this.TopBar.Controls.Add(this.OpenFileButton);
            this.TopBar.Controls.Add(this.SaveFileButton);
            this.TopBar.Controls.Add(this.CloseButton);
            this.TopBar.ForeColor = System.Drawing.Color.White;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(650, 34);
            this.TopBar.TabIndex = 0;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(650, 366);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.Editor);
            this.Controls.Add(this.AttachButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RBLXex";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.WebBrowser Editor;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button AttachButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel TopBar;
    }
}