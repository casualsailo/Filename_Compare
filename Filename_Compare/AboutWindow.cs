using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filename_Compare
{
    public partial class AboutWindow : Form
    {
        string[] about1 = new string[4];
        StringBuilder about = new StringBuilder();
        public AboutWindow()
        {
            InitializeComponent();
            this.showdescription();
        }

        private void showdescription()
        {
            about1[3] = "v1.1.1\t11/09/16\r\n\u2022 Fixed output text file formatting\r\n\r\n";
            about1[2] = "v1.1.0\t11/09/16\r\n\u2022 Added feature to individually ignore source/target folder filename file extensions\r\n\u2022 Added Help/About Menu\r\n\r\n";
            about1[1] = "v1.0.5\t11/08/16\r\n\u2022 Added feature to search all subfolders\r\n\r\n";
            about1[0] = "v1.0\t11/08/16\r\n\u2022 Initial Release";
            
            for (int i = about1.Length - 1; i >= 0; i--)
            {
                about.Append(about1[i]);
            }
            
            changeLog.Text = about.ToString();
            changeLog.Select(0, 0);
        }

        private void changeLog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }

            if (e.Control && e.KeyCode == Keys.A)
            {
                changeLog.SelectAll();
            }
        }
    }
}
