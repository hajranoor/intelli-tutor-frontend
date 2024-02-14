using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelli_tutor_frontend.TeacherSide
{
    internal class DashboardClass
    {
        public async void ShowDashbooard(FlowLayoutPanel flowLayoutPanel, Label formName)
        {
            formName.Text = "Dashboard";

            flowLayoutPanel.Controls.Clear();

            Label hello = new Label();
            hello.Text = "Welcome";

            flowLayoutPanel.Controls.Add(hello);    
        }
    }
}
