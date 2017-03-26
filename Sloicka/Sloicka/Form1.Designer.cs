namespace Sloicka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage_DataBase = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_del = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.textBox_Lang2 = new System.Windows.Forms.TextBox();
            this.textBox_Lang1 = new System.Windows.Forms.TextBox();
            this.tabPage_Practice = new System.Windows.Forms.TabPage();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.label_word = new System.Windows.Forms.Label();
            this.label_Deaths = new System.Windows.Forms.Label();
            this.label_Kills = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.tabPage_DataBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_Practice.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage_DataBase);
            this.TabControl.Controls.Add(this.tabPage_Practice);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(0, 0);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(666, 495);
            this.TabControl.TabIndex = 0;
            this.TabControl.TabStop = false;
            this.TabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl_Selecting);
            // 
            // tabPage_DataBase
            // 
            this.tabPage_DataBase.Controls.Add(this.label6);
            this.tabPage_DataBase.Controls.Add(this.label5);
            this.tabPage_DataBase.Controls.Add(this.btn_export);
            this.tabPage_DataBase.Controls.Add(this.btn_import);
            this.tabPage_DataBase.Controls.Add(this.btn_update);
            this.tabPage_DataBase.Controls.Add(this.label2);
            this.tabPage_DataBase.Controls.Add(this.label1);
            this.tabPage_DataBase.Controls.Add(this.dataGridView1);
            this.tabPage_DataBase.Controls.Add(this.btn_del);
            this.tabPage_DataBase.Controls.Add(this.Btn_Add);
            this.tabPage_DataBase.Controls.Add(this.textBox_Lang2);
            this.tabPage_DataBase.Controls.Add(this.textBox_Lang1);
            this.tabPage_DataBase.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DataBase.Name = "tabPage_DataBase";
            this.tabPage_DataBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DataBase.Size = new System.Drawing.Size(658, 469);
            this.tabPage_DataBase.TabIndex = 0;
            this.tabPage_DataBase.Text = "Database";
            this.tabPage_DataBase.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(492, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Comming soon ->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Comming soon ->";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(574, 442);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 10;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(575, 415);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 9;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_update
            // 
            this.btn_update.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_update.Location = new System.Drawing.Point(301, 438);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Language2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(642, 401);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(382, 438);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 4;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(220, 438);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 3;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // textBox_Lang2
            // 
            this.textBox_Lang2.Location = new System.Drawing.Point(113, 442);
            this.textBox_Lang2.Name = "textBox_Lang2";
            this.textBox_Lang2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Lang2.TabIndex = 2;
            // 
            // textBox_Lang1
            // 
            this.textBox_Lang1.Location = new System.Drawing.Point(6, 442);
            this.textBox_Lang1.Name = "textBox_Lang1";
            this.textBox_Lang1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Lang1.TabIndex = 1;
            // 
            // tabPage_Practice
            // 
            this.tabPage_Practice.Controls.Add(this.btn_Check);
            this.tabPage_Practice.Controls.Add(this.textBox_Answer);
            this.tabPage_Practice.Controls.Add(this.label_word);
            this.tabPage_Practice.Controls.Add(this.label_Deaths);
            this.tabPage_Practice.Controls.Add(this.label_Kills);
            this.tabPage_Practice.Controls.Add(this.label4);
            this.tabPage_Practice.Controls.Add(this.label3);
            this.tabPage_Practice.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Practice.Name = "tabPage_Practice";
            this.tabPage_Practice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Practice.Size = new System.Drawing.Size(658, 469);
            this.tabPage_Practice.TabIndex = 1;
            this.tabPage_Practice.Text = "Practice";
            this.tabPage_Practice.UseVisualStyleBackColor = true;
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Answer.Location = new System.Drawing.Point(6, 433);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(564, 30);
            this.textBox_Answer.TabIndex = 1;
            // 
            // label_word
            // 
            this.label_word.AutoSize = true;
            this.label_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_word.Location = new System.Drawing.Point(228, 131);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(244, 76);
            this.label_word.TabIndex = 4;
            this.label_word.Text = "WORD";
            // 
            // label_Deaths
            // 
            this.label_Deaths.AutoSize = true;
            this.label_Deaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Deaths.Location = new System.Drawing.Point(619, 26);
            this.label_Deaths.Name = "label_Deaths";
            this.label_Deaths.Size = new System.Drawing.Size(14, 13);
            this.label_Deaths.TabIndex = 3;
            this.label_Deaths.Text = "0";
            // 
            // label_Kills
            // 
            this.label_Kills.AutoSize = true;
            this.label_Kills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Kills.Location = new System.Drawing.Point(619, 7);
            this.label_Kills.Name = "label_Kills";
            this.label_Kills.Size = new System.Drawing.Size(14, 13);
            this.label_Kills.TabIndex = 2;
            this.label_Kills.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(567, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wrong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(567, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Right";
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(576, 439);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(75, 23);
            this.btn_Check.TabIndex = 11;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 496);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Erik\'s awesome trainer";
            this.TabControl.ResumeLayout(false);
            this.tabPage_DataBase.ResumeLayout(false);
            this.tabPage_DataBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_Practice.ResumeLayout(false);
            this.tabPage_Practice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage_DataBase;
        private System.Windows.Forms.TabPage tabPage_Practice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.TextBox textBox_Lang2;
        private System.Windows.Forms.TextBox textBox_Lang1;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.Label label_Deaths;
        private System.Windows.Forms.Label label_Kills;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Check;
    }
}

