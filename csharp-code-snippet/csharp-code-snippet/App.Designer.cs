﻿namespace csharp_code_snippet
{
    partial class App
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSortDictionary1 = new System.Windows.Forms.Button();
            this.btnSortDictionary2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 533);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSortDictionary2);
            this.tabPage1.Controls.Add(this.btnSortDictionary1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Snippet 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSortDictionary1
            // 
            this.btnSortDictionary1.Location = new System.Drawing.Point(9, 13);
            this.btnSortDictionary1.Name = "btnSortDictionary1";
            this.btnSortDictionary1.Size = new System.Drawing.Size(161, 32);
            this.btnSortDictionary1.TabIndex = 0;
            this.btnSortDictionary1.Text = "DictionarySort-1";
            this.btnSortDictionary1.UseVisualStyleBackColor = true;
            this.btnSortDictionary1.Click += new System.EventHandler(this.btnSortDictionary_Click);
            // 
            // btnSortDictionary2
            // 
            this.btnSortDictionary2.Location = new System.Drawing.Point(9, 51);
            this.btnSortDictionary2.Name = "btnSortDictionary2";
            this.btnSortDictionary2.Size = new System.Drawing.Size(161, 32);
            this.btnSortDictionary2.TabIndex = 1;
            this.btnSortDictionary2.Text = "DictionarySort-2";
            this.btnSortDictionary2.UseVisualStyleBackColor = true;
            this.btnSortDictionary2.Click += new System.EventHandler(this.btnSortDictionary2_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "App";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSortDictionary1;
        private System.Windows.Forms.Button btnSortDictionary2;
    }
}
