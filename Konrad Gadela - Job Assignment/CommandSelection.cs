namespace Konrad_Gadela___Job_Assignment
{
    public class CommandSelection
    {
        public static string SelectCommand(string request)
        {
            var userInput = request.Split(" ");
            return userInput[0];
        }
    }
}