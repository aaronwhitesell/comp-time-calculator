using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompTimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePickerStartTravel.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartTravel.CustomFormat = "hh:mm tt";
            dateTimePickerStartTravel.ShowUpDown = true;
            dateTimePickerStartTravel.Value = Convert.ToDateTime("12:00 PM");

            dateTimePickerEndTravel.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndTravel.CustomFormat = "hh:mm tt";
            dateTimePickerEndTravel.ShowUpDown = true;
            dateTimePickerEndTravel.Value = Convert.ToDateTime("12:00 PM");

            dateTimePickerStartWork.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartWork.CustomFormat = "hh:mm tt";
            dateTimePickerStartWork.ShowUpDown = true;
            dateTimePickerStartWork.Value = Convert.ToDateTime("12:00 PM");

            dateTimePickerEndWork.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndWork.CustomFormat = "hh:mm tt";
            dateTimePickerEndWork.ShowUpDown = true;
            dateTimePickerEndWork.Value = Convert.ToDateTime("12:00 PM");

            dateTimePickerCap.Format = DateTimePickerFormat.Custom;
            dateTimePickerCap.CustomFormat = "HH:mm";
            dateTimePickerCap.ShowUpDown = true;
            dateTimePickerCap.Value = Convert.ToDateTime("00:00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startTravel = dateTimePickerStartTravel.Value;
            DateTime endTravel = dateTimePickerEndTravel.Value;
            TimeSpan travelSpan = Program.TimeDifference(startTravel, endTravel);
            double travelDecimal = Program.ToDecimalHour(travelSpan);
            textTravelTime.Text = Program.ToString(travelSpan);
            textTravelDecimal.Text = Program.ToString(travelDecimal);

            DateTime startWork = dateTimePickerStartWork.Value;
            DateTime endWork = dateTimePickerEndWork.Value;
            TimeSpan workSpan = Program.TimeDifference(startWork, endWork);
            double workDecimal = Program.ToDecimalHour(workSpan);
            textWorkTime.Text = Program.ToString(workSpan);
            textWorkDecimal.Text = Program.ToString(workDecimal);

            DateTime cap = dateTimePickerCap.Value;
            TimeSpan capSpan = new TimeSpan(cap.Hour, cap.Minute, 0);
            double capDecimal = Program.ToDecimalHour(cap);
            textCapDecimal.Text = Program.ToString(capDecimal);

            double eligibleMealTime = travelDecimal - workDecimal - capDecimal;
            double mealTimeDecimal = eligibleMealTime / 8.5 * 0.5;
            TimeSpan mealTimeSpan = Program.ToTimeSpan(mealTimeDecimal);
            textMealTime.Text = Program.ToString(mealTimeSpan);
            textMealDecimal.Text = Program.ToString(mealTimeDecimal);

            double compDecimal = travelDecimal - workDecimal - mealTimeDecimal - capDecimal;
            TimeSpan compSpan = Program.ToTimeSpan(compDecimal);
            textCompTime.Text = Program.ToString(compSpan);
            textCompDecimal.Text = Program.ToString(compDecimal);
        }
    }
}
