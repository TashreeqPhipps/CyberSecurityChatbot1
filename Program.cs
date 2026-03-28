using System;

class Program
{
    static void Main(string[] args)
    {
        ShowHeader();

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

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
        // General
        if (input.Contains("how are you"))
            return "I'm just code, but I'm here to help you stay safe online!";

        if (input.Contains("purpose") || input.Contains("what do you do"))
            return "My purpose is to teach you cybersecurity basics and protect you from online threats.";

        if (input.Contains("what can i ask"))
            return "You can ask me about passwords, phishing, malware, safe browsing, emails, banking safety, and more.";

        if (input.Contains("help") || input.Contains("tips"))
            return "Tips: Use strong passwords, avoid suspicious links, never share OTPs, and browse securely.";

        // Passwords
        if (input.Contains("password"))
            return "Use strong passwords with uppercase, lowercase, numbers, and symbols. Never reuse passwords.";

        if (input.Contains("strong password"))
            return "A strong password should be at least 12 characters long and include a mix of letters, numbers, and symbols.";

        // Phishing
        if (input.Contains("phishing") || input.Contains("phish") || input.Contains("scam"))
            return "Phishing is when scammers trick you with fake emails or links to steal your personal information.";

        // Safe browsing
        if (input.Contains("safe") || input.Contains("online") || input.Contains("browse"))
            return "Avoid suspicious links, always check URLs, and ensure websites use HTTPS.";

        // Malware
        if (input.Contains("virus") || input.Contains("malware"))
            return "Malware is harmful software. Avoid downloading files from unknown sources.";

        // Email safety
        if (input.Contains("email"))
            return "Be cautious with emails from unknown senders. Avoid clicking suspicious links or attachments.";

        // Banking safety
        if (input.Contains("bank") || input.Contains("otp") || input.Contains("pin"))
            return "Never share your OTP, PIN, or banking details. Banks will never ask for this information.";

        // Social media
        if (input.Contains("social") || input.Contains("facebook") || input.Contains("instagram"))
            return "Avoid sharing personal information on social media. Protect your privacy.";

        // Public WiFi
        if (input.Contains("wifi"))
            return "Public WiFi is risky. Avoid accessing sensitive accounts like banking on public networks.";

        // Identity theft
        if (input.Contains("identity") || input.Contains("theft"))
            return "Identity theft happens when someone steals your personal information. Keep your data secure.";

        // Extra Features
        if (input.Contains("hack") || input.Contains("hacker"))
            return "Hackers try to gain unauthorized access to systems. Always keep your software updated and secure.";

        if (input.Contains("update") || input.Contains("software"))
            return "Always keep your apps and system updated to fix security vulnerabilities.";

        if (input.Contains("link") || input.Contains("url"))
            return "Always hover over links before clicking to check if they are legitimate.";

        if (input.Contains("2fa") || input.Contains("two factor"))
            return "Two-factor authentication adds an extra layer of security by requiring a second verification step.";

        return "I didn’t quite understand that. Try asking about cybersecurity topics like passwords or phishing.";
    }
}