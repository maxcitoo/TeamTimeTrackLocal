namespace TeamTimeTrack
{
    public partial class Form1 : Form
    {

        List<object[]> table = new List<object[]>();
        public Form1()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {
          

        }

        private void buttonAddDay_Click(object sender, EventArgs e)
        {
            int selectedDay = int.Parse(comboBoxDay.SelectedItem.ToString());
            int selectedMonth = int.Parse(comboBoxDay.SelectedItem.ToString());
            int selectedYear = int.Parse(comboBoxDay.SelectedItem.ToString());
            int startTime   = int.Parse(textBoxStartTime.ToString());
            int endTime = int.Parse(textBoxEndTime.ToString());
            int hours = endTime - startTime;
            int workBreak = int.Parse(textBoxBreak.ToString());
            string task =  richTextBoxTasks.Text;

            table.Add(new object[] { selectedDay, selectedMonth, selectedYear, startTime, endTime, hours, workBreak, workBreak  });

            addDayText();

            richTextBoxControlWindow.Text += "Datum\t\tStatzeit\t\tEndzeit\t\tStunden\t\tPause\t\t" + @"
                
";
        }


        //Funvtion for Add Day Text
        void addDayText()
        {
            richTextBoxControlWindow.Text += "Du hast den folgenden Tag hinzugefügt" + @":

";

        }

        private void textBoxStartTime_TextChanged(object sender, EventArgs e)
        {

        }
    }   
        
}