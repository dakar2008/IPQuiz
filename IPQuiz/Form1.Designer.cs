namespace IPQuiz
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
            this.RandomIPLabel = new System.Windows.Forms.Label();
            this.CheckAnwerLabel = new System.Windows.Forms.Label();
            this.AnswerResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WrongAnswerCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CorrectAnswerCounter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newipbtn = new System.Windows.Forms.Button();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RandomIPLabel
            // 
            this.RandomIPLabel.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomIPLabel.Location = new System.Drawing.Point(12, 9);
            this.RandomIPLabel.Name = "RandomIPLabel";
            this.RandomIPLabel.Size = new System.Drawing.Size(641, 52);
            this.RandomIPLabel.TabIndex = 0;
            this.RandomIPLabel.Text = "192.168.100.100";
            this.RandomIPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckAnwerLabel
            // 
            this.CheckAnwerLabel.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAnwerLabel.Location = new System.Drawing.Point(12, 103);
            this.CheckAnwerLabel.Name = "CheckAnwerLabel";
            this.CheckAnwerLabel.Size = new System.Drawing.Size(913, 55);
            this.CheckAnwerLabel.TabIndex = 2;
            this.CheckAnwerLabel.Text = "Check Her";
            this.CheckAnwerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckAnwerLabel.Visible = false;
            // 
            // AnswerResult
            // 
            this.AnswerResult.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerResult.Location = new System.Drawing.Point(12, 158);
            this.AnswerResult.Name = "AnswerResult";
            this.AnswerResult.Size = new System.Drawing.Size(913, 55);
            this.AnswerResult.TabIndex = 3;
            this.AnswerResult.Text = "Result Her";
            this.AnswerResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AnswerResult.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.WrongAnswerCounter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CorrectAnswerCounter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score Board";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(901, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Genstart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WrongAnswerCounter
            // 
            this.WrongAnswerCounter.ForeColor = System.Drawing.Color.Red;
            this.WrongAnswerCounter.Location = new System.Drawing.Point(6, 111);
            this.WrongAnswerCounter.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.WrongAnswerCounter.Name = "WrongAnswerCounter";
            this.WrongAnswerCounter.Size = new System.Drawing.Size(901, 23);
            this.WrongAnswerCounter.TabIndex = 3;
            this.WrongAnswerCounter.Text = "0";
            this.WrongAnswerCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(901, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Forkerte Svar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CorrectAnswerCounter
            // 
            this.CorrectAnswerCounter.ForeColor = System.Drawing.Color.Green;
            this.CorrectAnswerCounter.Location = new System.Drawing.Point(6, 55);
            this.CorrectAnswerCounter.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.CorrectAnswerCounter.Name = "CorrectAnswerCounter";
            this.CorrectAnswerCounter.Size = new System.Drawing.Size(901, 23);
            this.CorrectAnswerCounter.TabIndex = 1;
            this.CorrectAnswerCounter.Text = "0";
            this.CorrectAnswerCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(901, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Korrekte Svar:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newipbtn
            // 
            this.newipbtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newipbtn.Location = new System.Drawing.Point(659, 9);
            this.newipbtn.Name = "newipbtn";
            this.newipbtn.Size = new System.Drawing.Size(266, 52);
            this.newipbtn.TabIndex = 5;
            this.newipbtn.Text = "Ny IP Adresse";
            this.newipbtn.UseVisualStyleBackColor = true;
            this.newipbtn.Click += new System.EventHandler(this.newipbtn_Click);
            // 
            // UserInput
            // 
            this.UserInput.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.Location = new System.Drawing.Point(12, 69);
            this.UserInput.MaxLength = 35;
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(913, 31);
            this.UserInput.TabIndex = 0;
            this.UserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            this.UserInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserInput_KeyDown);
            this.UserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserInput_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 427);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.newipbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AnswerResult);
            this.Controls.Add(this.CheckAnwerLabel);
            this.Controls.Add(this.RandomIPLabel);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP To Binary Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RandomIPLabel;
        private System.Windows.Forms.Label CheckAnwerLabel;
        private System.Windows.Forms.Label AnswerResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label WrongAnswerCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CorrectAnswerCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newipbtn;
        private System.Windows.Forms.TextBox UserInput;
    }
}

