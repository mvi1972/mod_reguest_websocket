using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModReguestWebsocket
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
            this.textBox_para = new System.Windows.Forms.TextBox();
            this.textBox_data_websocket = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.but_start_request.Click += new System.EventHandler(this.But_start_request_Click);
            // 
            // but_stop_request
            // 
            this.but_stop_request.Location = new System.Drawing.Point(192, 376);
            this.but_stop_request.Name = "but_stop_request";
            this.but_stop_request.Size = new System.Drawing.Size(180, 62);
            this.but_stop_request.TabIndex = 1;
            this.but_stop_request.Text = "остановить";
            this.but_stop_request.UseVisualStyleBackColor = true;
            this.but_stop_request.Click += new System.EventHandler(this.But_stop_request_click);
            // 
            // but_pick_pair
            // 
            this.but_pick_pair.Location = new System.Drawing.Point(12, 376);
            this.but_pick_pair.Name = "but_pick_pair";
            this.but_pick_pair.Size = new System.Drawing.Size(147, 62);
            this.but_pick_pair.TabIndex = 2;
            this.but_pick_pair.Text = "выбрать пару";
            this.but_pick_pair.UseVisualStyleBackColor = true;
            this.but_pick_pair.Click += new System.EventHandler(this.But_pick_pair_click);
            // 
            // textBox_para
            // 
            this.textBox_para.Location = new System.Drawing.Point(12, 338);
            this.textBox_para.Name = "textBox_para";
            this.textBox_para.Size = new System.Drawing.Size(146, 22);
            this.textBox_para.TabIndex = 3;
            this.textBox_para.Text = "введите пару";
            // 
            // textBox_data_websocket
            // 
            this.textBox_data_websocket.Location = new System.Drawing.Point(12, 36);
            this.textBox_data_websocket.Multiline = true;
            this.textBox_data_websocket.Name = "textBox_data_websocket";
            this.textBox_data_websocket.Size = new System.Drawing.Size(535, 235);
            this.textBox_data_websocket.TabIndex = 4;
            this.textBox_data_websocket.Text = "данные потока";
            this.textBox_data_websocket.TextChanged += new System.EventHandler(this.textBox_data_websocket_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(389, 318);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 454);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_data_websocket);
            this.Controls.Add(this.textBox_para);
            this.Controls.Add(this.but_pick_pair);
            this.Controls.Add(this.but_stop_request);
            this.Controls.Add(this.but_start_request);
            this.Name = "Form1";
            this.Text = "получение потока";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void But_stop_request_click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button but_start_request;
        private System.Windows.Forms.Button but_stop_request;
        private System.Windows.Forms.Button but_pick_pair;
        private System.Windows.Forms.TextBox textBox_para;
        private System.Windows.Forms.TextBox textBox_data_websocket;
        private ComboBox comboBox1;
    }
}

