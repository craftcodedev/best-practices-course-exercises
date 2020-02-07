namespace LSP
{
    public interface ISetting
    {
        void SetSetting(string settingName, string settingValue);
        ISetting GetSetting();
    }
}
