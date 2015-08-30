namespace Interfaces
{
    public interface IIniReader
    {
        bool GetBool(string sectionName, string keyName);
        double GetDouble(string sectionName, string keyName);
        float GetFloat(string sectionName, string keyName);
        int GetInt(string sectionName, string keyName);
        long GetLong(string sectionName, string keyName);
        string GetString(string sectionName, string keyName);
    }
}