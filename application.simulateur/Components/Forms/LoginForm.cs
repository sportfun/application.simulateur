using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application.simulateur.Components.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            bool errors = false;

            // Check if the field "txtHost" is empty or not
            if (String.IsNullOrWhiteSpace(this.txtHost.Text))
                errors = true;

            // Check if the field "txtPort" is empty or not
            if (String.IsNullOrWhiteSpace(this.txtPort.Text))
                errors = true;

            // Check if the field "txtPort" contains only numbers
            if (Regex.IsMatch(this.txtPort.Text, @"^\d+$") == false)
                errors = true;

            // Check if the field "txtLink" is empty or not
            if (String.IsNullOrWhiteSpace(this.txtLink.Text))
                errors = true;

            if (errors)
            {
                this.lblError.Visible = true;
                this.lblError.Text = "Veuillez verifier tous les champs.";
            }
            else
            {
                Classes.WebSocketIO.LinkID = this.lblLinkID.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
