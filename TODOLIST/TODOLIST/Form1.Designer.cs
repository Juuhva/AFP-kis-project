﻿namespace TODOLIST
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
            this.Todolist_label = new System.Windows.Forms.Label();
            this.Cim_label = new System.Windows.Forms.Label();
            this.Leiras_label = new System.Windows.Forms.Label();
            this.Cim_textBox = new System.Windows.Forms.TextBox();
            this.Leiras_textBox = new System.Windows.Forms.TextBox();
            this.ujTeendoButton = new System.Windows.Forms.Button();
            this.szerkesztesButton = new System.Windows.Forms.Button();
            this.torlesButton = new System.Windows.Forms.Button();
            this.mentesButton = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Todolist_label
            // 
            this.Todolist_label.AutoSize = true;
            this.Todolist_label.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todolist_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Todolist_label.Location = new System.Drawing.Point(344, 21);
            this.Todolist_label.Name = "Todolist_label";
            this.Todolist_label.Size = new System.Drawing.Size(160, 38);
            this.Todolist_label.TabIndex = 0;
            this.Todolist_label.Text = "To-Do List";
            // 
            // Cim_label
            // 
            this.Cim_label.AutoSize = true;
            this.Cim_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cim_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cim_label.Location = new System.Drawing.Point(35, 92);
            this.Cim_label.Name = "Cim_label";
            this.Cim_label.Size = new System.Drawing.Size(36, 23);
            this.Cim_label.TabIndex = 1;
            this.Cim_label.Text = "Cím";
            // 
            // Leiras_label
            // 
            this.Leiras_label.AutoSize = true;
            this.Leiras_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leiras_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Leiras_label.Location = new System.Drawing.Point(35, 157);
            this.Leiras_label.Name = "Leiras_label";
            this.Leiras_label.Size = new System.Drawing.Size(57, 23);
            this.Leiras_label.TabIndex = 2;
            this.Leiras_label.Text = "Leírás";
            // 
            // Cim_textBox
            // 
            this.Cim_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Cim_textBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cim_textBox.Location = new System.Drawing.Point(39, 116);
            this.Cim_textBox.Name = "Cim_textBox";
            this.Cim_textBox.Size = new System.Drawing.Size(670, 24);
            this.Cim_textBox.TabIndex = 3;
            // 
            // Leiras_textBox
            // 
            this.Leiras_textBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Leiras_textBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leiras_textBox.Location = new System.Drawing.Point(39, 181);
            this.Leiras_textBox.Name = "Leiras_textBox";
            this.Leiras_textBox.Size = new System.Drawing.Size(670, 24);
            this.Leiras_textBox.TabIndex = 4;
            // 
            // ujTeendoButton
            // 
            this.ujTeendoButton.BackColor = System.Drawing.Color.SlateGray;
            this.ujTeendoButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujTeendoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ujTeendoButton.Location = new System.Drawing.Point(12, 252);
            this.ujTeendoButton.Name = "ujTeendoButton";
            this.ujTeendoButton.Size = new System.Drawing.Size(181, 48);
            this.ujTeendoButton.TabIndex = 5;
            this.ujTeendoButton.Text = "Új teendő hozzáadása";
            this.ujTeendoButton.UseVisualStyleBackColor = false;
            this.ujTeendoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // szerkesztesButton
            // 
            this.szerkesztesButton.BackColor = System.Drawing.Color.SlateGray;
            this.szerkesztesButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szerkesztesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.szerkesztesButton.Location = new System.Drawing.Point(209, 252);
            this.szerkesztesButton.Name = "szerkesztesButton";
            this.szerkesztesButton.Size = new System.Drawing.Size(181, 48);
            this.szerkesztesButton.TabIndex = 6;
            this.szerkesztesButton.Text = "Szerkesztés";
            this.szerkesztesButton.UseVisualStyleBackColor = false;
            this.szerkesztesButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // torlesButton
            // 
            this.torlesButton.BackColor = System.Drawing.Color.SlateGray;
            this.torlesButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torlesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.torlesButton.Location = new System.Drawing.Point(413, 252);
            this.torlesButton.Name = "torlesButton";
            this.torlesButton.Size = new System.Drawing.Size(181, 48);
            this.torlesButton.TabIndex = 7;
            this.torlesButton.Text = "Törlés";
            this.torlesButton.UseVisualStyleBackColor = false;
            this.torlesButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // mentesButton
            // 
            this.mentesButton.BackColor = System.Drawing.Color.SlateGray;
            this.mentesButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mentesButton.Location = new System.Drawing.Point(607, 252);
            this.mentesButton.Name = "mentesButton";
            this.mentesButton.Size = new System.Drawing.Size(181, 48);
            this.mentesButton.TabIndex = 8;
            this.mentesButton.Text = "Mentés";
            this.mentesButton.UseVisualStyleBackColor = false;
            this.mentesButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.checkedListBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(12, 306);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(776, 214);
            this.checkedListBox.TabIndex = 10;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(39, 216);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(228, 26);
            this.dateTimePicker.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.mentesButton);
            this.Controls.Add(this.torlesButton);
            this.Controls.Add(this.szerkesztesButton);
            this.Controls.Add(this.ujTeendoButton);
            this.Controls.Add(this.Leiras_textBox);
            this.Controls.Add(this.Cim_textBox);
            this.Controls.Add(this.Leiras_label);
            this.Controls.Add(this.Cim_label);
            this.Controls.Add(this.Todolist_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "To-Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Todolist_label;
        private System.Windows.Forms.Label Cim_label;
        private System.Windows.Forms.Label Leiras_label;
        private System.Windows.Forms.TextBox Cim_textBox;
        private System.Windows.Forms.TextBox Leiras_textBox;
        private System.Windows.Forms.Button ujTeendoButton;
        private System.Windows.Forms.Button szerkesztesButton;
        private System.Windows.Forms.Button torlesButton;
        private System.Windows.Forms.Button mentesButton;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

