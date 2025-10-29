using System.Linq;

namespace Domain
{
    public class CalculateUseCase
    {
        public string Process(string input)
        {
            if (!ValidateInput(input))
                return "Error";

            var parts = input.Split('+');
            if (parts.Length != 2)
                return "Error";

            if (!int.TryParse(parts[0], out int a) || !int.TryParse(parts[1], out int b))
                return "Error";

            return (a + b).ToString();
        }
        
        private bool ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            var plusCount = input.Count(c => c == '+');
            if (plusCount != 1)
                return false;

            var parts = input.Split('+');
            if (parts.Length != 2)
                return false;

            foreach (var part in parts)
            {
                if (string.IsNullOrEmpty(part))
                    return false;

                if (part.Any(c => !char.IsDigit(c)))
                    return false;
                
            }

            return true;
        }
    }
}