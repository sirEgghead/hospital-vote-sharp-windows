using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumUndetectedChromeDriver;
//using System.ComponentModel;
//using System.Security.Policy;
//using System.Threading;
//using Aspose.Html;
//using Aspose.Html.Collections;

namespace hospital_vote_sharp_windows
{
    public partial class Form1 : Form
    {
        const string url = "https://www.soliant.com/most-beautiful-hospital-contest/vote/southeast-health/";
        const string thankyou = "https://www.soliant.com/most-beautiful-hospital-contest/vote/hospital-detail/thank-you/";
        static int ucTimeout = 2000;
        static int numTabs = 3;
        static int numThreads = 1;
        static List<string> tabHandles = new List<string>();
        static bool cancelVoting = true;
        static bool cancelStats = false;
        public Form1()
        {
            InitializeComponent();

            new Thread(new ThreadStart(doStats)).Start();
        }

        private void doStats()
        {
            while (!cancelStats)
            {
                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        string[] topThreeNames = new string[3];
                        string[] topThreeVotes = new string[3];
                        var tyUrl = new Aspose.Html.Url(thankyou);
                        var htmlDoc = new Aspose.Html.HTMLDocument(tyUrl);
                        var topThree = htmlDoc.QuerySelectorAll(".thehospital");
                        var i = 0;
                        foreach (Aspose.Html.HTMLElement element in topThree)
                        {
                            topThreeNames[i] = element.QuerySelector("div.col-sm-3.hosp-name-col").QuerySelector("p").InnerHTML;
                            topThreeVotes[i] = element.QuerySelector("p.teal.thecount").InnerHTML.Split(" ")[0];
                            i++;
                            if (i == 3) break;
                        }
                        updateStats(topThreeNames, topThreeVotes);
                        Thread.Sleep(500);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }

        private async void doVote()
        {
            while (!cancelVoting)
            {
                using (var driver = UndetectedChromeDriver.Create(driverExecutablePath: await new ChromeDriverInstaller().Auto()))
                {
                    for (int i = 0; i < numTabs; i++)
                    {
                        driver.SwitchTo().NewWindow(WindowType.Tab);
                        tabHandles.Add(driver.CurrentWindowHandle.ToString());
                        driver.GoToUrl(url);
                    }
                    foreach (string tab in tabHandles)
                    {
                        driver.SwitchTo().Window(tab);
                        await driver.Reconnect(timeout: ucTimeout);
                        driver.SwitchTo().Window(tab);
                        driver.FindElement(By.Id("recaptcha")).Click();
                    }
                    WebDriverWait wait = new(driver, TimeSpan.FromSeconds(8));
                    driver.Quit();
                    tabHandles.Clear();
                }
            }
            updateButton("Start", true);
        }

        protected void updateStats(string[] topThreeNames, string[] topThreeVotes)
        {
            string margin12 = (int.Parse(topThreeVotes[0].Replace(",", "")) - int.Parse(topThreeVotes[1].Replace(",", ""))).ToString("N0");
            string margin23 = (int.Parse(topThreeVotes[1].Replace(",", "")) - int.Parse(topThreeVotes[2].Replace(",", ""))).ToString("N0");

            if (lblFirstName.InvokeRequired)
                lblFirstName.Invoke(new MethodInvoker(() => lblFirstName.Text = topThreeNames[0]));
            else lblFirstName.Text = topThreeNames[0];

            if (lblSecondName.InvokeRequired)
                lblSecondName.Invoke(new MethodInvoker(() => lblSecondName.Text = topThreeNames[1]));
            else lblSecondName.Text = topThreeNames[1];

            if (lblThirdName.InvokeRequired)
                lblThirdName.Invoke(new MethodInvoker(() => lblThirdName.Text = topThreeNames[1]));
            else lblThirdName.Text = topThreeNames[2];

            if (lblFirstVotes.InvokeRequired)
                lblFirstVotes.Invoke(new MethodInvoker(() => lblFirstVotes.Text = topThreeVotes[0]));
            else lblFirstVotes.Text = topThreeVotes[0];

            if (lblSecondVotes.InvokeRequired)
                lblSecondVotes.Invoke(new MethodInvoker(() => lblSecondVotes.Text = topThreeVotes[1]));
            else lblSecondVotes.Text = topThreeVotes[1];

            if (lblThirdVotes.InvokeRequired)
                lblThirdVotes.Invoke(new MethodInvoker(() => lblThirdVotes.Text = topThreeVotes[2]));
            else lblThirdVotes.Text = topThreeVotes[2];

            if (lblMargin12.InvokeRequired)
                lblMargin12.Invoke(new MethodInvoker(() => lblMargin12.Text = margin12.ToString()));
            else lblMargin12.Text = margin12;

            if (lblMargin23.InvokeRequired)
                lblMargin23.Invoke(new MethodInvoker(() => lblMargin23.Text = margin23.ToString()));
            else lblMargin23.Text = margin23;

            return;
        }

        protected void updateButton(string text, bool enabled)
        {
            if (btnVote.InvokeRequired) btnVote.Invoke(new MethodInvoker(() =>
            {
                btnVote.Text = text;
                btnVote.Enabled = enabled;
            }));
            else
            {
                btnVote.Text = text;
                btnVote.Enabled = enabled;
            }
        }

        private async void btnVote_Click(object sender, EventArgs e)
        {
            cancelVoting = !cancelVoting;
            if (cancelVoting) updateButton("Waiting", false);
            else
            {
                updateButton("Stop", true);
                await Task.Run(() => doVote());
            }
        }

        private void udTabs_ValueChanged(object sender, EventArgs e)
        {
            numTabs = Decimal.ToInt32(udTabs.Value);
        }

        private void udTimeout_ValueChanged(object sender, EventArgs e)
        {
            ucTimeout = Decimal.ToInt32(udTimeout.Value);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancelStats = true;
        }
    }
}
