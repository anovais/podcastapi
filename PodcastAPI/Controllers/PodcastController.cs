using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PodcastAPI.Context;
using PodcastAPI.Model;

namespace PodcastAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PodcastController : ControllerBase
    {
        // GET: api/Podcast
        [HttpGet]
        public IEnumerable<Podcast> Get()
        {
            return PodcastContext.GetPodcasts();
        }

        // GET: api/Podcast/GetEpisodes/5
        [HttpGet("GetEpisodes/", Name = "GetEpisodes")]
        public IEnumerable<Episode> GetEpisodes()
        {
            var list = new List<Episode>();
            var pods = PodcastContext.GetPodcasts();
            for (int i = 0; i < 30; i++)
            {
                list.Add(new Episode(pods[i%5].Thumbnail) { });
            }
            return list;
        }

        // GET: api/Podcast/5
        [HttpGet("{id}", Name = "Get")]
        public Podcast Get(string id)
        {            
            return PodcastContext.GetPodcast(new Guid(id));
        }
     
    }
}
