namespace Methods1;

class Program
{
    static void Main(string[] args)
    {
        // Test the three validation methods directly
        Console.WriteLine("=== Testing HasFourParts ===");
        string[] validParts = {"192", "168", "1", "1"};
        string[] invalidParts = {"192", "168", "1"};
        Console.WriteLine($"4 parts: {HasFourParts(validParts)}");             // True
        Console.WriteLine($"3 parts: {HasFourParts(invalidParts)}");           // False
        
        Console.WriteLine("\n=== Testing IsValidIPPart ===");
        Console.WriteLine($"'192': {IsValidIPPart("192")}");                   // True
        Console.WriteLine($"'255': {IsValidIPPart("255")}");                   // True
        Console.WriteLine($"'256': {IsValidIPPart("256")}");                   // False
        Console.WriteLine($"'01': {IsValidIPPart("01")}");                     // False
        Console.WriteLine($"'abc': {IsValidIPPart("abc")}");                   // False
        
        Console.WriteLine("\n=== Testing IsInValidRange ===");
        Console.WriteLine($"255: {IsInValidRange(255)}");                      // True
        Console.WriteLine($"0: {IsInValidRange(0)}");                          // True
        Console.WriteLine($"256: {IsInValidRange(256)}");                      // False
        Console.WriteLine($"-1: {IsInValidRange(-1)}");                        // False
        
        // Manual IPv4 validation using all 3 methods
        Console.WriteLine("\n=== Manual IPv4 Validation ===");
        string testIP = "192.168.1.1";
        string[] parts = testIP.Split('.');
        
        bool hasCorrectParts = HasFourParts(parts);
        Console.WriteLine($"Has 4 parts: {hasCorrectParts}");
        
        if (hasCorrectParts)
        {
            bool allPartsValid = true;
            foreach (string part in parts)
            {
                if (!IsValidIPPart(part))
                {
                    allPartsValid = false;
                    break;
                }
            }
            Console.WriteLine($"All parts valid: {allPartsValid}");
            Console.WriteLine($"IP {testIP} is valid: {allPartsValid}");
        }
    }
    
    // Method 1: Check if IP has exactly 4 parts
    static bool HasFourParts(string[] parts)
    {
        return parts.Length == 4;
    }
    
    // Method 2: Check if a single part of the IP is valid
    static bool IsValidIPPart(string part)
    {
        // Check if it's a valid number
        if (!int.TryParse(part, out int number))
        {
            return false;
        }
        
        // Check range (0-255)
        if (!IsInValidRange(number))
        {
            return false;
        }
        
        // Check for leading zeros (except for "0" itself)
        if (part.Length > 1 && part[0] == '0')
        {
            return false;
        }
        
        return true;
    }
    
    // Method 3: Check if number is in valid range (0-255)
    static bool IsInValidRange(int number)
    {
        return number >= 0 && number <= 255;
    }
}
