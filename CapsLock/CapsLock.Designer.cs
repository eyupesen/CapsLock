namespace CapsLock
{
    partial class CapsLock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapsLock));
            this.label_capsLock = new System.Windows.Forms.Label();
            this.label_numLock = new System.Windows.Forms.Label();
            this.label_scrollLock = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.label_capsLockIcon = new System.Windows.Forms.Label();
            this.label_numLockIcon = new System.Windows.Forms.Label();
            this.label_scrollLockIcon = new System.Windows.Forms.Label();
            this.label_closeIcon = new System.Windows.Forms.Label();
            this.notifyIcon_capsLock = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label_capsLock
            // 
            this.label_capsLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label_capsLock.Location = new System.Drawing.Point(2, 2);
            this.label_capsLock.Name = "label_capsLock";
            this.label_capsLock.Size = new System.Drawing.Size(20, 6);
            this.label_capsLock.TabIndex = 0;
            // 
            // label_numLock
            // 
            this.label_numLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label_numLock.Location = new System.Drawing.Point(24, 2);
            this.label_numLock.Name = "label_numLock";
            this.label_numLock.Size = new System.Drawing.Size(20, 6);
            this.label_numLock.TabIndex = 0;
            // 
            // label_scrollLock
            // 
            this.label_scrollLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label_scrollLock.Location = new System.Drawing.Point(46, 2);
            this.label_scrollLock.Name = "label_scrollLock";
            this.label_scrollLock.Size = new System.Drawing.Size(20, 6);
            this.label_scrollLock.TabIndex = 0;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(68, 2);
            this.label_close.Margin = new System.Windows.Forms.Padding(0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(20, 6);
            this.label_close.TabIndex = 0;
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_capsLockIcon
            // 
            this.label_capsLockIcon.ForeColor = System.Drawing.Color.White;
            this.label_capsLockIcon.Location = new System.Drawing.Point(4, 9);
            this.label_capsLockIcon.Margin = new System.Windows.Forms.Padding(0);
            this.label_capsLockIcon.Name = "label_capsLockIcon";
            this.label_capsLockIcon.Size = new System.Drawing.Size(20, 20);
            this.label_capsLockIcon.TabIndex = 1;
            this.label_capsLockIcon.Text = "A";
            this.label_capsLockIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_numLockIcon
            // 
            this.label_numLockIcon.ForeColor = System.Drawing.Color.White;
            this.label_numLockIcon.Location = new System.Drawing.Point(26, 9);
            this.label_numLockIcon.Margin = new System.Windows.Forms.Padding(0);
            this.label_numLockIcon.Name = "label_numLockIcon";
            this.label_numLockIcon.Size = new System.Drawing.Size(20, 20);
            this.label_numLockIcon.TabIndex = 2;
            this.label_numLockIcon.Text = "1";
            this.label_numLockIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_scrollLockIcon
            // 
            this.label_scrollLockIcon.ForeColor = System.Drawing.Color.White;
            this.label_scrollLockIcon.Location = new System.Drawing.Point(48, 9);
            this.label_scrollLockIcon.Margin = new System.Windows.Forms.Padding(0);
            this.label_scrollLockIcon.Name = "label_scrollLockIcon";
            this.label_scrollLockIcon.Size = new System.Drawing.Size(20, 20);
            this.label_scrollLockIcon.TabIndex = 3;
            this.label_scrollLockIcon.Text = "S";
            this.label_scrollLockIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_closeIcon
            // 
            this.label_closeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_closeIcon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_closeIcon.ForeColor = System.Drawing.Color.White;
            this.label_closeIcon.Location = new System.Drawing.Point(68, 10);
            this.label_closeIcon.Margin = new System.Windows.Forms.Padding(0);
            this.label_closeIcon.Name = "label_closeIcon";
            this.label_closeIcon.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label_closeIcon.Size = new System.Drawing.Size(20, 20);
            this.label_closeIcon.TabIndex = 3;
            this.label_closeIcon.Text = "X";
            this.label_closeIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_closeIcon.Click += new System.EventHandler(this.label_closeIcon_Click);
            // 
            // notifyIcon_capsLock
            // 
            this.notifyIcon_capsLock.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_capsLock.Icon")));
            this.notifyIcon_capsLock.Text = "CapsLock";
            this.notifyIcon_capsLock.Visible = true;
            // 
            // CapsLock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(90, 32);
            this.ControlBox = false;
            this.Controls.Add(this.label_closeIcon);
            this.Controls.Add(this.label_scrollLockIcon);
            this.Controls.Add(this.label_numLockIcon);
            this.Controls.Add(this.label_capsLockIcon);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label_scrollLock);
            this.Controls.Add(this.label_numLock);
            this.Controls.Add(this.label_capsLock);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(90, 32);
            this.MinimizeBox = false;
            this.Name = "CapsLock";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CapsLock";
            this.Activated += new System.EventHandler(this.CapsLock_Activated);
            this.Deactivate += new System.EventHandler(this.CapsLock_Deactivate);
            this.Load += new System.EventHandler(this.CapsLock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_capsLock;
        private System.Windows.Forms.Label label_numLock;
        private System.Windows.Forms.Label label_scrollLock;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_capsLockIcon;
        private System.Windows.Forms.Label label_numLockIcon;
        private System.Windows.Forms.Label label_scrollLockIcon;
        private System.Windows.Forms.Label label_closeIcon;
        private System.Windows.Forms.NotifyIcon notifyIcon_capsLock;
    }
}

