namespace KyrsFisr
{
    partial class BuyerForm
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
            this.CancelBut = new System.Windows.Forms.Button();
            this.BuyB = new System.Windows.Forms.Button();
            this.ChoosePay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChooseType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите способ оплаты";
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(405, 16);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(147, 35);
            this.CancelBut.TabIndex = 1;
            this.CancelBut.Text = "Вернуться назад";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // BuyB
            // 
            this.BuyB.Location = new System.Drawing.Point(19, 287);
            this.BuyB.Name = "BuyB";
            this.BuyB.Size = new System.Drawing.Size(147, 35);
            this.BuyB.TabIndex = 2;
            this.BuyB.Text = "Оплатить";
            this.BuyB.UseVisualStyleBackColor = true;
            this.BuyB.Click += new System.EventHandler(this.BuyB_Click);
            // 
            // ChoosePay
            // 
            this.ChoosePay.FormattingEnabled = true;
            this.ChoosePay.Items.AddRange(new object[] {
            "Наличные",
            "Карта"});
            this.ChoosePay.Location = new System.Drawing.Point(19, 117);
            this.ChoosePay.Name = "ChoosePay";
            this.ChoosePay.Size = new System.Drawing.Size(162, 24);
            this.ChoosePay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите вид доставки";
            // 
            // ChooseType
            // 
            this.ChooseType.FormattingEnabled = true;
            this.ChooseType.Items.AddRange(new object[] {
            "Пункт выдачи",
            "По Адресу"});
            this.ChooseType.Location = new System.Drawing.Point(19, 213);
            this.ChooseType.Name = "ChooseType";
            this.ChooseType.Size = new System.Drawing.Size(162, 24);
            this.ChooseType.TabIndex = 5;
            // 
            // BuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(564, 358);
            this.Controls.Add(this.ChooseType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChoosePay);
            this.Controls.Add(this.BuyB);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.label1);
            this.Name = "BuyerForm";
            this.Text = "BuyerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Button BuyB;
        private System.Windows.Forms.ComboBox ChoosePay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ChooseType;
    }
}