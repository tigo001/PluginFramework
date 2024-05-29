using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using PluginFramework.Common;

namespace PluginFramework
{
    public class PluginConfiguration
    {
        public void ConfigurePlugins()
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pluginConfig.json");
            string[] plugins = JsonConvert.DeserializeObject<string[]>(configPath);

            if(plugins != null)
            {
                foreach(string plugin in plugins)
                {
                    string pluginPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins", plugin + "Plugin.dll");
                    if(File.Exists(pluginPath))
                    {
                        var assembly = Assembly.LoadFrom(pluginPath);
                        var pluginType = assembly.GetTypes().FirstOrDefault(x => typeof(IManipulation).IsAssignableFrom(x) && !x.IsInterface);

                        if(pluginType != null)
                        {
                            var pluginInstance = Activator.CreateInstance(pluginType);
                        }
                    }
                }
            }
        }
    }
}
