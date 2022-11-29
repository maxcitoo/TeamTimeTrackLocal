using System.Globalization;
using System.Xml.Serialization;

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
            int selectedMonth = int.Parse(comboBoxMonth.SelectedItem.ToString());
            int selectedYear = int.Parse(comboBoxYear.SelectedItem.ToString());
            float startTime   = float.Parse(textBoxStartTime.Text);
            float endTime = float.Parse(textBoxEndTime.Text);
            float hours = endTime - startTime;
            float workBreak = float.Parse(textBoxBreak.Text);
            string task =  richTextBoxTasks.Text;

            table.Add(new object[] { selectedDay, selectedMonth, selectedYear, startTime, endTime, hours, workBreak, task });

            addDayText();

            richTextBoxControlWindow.Text += "Datum\t\tStatzeit\t\tEndzeit\t\tStunden\t\tPause\t\t" + @"
                
";
            for (int i = 0; i < table.Count; i++)
            {
                printDay(i);
            }
        }


        //Function for Add Day Text 
        void addDayText()
        {
            richTextBoxControlWindow.Text += "Du hast den folgenden Tag hinzugefügt" + @":

";

        }

        void printDay(int rowNumber)
        {
            printDaydetail((int)table[rowNumber][0], (int)table[rowNumber][1], (int)table[rowNumber][2],
            (float)table[rowNumber][3], (float)table[rowNumber][4], (float)table[rowNumber][5], (float)table[rowNumber][6], (string)table[rowNumber][7]);
        }

        void printDaydetail(int selectedDay, int selectedMonth, int selectedYear, float startTime, float endTime, float hours, float workbreak, string task)
        {

            

            richTextBoxControlWindow.Text += selectedDay + "." + selectedMonth + "." + selectedYear + "\t\t" + startTime + " Uhr" + "\t\t" + endTime + " Uhr" + "\t\t" + hours + "\t\t" + workbreak + "\t\t" + task + @"
";

        }
        private void textBoxStartTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            richTextBoxControlWindow.ResetText();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

            int selectedDay = int.Parse(comboBoxDay.SelectedItem.ToString());
            int selectedMonth = int.Parse(comboBoxMonth.SelectedItem.ToString());
            int selectedYear = int.Parse(comboBoxYear.SelectedItem.ToString());
            float startTime = float.Parse(textBoxStartTime.Text);
            float endTime = float.Parse(textBoxEndTime.Text);
            float hours = endTime - startTime;
            float workBreak = float.Parse(textBoxBreak.Text);
            string task = richTextBoxTasks.Text;


            List<dayTime> d1 = new List<dayTime>();
            XmlSerializer serial = new XmlSerializer(typeof(List<dayTime>));
            d1.Add(new dayTime() { Day = selectedDay, Month = selectedMonth, Year = selectedYear, startTime = startTime, endTime = endTime, hours = hours, workBreak = workBreak, Task = task});
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Day_Data.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, d1);
                MessageBox.Show("Created");
            }
        }   

    }   
        
}