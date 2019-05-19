using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Configuration;

namespace ConfigTest
{
    public class ConfigOperator
    {
public static void SetAppSetting(string key, string value)
{
    Configuration config = WebConfigurationManager.OpenWebConfiguration("~");
    AppSettingsSection appSetting = config.AppSettings;

    //如果不存在则添加
    if (appSetting.Settings[key] == null)
    {
        appSetting.Settings.Add(key, value);
    }
    else//否则修改
    {
        appSetting.Settings[key].Value = value;
    }
    config.Save(ConfigurationSaveMode.Full);
}

public static void ProtectSection()
{
    Configuration config = WebConfigurationManager.OpenWebConfiguration("~");
    ConfigurationSection section = config.Sections["connectionStrings"];
    section.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");
    section.SectionInformation.ForceSave = true;
    config.Save(ConfigurationSaveMode.Full);
}
    }
}