﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {

        private int min;
        private int max;

        public Form1() {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e) {

            min = (int)minNum.Value;
            max = (int)maxNum.Value;
            
            var rand = new Random();
            Number.Value = rand.Next(min,max+1);
        }
    }
}
