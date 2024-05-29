using PluginFramework.Common;
using System.Threading.Tasks;

namespace AddingEffectPlugin.cs
{
    public class AddEffectRequestModel : IManipulation
    {
        public string ImageName { get; set; }

        public EffectsEnum Effect { get; set; }

        public Task ApplyManipulation(ImageModel image)
        {
            //some logic to add effect to the image
            return Task.CompletedTask;
        }
    }
}
