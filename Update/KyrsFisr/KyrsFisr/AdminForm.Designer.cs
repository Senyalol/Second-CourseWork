namespace KyrsFisr
{
    partial class AdminForm
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
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseProduct = new System.Windows.Forms.ComboBox();
            this.Hide = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProd = new System.Windows.Forms.Button();
            this.DelProd = new System.Windows.Forms.Button();
            this.ChangeProd = new System.Windows.Forms.Button();
            this.AdminDisplay = new System.Windows.Forms.ListView();
            this.photo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cyear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NewDataProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChooseParamProd = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.OkBut = new System.Windows.Forms.Button();
            this.ChangePhoto = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(756, 27);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(148, 49);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выйти из аккаунта";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Администратор";
            // 
            // ChooseProduct
            // 
            this.ChooseProduct.FormattingEnabled = true;
            this.ChooseProduct.Location = new System.Drawing.Point(19, 110);
            this.ChooseProduct.Name = "ChooseProduct";
            this.ChooseProduct.Size = new System.Drawing.Size(135, 24);
            this.ChooseProduct.TabIndex = 2;
            this.ChooseProduct.SelectedIndexChanged += new System.EventHandler(this.ChooseProduct_SelectedIndexChanged);
            // 
            // Hide
            // 
            this.Hide.Location = new System.Drawing.Point(602, 27);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(148, 49);
            this.Hide.TabIndex = 3;
            this.Hide.Text = "Закрыть";
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID продукта";
            // 
            // AddProd
            // 
            this.AddProd.Location = new System.Drawing.Point(19, 475);
            this.AddProd.Name = "AddProd";
            this.AddProd.Size = new System.Drawing.Size(148, 49);
            this.AddProd.TabIndex = 5;
            this.AddProd.Text = "Добавить товар";
            this.AddProd.UseVisualStyleBackColor = true;
            this.AddProd.Click += new System.EventHandler(this.AddProd_Click);
            // 
            // DelProd
            // 
            this.DelProd.Location = new System.Drawing.Point(21, 541);
            this.DelProd.Name = "DelProd";
            this.DelProd.Size = new System.Drawing.Size(148, 49);
            this.DelProd.TabIndex = 6;
            this.DelProd.Text = "Удалить товар";
            this.DelProd.UseVisualStyleBackColor = true;
            this.DelProd.Click += new System.EventHandler(this.DelProd_Click);
            // 
            // ChangeProd
            // 
            this.ChangeProd.Location = new System.Drawing.Point(185, 475);
            this.ChangeProd.Name = "ChangeProd";
            this.ChangeProd.Size = new System.Drawing.Size(148, 49);
            this.ChangeProd.TabIndex = 7;
            this.ChangeProd.Text = "Изменить товар";
            this.ChangeProd.UseVisualStyleBackColor = true;
            this.ChangeProd.Click += new System.EventHandler(this.ChangeProd_Click);
            // 
            // AdminDisplay
            // 
            this.AdminDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.photo,
            this.bran,
            this.Cyear,
            this.mat,
            this.bat,
            this.Cat,
            this.cst});
            this.AdminDisplay.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminDisplay.HideSelection = false;
            this.AdminDisplay.Location = new System.Drawing.Point(19, 140);
            this.AdminDisplay.Name = "AdminDisplay";
            this.AdminDisplay.Size = new System.Drawing.Size(885, 317);
            this.AdminDisplay.TabIndex = 54;
            this.AdminDisplay.UseCompatibleStateImageBehavior = false;
            this.AdminDisplay.View = System.Windows.Forms.View.Details;
            // 
            // photo
            // 
            this.photo.Text = "Изображение";
            this.photo.Width = 127;
            // 
            // bran
            // 
            this.bran.Text = "Бренд";
            this.bran.Width = 66;
            // 
            // Cyear
            // 
            this.Cyear.Text = "Год выпуска";
            this.Cyear.Width = 115;
            // 
            // mat
            // 
            this.mat.Text = "Материал корпуса";
            this.mat.Width = 166;
            // 
            // bat
            // 
            this.bat.Text = "Батарея(мА/ч)";
            this.bat.Width = 132;
            // 
            // Cat
            // 
            this.Cat.Text = "Категория";
            this.Cat.Width = 93;
            // 
            // cst
            // 
            this.cst.Text = "Цена";
            // 
            // NewDataProduct
            // 
            this.NewDataProduct.Location = new System.Drawing.Point(406, 512);
            this.NewDataProduct.Multiline = true;
            this.NewDataProduct.Name = "NewDataProduct";
            this.NewDataProduct.Size = new System.Drawing.Size(379, 78);
            this.NewDataProduct.TabIndex = 55;
            this.NewDataProduct.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(468, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Введите новые данные";
            this.label3.Visible = false;
            // 
            // ChooseParamProd
            // 
            this.ChooseParamProd.FormattingEnabled = true;
            this.ChooseParamProd.Items.AddRange(new object[] {
            "Бренд",
            "Год",
            "Материал",
            "Батарея",
            "Категория",
            "Цена",
            "Колличество",
            "Фото"});
            this.ChooseParamProd.Location = new System.Drawing.Point(185, 566);
            this.ChooseParamProd.Name = "ChooseParamProd";
            this.ChooseParamProd.Size = new System.Drawing.Size(152, 24);
            this.ChooseParamProd.TabIndex = 57;
            this.ChooseParamProd.Visible = false;
            this.ChooseParamProd.SelectedIndexChanged += new System.EventHandler(this.ChooseParamProd_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(180, 527);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(174, 25);
            this.label.TabIndex = 58;
            this.label.Text = "Параметр товара";
            this.label.Visible = false;
            // 
            // OkBut
            // 
            this.OkBut.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBut.Location = new System.Drawing.Point(802, 512);
            this.OkBut.Name = "OkBut";
            this.OkBut.Size = new System.Drawing.Size(102, 78);
            this.OkBut.TabIndex = 59;
            this.OkBut.Text = "Ок";
            this.OkBut.UseVisualStyleBackColor = true;
            this.OkBut.Visible = false;
            this.OkBut.Click += new System.EventHandler(this.OkBut_Click);
            // 
            // ChangePhoto
            // 
            this.ChangePhoto.FileName = "ChangePhoto";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(916, 623);
            this.Controls.Add(this.OkBut);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ChooseParamProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewDataProduct);
            this.Controls.Add(this.AdminDisplay);
            this.Controls.Add(this.ChangeProd);
            this.Controls.Add(this.DelProd);
            this.Controls.Add(this.AddProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.ChooseProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChooseProduct;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProd;
        private System.Windows.Forms.Button DelProd;
        private System.Windows.Forms.Button ChangeProd;
        private System.Windows.Forms.ListView AdminDisplay;
        private System.Windows.Forms.ColumnHeader photo;
        private System.Windows.Forms.ColumnHeader bran;
        private System.Windows.Forms.ColumnHeader Cyear;
        private System.Windows.Forms.ColumnHeader mat;
        private System.Windows.Forms.ColumnHeader bat;
        private System.Windows.Forms.ColumnHeader Cat;
        private System.Windows.Forms.ColumnHeader cst;
        private System.Windows.Forms.TextBox NewDataProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ChooseParamProd;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button OkBut;
        private System.Windows.Forms.OpenFileDialog ChangePhoto;
    }
}