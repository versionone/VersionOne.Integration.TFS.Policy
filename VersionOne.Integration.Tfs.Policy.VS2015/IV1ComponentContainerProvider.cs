using VersionOne.Integration.Tfs.Core.DataLayer;

namespace VersionOne.Integration.Tfs.Policy
{
    public interface IV1ComponentContainerProvider
    {
        V1ComponentContainer GetContainer();
        VersionOneQueryContainer GetVersionOneHelper();
    }
}