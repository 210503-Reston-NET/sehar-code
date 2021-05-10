namespace SUI
{
    public interface IValidateService
    {
        /// <summary>
        /// Takes in a prompt, and keeps asking that prompt till the end user returns a valid string
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        string ValidateString(string prompt);
        double ValidateDouble(string prompt);
        int ValidateInt(string prompt);
    }
}