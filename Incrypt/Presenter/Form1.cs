using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;
using Incrypt.BusinessObjects;


namespace Incrypt
{
    public partial class Form1 : Form
    {
        MyContext db;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new MyContext();

            try
            {

               /* if (Database.Exists("MyContext"))
                {
                    System.Windows.Forms.MessageBox.Show("Database already exists");
                }
                else*/
                    db.Database.Initialize(true);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }
    }
}
