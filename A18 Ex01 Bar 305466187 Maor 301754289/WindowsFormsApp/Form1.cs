﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using Facebook;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoginResult result = FacebookService.Login("915609945259039", "user_likes", "public_profile", "user_photos", "publish_actions", "email");
            FacebookWrapper.ObjectModel.User user = result.LoggedInUser;
            Console.WriteLine();
            Console.WriteLine(user.Id);
            Console.WriteLine(result.AccessToken);
            Console.WriteLine();
        }

        private void test()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
