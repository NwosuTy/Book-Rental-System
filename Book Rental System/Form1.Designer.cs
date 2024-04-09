namespace Book_Rental_System
{
    partial class LoginForm
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
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialCheckbox1
            // 
            materialCheckbox1.AutoSize = true;
            materialCheckbox1.Depth = 0;
            materialCheckbox1.Location = new Point(16, 260);
            materialCheckbox1.Margin = new Padding(0);
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.Size = new Size(149, 37);
            materialCheckbox1.TabIndex = 0;
            materialCheckbox1.Text = "Remember me ?";
            materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(16, 207);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(270, 50);
            materialTextBox1.TabIndex = 1;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = SystemColors.ButtonHighlight;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(16, 185);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(71, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Password";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(16, 82);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(74, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "UserName";
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(16, 104);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(270, 50);
            materialTextBox2.TabIndex = 3;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(16, 322);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(74, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "Sign-In";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(302, 386);
            Controls.Add(materialButton1);
            Controls.Add(materialLabel2);
            Controls.Add(materialTextBox2);
            Controls.Add(materialLabel1);
            Controls.Add(materialTextBox1);
            Controls.Add(materialCheckbox1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}
