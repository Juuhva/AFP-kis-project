namespace TODOLIST
{
    partial class PopUpForm
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
            this.Uzenet_label = new System.Windows.Forms.Label();
            this.ertesitesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Uzenet_label
            // 
            this.Uzenet_label.AutoSize = true;
            this.Uzenet_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Uzenet_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Uzenet_label.Location = new System.Drawing.Point(35, 42);
            this.Uzenet_label.Name = "Uzenet_label";
            this.Uzenet_label.Size = new System.Drawing.Size(0, 33);
            this.Uzenet_label.TabIndex = 0;
            // 
            // ertesitesButton
            // 
            this.ertesitesButton.BackColor = System.Drawing.Color.SlateGray;
            this.ertesitesButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ertesitesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ertesitesButton.Location = new System.Drawing.Point(235, 237);
            this.ertesitesButton.Name = "ertesitesButton";
            this.ertesitesButton.Size = new System.Drawing.Size(144, 46);
            this.ertesitesButton.TabIndex = 1;
            this.ertesitesButton.Text = "Rendben";
            this.ertesitesButton.UseVisualStyleBackColor = false;
            this.ertesitesButton.Click += new System.EventHandler(this.ertesitesButton_Click);
            // 
            // PopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(643, 319);
            this.Controls.Add(this.ertesitesButton);
            this.Controls.Add(this.Uzenet_label);
            this.Name = "PopUpForm";
            this.Text = "PopUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Uzenet_label;
        private System.Windows.Forms.Button ertesitesButton;
    }
}