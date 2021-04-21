
namespace Hpdi.Vss2Git
{
    partial class UserEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.vssNameTextbox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.gitNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gitEMailTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VSS Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vssNameTextbox
            // 
            this.vssNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vssNameTextbox.Location = new System.Drawing.Point(103, 10);
            this.vssNameTextbox.Name = "vssNameTextbox";
            this.vssNameTextbox.Size = new System.Drawing.Size(174, 20);
            this.vssNameTextbox.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(202, 146);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(121, 146);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // gitNameTextbox
            // 
            this.gitNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gitNameTextbox.Location = new System.Drawing.Point(103, 65);
            this.gitNameTextbox.Name = "gitNameTextbox";
            this.gitNameTextbox.Size = new System.Drawing.Size(174, 20);
            this.gitNameTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Git Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gitEMailTextbox
            // 
            this.gitEMailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gitEMailTextbox.Location = new System.Drawing.Point(103, 91);
            this.gitEMailTextbox.Name = "gitEMailTextbox";
            this.gitEMailTextbox.Size = new System.Drawing.Size(174, 20);
            this.gitEMailTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Git EMail";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 181);
            this.ControlBox = false;
            this.Controls.Add(this.gitEMailTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gitNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.vssNameTextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VSS / Git User";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserEditForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vssNameTextbox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox gitNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gitEMailTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}