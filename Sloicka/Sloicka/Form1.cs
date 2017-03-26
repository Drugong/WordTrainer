using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sloicka
{
    public partial class Form1 : Form
    {
        WordDataModel model = new WordDataModel();
        Random r = new Random();
        Word ActiveWord;
        bool IsLanguage1InLabel;

        private int right;
        public int Right
        {
            get { return right; }
            set { right = value; this.label_Kills.Text = right.ToString(); }
        }

        private int wrong;
        public int Wrong
        {
            get { return wrong; }
            set { wrong = value; this.label_Deaths.Text = wrong.ToString(); }
        }

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = this.textBox_Lang1;
            this.dataGridView1.DataSource = this.model;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Word w = GetWordFromTextbox();
            if (model.IsWordOriginal(w) && w != null)
                model.Add(w);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            model.Delete(this.dataGridView1.CurrentCell.RowIndex);
            this.textBox_Lang1.Text = "";
            this.textBox_Lang2.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Word w = model.GetWordByIndex(this.dataGridView1.CurrentCell.RowIndex);
            this.textBox_Lang1.Text = w.Language1;
            this.textBox_Lang2.Text = w.Language2;
        }

        private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //windows makes annoying sound when is not acceptbutton selected
            if (this.TabControl.SelectedTab == this.tabPage_Practice)
                this.AcceptButton = this.btn_Check;
            else
                this.AcceptButton = this.Btn_Add;
            //

            this.SetWordLabel();
        }

        public void SetWordLabel()
        {
            this.textBox_Answer.Text = "";

            int dataCount = model.ItemCount();
            if (dataCount > 1)
            {
                GiveMeRandomWord(dataCount);
                if (r.Next(0, 2) == 1)
                {
                    this.label_word.Text = ActiveWord.Language1;
                    this.IsLanguage1InLabel = true;
                }
                else
                {
                    this.label_word.Text = ActiveWord.Language2;
                    this.IsLanguage1InLabel = false;
                }
            }
        }

        public void GiveMeRandomWord(int dataCount)
        {
            Word w = model.GetWordByIndex(r.Next(0, dataCount));

            if (w != ActiveWord)
                this.ActiveWord = w;
            else
                GiveMeRandomWord(dataCount);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Word w = GetWordFromTextbox();
            this.model.Update(this.dataGridView1.CurrentCell.RowIndex, w);
            dataGridView1.Refresh();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {

        }

        private void btn_export_Click(object sender, EventArgs e)
        {

        }

        public Word GetWordFromTextbox()
        {
            string txt1 = this.textBox_Lang1.Text;
            string txt2 = this.textBox_Lang2.Text;
            this.textBox_Lang1.Text = "";
            this.textBox_Lang2.Text = "";

            if (!string.IsNullOrWhiteSpace(txt1) || !string.IsNullOrWhiteSpace(txt2))
                return new Word(txt1, txt2);
            else
                return null;
        }

        public bool CheckAnswer()
        {
            string answer = this.textBox_Answer.Text.ToLower();
            string lang1 = ActiveWord.Language1.ToLower();
            string lang2 = ActiveWord.Language2.ToLower();

            if (IsLanguage1InLabel)
            {
                if (answer == lang2)
                    return true;
            }
            else
            {
                if (answer == lang1)
                    return true;
            }
            return false;
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (CheckAnswer())
                Right++;
            else
                Wrong++;
            SetWordLabel();
        }
    }
}
