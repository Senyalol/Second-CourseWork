namespace KyrsFisr
{
    partial class ClientCartForm
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
            this.BuyButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.DisplayCart2 = new System.Windows.Forms.CheckedListBox();
            this.RemoveBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeliveryType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Корзина покупателя";
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BuyButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyButton.Location = new System.Drawing.Point(510, 357);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(147, 59);
            this.BuyButton.TabIndex = 2;
            this.BuyButton.Text = "Купить";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(586, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(71, 59);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DisplayCart2
            // 
            this.DisplayCart2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayCart2.FormattingEnabled = true;
            this.DisplayCart2.Location = new System.Drawing.Point(12, 84);
            this.DisplayCart2.Name = "DisplayCart2";
            this.DisplayCart2.Size = new System.Drawing.Size(438, 334);
            this.DisplayCart2.TabIndex = 4;
            // 
            // RemoveBut
            // 
            this.RemoveBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RemoveBut.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveBut.Location = new System.Drawing.Point(510, 74);
            this.RemoveBut.Name = "RemoveBut";
            this.RemoveBut.Size = new System.Drawing.Size(147, 59);
            this.RemoveBut.TabIndex = 5;
            this.RemoveBut.Text = "Убрать из корзины выбранные";
            this.RemoveBut.UseVisualStyleBackColor = false;
            this.RemoveBut.Click += new System.EventHandler(this.RemoveBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(516, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вид доставки";
            // 
            // DeliveryType
            // 
            this.DeliveryType.FormattingEnabled = true;
            this.DeliveryType.Items.AddRange(new object[] {
            "Домашний адрес",
            "Пункт выдачи"});
            this.DeliveryType.Location = new System.Drawing.Point(510, 317);
            this.DeliveryType.Name = "DeliveryType";
            this.DeliveryType.Size = new System.Drawing.Size(147, 24);
            this.DeliveryType.TabIndex = 7;
            // 
            // ClientCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(675, 428);
            this.Controls.Add(this.DeliveryType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveBut);
            this.Controls.Add(this.DisplayCart2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientCartForm";
            this.Text = "ClientCartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckedListBox DisplayCart2;
        private System.Windows.Forms.Button RemoveBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DeliveryType;
    }
}