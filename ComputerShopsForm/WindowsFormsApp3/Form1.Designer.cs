namespace WindowsFormsApp3
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
            this.listBoxCPU = new System.Windows.Forms.ListBox();
            this.listBoxMotherBoard = new System.Windows.Forms.ListBox();
            this.listBoxHardDrive = new System.Windows.Forms.ListBox();
            this.listBoxRam = new System.Windows.Forms.ListBox();
            this.sortCpu = new System.Windows.Forms.Button();
            this.sortMotherboard = new System.Windows.Forms.Button();
            this.sortHD = new System.Windows.Forms.Button();
            this.sortRam = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCPU
            // 
            this.listBoxCPU.FormattingEnabled = true;
            this.listBoxCPU.Location = new System.Drawing.Point(38, 57);
            this.listBoxCPU.Name = "listBoxCPU";
            this.listBoxCPU.Size = new System.Drawing.Size(205, 290);
            this.listBoxCPU.TabIndex = 0;
            // 
            // listBoxMotherBoard
            // 
            this.listBoxMotherBoard.FormattingEnabled = true;
            this.listBoxMotherBoard.Location = new System.Drawing.Point(321, 57);
            this.listBoxMotherBoard.Name = "listBoxMotherBoard";
            this.listBoxMotherBoard.Size = new System.Drawing.Size(205, 290);
            this.listBoxMotherBoard.TabIndex = 1;
            // 
            // listBoxHardDrive
            // 
            this.listBoxHardDrive.FormattingEnabled = true;
            this.listBoxHardDrive.Location = new System.Drawing.Point(604, 57);
            this.listBoxHardDrive.Name = "listBoxHardDrive";
            this.listBoxHardDrive.Size = new System.Drawing.Size(205, 290);
            this.listBoxHardDrive.TabIndex = 2;
            // 
            // listBoxRam
            // 
            this.listBoxRam.FormattingEnabled = true;
            this.listBoxRam.Location = new System.Drawing.Point(885, 57);
            this.listBoxRam.Name = "listBoxRam";
            this.listBoxRam.Size = new System.Drawing.Size(205, 290);
            this.listBoxRam.TabIndex = 3;
            // 
            // sortCpu
            // 
            this.sortCpu.Location = new System.Drawing.Point(39, 369);
            this.sortCpu.Name = "sortCpu";
            this.sortCpu.Size = new System.Drawing.Size(203, 26);
            this.sortCpu.TabIndex = 4;
            this.sortCpu.Text = "Sort";
            this.sortCpu.UseVisualStyleBackColor = true;
            this.sortCpu.Click += new System.EventHandler(this.sortCpu_Click);
            // 
            // sortMotherboard
            // 
            this.sortMotherboard.Location = new System.Drawing.Point(321, 369);
            this.sortMotherboard.Name = "sortMotherboard";
            this.sortMotherboard.Size = new System.Drawing.Size(203, 26);
            this.sortMotherboard.TabIndex = 5;
            this.sortMotherboard.Text = "Sort";
            this.sortMotherboard.UseVisualStyleBackColor = true;
            this.sortMotherboard.Click += new System.EventHandler(this.sortMotherboard_Click);
            // 
            // sortHD
            // 
            this.sortHD.Location = new System.Drawing.Point(604, 369);
            this.sortHD.Name = "sortHD";
            this.sortHD.Size = new System.Drawing.Size(203, 26);
            this.sortHD.TabIndex = 6;
            this.sortHD.Text = "Sort";
            this.sortHD.UseVisualStyleBackColor = true;
            this.sortHD.Click += new System.EventHandler(this.sortHD_Click);
            // 
            // sortRam
            // 
            this.sortRam.Location = new System.Drawing.Point(885, 369);
            this.sortRam.Name = "sortRam";
            this.sortRam.Size = new System.Drawing.Size(203, 26);
            this.sortRam.TabIndex = 7;
            this.sortRam.Text = "Sort";
            this.sortRam.UseVisualStyleBackColor = true;
            this.sortRam.Click += new System.EventHandler(this.sortRam_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1163, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 72);
            this.button1.TabIndex = 8;
            this.button1.Text = "Get price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sortRam);
            this.Controls.Add(this.sortHD);
            this.Controls.Add(this.sortMotherboard);
            this.Controls.Add(this.sortCpu);
            this.Controls.Add(this.listBoxRam);
            this.Controls.Add(this.listBoxHardDrive);
            this.Controls.Add(this.listBoxMotherBoard);
            this.Controls.Add(this.listBoxCPU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCPU;
        private System.Windows.Forms.ListBox listBoxMotherBoard;
        private System.Windows.Forms.ListBox listBoxHardDrive;
        private System.Windows.Forms.ListBox listBoxRam;
        private System.Windows.Forms.Button sortCpu;
        private System.Windows.Forms.Button sortMotherboard;
        private System.Windows.Forms.Button sortHD;
        private System.Windows.Forms.Button sortRam;
        private System.Windows.Forms.Button button1;
    }
}

