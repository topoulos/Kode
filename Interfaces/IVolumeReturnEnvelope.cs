namespace KodiClient
{
    public interface IVolumeReturnEnvelope
    {
        int Id { get; set; }
        string Jsonrpc { get; set; }
        IVolumeResult Result { get; set; }
    }
}