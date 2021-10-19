
namespace Projekt1
{
    partial class LoginForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.signinButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signinButton
            // 
            this.signinButton.Location = new System.Drawing.Point(352, 304);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(75, 23);
            this.signinButton.TabIndex = 0;
            this.signinButton.Text = "Sign in";
            this.signinButton.UseVisualStyleBackColor = true;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(352, 333);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 1;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = true;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(273, 111);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(244, 20);
            this.loginBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(273, 167);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(244, 20);
            this.PasswordBox.TabIndex = 3;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(206, 114);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(209, 173);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorLabel.Location = new System.Drawing.Point(367, 228);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(29, 13);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "Error";
            this.errorLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signinButton);
            this.Name = "LoginForm";
            this.Text = "Projekt_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}

