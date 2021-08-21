using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.ProxyPattern.Sample
{
    interface IThirdPartyVideoService
    {
        IEnumerable<Video> ListVideos();
        Video GetVideoInfo(long id);
        void DownloadVideo(long id);
    }
}
