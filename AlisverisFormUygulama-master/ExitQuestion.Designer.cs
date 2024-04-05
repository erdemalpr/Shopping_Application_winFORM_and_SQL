using System.Windows.Forms;

namespace form_deneme
{
    partial class ExitQuestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.log_out = new System.Windows.Forms.Button();
            this.close_question = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "UYGULAMAYI KAPAT ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_button.Location = new System.Drawing.Point(11, 42);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(66, 36);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "ÇIK";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // log_out
            // 
            this.log_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.log_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_out.FlatAppearance.BorderSize = 0;
            this.log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_out.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.log_out.Location = new System.Drawing.Point(90, 42);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(171, 36);
            this.log_out.TabIndex = 2;
            this.log_out.Text = "OTURUMU KAPAT";
            this.log_out.UseVisualStyleBackColor = false;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // close_question
            // 
            this.close_question.BackColor = System.Drawing.Color.Transparent;
            this.close_question.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_question.FlatAppearance.BorderSize = 0;
            this.close_question.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.close_question.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.close_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_question.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.close_question.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close_question.Location = new System.Drawing.Point(243, -1);
            this.close_question.Name = "close_question";
            this.close_question.Size = new System.Drawing.Size(25, 29);
            this.close_question.TabIndex = 3;
            this.close_question.Text = "X";
            this.close_question.UseVisualStyleBackColor = true;
            this.close_question.Click += new System.EventHandler(this.close_question_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close_question);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.log_out);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 91);
            this.panel1.TabIndex = 4;
            // 
            // ExitQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(274, 91);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExitQuestion";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button exit_button;
        private Button log_out;
        private Button close_question;
        private Panel panel1;
    }
}