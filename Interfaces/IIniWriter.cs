namespace Kode.Interfaces
{
    public interface IIniWriter
    {
        void AddSection(string sectionName);
        void RemoveKey(string sectionName, string keyName);
        void Set(string sectionName, string keyName, object value);
    }
}