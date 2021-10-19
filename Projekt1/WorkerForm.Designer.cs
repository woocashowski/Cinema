
namespace Projekt1
{
    partial class WorkerForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleMovieBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.durationTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.durationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Client/Worker";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Movie";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 279);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // timeTimePicker
            // 
            this.timeTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeTimePicker.Location = new System.Drawing.Point(270, 236);
            this.timeTimePicker.Name = "timeTimePicker";
            this.timeTimePicker.Size = new System.Drawing.Size(200, 20);
            this.timeTimePicker.TabIndex = 3;
            // 
            // titleMovieBox
            // 
            this.titleMovieBox.Location = new System.Drawing.Point(270, 189);
            this.titleMovieBox.Name = "titleMovieBox";
            this.titleMovieBox.Size = new System.Drawing.Size(200, 20);
            this.titleMovieBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // durationTimePicker2
            // 
            this.durationTimePicker2.CustomFormat = "HH:mm";
            this.durationTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.durationTimePicker2.Location = new System.Drawing.Point(270, 141);
            this.durationTimePicker2.Name = "durationTimePicker2";
            this.durationTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.durationTimePicker2.TabIndex = 8;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(217, 141);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(47, 13);
            this.durationLabel.TabIndex = 10;
            this.durationLabel.Text = "Duration";
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.durationTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleMovieBox);
            this.Controls.Add(this.timeTimePicker);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker timeTimePicker;
        private System.Windows.Forms.TextBox titleMovieBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker durationTimePicker2;
        private System.Windows.Forms.Label durationLabel;
    }
}