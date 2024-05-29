using PluginFramework.Common;

namespace PluginFramework
{
    public static class ImageFinder
    {
        public static ImageModel FindByName(string name)
        {
            //here should be some implementation for finding image by name, in my example I will identify images by name
            return new ImageModel
            {
                Name = name
            };

        }
    }
}
