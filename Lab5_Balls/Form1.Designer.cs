namespace Lab5_Balls
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainField = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.labelScores = new System.Windows.Forms.Label();
            this.targetTimer = new System.Windows.Forms.Timer(this.components);
            this.danZoneTimer = new System.Windows.Forms.Timer(this.components);
            this.wallTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainField)).BeginInit();
            this.SuspendLayout();
            // 
            // mainField
            // 
            this.mainField.Location = new System.Drawing.Point(0, 0);
            this.mainField.Name = "mainField";
            this.mainField.Size = new System.Drawing.Size(801, 497);
            this.mainField.TabIndex = 0;
            this.mainField.TabStop = false;
            this.mainField.Paint += new System.Windows.Forms.PaintEventHandler(this.mainField_Paint);
            this.mainField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainField_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(807, 61);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(367, 451);
            this.logBox.TabIndex = 1;
            this.logBox.Text = "";
            // 
            // labelScores
            // 
            this.labelScores.AutoSize = true;
            this.labelScores.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScores.Location = new System.Drawing.Point(807, 9);
            this.labelScores.Name = "labelScores";
            this.labelScores.Size = new System.Drawing.Size(113, 40);
            this.labelScores.TabIndex = 2;
            this.labelScores.Text = "label1";
            // 
            // targetTimer
            // 
            this.targetTimer.Interval = 80;
            this.targetTimer.Tick += new System.EventHandler(this.targetTimer_Tick);
            // 
            // danZoneTimer
            // 
            this.danZoneTimer.Interval = 20;
            this.danZoneTimer.Tick += new System.EventHandler(this.danZoneTimer_Tick);
            // 
            // wallTimer
            // 
            this.wallTimer.Interval = 10;
            this.wallTimer.Tick += new System.EventHandler(this.wallTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 509);
            this.Controls.Add(this.labelScores);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.mainField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mainField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainField;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Label labelScores;
        private System.Windows.Forms.Timer targetTimer;
        private System.Windows.Forms.Timer danZoneTimer;
        private System.Windows.Forms.Timer wallTimer;
    }
}

