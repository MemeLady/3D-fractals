namespace Lab3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.zoomButton = new System.Windows.Forms.Button();
            this.bistanceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.paintButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 785);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Снежинка",
            "Дракон",
            "Треугольник",
            "Кривая",
            "Дерево 1",
            "Дерево 2",
            "Дерево 3",
            "Дерево 4"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // zoomButton
            // 
            this.zoomButton.Location = new System.Drawing.Point(171, 12);
            this.zoomButton.Name = "zoomButton";
            this.zoomButton.Size = new System.Drawing.Size(104, 40);
            this.zoomButton.TabIndex = 2;
            this.zoomButton.Text = "Приблизить";
            this.zoomButton.UseVisualStyleBackColor = true;
            this.zoomButton.Click += new System.EventHandler(this.zoomButton_Click);
            // 
            // bistanceButton
            // 
            this.bistanceButton.Location = new System.Drawing.Point(171, 58);
            this.bistanceButton.Name = "bistanceButton";
            this.bistanceButton.Size = new System.Drawing.Size(104, 40);
            this.bistanceButton.TabIndex = 3;
            this.bistanceButton.Text = "Отдалить";
            this.bistanceButton.UseVisualStyleBackColor = true;
            this.bistanceButton.Click += new System.EventHandler(this.bistanceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(302, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Итерация:";
            // 
            // iterationLabel
            // 
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterationLabel.Location = new System.Drawing.Point(410, 18);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(20, 24);
            this.iterationLabel.TabIndex = 5;
            this.iterationLabel.Text = "0";
            // 
            // paintButton
            // 
            this.paintButton.Location = new System.Drawing.Point(306, 56);
            this.paintButton.Name = "paintButton";
            this.paintButton.Size = new System.Drawing.Size(156, 40);
            this.paintButton.TabIndex = 6;
            this.paintButton.Text = "Нарисовать фрактал";
            this.paintButton.UseVisualStyleBackColor = true;
            this.paintButton.Click += new System.EventHandler(this.paintButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 785);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // restartButton
            // 
            this.restartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restartButton.Location = new System.Drawing.Point(641, 12);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(156, 40);
            this.restartButton.TabIndex = 7;
            this.restartButton.Text = "Удалить рисунок";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 899);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.paintButton);
            this.Controls.Add(this.iterationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bistanceButton);
            this.Controls.Add(this.zoomButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button zoomButton;
        private System.Windows.Forms.Button bistanceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label iterationLabel;
        private System.Windows.Forms.Button paintButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button restartButton;
    }
}

