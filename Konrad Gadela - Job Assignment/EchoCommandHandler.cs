using System.Text;

namespace Konrad_Gadela___Job_Assignment
{
    public class EchoCommandHandler : ICommandHandler
    {
        public string Handle(string input)
        {
            string[] splittedInput = input.Split(" ");
            var stringBuilder = new StringBuilder();

            for (int i = 1; i < splittedInput.Length; i++)
            {
                stringBuilder.Append(splittedInput[i]);
                stringBuilder.Append(" ");
            }

            return stringBuilder.ToString();
        }
    }
}