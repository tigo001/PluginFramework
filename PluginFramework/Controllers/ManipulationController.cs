using PluginFramework.Common;
using System.Threading.Tasks;

namespace PluginFramework.Controllers
{
    public class ManipulationController
    {
        public async Task ManipulateImage(IManipulation manipulation)
        {
            ImageModel image = ImageFinder.FindByName(manipulation.ImageName);
            if (image == null)
                throw new System.Exception("Image not found");

            await manipulation.ApplyManipulation(image);
        }
    }
}
