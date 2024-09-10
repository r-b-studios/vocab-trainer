namespace VocabTrainer
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.openButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.taskBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(155, 50);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(80, 30);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OpenButton_MouseClick);
            // 
            // answerBox
            // 
            this.answerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBox.Location = new System.Drawing.Point(10, 197);
            this.answerBox.Multiline = true;
            this.answerBox.Name = "answerBox";
            this.answerBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answerBox.Size = new System.Drawing.Size(380, 90);
            this.answerBox.TabIndex = 1;
            this.answerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerBox_KeyDown);
            this.answerBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AnswerBox_KeyUp);
            // 
            // checkButton
            // 
            this.checkButton.Enabled = false;
            this.checkButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Location = new System.Drawing.Point(100, 300);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(80, 30);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckButton_MouseClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Vocabulary|*.voc";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(10, 10);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(380, 30);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartButton
            // 
            this.restartButton.Enabled = false;
            this.restartButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(220, 300);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(80, 30);
            this.restartButton.TabIndex = 5;
            this.restartButton.Text = "restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RestartButton_MouseClick);
            // 
            // taskBox
            // 
            this.taskBox.BackColor = System.Drawing.Color.Lavender;
            this.taskBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskBox.Location = new System.Drawing.Point(10, 101);
            this.taskBox.Multiline = true;
            this.taskBox.Name = "taskBox";
            this.taskBox.ReadOnly = true;
            this.taskBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.taskBox.Size = new System.Drawing.Size(380, 90);
            this.taskBox.TabIndex = 6;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 341);
            this.Controls.Add(this.taskBox);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.openButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocab Trainer";
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.TextBox taskBox;
    }
}

