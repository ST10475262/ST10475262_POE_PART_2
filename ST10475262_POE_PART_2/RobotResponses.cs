using System;
using System.Collections.Generic;
using System.Text;

namespace ST10475262_POE_PART_1
{

    public class RobotResponses
    {
        static Random rand = new Random();//global randomizer for responses
        static string botName = "Cypherr: "; //global variable to store the bot's name
        
        
        static void TypeResponse(string message, int delay = 25)//types out the bot's responses character by character over a period of time
        {
            foreach (char c in message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        /*public static bool Hello(string input)//metjod to handle user greetings
        {
            if (input.Contains("hi") || input.Contains("hello") || input.Contains("hey"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000);//a slight delay before the chatbot responds


                //an array to store responses to questions related to greetings
                string[] responses ={$"hi {ASCIIArt.name}, hope you're doing great! Ready to talk cybersecurity?",
                                     $"hey {ASCIIArt.name}! Let's talk cybersecurity!!",
                                     $"hello {ASCIIArt.name} I hope you're doing great! Ready to talk about cybersecurity?"};

                TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);//selects a random response from the array(0,1,2)

                Console.ResetColor();
                return true;
            }
            return false;
        }*/

        public static bool Greeting(string input)
        {
            if (input.Contains("how are you") || input.Contains("how's it going") || input.Contains("how are you doing"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000);//a slight delay before the chatbot responds


                //an array to store responses to questions related to greetings
                string[] responses ={"I'm running smoothly! Ready to discuss cybersecurity?",
                                     "All systems operational! Let's talk cybersecurity!!",
                                     "Doing great! Ready to talk about cybersecurity?",
                                     "I'm good! How can I help you stay safe online?"};

                TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);//selects a random response from the array(0,1,2,3)

                Console.ResetColor();
                return true;
            }
            return false;
        }

        public static bool Purpose(string input)//method to state the purpose / use of the bot
        {
            if (input.Contains("purpose") || input.Contains("what do you do") || input.Contains("what can you do"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000);//a slight delay before the chatbot responds

                Console.WriteLine("=========================================================================================\n" +
                                  "\t\t\t\t WHAT'S MY PURPOSE\n" +
                                  "=========================================================================================");
                //the array storing responses to the specified keywords
                string[] responses ={"My purpose is to help people learn about cybersecurity.",
                                     "I provide tips on staying safe online.",
                                     "I'm here to answer questions about internet safety."};

                TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);//selects a random response from the array(0,1,2)

                Console.ResetColor();
                return true;
            }
            return false;
        }

        public static bool Help(string input)// method to give the user topics to question the bot about
        {
            if (input.Contains("what can i ask") || input.Contains("help with") || input.Contains("help"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000);//a slight delay before the chatbot responds

                Console.WriteLine("=========================================================================================\n" +
                                  "\t\t\t\t HELP\n" +
                                  "=========================================================================================");

                TypeResponse($"{botName} You can ask me about passwords, password managers, 2FA(Two-Factor Authentication),\n" +
                                  "phishing, malware, antiviruses, social engrinnering, data privacy and safe browsing.");

                Console.ResetColor();
                return true;
            }
            return false;
        }

        public static bool Passwords(string input)
        {
            if (input.Contains("password") || input.Contains("password safety"))//method to respond to password safety
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000); //a slight delay before the chatbot responds

                Console.WriteLine("=========================================================================================\n" +
                                  "\t\t\t\t PASSWORD SAFETY\n" +
                                  "=========================================================================================");

                string[] responses = {"When creating a password, ALWAYS avoid using personal information such as your name, birthdate,\n" +
                                      "etc. Use a combination of uppercase and lowercase letters, numbers, and special characters to \n" +
                                      "make your password stronger.\n\n" +
                                      "It is also important to use a different password for each account. Consider using a\n" +
                                      "password manager and enable two-factor authentication for added security.",

                                      "A strong password is essential for protecting your accounts from hackers. Avoid using common\n" +
                                      "words and predictable patterns. Instead, ypu must create long and unique passwords that are hard\n" +
                                      "to guess.\n\n" +
                                      "Never reuse passwords across multiple platforms. If one gets compromised, all your\n" +
                                      "accounts could be at risk. Using a password manager can help keep track of them safely\n" +
                                      "and two-factor authentication increases the security on you account.",

                                      "Cybercriminals often target weak passwords using automated attacks. Avoid using any words related\n" +
                                      "to you such as names, dates and hobbies. To ensure that you stay safe and protect your account, make\n" +
                                      "sure your password is at least 12 characters long and includes a variety of character types.\n\n" +
                                      "Enable two-factor authentication (2FA) wherever possible, as it adds an extra layer of\n" +
                                      "protection beyond just your password."};

                TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);

                Console.ResetColor();
                return true;
            }
            return false;
        }

        public static bool PasswordManagers(string input)//method to respond to password managers
        {
            if (input.Contains("password manager"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("=========================================================================================\n" +
                                  "\t\t\t\t PASSWORD MANAGERS\n" +
                                  "=========================================================================================");

                string[] responses =  {"A password manager securely stores all your passwords in one place.\n" +
                                       "You only need to remember one master password to access everything.\n\n" +
                                       "It can also generate strong, unique passwords for each account,\n" +
                                       "helping you avoid reuse and improving your security.",

                                       "Managing multiple passwords can be difficult, which is why password managers are useful.\n" +
                                       "They store your login details securely and autofill them when needed.\n\n" +
                                       "Most password managers use encryption, meaning your data is protected\n" +
                                       "even if someone gains access to the storage.",

                                       "Using a password manager reduces the risk of weak or repeated passwords.\n" +
                                       "It helps you create long, complex passwords without needing to remember them.\n\n" +
                                       "This is one of the easiest ways to improve your overall cybersecurity."};

                TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);

                Console.ResetColor();
                return true;
            }
            return false;
        }

        public static bool TwoFactorAuthentication(string input)//method to respond to two-factor authentication
        {
            if (input.Contains("2fa") || input.Contains("two factor") || input.Contains("two-factor"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("=========================================================================================\n" +
                                  "\t\t\t\t TWO-FACTOR AUTHENTICATION\n" +
                                  "=========================================================================================");

                string[] responses ={"Two-Factor Authentication (2FA) adds an extra layer of security to your accounts.\n" +
                                     "In addition to your password, you must provide a second form of verification.\n\n" +
                                     "This could be a code sent to your phone or generated by an authenticator app.",

                                     "Even if someone steals your password, 2FA can stop them from accessing your account.\n" +
                                     "It requires a second step, such as a fingerprint, OTP, or security key.\n\n" +
                                     "This makes your accounts much harder to compromise.",

                                     "Enabling 2FA is one of the best ways to protect sensitive accounts.\n" +
                                     "It ensures that logging in requires something you know (password)\n" +
                                     "and something you have (like your phone).\n\n" +
                                     "Always enable it on email, banking, and social media accounts."};

                TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);

                Console.ResetColor();
                return true;
            }
            return false;
        }

        public static bool Phishing(string input)//method to respond to phishing
        {
            if (input.Contains("phishing"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("=========================================================================================\n" +
                                  "\t\t\t\t PHISHING\n" +
                                  "=========================================================================================");

                string[] responses ={"Phishing is a cyber attack where attackers trick you into revealing sensitive information.\n" +
                                     "They often pretend to be trusted organisations through emails or messages.\n\n" +
                                     "Always verify the sender before clicking any links or sharing personal data.",

                                     "Attackers use phishing to steal passwords, banking details, and personal information.\n" +
                                     "They create fake websites or urgent messages to pressure you into acting quickly.\n\n" +
                                     "Be cautious of unexpected emails and avoid clicking suspicious links.",

                                     "A common sign of phishing is urgency, such as messages claiming your account is at risk.\n" +
                                     "These messages try to make you panic and act without thinking.\n\n" +
                                     "Always double-check URLs and confirm requests directly with the organisation."};

                TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);

                Console.ResetColor();
                return true;
            }
            return false;
        }

        public static bool Malware(string input)//method to respond to malware
        {
            if (input.Contains("malware") || input.Contains("virus"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("=========================================================================================\n" +
                                  "\t\t\t\t MALWARE AND VIRUSES\n" +
                                  "=========================================================================================");

                string[] responses ={"Malware is malicious software designed to harm your device or steal your data.\n\n" +
                                     "It includes viruses, worms, trojans, ransomware, spyware, and adware.\n" +
                                     "Each type behaves differently but all aim to compromise your system.\n\n" +
                                     "Avoid downloading files from untrusted sources and always keep your system updated.",

                                     "Viruses and malware can spread through infected files, downloads, or email attachments.\n" +
                                     "Some malware runs silently in the background, collecting your personal information.\n\n" +
                                     "Be cautious of unknown links and always scan files before opening them.\n" +
                                     "Using security software greatly reduces your risk.",

                                     "Ransomware is a dangerous type of malware that locks your files and demands payment.\n" +
                                     "Spyware secretly tracks your activity, while trojans disguise themselves as safe programs.\n\n" +
                                     "Keeping backups of your data and avoiding suspicious downloads can protect you."};

                TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);

                Console.ResetColor();
                return true;
            }
            return false;
        }

        public static bool Antivirues(string input)//method to respond to antiviruses
        {
            if (input.Contains("antivirus"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("=========================================================================================\n" +
                                  "\t\t\t\t ANTIVIRUSES\n" +
                                  "=========================================================================================");

                string[] responses ={"Antivirus software helps detect and remove malware from your device.\n\n" +
                                     "It scans files and programs for suspicious behavior and blocks threats in real time.\n" +
                                     "Keeping it updated ensures protection against the latest threats.",

                                     "A good antivirus program acts as your first line of defense against cyber attacks.\n\n" +
                                     "It can quarantine infected files and prevent harmful software from running.\n" +
                                     "Regular scans help keep your system clean and secure.",

                                     "Antivirus tools use databases of known threats and behavior analysis to detect malware.\n\n" +
                                     "Enabling real-time protection and scheduling automatic scans\n" +
                                     "can significantly reduce your chances of infection."};

                TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);

                Console.ResetColor();
                return true;
            }
            return false;
        }

        public static bool SocialEngineering(string input)//method to respond to social engineering
        {
            if (input.Contains("social engineering"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("=========================================================================================\n" +
                                  "\t\t\t\t SOCIAL ENGINEERING\n" +
                                  "=========================================================================================");

                string[] responses ={"Social engineering attacks manipulate people into revealing sensitive information.\n\n" +
                                     "Attackers often pretend to be trusted individuals or organisations.\n" +
                                     "This can include fake emails, phone calls, or messages.\n\n" +
                                     "Always verify identities before sharing personal information.",

                                     "Instead of hacking systems, social engineering targets human behavior.\n\n" +
                                     "Common tactics include phishing, impersonation, and urgent requests.\n" +
                                     "Attackers rely on fear and urgency to trick victims.\n\n" +
                                     "Stay calm and double-check suspicious requests.",

                                     "A common social engineering trick is pretending to be technical support or a bank.\n\n" +
                                     "They may ask for passwords or sensitive details.\n" +
                                     "Legitimate organisations will never ask for this information directly.\n\n" +
                                     "Never share confidential data with unverified sources."};

                TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);

                Console.ResetColor();
                return true;
            }
            return false;
        }

        public static bool DataPrivacy(string input)//method to respond to data privacy
        {
            if (input.Contains("data privacy") || input.Contains("privacy"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("=========================================================================================\n" +
                                  "\t\t\t\t DATA PRIVACY\n" +
                                  "=========================================================================================");

                string[] responses ={"Data privacy is about protecting your personal information online.\n\n" +
                                     "This includes your name, location, financial details, and browsing activity.\n" +
                                     "Limiting what you share online helps reduce your risk.",

                                     "Many websites collect user data, sometimes without you realising it.\n\n" +
                                     "Always review privacy settings and permissions on apps and platforms.\n" +
                                     "Only share information that is necessary.",

                                     "Protecting your data involves using strong passwords and secure connections.\n\n" +
                                     "Avoid public Wi-Fi for sensitive transactions and use trusted applications.\n" +
                                     "Being cautious online helps keep your information safe."};

                TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);

                Console.ResetColor();
                return true;
            }
            return false;
        }


        public static bool SafeBrowsing(string input)
        {
            if (input.Contains("safe browsing") || input.Contains("browse safely")) //method to respond to safely browsing the internet
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("=========================================================================================\n" +
                                  "\t\t\t\t SAFE BROWSING\n" +
                                  "=========================================================================================");

                string[] responses ={"Safe browsing means using the internet in a way that protects your data and devices.\n\n" +
                                     "Always check for HTTPS in website URLs to ensure a secure connection.\n" +
                                     "Avoid clicking suspicious links or pop-ups.",
                                      
                                     "Many cyber threats come from unsafe websites and downloads.\n\n" +
                                     "Only download files from trusted sources and avoid unknown links.\n" +
                                     "Keeping your browser updated helps protect against vulnerabilities.",

                                     "Be cautious when browsing unfamiliar websites.\n\n" +
                                     "Look out for signs like poor design, strange URLs, or unexpected downloads.\n" +
                                     "Using security tools and updated browsers improves your safety online."};

                TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);

                Console.ResetColor();
                return true;
            }
            return false;
        }


        public static void DefaultResponse() //method to handle exceptions such as questions outside the bot's scope and blank questions
        {
            Console.ForegroundColor = ConsoleColor.Red;

            string[] responses ={"I'm not sure I understand. Try asking about cybersecurity.",
                                 "Could you rephrase that?",
                                 "Please rephrase your question, I can help with passwords, phishing, and online safety.",
                                 "Try asking about cybersecurity topics."};

            TypeResponse($"{botName} " + responses[rand.Next(responses.Length)]);//selects a random response from the array when the prompt is blank not in the specified topics
            Console.ResetColor();
        }


        public static bool Exit(string input)//method to terminate the conversation
        {
            if (input.Contains("exit") || input.Contains("quit"))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                System.Threading.Thread.Sleep(1000);//a slight delay before the chatbot responds

                Console.WriteLine("=========================================================================================");
                TypeResponse("\t\t\t\tGoodbye! Stay safe online.");
                Console.WriteLine("=========================================================================================");


                Console.ResetColor();
                return true;
            }
            return false;
        }
    }
}