﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvwater_netfw
{
    public partial class messageBox : Form
    {
        public messageBox(string theMessage)
        {
            InitializeComponent();
        }

        public string getANewMessage(string theMessage)
        {
            return theMessage;
        }

        private void messageBox_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            var showInfoBox = new messageBox("");
            string infoMessage = string.Empty;
            showInfoBox.getANewMessage(infoMessage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
