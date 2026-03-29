using System;
using System.Media;

class Program
{
    static void Main(string[] args)
    {
        PlayGreeting();// Audio

        ShowHeader();

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine() ?? "User";

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nWelcome, {userName}!");
        Console.ResetColor();

        Console.WriteLine("I am your Cybersecurity Awareness Bot.");
        Console.WriteLine("Ask me anything about staying safe online.");
        Console.WriteLine("Tip: Never share your passwords with anyone! 🔐");
        Console.WriteLine("Type 'exit' to quit.\n");

        RunChatbot(userName);
    }

    static void ShowHeader()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"
   ____            _                ____        _   
  / ___| _   _ ___| |_ ___ _ __    | __ )  ___ | |_ 
  \___ \| | | / __| __/ _ \ '__|   |  _ \ / _ \| __|
   ___) | |_| \__ \ ||  __/ |      | |_) | (_) | |_ 
  |____/ \__, |___/\__\___|_|      |____/ \___/ \__|
         |___/                                     
");

        Console.WriteLine("=== CYBERSECURITY AWARENESS CHATBOT ===");
        Console.WriteLine("========================================\n");

        Console.ResetColor();
    }

    // AUDIO METHOD 
    static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("Greeting.wav");
            player.PlaySync(); // plays audio
        }
        catch
        {
            Console.WriteLine("Audio file not found.");
        }
    }

    static void RunChatbot(string userName)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nYou: ");
            Console.ResetColor();

            string input = Console.ReadLine()?.ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bot: Please enter something.");
                Console.ResetColor();
                continue;
            }

            if (input == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nBot: Goodbye! Stay safe online.");
                Console.ResetColor();
                break;
            }

            Console.WriteLine("-----------------------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bot: " + GetResponse(input));
            Console.ResetColor();

            Console.WriteLine("-----------------------------------");
        }
    }

    static string GetResponse(string input)
    {
        if (input.Contains("how are you"))
            return "I'm just code, but I'm here to help you stay safe online!";

        if (input.Contains("purpose") || input.Contains("what do you do"))
            return "My purpose is to teach you cybersecurity basics and protect you from online threats.";

        if (input.Contains("what can i ask"))
            return "You can ask me about passwords, phishing, malware, safe browsing, emails, banking safety, and more.";

        if (input.Contains("help") || input.Contains("tips"))
            return "Tips: Use strong passwords, avoid suspicious links, never share OTPs, and browse securely.";

        if (input.Contains("password"))
            return "Use strong passwords with uppercase, lowercase, numbers, and symbols. Never reuse passwords.";

        if (input.Contains("strong password"))
            return "A strong password should be at least 12 characters long and include a mix of letters, numbers, and symbols.";

        if (input.Contains("phishing") || input.Contains("phish") || input.Contains("scam"))
            return "Phishing is when scammers trick you with fake emails or links to steal your personal information.";

        if (input.Contains("safe") || input.Contains("online") || input.Contains("browse"))
            return "Avoid suspicious links, always check URLs, and ensure websites use HTTPS.";

        if (input.Contains("virus") || input.Contains("malware"))
            return "Malware is harmful software. Avoid downloading files from unknown sources.";

        if (input.Contains("email"))
            return "Be cautious with emails from unknown senders.";

        if (input.Contains("bank") || input.Contains("otp") || input.Contains("pin"))
            return "Never share your OTP, PIN, or banking details.";

        if (input.Contains("social"))
            return "Avoid sharing personal information on social media.";

        if (input.Contains("wifi"))
            return "Public WiFi is risky. Avoid banking on it.";

        if (input.Contains("identity"))
            return "Identity theft happens when someone steals your info.";

        if (input.Contains("hack"))
            return "Hackers try to access systems. Keep software updated.";

        if (input.Contains("update"))
            return "Always update your apps to stay secure.";

        if (input.Contains("link"))
            return "Check links before clicking.";

        if (input.Contains("2fa"))
            return "2FA adds extra security.";

        return "I didn’t quite understand that. Try asking about cybersecurity topics.";
    }
}