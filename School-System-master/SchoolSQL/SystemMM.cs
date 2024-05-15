namespace SchoolSQL
{
    public partial class SystemMM : Form
    {

        public SystemMM()
        {
            InitializeComponent();
        }


        /* When loading the main form */
        private void SystemMM_Load(object sender, EventArgs e)
        {
            // Hid all other user controls
            students1.Hide();
            relations1.Hide();
            subjects1.Hide();
            teachers1.Hide();
        }


        /* Teachers button on click */
        private void MMTeachersBTN_Click(object sender, EventArgs e)
        {
            // Hid all other user controls
            students1.Hide();
            relations1.Hide();
            subjects1.Hide();
            // Show current user control
            teachers1.Show();
            teachers1.BringToFront();
        }


        /* Students button on click */
        private void MMStudentsBTN_Click(object sender, EventArgs e)
        {
            // Hid all other user controls
            relations1.Hide();
            subjects1.Hide();
            teachers1.Hide();
            // Show current user control
            students1.Show();
            students1.BringToFront();
        }


        /* Subjects button on click */
        private void MMSubjectsBTN_Click(object sender, EventArgs e)
        {
            // Hid all other user controls
            students1.Hide();
            relations1.Hide();
            teachers1.Hide();
            // Show current user control
            subjects1.Show();
            subjects1.BringToFront();
        }


        /* Relations button on click */
        private void MMRelationBTN_Click(object sender, EventArgs e)
        {
            // Hid all other user controls
            students1.Hide();
            subjects1.Hide();
            teachers1.Hide();
            // Show current user control
            relations1.Show();
            relations1.BringToFront();
        }


        /* Exit button on click */
        private void MMExitBTN_Click(object sender, EventArgs e)
        {
            // Clos the application with yes/no message box
            if (MessageBox.Show("Are you sure, you want to exit", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
