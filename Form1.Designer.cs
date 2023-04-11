namespace lists
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
            this.components = new System.ComponentModel.Container();
            this.lb_1 = new System.Windows.Forms.ListBox();
            this.lb_2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.ch_ListBox1 = new System.Windows.Forms.CheckedListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar_red = new System.Windows.Forms.TrackBar();
            this.trackBar_green = new System.Windows.Forms.TrackBar();
            this.trackBar_blue = new System.Windows.Forms.TrackBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.lb_1.FormattingEnabled = true;
            this.lb_1.ItemHeight = 20;
            this.lb_1.Location = new System.Drawing.Point(2, 3);
            this.lb_1.Name = "lb_1";
            this.lb_1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_1.Size = new System.Drawing.Size(176, 224);
            this.lb_1.TabIndex = 0;
            // 
            // lb_2
            // 
            this.lb_2.FormattingEnabled = true;
            this.lb_2.ItemHeight = 20;
            this.lb_2.Location = new System.Drawing.Point(196, 3);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(176, 224);
            this.lb_2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 26);
            this.textBox1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox1, "введите элемент списка\r\n\r\n\r\n");
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(2, 279);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(119, 31);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(2, 316);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(119, 31);
            this.button_copy.TabIndex = 4;
            this.button_copy.Text = "copy";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(2, 363);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(116, 31);
            this.button_remove.TabIndex = 5;
            this.button_remove.Text = "remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // ch_ListBox1
            // 
            this.ch_ListBox1.CheckOnClick = true;
            this.ch_ListBox1.FormattingEnabled = true;
            this.ch_ListBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ch_ListBox1.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight"});
            this.ch_ListBox1.Location = new System.Drawing.Point(378, 28);
            this.ch_ListBox1.MultiColumn = true;
            this.ch_ListBox1.Name = "ch_ListBox1";
            this.ch_ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ch_ListBox1.Size = new System.Drawing.Size(250, 142);
            this.ch_ListBox1.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(634, 28);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(226, 38);
            this.progressBar1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(195, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 48);
            this.label1.TabIndex = 9;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(378, 176);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(102, 36);
            this.button_start.TabIndex = 10;
            this.button_start.Text = "start";
            this.toolTip1.SetToolTip(this.button_start, "нажмите для запуска\r\n");
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 138;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 50);
            this.label2.TabIndex = 13;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 50);
            this.label3.TabIndex = 14;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 50);
            this.label4.TabIndex = 15;
            this.label4.Text = "B";
            // 
            // trackBar_red
            // 
            this.trackBar_red.LargeChange = 1;
            this.trackBar_red.Location = new System.Drawing.Point(530, 279);
            this.trackBar_red.Maximum = 255;
            this.trackBar_red.Name = "trackBar_red";
            this.trackBar_red.Size = new System.Drawing.Size(358, 69);
            this.trackBar_red.TabIndex = 16;
            this.trackBar_red.Scroll += new System.EventHandler(this.trackBar_red_Scroll);
            // 
            // trackBar_green
            // 
            this.trackBar_green.LargeChange = 1;
            this.trackBar_green.Location = new System.Drawing.Point(530, 363);
            this.trackBar_green.Maximum = 255;
            this.trackBar_green.Name = "trackBar_green";
            this.trackBar_green.Size = new System.Drawing.Size(358, 69);
            this.trackBar_green.TabIndex = 17;
            this.trackBar_green.Scroll += new System.EventHandler(this.trackBar_green_Scroll);
            // 
            // trackBar_blue
            // 
            this.trackBar_blue.LargeChange = 1;
            this.trackBar_blue.Location = new System.Drawing.Point(530, 460);
            this.trackBar_blue.Maximum = 255;
            this.trackBar_blue.Name = "trackBar_blue";
            this.trackBar_blue.Size = new System.Drawing.Size(358, 69);
            this.trackBar_blue.TabIndex = 18;
            this.trackBar_blue.Scroll += new System.EventHandler(this.trackBar_blue_Scroll);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(196, 304);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 109);
            this.textBox2.TabIndex = 19;
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(196, 440);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(94, 34);
            this.button_load.TabIndex = 20;
            this.button_load.Text = "load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(319, 441);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(91, 33);
            this.button_save.TabIndex = 21;
            this.button_save.Text = "save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 565);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.trackBar_blue);
            this.Controls.Add(this.trackBar_green);
            this.Controls.Add(this.trackBar_red);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ch_ListBox1);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_1;
        private System.Windows.Forms.ListBox lb_2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.CheckedListBox ch_ListBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar_red;
        private System.Windows.Forms.TrackBar trackBar_green;
        private System.Windows.Forms.TrackBar trackBar_blue;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_save;
    }
}

