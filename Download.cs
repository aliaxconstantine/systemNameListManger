using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Variable_Editor
{
    public partial class Download : UIForm
    {
        private string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "exeurl.json");
        public Download()
        {
            InitializeComponent();

        }
        public void never()
        {
            InStallExeFactor.InitCreateFactor(exePath);
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };
            var e = InStallExeFactor.GetFactor().Value;
            if (e == null)
            {
                throw new Exception("未知错误");
            }
            e.ForEach(r =>
            {
                TableLayoutPanel tableLayout = new TableLayoutPanel()
                {
                    ColumnCount = 2,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink
                };

                UILabel label = new UILabel() { Text = r.Name + "下载中" };
                tableLayout.Controls.Add(label, 0, 0);
                UIProcessBar proBar = new UIProcessBar();
                tableLayout.Controls.Add(proBar, 1, 0);
                Progress<int> progress = new Progress<int>(ReportProgress =>
                {
                    proBar.Value = ReportProgress;
                });
                ThreadLocal<int> varProgress = new ThreadLocal<int>();
                varProgress.Value = 0;
                //下载安装包
                progress.ProgressChanged += (sender, e) =>
                {
                    varProgress.Value = e;
                };

                InStallStrat.InStallEXEAsync(r, progress, label.Text);
                flowLayoutPanel.Controls.Add(tableLayout);
            });
            this.Controls.Add(flowLayoutPanel);
        }

        private void javabutton_Click(object sender, EventArgs e)
        {

        }

        private void vsbutton_Click(object sender, EventArgs e)
        {

        }

        private void pythonbutton_Click(object sender, EventArgs e)
        {

        }

        private void uniappbutton_Click(object sender, EventArgs e)
        {

        }

        private void jsbutton_Click(object sender, EventArgs e)
        {

        }

        private void mysqlbutton_Click(object sender, EventArgs e)
        {

        }

        private void redisbutton_Click(object sender, EventArgs e)
        {

        }

        private void javaSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void javaLoadButton_Click(object sender, EventArgs e)
        {

        }

        private void pythonSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void pythonLoedButton_Click(object sender, EventArgs e)
        {

        }

        private void JsSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void jsLoadButton_Click(object sender, EventArgs e)
        {

        }

        private void saveLocal_Click(object sender, EventArgs e)
        {

        }

        private void loadLocal_Click(object sender, EventArgs e)
        {

        }
    }
}
