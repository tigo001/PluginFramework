using PluginFramework.Common;
using System.Threading.Tasks;

namespace PluginFramework.Models.Request
{
    public class ResizeRequestModel : IManipulation
    {
        public string ImageName { get; set; }
        
        public int Size { get; set; }

        public Task ApplyManipulation(ImageModel image)
        {
            //some logic to resize the image
            return Task.CompletedTask;
        }
    }
}
