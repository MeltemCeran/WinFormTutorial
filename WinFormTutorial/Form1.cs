namespace WinFormTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKutu1_Click(object sender, EventArgs e)
        {
            string txtKutuBir = txtKutu1.Text;
            string txtKutuIki = txtKutu2.Text;

            lblKutu3.Text = txtKutuBir;
            lblKutu4.Text = txtKutuIki;

            gBoxKutu1.Visible = false;
            gBoxKutu2.Visible = true;

            gBoxKutu2.Location = gBoxKutu1.Location; //alttakiyle ayný þeyi yapýyor.
            //gBoxKutu2.Location = new System.Drawing.Point(gBoxKutu1.Location.X, gBoxKutu1.Location.Y);
        }

        private void btnKutu2_Click(object sender, EventArgs e)
        {
            string txtKutuUc = txtKutu3.Text;
            string txtKutuDort = txtKutu4.Text;

            lblKutu5.Text = txtKutuUc;
            lblKutu6.Text = txtKutuDort;

            gBoxKutu2.Visible = false;
            gBoxKutu3.Visible = true;

            gBoxKutu3.Location = gBoxKutu2.Location;

        }

        private void btnKutu3_Click(object sender, EventArgs e)
        {
            string txtKutuBes = txtKutu5.Text;
            string txtKutuAlti = txtKutu6.Text;

            lblKutu1.Text = txtKutuBes;
            lblKutu2.Text = txtKutuAlti;

            gBoxKutu3.Visible = false;
            gBoxKutu1.Visible = true;

            gBoxKutu1.Location = gBoxKutu3.Location;
        }

        private void btnUserRegister_Click(object sender, EventArgs e)
        {
            UserRegister userRegister = new UserRegister();
            userRegister.ShowDialog();
        }
    }
}
