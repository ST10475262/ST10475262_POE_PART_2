using ST10475262_POE_PART_2;

namespace ST10475262_POE_PART_2
{
    public partial class Form1 : Form
    {
        List<ResponseDelegate> responseHandlers = new List<ResponseDelegate>(); //list of delegates pointing to all our response methods
        public Form1()
        {
            InitializeComponent();
            SetupDelegateList();

        }

        private void SetupDelegateList() //method to fill the delegate list with all our topic methods
        {
            responseHandlers.Add(RobotResponses.Hello);                 //greetings
            responseHandlers.Add(RobotResponses.Greeting);             //how are you questions
            responseHandlers.Add(RobotResponses.Purpose);               //what do you do
            responseHandlers.Add(RobotResponses.Help);                  //help / topic list
            responseHandlers.Add(RobotResponses.PasswordManagers);      //password managers - MUST come before Passwords
            responseHandlers.Add(RobotResponses.Passwords);             //password safety
            responseHandlers.Add(RobotResponses.TwoFactorAuthentication); //2fa
            responseHandlers.Add(RobotResponses.Phishing);              //phishing
            responseHandlers.Add(RobotResponses.Malware);               //malware and viruses
            responseHandlers.Add(RobotResponses.Antivirus);             //antivirus
            responseHandlers.Add(RobotResponses.SocialEngineering);     //social engineering
            responseHandlers.Add(RobotResponses.DataPrivacy);           //data privacy
            responseHandlers.Add(RobotResponses.SafeBrowsing);          //safe browsing
            responseHandlers.Add(RobotResponses.Exit);                  //exit / goodbye
        }

        private void ShowWelcomeMessage() //displays the welcome message when the app starts
        {
            AddBotMessage("Welcome to Cypherr Bot - your Cybersecurity Awareness Assistant!\n\n" +
                          "Tell me your name to get started, or ask about:\n" +
                          "Passwords, Phishing, Malware, 2FA, Antivirus, Privacy, Safe Browsing.\n\n" +
                          "Type 'help' to see all topics.  Type 'exit' to quit.");
        }

        private void AddBotMessage(string message) //adds a bot message to the left side of the chat
        {
            Panel messagePanel = CreateMessagePanel(message, isBotMessage: true); //create a left-aligned panel
            panelDisplay.Controls.Add(messagePanel); //add the panel to the chat flow
            ScrollToBottom(); //scroll down so the new message is visible
        }

        private Panel CreateMessagePanel(string message, bool isBotMessage) //creates a coloured message panel
        {
            //the outer panel takes the full width and is used to push the bubble left or right
            Panel outerPanel = new Panel();
            outerPanel.Width = panelDisplay.ClientSize.Width - 20; //match the width of the chat area
            outerPanel.AutoSize = true; //grow to fit the content inside
            outerPanel.BackColor = Color.Transparent; //transparent so the chat background shows through

            //the name label shows who sent the message ("Cypherr" or the user's name)
            Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 8f, FontStyle.Bold); //small bold font for the name

            //the message label holds the actual text of the message
            Label messageLabel = new Label();
            messageLabel.Text = message; //set the message text
            messageLabel.Font = new Font("Segoe UI", 10f); //readable font size
            messageLabel.AutoSize = true;
            messageLabel.MaximumSize = new Size((outerPanel.Width / 2) + 80, 0); //limit width to half the panel so it looks like a bubble
            messageLabel.Padding = new Padding(10, 8, 10, 8); //padding inside the bubble

            if (isBotMessage) //bot messages go on the LEFT
            {
                nameLabel.Text = "Cypherr"; //bot name label
                nameLabel.ForeColor = Color.FromArgb(56, 189, 248); //cyan colour for the bot name
                nameLabel.Location = new Point(5, 2); //position name label at the top left

                messageLabel.BackColor = Color.FromArgb(21, 51, 78); //dark teal background for bot messages
                messageLabel.ForeColor = Color.FromArgb(230, 237, 243); //light grey text
                messageLabel.Location = new Point(5, nameLabel.Height + 4); //position below the name label
            }
            else //user messages go on the RIGHT
            {
                //check if we remember the user's name to display it
                string displayName = "You";
                if (RobotResponses.memory.ContainsKey("name"))
                {
                    displayName = RobotResponses.memory["name"]; //use the remembered name
                }

                nameLabel.Text = displayName; //user's name label
                nameLabel.ForeColor = Color.FromArgb(74, 222, 128); //green colour for the user name
                messageLabel.BackColor = Color.FromArgb(35, 71, 34); //dark green background for user messages
                messageLabel.ForeColor = Color.FromArgb(230, 237, 243); //light grey text

                //measure the label so we can push it to the right side
                messageLabel.Location = new Point(5, nameLabel.Height + 4); //position below name label temporarily

                //we'll adjust the position after adding to the panel so it sits on the right
                outerPanel.SizeChanged += (s, e) => //wait until the panel knows its size, then position on the right
                {
                    int rightX = outerPanel.Width - messageLabel.Width - 5; //calculate right-aligned X position
                    messageLabel.Location = new Point(rightX, nameLabel.Height + 4); //move bubble to the right
                    nameLabel.Location = new Point(rightX, 2); //move name label to match
                };
            }

            outerPanel.Controls.Add(nameLabel);    //add name label to the panel
            outerPanel.Controls.Add(messageLabel); //add message label to the panel

            return outerPanel; //return the complete message panel
        }

        private void ScrollToBottom() //scrolls the chat to show the most recent message
        {
            if (panelDisplay.Controls.Count > 0)
            {
                panelDisplay.ScrollControlIntoView(panelDisplay.Controls[panelDisplay.Controls.Count - 1]); //scroll to the last control
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
