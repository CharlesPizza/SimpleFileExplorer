namespace FileExplorer
{
    partial class Window1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listView = new ListView();
            imageList = new ImageList(components);
            txtPath = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView
            // 
            listView.LargeImageList = imageList;
            listView.Location = new Point(12, 12);
            listView.Name = "listView";
            listView.Size = new Size(1043, 521);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageSize = new Size(32, 32);
            imageList.TransparentColor = Color.Transparent;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(12, 550);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(903, 23);
            txtPath.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(921, 550);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 2;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Window1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 597);
            Controls.Add(button1);
            Controls.Add(txtPath);
            Controls.Add(listView);
            Name = "Window1";
            Text = "FileExplorer";
            Load += Window1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView;
        private TextBox txtPath;
        private Button button1;
        private ImageList imageList;
    }
}
