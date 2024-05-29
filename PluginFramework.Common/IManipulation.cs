using System.Threading.Tasks;

namespace PluginFramework.Common
{
    public interface IManipulation
    {
        string ImageName { get; set; }

        Task ApplyManipulation(ImageModel image);
    }
}
