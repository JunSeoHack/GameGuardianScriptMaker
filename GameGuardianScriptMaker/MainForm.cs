using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GameGuardianScriptMaker
{
    public partial class MainForm : Form
    {
        List<HackModule> HackModuleList = new List<HackModule>();
        const string ScriptMakeName = "JunSeo";

        public MainForm()
        {
            InitializeComponent();
        }
        private void HackModule_Plus_Click(object sender, EventArgs e)
        {
            HackModule Hm = new HackModule();
            HackModuleList.Add(Hm);
            HackModuleListBox.Items.Add("HackModule" + HackModuleList.Count);
        }

        private void HackModule_Minus_Click(object sender, EventArgs e)
        {
            if (HackModuleListBox.SelectedIndex > -1)
            {
                if (MessageBox.Show("선택하신 항목을 정말 삭제할까요?", "GameGuardian Script Maker", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    HackModuleList.RemoveAt(HackModuleListBox.SelectedIndex);
                    HackModuleListBox.Items.RemoveAt(HackModuleListBox.SelectedIndex);
                }
            }
        }

        private void ScriptOutput_button_Click(object sender, EventArgs e)
        {
            if (HackModuleList.Count > 0)
            {
                bool IsDone = true;
                for (int i = 0; i < HackModuleList.Count; i++)
                {
                    bool HackModuleIsdone = true;
                    if (HackModuleList[i].HackModuleName == "" || HackModuleList[i].HackModuleName == null)
                    {
                        IsDone = false;
                        HackModuleIsdone = false;
                    }
                    if (HackModuleList[i].SetRange == null) // 콤보 박스
                    {
                        IsDone = false;
                        HackModuleIsdone = false;
                    }
                    if (HackModuleList[i].SearchNumber == "" || HackModuleList[i].SearchNumber == null)
                    {
                        IsDone = false;
                        HackModuleIsdone = false;
                    }
                    if (HackModuleList[i].Type == null) // 콤보박스
                    {
                        IsDone = false;
                        HackModuleIsdone = false;
                    }
                    if (HackModuleList[i].GetResult == "" || HackModuleList[i].GetResult == null)
                    {
                        IsDone = false;
                        HackModuleIsdone = false;
                    }
                    if (HackModuleList[i].RefindNumber == "" || HackModuleList[i].RefindNumber == null)
                    {
                        IsDone = false;
                        HackModuleIsdone = false;
                    }
                    if (HackModuleList[i].EditAll == "" || HackModuleList[i].EditAll == null)
                    {
                        IsDone = false;
                        HackModuleIsdone = false;
                    }
                    if (HackModuleList[i].Message == "" || HackModuleList[i].Message == null)
                    {
                        IsDone = false;
                        HackModuleIsdone = false;
                    }

                    if(!HackModuleIsdone)
                    {
                        MessageBox.Show(HackModuleListBox.Items[i] + "에 비어 있는 항목이 있습니다.", "GameGuardian Script Maker");
                    }
                }

                if (IsDone)
                {
                    string ScriptText = "function main()\n";
                    ScriptText += "PO = gg.choice({";
                    for (int i = 0; i < HackModuleList.Count; i++)
                    {
                        ScriptText += "\"" + HackModuleList[i].HackModuleName + "\", ";
                    }
                    ScriptText += "\"Exit\"";
                    ScriptText += "}, nil, '" + ScriptMakeName + "')";
                    ScriptText += "\n";

                    for (int i = 0; i < HackModuleList.Count; i++)
                    {
                        ScriptText += "if PO == " + (i + 1).ToString() + " then Hack" + (i + 1).ToString() + "() end";
                        ScriptText += "\n";
                    }
                    ScriptText += "if PO == " + (HackModuleList.Count+1).ToString() + " then Exit() end";
                    ScriptText += "\n";

                    ScriptText += "mai=-1" + "\n";
                    ScriptText += "end" + "\n";
                    ScriptText += "\n";

                    for (int i = 0; i < HackModuleList.Count; i++)
                    {
                        ScriptText += "function Hack" + (i + 1).ToString() + "()";
                        ScriptText += "\n";

                        ScriptText += "gg.clearResults()";
                        ScriptText += "\n";
                        ScriptText += "gg.setRanges(gg.REGION_" + HackModuleList[i].SetRange + ")";
                        ScriptText += "\n";
                        ScriptText += "gg.searchNumber('" + HackModuleList[i].SearchNumber + "',gg.TYPE_" + HackModuleList[i].Type.ToUpper() + ")";
                        ScriptText += "\n";
                        ScriptText += "gg.refineNumber('" + HackModuleList[i].RefindNumber + "',gg.TYPE_" + HackModuleList[i].Type.ToUpper() + ")";
                        ScriptText += "\n";
                        ScriptText += "gg.getResults(\"" + HackModuleList[i].GetResult + "\")";
                        ScriptText += "\n";
                        ScriptText += "gg.editAll(\"" + HackModuleList[i].EditAll + "\", gg.TYPE_" + HackModuleList[i].Type.ToUpper() + ")";
                        ScriptText += "\n";
                        ScriptText += "gg.clearResults()";
                        ScriptText += "\n";
                        ScriptText += "gg.toast('" + HackModuleList[i].Message + "')";
                        ScriptText += "\n";

                        ScriptText += "end";
                        ScriptText += "\n";
                        ScriptText += "\n";
                    }

                    ScriptText += "function Exit()";
                    ScriptText += "\n";
                    ScriptText += "os.exit()";
                    ScriptText += "\n";
                    ScriptText += "end";
                    ScriptText += "\n\n";

                    ScriptText += "while(true)";
                    ScriptText += "\n";
                    ScriptText += "do";
                    ScriptText += "\n";
                    ScriptText += "if gg.isVisible(true) then";
                    ScriptText += "\n";
                    ScriptText += "mai=1";
                    ScriptText += "\n";
                    ScriptText += "gg.setVisible(false)";
                    ScriptText += "\n";
                    ScriptText += "end";
                    ScriptText += "\n";
                    ScriptText += "if mai==1 then";
                    ScriptText += "\n";
                    ScriptText += "main()";
                    ScriptText += "\n";
                    ScriptText += "end";
                    ScriptText += "\n";
                    ScriptText += "end";
                    ScriptText += "\n";
                    MessageBox.Show(ScriptText);
                    System.Windows.Forms.Clipboard.SetText(ScriptText);
                }
            }
            else
            {
                MessageBox.Show("최소한 한 개의 모듈은 있어야 합니다.", "GameGuardian Script Maker");
            }
        }

        private void HackModuleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HackModuleListBox.SelectedIndex > -1) //  선택되어 있다면
            {
                HackModuleName_textBox.Enabled = true;
                SetRange_comboBox.Enabled = true;
                SearchNumber_textBox.Enabled = true;
                Type_comboBox.Enabled = true;
                GetResult_textBox.Enabled = true;
                RefindNumber_textBox.Enabled = true;
                EditAll_textbox.Enabled = true;
                Message_textBox.Enabled = true;
                HackModuleName_textBox.Text = HackModuleList[HackModuleListBox.SelectedIndex].HackModuleName;
                SetRange_comboBox.Text = HackModuleList[HackModuleListBox.SelectedIndex].SetRange;
                SearchNumber_textBox.Text = HackModuleList[HackModuleListBox.SelectedIndex].SearchNumber;
                Type_comboBox.Text = HackModuleList[HackModuleListBox.SelectedIndex].Type;
                GetResult_textBox.Text = HackModuleList[HackModuleListBox.SelectedIndex].GetResult;
                RefindNumber_textBox.Text = HackModuleList[HackModuleListBox.SelectedIndex].RefindNumber;
                EditAll_textbox.Text = HackModuleList[HackModuleListBox.SelectedIndex].EditAll;
                Message_textBox.Text = HackModuleList[HackModuleListBox.SelectedIndex].Message;
            }
            else
            {
                HackModuleName_textBox.Enabled = false;
                SetRange_comboBox.Enabled = false;
                SearchNumber_textBox.Enabled = false;
                Type_comboBox.Enabled = false;
                GetResult_textBox.Enabled = false;
                RefindNumber_textBox.Enabled = false;
                EditAll_textbox.Enabled = false;
                Message_textBox.Enabled = false;

                HackModuleName_textBox.Text = "";
                SetRange_comboBox.SelectedIndex = -1;
                SearchNumber_textBox.Text = "";
                Type_comboBox.SelectedIndex = -1;
                GetResult_textBox.Text = "";
                RefindNumber_textBox.Text = "";
                EditAll_textbox.Text = "";
                Message_textBox.Text = "";
            }
        }

        private void HackModuleName_textBox_TextChanged(object sender, EventArgs e)
        {
            if (HackModuleListBox.SelectedIndex > -1)
            {
                HackModuleList[HackModuleListBox.SelectedIndex].HackModuleName = HackModuleName_textBox.Text;
                //HackModuleListBox.Items[HackModuleListBox.SelectedIndex] = HackModuleName_textBox.Text;
            }
        }
        private void SetRange_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (HackModuleListBox.SelectedIndex > -1)
            {
                HackModuleList[HackModuleListBox.SelectedIndex].SetRange = SetRange_comboBox.Text;
            }
        }

        private void SearchNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            if (HackModuleListBox.SelectedIndex > -1)
            {
                HackModuleList[HackModuleListBox.SelectedIndex].SearchNumber = SearchNumber_textBox.Text;
            }
        }

        private void Type_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (HackModuleListBox.SelectedIndex > -1)
            {
                HackModuleList[HackModuleListBox.SelectedIndex].Type = Type_comboBox.Text;
            }
        }

        private void GetResult_textBox_TextChanged(object sender, EventArgs e)
        {
            if (HackModuleListBox.SelectedIndex > -1)
            {
                HackModuleList[HackModuleListBox.SelectedIndex].GetResult = GetResult_textBox.Text;
            }
        }

        private void RefindNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            if (HackModuleListBox.SelectedIndex > -1)
            {
                HackModuleList[HackModuleListBox.SelectedIndex].RefindNumber = RefindNumber_textBox.Text;
            }
        }

        private void EditAll_textbox_TextChanged(object sender, EventArgs e)
        {
            if (HackModuleListBox.SelectedIndex > -1)
            {
                HackModuleList[HackModuleListBox.SelectedIndex].EditAll = EditAll_textbox.Text;
            }
        }

        private void Message_textBox_TextChanged(object sender, EventArgs e)
        {
            if (HackModuleListBox.SelectedIndex > -1)
            {
                HackModuleList[HackModuleListBox.SelectedIndex].Message = Message_textBox.Text;
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Event_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
