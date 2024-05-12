namespace SchoolSQL
{
    public partial class SystemMM : Form
    {

        public SystemMM()
        {
            InitializeComponent();
        }

        private void SystemMM_Load(object sender, EventArgs e)
        {
            students1.Hide();
            relations1.Hide();
            subjects1.Hide();
            teachers1.Hide();
        }

        private void MMTeachersBTN_Click(object sender, EventArgs e)
        {
            students1.Hide();
            relations1.Hide();
            subjects1.Hide();

            teachers1.Show();
            teachers1.BringToFront();
        }

        private void MMStudentsBTN_Click(object sender, EventArgs e)
        {
            relations1.Hide();
            subjects1.Hide();
            teachers1.Hide();

            students1.Show();
            students1.BringToFront();
        }

        private void MMSubjectsBTN_Click(object sender, EventArgs e)
        {
            students1.Hide();
            relations1.Hide();
            teachers1.Hide();

            subjects1.Show();
            subjects1.BringToFront();
        }

        private void MMRelationBTN_Click(object sender, EventArgs e)
        {
            students1.Hide();
            subjects1.Hide();
            teachers1.Hide();

            relations1.Show();
            relations1.BringToFront();
        }

        private void MMExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
