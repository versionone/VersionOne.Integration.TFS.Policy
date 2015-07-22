using VersionOne.Integration.Tfs.Core.DataLayer;

namespace VersionOne.Integration.Tfs.Policy.VS2015
{
    public interface IV1ComponentContainerProvider
    {
        V1ComponentContainer GetContainer();
        VersionOneQueryContainer GetVersionOneHelper();
    }
}