using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

using WebApi.Streams;

namespace WebApi.Controllers
{
    public class CameraController : ApiController
    {
        public IEnumerable<string> Get()
        {


            return new string[] { "Tugsuu", "Lion" };
        }

        [HttpGet]
        public HttpResponseMessage FromVideo(string videoName)
        {
            var video = new VideoStream(videoName);
            Func<Stream, HttpContent, TransportContext, Task> func = video.WriteToStream;
            var response = Request.CreateResponse();
            response.Content = new PushStreamContent(func, new MediaTypeHeaderValue("video/mp4"));

            return response;
        }
    }
}
