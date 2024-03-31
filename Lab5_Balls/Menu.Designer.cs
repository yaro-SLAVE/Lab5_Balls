namespace Lab5_Balls
{
    partial class Menu
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
            this.vCoefBox = new System.Windows.Forms.NumericUpDown();
            this.countEllBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.danZoneRadio = new System.Windows.Forms.RadioButton();
            this.wallRadio = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vCoefBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countEllBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Коэффициент скорости";
            // 
            // vCoefBox
            // 
            this.vCoefBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vCoefBox.Location = new System.Drawing.Point(12, 14);
            this.vCoefBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.vCoefBox.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.vCoefBox.Name = "vCoefBox";
            this.vCoefBox.Size = new System.Drawing.Size(120, 39);
            this.vCoefBox.TabIndex = 1;
            this.vCoefBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // countEllBox
            // 
            this.countEllBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countEllBox.Location = new System.Drawing.Point(12, 63);
            this.countEllBox.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.countEllBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.countEllBox.Name = "countEllBox";
            this.countEllBox.Size = new System.Drawing.Size(120, 39);
            this.countEllBox.TabIndex = 3;
            this.countEllBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(151, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество кружков";
            // 
            // danZoneRadio
            // 
            this.danZoneRadio.AutoSize = true;
            this.danZoneRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.danZoneRadio.Location = new System.Drawing.Point(12, 135);
            this.danZoneRadio.Name = "danZoneRadio";
            this.danZoneRadio.Size = new System.Drawing.Size(204, 36);
            this.danZoneRadio.TabIndex = 4;
            this.danZoneRadio.Text = "Danger Zone";
            this.danZoneRadio.UseVisualStyleBackColor = true;
            // 
            // wallRadio
            // 
            this.wallRadio.AutoSize = true;
            this.wallRadio.Checked = true;
            this.wallRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wallRadio.Location = new System.Drawing.Point(12, 177);
            this.wallRadio.Name = "wallRadio";
            this.wallRadio.Size = new System.Drawing.Size(275, 36);
            this.wallRadio.TabIndex = 5;
            this.wallRadio.TabStop = true;
            this.wallRadio.Text = "Негативная стена";
            this.wallRadio.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(257, 246);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(148, 57);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 326);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.wallRadio);
            this.Controls.Add(this.danZoneRadio);
            this.Controls.Add(this.countEllBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vCoefBox);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.vCoefBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countEllBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown vCoefBox;
        private System.Windows.Forms.NumericUpDown countEllBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton danZoneRadio;
        private System.Windows.Forms.RadioButton wallRadio;
        private System.Windows.Forms.Button startButton;
    }
}