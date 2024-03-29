﻿namespace WinFormTest03_Paint
{
    partial class frmPaint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.홈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuErase = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.동작테스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestSine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.홈ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.동작테스트ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(138, 22);
            this.mnuNew.Text = "새로 만들기";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuOpen.Text = "열기";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(138, 22);
            this.mnuSave.Text = "저장";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(138, 22);
            this.mnuExit.Text = "끝내기";
            // 
            // 홈ToolStripMenuItem
            // 
            this.홈ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDraw,
            this.mnuLine,
            this.mnuRect,
            this.mnuCircle,
            this.mnuText,
            this.toolStripMenuItem2,
            this.mnuErase});
            this.홈ToolStripMenuItem.Name = "홈ToolStripMenuItem";
            this.홈ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.홈ToolStripMenuItem.Text = "그리기";
            // 
            // mnuDraw
            // 
            this.mnuDraw.Name = "mnuDraw";
            this.mnuDraw.Size = new System.Drawing.Size(150, 22);
            this.mnuDraw.Text = "연필그리기";
            this.mnuDraw.Click += new System.EventHandler(this.mnuDraw_Click);
            // 
            // mnuLine
            // 
            this.mnuLine.Name = "mnuLine";
            this.mnuLine.Size = new System.Drawing.Size(150, 22);
            this.mnuLine.Text = "선그리기";
            this.mnuLine.Click += new System.EventHandler(this.mnuLine_Click);
            // 
            // mnuRect
            // 
            this.mnuRect.Name = "mnuRect";
            this.mnuRect.Size = new System.Drawing.Size(150, 22);
            this.mnuRect.Text = "사각형 그리기";
            this.mnuRect.Click += new System.EventHandler(this.mnuRect_Click);
            // 
            // mnuCircle
            // 
            this.mnuCircle.Name = "mnuCircle";
            this.mnuCircle.Size = new System.Drawing.Size(150, 22);
            this.mnuCircle.Text = "원그리기";
            this.mnuCircle.Click += new System.EventHandler(this.mnuCircle_Click);
            // 
            // mnuText
            // 
            this.mnuText.Name = "mnuText";
            this.mnuText.Size = new System.Drawing.Size(150, 22);
            this.mnuText.Text = "문자 입력";
            this.mnuText.Click += new System.EventHandler(this.mnuText_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 6);
            // 
            // mnuErase
            // 
            this.mnuErase.Name = "mnuErase";
            this.mnuErase.Size = new System.Drawing.Size(150, 22);
            this.mnuErase.Text = "모두 지우기";
            this.mnuErase.Click += new System.EventHandler(this.mnuErase_Click);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuColor});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // mnuColor
            // 
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(180, 22);
            this.mnuColor.Text = "색상";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1,
            this.sbLabel2,
            this.sbLabel3,
            this.sbLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 301);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(612, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbLabel1
            // 
            this.sbLabel1.AutoSize = false;
            this.sbLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sbLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(100, 19);
            this.sbLabel1.Text = " ";
            // 
            // sbLabel2
            // 
            this.sbLabel2.AutoSize = false;
            this.sbLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sbLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.sbLabel2.Name = "sbLabel2";
            this.sbLabel2.Size = new System.Drawing.Size(100, 19);
            this.sbLabel2.Text = " ";
            // 
            // sbLabel3
            // 
            this.sbLabel3.AutoSize = false;
            this.sbLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sbLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.sbLabel3.Name = "sbLabel3";
            this.sbLabel3.Size = new System.Drawing.Size(100, 19);
            this.sbLabel3.Text = " ";
            // 
            // sbLabel4
            // 
            this.sbLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sbLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.sbLabel4.Name = "sbLabel4";
            this.sbLabel4.Size = new System.Drawing.Size(15, 19);
            this.sbLabel4.Text = " ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Canvas
            // 
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 24);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(612, 277);
            this.Canvas.TabIndex = 2;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // 동작테스트ToolStripMenuItem
            // 
            this.동작테스트ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTestSine});
            this.동작테스트ToolStripMenuItem.Name = "동작테스트ToolStripMenuItem";
            this.동작테스트ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.동작테스트ToolStripMenuItem.Text = "동작테스트";
            // 
            // mnuTestSine
            // 
            this.mnuTestSine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnuTestSine.Name = "mnuTestSine";
            this.mnuTestSine.Size = new System.Drawing.Size(180, 22);
            this.mnuTestSine.Text = "Sine Graph";
            this.mnuTestSine.Click += new System.EventHandler(this.mnuTestSine_Click);
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 325);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPaint";
            this.Text = "My Paint ver 1.7";
            this.ResizeEnd += new System.EventHandler(this.frmPaint_ResizeEnd);
            this.Resize += new System.EventHandler(this.frmPaint_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem 홈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDraw;
        private System.Windows.Forms.ToolStripMenuItem mnuLine;
        private System.Windows.Forms.ToolStripMenuItem mnuRect;
        private System.Windows.Forms.ToolStripMenuItem mnuCircle;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.ToolStripMenuItem mnuErase;
        private System.Windows.Forms.ToolStripMenuItem mnuText;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel2;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel3;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel4;
        private System.Windows.Forms.ToolStripMenuItem 동작테스트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTestSine;
    }
}

