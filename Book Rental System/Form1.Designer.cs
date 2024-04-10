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
            remeberMeBox = new MaterialSkin.Controls.MaterialCheckbox();
            passwordBox = new MaterialSkin.Controls.MaterialTextBox();
            passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            userNameLabel = new MaterialSkin.Controls.MaterialLabel();
            userNameBox = new MaterialSkin.Controls.MaterialTextBox();
            signInButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // remeberMeBox
            // 
            remeberMeBox.AutoSize = true;
            remeberMeBox.Depth = 0;
            remeberMeBox.Location = new Point(16, 260);
            remeberMeBox.Margin = new Padding(0);
            remeberMeBox.MouseLocation = new Point(-1, -1);
            remeberMeBox.MouseState = MaterialSkin.MouseState.HOVER;
            remeberMeBox.Name = "remeberMeBox";
            remeberMeBox.ReadOnly = false;
            remeberMeBox.Ripple = true;
            remeberMeBox.Size = new Size(149, 37);
            remeberMeBox.TabIndex = 0;
            remeberMeBox.Text = "Remember me ?";
            remeberMeBox.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            passwordBox.AnimateReadOnly = false;
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Depth = 0;
            passwordBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordBox.LeadingIcon = null;
            passwordBox.Location = new Point(16, 207);
            passwordBox.MaxLength = 50;
            passwordBox.MouseState = MaterialSkin.MouseState.OUT;
            passwordBox.Multiline = false;
            passwordBox.Name = "passwordBox";
            passwordBox.Password = true;
            passwordBox.Size = new Size(270, 50);
            passwordBox.TabIndex = 1;
            passwordBox.Text = "";
            passwordBox.TrailingIcon = null;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = SystemColors.ButtonHighlight;
            passwordLabel.Depth = 0;
            passwordLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordLabel.Location = new Point(16, 185);
            passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(71, 19);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Depth = 0;
            userNameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            userNameLabel.Location = new Point(16, 82);
            userNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(74, 19);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "UserName";
            // 
            // userNameBox
            // 
            userNameBox.AnimateReadOnly = false;
            userNameBox.BorderStyle = BorderStyle.None;
            userNameBox.Depth = 0;
            userNameBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            userNameBox.LeadingIcon = null;
            userNameBox.Location = new Point(16, 104);
            userNameBox.MaxLength = 50;
            userNameBox.MouseState = MaterialSkin.MouseState.OUT;
            userNameBox.Multiline = false;
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(270, 50);
            userNameBox.TabIndex = 3;
            userNameBox.Text = "";
            userNameBox.TrailingIcon = null;
            // 
            // signInButton
            // 
            signInButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            signInButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            signInButton.Depth = 0;
            signInButton.HighEmphasis = true;
            signInButton.Icon = null;
            signInButton.Location = new Point(16, 322);
            signInButton.Margin = new Padding(4, 6, 4, 6);
            signInButton.MouseState = MaterialSkin.MouseState.HOVER;
            signInButton.Name = "signInButton";
            signInButton.NoAccentTextColor = Color.Empty;
            signInButton.Size = new Size(74, 36);
            signInButton.TabIndex = 5;
            signInButton.Text = "Sign-In";
            signInButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            signInButton.UseAccentColor = false;
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(302, 386);
            Controls.Add(signInButton);
            Controls.Add(userNameLabel);
            Controls.Add(userNameBox);
            Controls.Add(passwordLabel);
            Controls.Add(passwordBox);
            Controls.Add(remeberMeBox);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckbox remeberMeBox;
        private MaterialSkin.Controls.MaterialTextBox passwordBox;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialLabel userNameLabel;
        private MaterialSkin.Controls.MaterialTextBox userNameBox;
        private MaterialSkin.Controls.MaterialButton signInButton;
    }
}
