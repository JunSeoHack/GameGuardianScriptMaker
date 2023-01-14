namespace GameGuardianScriptMaker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HackModuleListBox = new System.Windows.Forms.ListBox();
            this.HackModule_Plus = new System.Windows.Forms.Button();
            this.HackModule_Minus = new System.Windows.Forms.Button();
            this.HackModuleName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SetRange_comboBox = new System.Windows.Forms.ComboBox();
            this.SearchNumber_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Type_comboBox = new System.Windows.Forms.ComboBox();
            this.GetResult_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RefindNumber_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.EditAll_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Message_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ScriptOutput_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // HackModuleListBox
            // 
            this.HackModuleListBox.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HackModuleListBox.FormattingEnabled = true;
            this.HackModuleListBox.ItemHeight = 18;
            this.HackModuleListBox.Location = new System.Drawing.Point(12, 22);
            this.HackModuleListBox.Name = "HackModuleListBox";
            this.HackModuleListBox.Size = new System.Drawing.Size(180, 472);
            this.HackModuleListBox.TabIndex = 2;
            this.HackModuleListBox.SelectedIndexChanged += new System.EventHandler(this.HackModuleListBox_SelectedIndexChanged);
            // 
            // HackModule_Plus
            // 
            this.HackModule_Plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.HackModule_Plus.Location = new System.Drawing.Point(12, 501);
            this.HackModule_Plus.Name = "HackModule_Plus";
            this.HackModule_Plus.Size = new System.Drawing.Size(30, 30);
            this.HackModule_Plus.TabIndex = 3;
            this.HackModule_Plus.Text = "+";
            this.HackModule_Plus.UseVisualStyleBackColor = false;
            this.HackModule_Plus.Click += new System.EventHandler(this.HackModule_Plus_Click);
            // 
            // HackModule_Minus
            // 
            this.HackModule_Minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.HackModule_Minus.Location = new System.Drawing.Point(162, 498);
            this.HackModule_Minus.Name = "HackModule_Minus";
            this.HackModule_Minus.Size = new System.Drawing.Size(30, 30);
            this.HackModule_Minus.TabIndex = 4;
            this.HackModule_Minus.Text = "-";
            this.HackModule_Minus.UseVisualStyleBackColor = false;
            this.HackModule_Minus.Click += new System.EventHandler(this.HackModule_Minus_Click);
            // 
            // HackModuleName_textBox
            // 
            this.HackModuleName_textBox.Enabled = false;
            this.HackModuleName_textBox.Font = new System.Drawing.Font("메이플스토리", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HackModuleName_textBox.Location = new System.Drawing.Point(6, 33);
            this.HackModuleName_textBox.Name = "HackModuleName_textBox";
            this.HackModuleName_textBox.Size = new System.Drawing.Size(165, 24);
            this.HackModuleName_textBox.TabIndex = 0;
            this.HackModuleName_textBox.TextChanged += new System.EventHandler(this.HackModuleName_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "HackModuleName ";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HackModuleName_textBox);
            this.panel1.Location = new System.Drawing.Point(210, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 60);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "SetRange ";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SetRange_comboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(210, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 60);
            this.panel2.TabIndex = 9;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // SetRange_comboBox
            // 
            this.SetRange_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SetRange_comboBox.Enabled = false;
            this.SetRange_comboBox.Font = new System.Drawing.Font("메이플스토리", 11.25F);
            this.SetRange_comboBox.FormattingEnabled = true;
            this.SetRange_comboBox.Items.AddRange(new object[] {
            "JAVA_HEAP",
            "C_HEAP",
            "C_ALLOC",
            "C_DATA",
            "C_BSS",
            "PPSSPP",
            "ANONYMOUS",
            "JAVA",
            "STACK",
            "ASHMEM",
            "VIDEO",
            "OTHER",
            "BAD",
            "CODE_APP",
            "CODE_SYS"});
            this.SetRange_comboBox.Location = new System.Drawing.Point(6, 33);
            this.SetRange_comboBox.Name = "SetRange_comboBox";
            this.SetRange_comboBox.Size = new System.Drawing.Size(165, 25);
            this.SetRange_comboBox.TabIndex = 8;
            this.SetRange_comboBox.SelectionChangeCommitted += new System.EventHandler(this.SetRange_comboBox_SelectionChangeCommitted);
            // 
            // SearchNumber_textBox
            // 
            this.SearchNumber_textBox.Enabled = false;
            this.SearchNumber_textBox.Font = new System.Drawing.Font("메이플스토리", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchNumber_textBox.Location = new System.Drawing.Point(6, 33);
            this.SearchNumber_textBox.Name = "SearchNumber_textBox";
            this.SearchNumber_textBox.Size = new System.Drawing.Size(165, 24);
            this.SearchNumber_textBox.TabIndex = 5;
            this.SearchNumber_textBox.TextChanged += new System.EventHandler(this.SearchNumber_textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "SearchNumber ";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.SearchNumber_textBox);
            this.panel3.Location = new System.Drawing.Point(210, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 60);
            this.panel3.TabIndex = 9;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type ";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Type_comboBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(210, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 60);
            this.panel4.TabIndex = 9;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // Type_comboBox
            // 
            this.Type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_comboBox.Enabled = false;
            this.Type_comboBox.Font = new System.Drawing.Font("메이플스토리", 11.25F);
            this.Type_comboBox.FormattingEnabled = true;
            this.Type_comboBox.Items.AddRange(new object[] {
            "Auto",
            "Dword",
            "Float",
            "Doubel",
            "Word",
            "Byte",
            "Qword",
            "Xor"});
            this.Type_comboBox.Location = new System.Drawing.Point(6, 33);
            this.Type_comboBox.Name = "Type_comboBox";
            this.Type_comboBox.Size = new System.Drawing.Size(165, 25);
            this.Type_comboBox.TabIndex = 9;
            this.Type_comboBox.SelectionChangeCommitted += new System.EventHandler(this.Type_comboBox_SelectionChangeCommitted);
            // 
            // GetResult_textBox
            // 
            this.GetResult_textBox.Enabled = false;
            this.GetResult_textBox.Font = new System.Drawing.Font("메이플스토리", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GetResult_textBox.Location = new System.Drawing.Point(6, 33);
            this.GetResult_textBox.Name = "GetResult_textBox";
            this.GetResult_textBox.Size = new System.Drawing.Size(165, 24);
            this.GetResult_textBox.TabIndex = 5;
            this.GetResult_textBox.TextChanged += new System.EventHandler(this.GetResult_textBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "GetResult ";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.GetResult_textBox);
            this.panel5.Location = new System.Drawing.Point(210, 276);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 60);
            this.panel5.TabIndex = 9;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // RefindNumber_textBox
            // 
            this.RefindNumber_textBox.Enabled = false;
            this.RefindNumber_textBox.Font = new System.Drawing.Font("메이플스토리", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RefindNumber_textBox.Location = new System.Drawing.Point(6, 33);
            this.RefindNumber_textBox.Name = "RefindNumber_textBox";
            this.RefindNumber_textBox.Size = new System.Drawing.Size(165, 24);
            this.RefindNumber_textBox.TabIndex = 5;
            this.RefindNumber_textBox.TextChanged += new System.EventHandler(this.RefindNumber_textBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "RefindNumber ";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.RefindNumber_textBox);
            this.panel6.Location = new System.Drawing.Point(210, 342);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 60);
            this.panel6.TabIndex = 10;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // EditAll_textbox
            // 
            this.EditAll_textbox.Enabled = false;
            this.EditAll_textbox.Font = new System.Drawing.Font("메이플스토리", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EditAll_textbox.Location = new System.Drawing.Point(6, 33);
            this.EditAll_textbox.Name = "EditAll_textbox";
            this.EditAll_textbox.Size = new System.Drawing.Size(165, 24);
            this.EditAll_textbox.TabIndex = 5;
            this.EditAll_textbox.TextChanged += new System.EventHandler(this.EditAll_textbox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "EditAll ";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.EditAll_textbox);
            this.panel7.Location = new System.Drawing.Point(210, 408);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 60);
            this.panel7.TabIndex = 11;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // Message_textBox
            // 
            this.Message_textBox.Enabled = false;
            this.Message_textBox.Font = new System.Drawing.Font("메이플스토리", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Message_textBox.Location = new System.Drawing.Point(6, 33);
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.Size = new System.Drawing.Size(165, 24);
            this.Message_textBox.TabIndex = 5;
            this.Message_textBox.TextChanged += new System.EventHandler(this.Message_textBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Message ";
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.Message_textBox);
            this.panel8.Location = new System.Drawing.Point(210, 474);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(175, 60);
            this.panel8.TabIndex = 11;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            // 
            // ScriptOutput_button
            // 
            this.ScriptOutput_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.ScriptOutput_button.CausesValidation = false;
            this.ScriptOutput_button.Location = new System.Drawing.Point(12, 559);
            this.ScriptOutput_button.Name = "ScriptOutput_button";
            this.ScriptOutput_button.Size = new System.Drawing.Size(373, 34);
            this.ScriptOutput_button.TabIndex = 12;
            this.ScriptOutput_button.Text = "Script Output";
            this.ScriptOutput_button.UseVisualStyleBackColor = false;
            this.ScriptOutput_button.Click += new System.EventHandler(this.ScriptOutput_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(397, 605);
            this.Controls.Add(this.ScriptOutput_button);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HackModule_Minus);
            this.Controls.Add(this.HackModule_Plus);
            this.Controls.Add(this.HackModuleListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "GameGuardian Script Maker";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox HackModuleListBox;
        private System.Windows.Forms.Button HackModule_Plus;
        private System.Windows.Forms.Button HackModule_Minus;
        private System.Windows.Forms.TextBox HackModuleName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchNumber_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox GetResult_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox RefindNumber_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox EditAll_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox Message_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox SetRange_comboBox;
        private System.Windows.Forms.ComboBox Type_comboBox;
        private System.Windows.Forms.Button ScriptOutput_button;
    }
}

