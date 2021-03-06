﻿namespace FractalAssignment
{
    partial class Mandelbrot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mandelbrot));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.messageBox = new System.Windows.Forms.Label();
            this.panel2 = new FractalAssignment.PanelDoubleBuffered();
            this.frameCount = new System.Windows.Forms.Label();
            this.stateMessage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.autoCycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoWarpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFramesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.randomiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMandelbrotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cycleInput = new System.Windows.Forms.Panel();
            this.txtcyclenumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.cycleInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.trackBar1.Location = new System.Drawing.Point(437, 1);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(175, 30);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.Color_ValueChanged);
            // 
            // messageBox
            // 
            this.messageBox.AutoSize = true;
            this.messageBox.BackColor = System.Drawing.Color.Transparent;
            this.messageBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.messageBox.Location = new System.Drawing.Point(390, 3);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(232, 13);
            this.messageBox.TabIndex = 0;
            this.messageBox.Text = "Mandelbrot-Set ready - Please select zoom area";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.frameCount);
            this.panel2.Controls.Add(this.stateMessage);
            this.panel2.Controls.Add(this.messageBox);
            this.panel2.Location = new System.Drawing.Point(-10, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 20);
            this.panel2.TabIndex = 2;
            // 
            // frameCount
            // 
            this.frameCount.AutoSize = true;
            this.frameCount.BackColor = System.Drawing.Color.Transparent;
            this.frameCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.frameCount.Location = new System.Drawing.Point(213, 3);
            this.frameCount.Name = "frameCount";
            this.frameCount.Size = new System.Drawing.Size(116, 13);
            this.frameCount.TabIndex = 2;
            this.frameCount.Text = "Animation Frames 0/10";
            // 
            // stateMessage
            // 
            this.stateMessage.AutoSize = true;
            this.stateMessage.BackColor = System.Drawing.Color.Transparent;
            this.stateMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stateMessage.Location = new System.Drawing.Point(22, 3);
            this.stateMessage.Name = "stateMessage";
            this.stateMessage.Size = new System.Drawing.Size(0, 13);
            this.stateMessage.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(624, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveStateToolStripMenuItem,
            this.loadStateToolStripMenuItem,
            this.deleteStateToolStripMenuItem,
            this.toolStripSeparator3,
            this.autoCycleToolStripMenuItem,
            this.autoWarpToolStripMenuItem,
            this.animateToolStripMenuItem,
            this.toolStripSeparator1,
            this.randomiseToolStripMenuItem,
            this.resetMandelbrotToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.fileToolStripMenuItem.Text = "&Menu";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(168, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShowShortcutKeys = false;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveToolStripMenuItem.Text = "&Save Image";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // saveStateToolStripMenuItem
            // 
            this.saveStateToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.saveStateToolStripMenuItem.Name = "saveStateToolStripMenuItem";
            this.saveStateToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveStateToolStripMenuItem.Text = "Save State";
            this.saveStateToolStripMenuItem.Click += new System.EventHandler(this.saveState_Click);
            // 
            // loadStateToolStripMenuItem
            // 
            this.loadStateToolStripMenuItem.Name = "loadStateToolStripMenuItem";
            this.loadStateToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.loadStateToolStripMenuItem.Text = "Load State";
            this.loadStateToolStripMenuItem.Click += new System.EventHandler(this.loadState_Click);
            // 
            // deleteStateToolStripMenuItem
            // 
            this.deleteStateToolStripMenuItem.Name = "deleteStateToolStripMenuItem";
            this.deleteStateToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.deleteStateToolStripMenuItem.Text = "Delete State";
            this.deleteStateToolStripMenuItem.Click += new System.EventHandler(this.deleteState_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // autoCycleToolStripMenuItem
            // 
            this.autoCycleToolStripMenuItem.Name = "autoCycleToolStripMenuItem";
            this.autoCycleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.autoCycleToolStripMenuItem.Text = "Auto Cycle Colour";
            this.autoCycleToolStripMenuItem.Click += new System.EventHandler(this.CycleInput_Click);
            // 
            // autoWarpToolStripMenuItem
            // 
            this.autoWarpToolStripMenuItem.Name = "autoWarpToolStripMenuItem";
            this.autoWarpToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.autoWarpToolStripMenuItem.Text = "Auto Warp";
            this.autoWarpToolStripMenuItem.Click += new System.EventHandler(this.AutoWarp_Click);
            // 
            // animateToolStripMenuItem
            // 
            this.animateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.deleteFramesToolStripMenuItem});
            this.animateToolStripMenuItem.Name = "animateToolStripMenuItem";
            this.animateToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.animateToolStripMenuItem.Text = "Animation";
            this.animateToolStripMenuItem.Click += new System.EventHandler(this.start_animate);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.start_animate);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stop_animate);
            // 
            // deleteFramesToolStripMenuItem
            // 
            this.deleteFramesToolStripMenuItem.Name = "deleteFramesToolStripMenuItem";
            this.deleteFramesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteFramesToolStripMenuItem.Text = "Delete Frames";
            this.deleteFramesToolStripMenuItem.Click += new System.EventHandler(this.delete_frames);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // randomiseToolStripMenuItem
            // 
            this.randomiseToolStripMenuItem.Name = "randomiseToolStripMenuItem";
            this.randomiseToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.randomiseToolStripMenuItem.Text = "Randomise";
            this.randomiseToolStripMenuItem.Click += new System.EventHandler(this.random_Click);
            // 
            // resetMandelbrotToolStripMenuItem
            // 
            this.resetMandelbrotToolStripMenuItem.Name = "resetMandelbrotToolStripMenuItem";
            this.resetMandelbrotToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.resetMandelbrotToolStripMenuItem.Text = "Reset Mandelbrot";
            this.resetMandelbrotToolStripMenuItem.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cycle Colour:";
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.trackBar2.Location = new System.Drawing.Point(206, 1);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(150, 30);
            this.trackBar2.TabIndex = 6;
            this.trackBar2.Scroll += new System.EventHandler(this.Warp_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(165, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Warp:";
            // 
            // cycleInput
            // 
            this.cycleInput.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cycleInput.Controls.Add(this.txtcyclenumber);
            this.cycleInput.Controls.Add(this.label3);
            this.cycleInput.Controls.Add(this.button1);
            this.cycleInput.Location = new System.Drawing.Point(201, 182);
            this.cycleInput.Name = "cycleInput";
            this.cycleInput.Size = new System.Drawing.Size(225, 123);
            this.cycleInput.TabIndex = 8;
            this.cycleInput.Visible = false;
            // 
            // txtcyclenumber
            // 
            this.txtcyclenumber.Location = new System.Drawing.Point(93, 43);
            this.txtcyclenumber.MaxLength = 2;
            this.txtcyclenumber.Name = "txtcyclenumber";
            this.txtcyclenumber.Size = new System.Drawing.Size(39, 20);
            this.txtcyclenumber.TabIndex = 2;
            this.txtcyclenumber.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "How many time would you like to cycle?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(70, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cycle Colour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AutoCycle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(624, 471);
            this.Controls.Add(this.cycleInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseReleased);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.cycleInput.ResumeLayout(false);
            this.cycleInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label messageBox;
        private PanelDoubleBuffered panel2;
        private System.Windows.Forms.Label stateMessage;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStateToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem autoCycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoWarpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFramesToolStripMenuItem;
        private System.Windows.Forms.Label frameCount;
        private System.Windows.Forms.ToolStripMenuItem randomiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem resetMandelbrotToolStripMenuItem;
        private System.Windows.Forms.Panel cycleInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcyclenumber;
        private System.Windows.Forms.Label label3;
    }
}

