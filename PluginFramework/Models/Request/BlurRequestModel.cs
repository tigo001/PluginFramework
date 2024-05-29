using PluginFramework.Common;
using System.Threading.Tasks;

namespace PluginFramework.Models.Request
{
    public  class BlurRequestModel : IManipulation
    {
        public string ImageName { get; set; }

        public int BlurSize { get; set; }

        public Task ApplyManipulation(ImageModel image)
        {
            //some logic to blur the image
            return Task.CompletedTask;
        }
    }
}
