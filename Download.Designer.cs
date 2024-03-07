namespace System_Variable_Editor
{
    partial class Download
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
            javabutton = new Sunny.UI.UIButton();
            pythonbutton = new Sunny.UI.UIButton();
            jsbutton = new Sunny.UI.UIButton();
            uniappbutton = new Sunny.UI.UIButton();
            vsbutton = new Sunny.UI.UIButton();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiLabel2 = new Sunny.UI.UILabel();
            javaSaveButton = new Sunny.UI.UIButton();
            pythonSaveButton = new Sunny.UI.UIButton();
            JsSaveButton = new Sunny.UI.UIButton();
            javaLoadButton = new Sunny.UI.UIButton();
            pythonLoedButton = new Sunny.UI.UIButton();
            jsLoadButton = new Sunny.UI.UIButton();
            saveLocal = new Sunny.UI.UIButton();
            saveLabel = new Sunny.UI.UILabel();
            uiPanel3 = new Sunny.UI.UIPanel();
            loadLocal = new Sunny.UI.UIButton();
            loadLabel = new Sunny.UI.UILabel();
            mysqlbutton = new Sunny.UI.UIButton();
            redisbutton = new Sunny.UI.UIButton();
            uiLabel5 = new Sunny.UI.UILabel();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            uiPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // javabutton
            // 
            javabutton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            javabutton.Location = new Point(20, 42);
            javabutton.MinimumSize = new Size(1, 1);
            javabutton.Name = "javabutton";
            javabutton.Size = new Size(125, 44);
            javabutton.TabIndex = 0;
            javabutton.Text = "java安装";
            javabutton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            javabutton.Click += javabutton_Click;
            // 
            // pythonbutton
            // 
            pythonbutton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pythonbutton.Location = new Point(21, 92);
            pythonbutton.MinimumSize = new Size(1, 1);
            pythonbutton.Name = "pythonbutton";
            pythonbutton.Size = new Size(125, 44);
            pythonbutton.TabIndex = 1;
            pythonbutton.Text = "python安装";
            pythonbutton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pythonbutton.Click += pythonbutton_Click;
            // 
            // jsbutton
            // 
            jsbutton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            jsbutton.Location = new Point(21, 142);
            jsbutton.MinimumSize = new Size(1, 1);
            jsbutton.Name = "jsbutton";
            jsbutton.Size = new Size(125, 44);
            jsbutton.TabIndex = 2;
            jsbutton.Text = "node.js安装";
            jsbutton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            jsbutton.Click += jsbutton_Click;
            // 
            // uniappbutton
            // 
            uniappbutton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uniappbutton.Location = new Point(168, 92);
            uniappbutton.MinimumSize = new Size(1, 1);
            uniappbutton.Name = "uniappbutton";
            uniappbutton.Size = new Size(167, 44);
            uniappbutton.TabIndex = 3;
            uniappbutton.Text = "uniapp安装";
            uniappbutton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uniappbutton.Click += uniappbutton_Click;
            // 
            // vsbutton
            // 
            vsbutton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vsbutton.Location = new Point(168, 42);
            vsbutton.MinimumSize = new Size(1, 1);
            vsbutton.Name = "vsbutton";
            vsbutton.Size = new Size(167, 44);
            vsbutton.TabIndex = 4;
            vsbutton.Text = "vs （c#）安装";
            vsbutton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            vsbutton.Click += vsbutton_Click;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(redisbutton);
            uiPanel1.Controls.Add(mysqlbutton);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(uniappbutton);
            uiPanel1.Controls.Add(vsbutton);
            uiPanel1.Controls.Add(javabutton);
            uiPanel1.Controls.Add(pythonbutton);
            uiPanel1.Controls.Add(jsbutton);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel1.Location = new Point(16, 50);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(387, 340);
            uiPanel1.TabIndex = 5;
            uiPanel1.Text = "uiPanel1";
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(20, 10);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(125, 29);
            uiLabel1.TabIndex = 5;
            uiLabel1.Text = "软件安装";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(uiLabel5);
            uiPanel2.Controls.Add(jsLoadButton);
            uiPanel2.Controls.Add(pythonLoedButton);
            uiPanel2.Controls.Add(javaLoadButton);
            uiPanel2.Controls.Add(JsSaveButton);
            uiPanel2.Controls.Add(pythonSaveButton);
            uiPanel2.Controls.Add(javaSaveButton);
            uiPanel2.Controls.Add(uiLabel2);
            uiPanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel2.Location = new Point(411, 50);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(416, 340);
            uiPanel2.TabIndex = 6;
            uiPanel2.Text = "uiPanel2";
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(20, 10);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(125, 29);
            uiLabel2.TabIndex = 0;
            uiLabel2.Text = "库迁移";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // javaSaveButton
            // 
            javaSaveButton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            javaSaveButton.Location = new Point(20, 42);
            javaSaveButton.MinimumSize = new Size(1, 1);
            javaSaveButton.Name = "javaSaveButton";
            javaSaveButton.Size = new Size(125, 44);
            javaSaveButton.TabIndex = 1;
            javaSaveButton.Text = "java库存档";
            javaSaveButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            javaSaveButton.Click += javaSaveButton_Click;
            // 
            // pythonSaveButton
            // 
            pythonSaveButton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pythonSaveButton.Location = new Point(20, 92);
            pythonSaveButton.MinimumSize = new Size(1, 1);
            pythonSaveButton.Name = "pythonSaveButton";
            pythonSaveButton.Size = new Size(133, 44);
            pythonSaveButton.TabIndex = 2;
            pythonSaveButton.Text = "python库存档";
            pythonSaveButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pythonSaveButton.Click += pythonSaveButton_Click;
            // 
            // JsSaveButton
            // 
            JsSaveButton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            JsSaveButton.Location = new Point(20, 142);
            JsSaveButton.MinimumSize = new Size(1, 1);
            JsSaveButton.Name = "JsSaveButton";
            JsSaveButton.Size = new Size(125, 44);
            JsSaveButton.TabIndex = 3;
            JsSaveButton.Text = "js库存档";
            JsSaveButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            JsSaveButton.Click += JsSaveButton_Click;
            // 
            // javaLoadButton
            // 
            javaLoadButton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            javaLoadButton.Location = new Point(151, 42);
            javaLoadButton.MinimumSize = new Size(1, 1);
            javaLoadButton.Name = "javaLoadButton";
            javaLoadButton.Size = new Size(125, 44);
            javaLoadButton.TabIndex = 4;
            javaLoadButton.Text = "java库迁移";
            javaLoadButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            javaLoadButton.Click += javaLoadButton_Click;
            // 
            // pythonLoedButton
            // 
            pythonLoedButton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pythonLoedButton.Location = new Point(159, 92);
            pythonLoedButton.MinimumSize = new Size(1, 1);
            pythonLoedButton.Name = "pythonLoedButton";
            pythonLoedButton.Size = new Size(125, 44);
            pythonLoedButton.TabIndex = 5;
            pythonLoedButton.Text = "python库迁移";
            pythonLoedButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pythonLoedButton.Click += pythonLoedButton_Click;
            // 
            // jsLoadButton
            // 
            jsLoadButton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            jsLoadButton.Location = new Point(159, 142);
            jsLoadButton.MinimumSize = new Size(1, 1);
            jsLoadButton.Name = "jsLoadButton";
            jsLoadButton.Size = new Size(125, 44);
            jsLoadButton.TabIndex = 6;
            jsLoadButton.Text = "js库迁移";
            jsLoadButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            jsLoadButton.Click += jsLoadButton_Click;
            // 
            // saveLocal
            // 
            saveLocal.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveLocal.Location = new Point(13, 16);
            saveLocal.MinimumSize = new Size(1, 1);
            saveLocal.Name = "saveLocal";
            saveLocal.Size = new Size(133, 35);
            saveLocal.TabIndex = 7;
            saveLocal.Text = "选择存档地址";
            saveLocal.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            saveLocal.Click += saveLocal_Click;
            // 
            // saveLabel
            // 
            saveLabel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveLabel.Location = new Point(152, 16);
            saveLabel.Name = "saveLabel";
            saveLabel.Size = new Size(125, 29);
            saveLabel.TabIndex = 8;
            saveLabel.Text = "未选择路径";
            saveLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiPanel3
            // 
            uiPanel3.Controls.Add(loadLabel);
            uiPanel3.Controls.Add(loadLocal);
            uiPanel3.Controls.Add(saveLabel);
            uiPanel3.Controls.Add(saveLocal);
            uiPanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel3.Location = new Point(16, 400);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Size = new Size(811, 151);
            uiPanel3.TabIndex = 9;
            uiPanel3.Text = "uiPanel3";
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // loadLocal
            // 
            loadLocal.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadLocal.Location = new Point(13, 54);
            loadLocal.MinimumSize = new Size(1, 1);
            loadLocal.Name = "loadLocal";
            loadLocal.Size = new Size(133, 33);
            loadLocal.TabIndex = 9;
            loadLocal.Text = "选择迁移地址";
            loadLocal.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loadLocal.Click += loadLocal_Click;
            // 
            // loadLabel
            // 
            loadLabel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadLabel.Location = new Point(152, 54);
            loadLabel.Name = "loadLabel";
            loadLabel.Size = new Size(125, 29);
            loadLabel.TabIndex = 10;
            loadLabel.Text = "未选择路径";
            loadLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mysqlbutton
            // 
            mysqlbutton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mysqlbutton.Location = new Point(168, 142);
            mysqlbutton.MinimumSize = new Size(1, 1);
            mysqlbutton.Name = "mysqlbutton";
            mysqlbutton.Size = new Size(167, 44);
            mysqlbutton.TabIndex = 6;
            mysqlbutton.Text = "mysql安装";
            mysqlbutton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mysqlbutton.Click += mysqlbutton_Click;
            // 
            // redisbutton
            // 
            redisbutton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            redisbutton.Location = new Point(168, 192);
            redisbutton.MinimumSize = new Size(1, 1);
            redisbutton.Name = "redisbutton";
            redisbutton.Size = new Size(167, 44);
            redisbutton.TabIndex = 7;
            redisbutton.Text = "redis安装";
            redisbutton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            redisbutton.Click += redisbutton_Click;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.Location = new Point(28, 302);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(125, 29);
            uiLabel5.TabIndex = 7;
            uiLabel5.Text = "使用u盘迁移数据";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Download
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(846, 567);
            Controls.Add(uiPanel3);
            Controls.Add(uiPanel2);
            Controls.Add(uiPanel1);
            Name = "Download";
            Text = "安装程序";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            uiPanel1.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            uiPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton javabutton;
        private Sunny.UI.UIButton pythonbutton;
        private Sunny.UI.UIButton jsbutton;
        private Sunny.UI.UIButton uniappbutton;
        private Sunny.UI.UIButton vsbutton;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton redisbutton;
        private Sunny.UI.UIButton mysqlbutton;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton jsLoadButton;
        private Sunny.UI.UIButton pythonLoedButton;
        private Sunny.UI.UIButton javaLoadButton;
        private Sunny.UI.UIButton JsSaveButton;
        private Sunny.UI.UIButton pythonSaveButton;
        private Sunny.UI.UIButton javaSaveButton;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton saveLocal;
        private Sunny.UI.UILabel saveLabel;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UILabel loadLabel;
        private Sunny.UI.UIButton loadLocal;
    }
}