namespace FractalAssignment
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
            this.panel1 = new FractalAssignment.Form1.PanelDoubleBuffered();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.loadState = new System.Windows.Forms.Button();
            this.saveState = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.Label();
            this.panel2 = new FractalAssignment.Form1.PanelDoubleBuffered();
            this.stateMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.loadState);
            this.panel1.Controls.Add(this.saveState);
            this.panel1.Location = new System.Drawing.Point(-10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 30);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete State";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteState_Click);
            // 
            // loadState
            // 
            this.loadState.Location = new System.Drawing.Point(103, 3);
            this.loadState.Name = "loadState";
            this.loadState.Size = new System.Drawing.Size(75, 23);
            this.loadState.TabIndex = 2;
            this.loadState.Text = "Load State";
            this.loadState.UseVisualStyleBackColor = true;
            this.loadState.Click += new System.EventHandler(this.loadState_Click);
            // 
            // saveState
            // 
            this.saveState.Location = new System.Drawing.Point(22, 4);
            this.saveState.Name = "saveState";
            this.saveState.Size = new System.Drawing.Size(75, 23);
            this.saveState.TabIndex = 1;
            this.saveState.Text = "Save State";
            this.saveState.UseVisualStyleBackColor = true;
            this.saveState.Click += new System.EventHandler(this.saveState_Click);
            // 
            // messageBox
            // 
            this.messageBox.AutoSize = true;
            this.messageBox.BackColor = System.Drawing.Color.Transparent;
            this.messageBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.messageBox.Location = new System.Drawing.Point(21, 3);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(39, 13);
            this.messageBox.TabIndex = 0;
            this.messageBox.Text = "Label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.stateMessage);
            this.panel2.Controls.Add(this.messageBox);
            this.panel2.Location = new System.Drawing.Point(-10, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 20);
            this.panel2.TabIndex = 2;
            // 
            // stateMessage
            // 
            this.stateMessage.AutoSize = true;
            this.stateMessage.BackColor = System.Drawing.Color.Transparent;
            this.stateMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stateMessage.Location = new System.Drawing.Point(531, 3);
            this.stateMessage.Name = "stateMessage";
            this.stateMessage.Size = new System.Drawing.Size(0, 13);
            this.stateMessage.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseReleased);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PanelDoubleBuffered panel1;
        private System.Windows.Forms.Button saveState;
        private System.Windows.Forms.Button loadState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label messageBox;
        private PanelDoubleBuffered panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label stateMessage;
    }
}

