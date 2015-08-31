namespace Kode.Interfaces
{
    public interface IKodiInputCommand
    {
        string Back { get; set; }
        string Down { get; set; }
        string Home { get; set; }
        string Left { get; set; }
        string Right { get; set; }
        string Select { get; set; }
        string Up { get; set; }

        string SendText(string text);
    }
}