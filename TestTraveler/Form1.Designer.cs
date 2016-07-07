namespace TestTraveler
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbSortedItems = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbUnsortedItems = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bClose = new System.Windows.Forms.Button();
            this.bLoadCards = new System.Windows.Forms.Button();
            this.bSorted = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 504);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 504);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbSortedItems);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 244);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(531, 260);
            this.panel5.TabIndex = 2;
            // 
            // lbSortedItems
            // 
            this.lbSortedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSortedItems.FormattingEnabled = true;
            this.lbSortedItems.Location = new System.Drawing.Point(5, 5);
            this.lbSortedItems.Name = "lbSortedItems";
            this.lbSortedItems.Size = new System.Drawing.Size(521, 250);
            this.lbSortedItems.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbUnsortedItems);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(531, 244);
            this.panel4.TabIndex = 1;
            // 
            // lbUnsortedItems
            // 
            this.lbUnsortedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUnsortedItems.FormattingEnabled = true;
            this.lbUnsortedItems.Location = new System.Drawing.Point(5, 5);
            this.lbUnsortedItems.Name = "lbUnsortedItems";
            this.lbUnsortedItems.Size = new System.Drawing.Size(521, 234);
            this.lbUnsortedItems.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bSorted);
            this.panel2.Controls.Add(this.bClose);
            this.panel2.Controls.Add(this.bLoadCards);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(531, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 504);
            this.panel2.TabIndex = 0;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(9, 469);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(158, 23);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "Выход";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bLoadCards
            // 
            this.bLoadCards.Location = new System.Drawing.Point(9, 12);
            this.bLoadCards.Name = "bLoadCards";
            this.bLoadCards.Size = new System.Drawing.Size(158, 23);
            this.bLoadCards.TabIndex = 0;
            this.bLoadCards.Text = "Загрузить карточки";
            this.bLoadCards.UseVisualStyleBackColor = true;
            this.bLoadCards.Click += new System.EventHandler(this.bLoadCards_Click);
            // 
            // bSorted
            // 
            this.bSorted.Location = new System.Drawing.Point(9, 68);
            this.bSorted.Name = "bSorted";
            this.bSorted.Size = new System.Drawing.Size(158, 23);
            this.bSorted.TabIndex = 3;
            this.bSorted.Text = "Сортировка";
            this.bSorted.UseVisualStyleBackColor = true;
            this.bSorted.Click += new System.EventHandler(this.bSorted_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ТЕСТ - Сортировка карточек путешествий";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bLoadCards;
        private System.Windows.Forms.ListBox lbUnsortedItems;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lbSortedItems;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bSorted;
    }
}

