using System;
using System.Collections.Generic;
/* Test characters
 * Date:2014-10-02
 * 
 * 
 * 
 */
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the Click button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "帳幷廈廉廘廲弆弜彙";// Chinees characters
        }
    }
}
