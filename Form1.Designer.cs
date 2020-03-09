namespace mod_reguest_websocket
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
            this.but_start_request = new System.Windows.Forms.Button();
            this.but_stop_request = new System.Windows.Forms.Button();
            this.but_pick_pair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_start_request
            // 
            this.but_start_request.Location = new System.Drawing.Point(389, 376);
            this.but_start_request.Name = "but_start_request";
            this.but_start_request.Size = new System.Drawing.Size(158, 62);
            this.but_start_request.TabIndex = 0;
            this.but_start_request.Text = "запросить";
            this.but_start_request.UseVisualStyleBackColor = true;
            this.but_start_request.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_stop_request
            // 
            this.but_stop_request.Location = new System.Drawing.Point(192, 376);
            this.but_stop_request.Name = "but_stop_request";
            this.but_stop_request.Size = new System.Drawing.Size(180, 62);
            this.but_stop_request.TabIndex = 1;
            this.but_stop_request.Text = "остановить";
            this.but_stop_request.UseVisualStyleBackColor = true;
            // 
            // but_pick_pair
            // 
            this.but_pick_pair.Location = new System.Drawing.Point(12, 376);
            this.but_pick_pair.Name = "but_pick_pair";
            this.but_pick_pair.Size = new System.Drawing.Size(147, 62);
            this.but_pick_pair.TabIndex = 2;
            this.but_pick_pair.Text = "выбрать пару";
            this.but_pick_pair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.but_pick_pair);
            this.Controls.Add(this.but_stop_request);
            this.Controls.Add(this.but_start_request);
            this.Name = "Form1";
            this.Text = "получение потока";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_start_request;
        private System.Windows.Forms.Button but_stop_request;
        private System.Windows.Forms.Button but_pick_pair;
    }
}

