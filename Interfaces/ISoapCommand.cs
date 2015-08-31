namespace Kode.Interfaces
{
    public interface ISoapCommand
    {
        string Response { get; set; }
        void SendCommand(string command);
    }
}