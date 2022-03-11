using gameClient.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameClient
{
    public partial class MainMenu : Form
    {
        private String BACKGROUNDPATH = "/resources/MainMenuBackground.jpg";
        private MainController controller = null;
        private Player user;
        private Home home;
        public MainMenu()
        {
            InitializeComponent();
            initBackground();
            hideAllPanels();
        }

        public void initBackground() {
            Bitmap img = new Bitmap(Application.StartupPath+ @BACKGROUNDPATH);
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.gbLogin.BackgroundImage = img;
            this.panelRegister.BackgroundImage = img;
            this.gbLogin.BackgroundImageLayout = ImageLayout.Stretch;
            this.panelRegister.BackgroundImageLayout = ImageLayout.Stretch;
            tbMail.Text = "freddyachata@gmail.com";
            tbPassword.Text = "1234567890";
        }

        private void btGoLogin_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            this.gbLogin.Visible = true;
        }

        private void hideAllPanels() {
            this.panelRegister.Visible = false;
            this.gbLogin.Visible = false;
        }

        private void btGoRegister_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            this.panelRegister.Visible = true;
        }


        private void btLog_Click(object sender, EventArgs e)
        {
            labelErrorLogin.Text = "";
            String mail = tbMail.Text;
            String password = tbPassword.Text;
            if (isValidEmail(mail)) {
                if (!string.IsNullOrWhiteSpace(password)) {
                    if (user != null && controller!=null)
                    {
                        controller.disconnect();
                        home.Close();
                    }
                        controller = new MainController();
                        user = controller.login(mail, password);
                        if (user != null)
                        {
                            home = new Home(controller, user);
                        home.MdiParent = this.MdiParent;
                            home.Show();
                        }
                        else
                        {
                            showErrorMessage("Error at login ", labelErrorLogin);
                        }
                }
            else {
                showErrorMessage("The pasword introduced is not valid.", labelErrorLogin);
                resetTextBox();
            }
            } else {
                showErrorMessage("The mail introduced is not valid.", labelErrorLogin);
                resetTextBox();
            }
            //tbMail.Text = "";
            //tbPassword.Text = "";

        }

        private bool isValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void btRegist_Click(object sender, EventArgs e)
        {
            String mail = tbMailR.Text;
            String password = tbPassR.Text;
            String confirmationPass = tbConfirmPassR.Text;
            String name = tbNameR.Text;
            if (isValidEmail(mail))
            {
                if (!string.IsNullOrWhiteSpace(password))
                {
                    if (tbPassR.Text.Length > 8) {

                        if (password.Equals(confirmationPass))
                        {
                            if (!string.IsNullOrWhiteSpace(name))
                            {
                                if (user != null && controller != null)
                                {
                                    controller.disconnect();
                                }
                                controller = new MainController();
                                user = controller.register(mail, password, name);
                                if (user != null)
                                {
                                    Home home = new Home(controller, user);
                                    home.Show();
                                }
                                else
                                {
                                    showErrorMessage("Error at registering user in the database", labelRegisterError);
                                }
                            }
                            else
                            {
                                showErrorMessage("The name is not valid.", labelRegisterError);
                                tbNameR.Text = "";
                            }
                        }
                        else
                        {
                            showErrorMessage("The password and the confirmation are not the same.", labelRegisterError);
                            tbConfirmPassR.Text = "";
                            tbPassR.Text = "";
                        }
                }
                else
                {
                    showErrorMessage("The pasword must have more than 8 characters", labelRegisterError);
                    tbPassR.Text = "";
                }
            }
                else
                {
                    showErrorMessage("The pasword introduced is not valid.", labelRegisterError);
                    tbPassR.Text = "";
                }
            }
            else
            {
                showErrorMessage("The mail introduced is not valid.", labelRegisterError);
                tbMailR.Text = "";
            }
        }
        private void showErrorMessage(String message, Label label) {
            label.Text = message;
            label.Visible = true;
        }

        private void resetTextBox() {
            tbConfirmPassR.Text = "";
            tbMail.Text = "";
            tbMailR.Text = "";
            tbNameR.Text = "";
            tbPassR.Text = "";
            tbPassword.Text = "";
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            hideAllPanels();
        }
    }
}
