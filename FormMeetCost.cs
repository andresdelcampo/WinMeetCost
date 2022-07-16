using System.Configuration;
using System.Diagnostics;

namespace WinMeetCost
{
    public partial class FormMeetCost : Form
    {
        private Stopwatch stopWatch = new Stopwatch();
        private int avgCostPerHour;
        private int numAttendees;
        private string currencySymbol;
        private string screenLocation;

        private int currentCost;

        public FormMeetCost()
        {
            InitializeComponent();

            var appSettings = ConfigurationManager.AppSettings;
            avgCostPerHour = int.Parse(appSettings["AvgCostPerHour"] ?? "500");
            numAttendees = int.Parse(appSettings["NumAttendees"] ?? "5");
            currencySymbol = appSettings["CurrencySymbol"] ?? "kr";
            screenLocation = appSettings["ScreenLocation"] ?? "Left";
        }

        private void FormCountdown_Load(object sender, EventArgs e)
        {
            SetLocation();
            InitCostLabel();
            UpdateAttendeesLabel();

            stopWatch.Start();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateCostLabel();
        }

        private void SetLocation()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);

            Location = screenLocation switch
            {
                "Right" => new Point(workingArea.Right - Size.Width,
                                     workingArea.Bottom - Size.Height),
                "Center" => new Point(workingArea.Right / 2 - Size.Width / 2,
                                      workingArea.Bottom - Size.Height),
                _ => new Point(0, workingArea.Bottom - Size.Height),
            };
        }

        private void InitCostLabel()
        {
            labelCost.Text = $"{0:n0} {currencySymbol}";
        }

        private void UpdateCostLabel()
        {
            currentCost += (int) ((timer.Interval * numAttendees * avgCostPerHour) / (3600.0 * 1000.0));
            labelCost.Text = $"{currentCost:n0} {currencySymbol}";
        }

        private void UpdateAttendeesLabel()
        {
            labelAttendees.Text = numAttendees.ToString() + "☺";
        }

        private void labelMinusAttendee_Click(object sender, EventArgs e)
        {
            if (numAttendees > 0)
                numAttendees--;
            UpdateAttendeesLabel();
        }

        private void labelPlusAttendee_Click(object sender, EventArgs e)
        {
            numAttendees++;
            UpdateAttendeesLabel();
        }
    }
}