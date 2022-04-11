
namespace WindowsFormsApp6
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
            this.makePaymentButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.transfersGridView = new System.Windows.Forms.DataGridView();
            this.paymentSumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // makePaymentButton
            // 
            this.makePaymentButton.Location = new System.Drawing.Point(12, 464);
            this.makePaymentButton.Name = "makePaymentButton";
            this.makePaymentButton.Size = new System.Drawing.Size(88, 30);
            this.makePaymentButton.TabIndex = 0;
            this.makePaymentButton.Text = "Оплатить";
            this.makePaymentButton.UseVisualStyleBackColor = true;
            this.makePaymentButton.Click += new System.EventHandler(this.makePaymentButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "ОК";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ordersGridView
            // 
            this.ordersGridView.AllowUserToAddRows = false;
            this.ordersGridView.AllowUserToDeleteRows = false;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Location = new System.Drawing.Point(12, 82);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            this.ordersGridView.RowHeadersWidth = 51;
            this.ordersGridView.RowTemplate.Height = 24;
            this.ordersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersGridView.Size = new System.Drawing.Size(620, 304);
            this.ordersGridView.TabIndex = 2;
            // 
            // transfersGridView
            // 
            this.transfersGridView.AllowUserToAddRows = false;
            this.transfersGridView.AllowUserToDeleteRows = false;
            this.transfersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transfersGridView.Location = new System.Drawing.Point(638, 82);
            this.transfersGridView.Name = "transfersGridView";
            this.transfersGridView.ReadOnly = true;
            this.transfersGridView.RowHeadersWidth = 51;
            this.transfersGridView.RowTemplate.Height = 24;
            this.transfersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transfersGridView.Size = new System.Drawing.Size(604, 304);
            this.transfersGridView.TabIndex = 3;
            // 
            // paymentSumTextBox
            // 
            this.paymentSumTextBox.Location = new System.Drawing.Point(12, 426);
            this.paymentSumTextBox.Name = "paymentSumTextBox";
            this.paymentSumTextBox.Size = new System.Drawing.Size(110, 22);
            this.paymentSumTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Заказы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Приход денег";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сумма платежа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Найти";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 22);
            this.textBox2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Найти";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(693, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 22);
            this.textBox3.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(838, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(919, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 538);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentSumTextBox);
            this.Controls.Add(this.transfersGridView);
            this.Controls.Add(this.ordersGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.makePaymentButton);
            this.Name = "Form1";
            this.Text = "Тестовое задание";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makePaymentButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.DataGridView transfersGridView;
        private System.Windows.Forms.TextBox paymentSumTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

