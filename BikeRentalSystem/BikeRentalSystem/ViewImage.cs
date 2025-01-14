﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BikeRentalSystem
{
    public partial class ViewImage : Form
    {
        public string viewname;
        public string cashierusername;
        string bikeid;

        //for old data of the customer
        public string customerNameview;
        public string customerEmailview;
        public string customerPhoneNumberview;
        public string customerIDtypeview;
        public string customerIdRefview;
        public string customerAddressview;
        public ViewImage()
        {
            InitializeComponent();
        }

        private void ViewImage_Load(object sender, EventArgs e)
        {
            MySqlConnection viewconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
            MySqlDataReader viewreader;

           
            viewconnection.Open();
            MySqlCommand viewcmd = new MySqlCommand("select bikeimg, id from biketable where bikename=@name", viewconnection);
            viewcmd.Parameters.AddWithValue("@name", viewname);
            viewreader = viewcmd.ExecuteReader();
            viewreader.Read();

            if (viewreader.HasRows)
            {
                byte[] image = ((byte[])viewreader["bikeimg"]);
                MemoryStream mstreem = new MemoryStream(image);
                pictureBoxView.Image = Image.FromStream(mstreem);
                bikeid = viewreader["id"].ToString();

            }
            viewconnection.Close();


        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            
            
            buttonSelect.Text = viewname;
            Dashboard dashboarddata = new Dashboard();
            ImageSlider imgslide = new ImageSlider();


            ImageSlider obj = (ImageSlider)Application.OpenForms["ImageSlider"];
            obj.Close();
            dashboarddata.customerSelected = buttonSelect.Text;
            dashboarddata.customerSelectedid = bikeid;

            dashboarddata.cashierusername = cashierusername;
        dashboarddata.customerName = customerNameview;
        dashboarddata.customerEmail  = customerEmailview;
         dashboarddata.customerPhoneNumber=customerPhoneNumberview;
         dashboarddata.customerIDtype=customerIDtypeview;
         dashboarddata.customerIdRef=customerIdRefview;
         dashboarddata.customerAddress=customerAddressview;

        dashboarddata.Show();
                this.Hide();
           
        }

        private void ViewImage_FormClosing(object sender, FormClosingEventArgs e)
        {
          ImageSlider imageSlider1 = new ImageSlider();
            imageSlider1.Show();
            imageSlider1.cashierusername = cashierusername;
            this.Hide();
        }
    }
}
