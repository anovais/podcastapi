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

        // GET: api/Podcast/Many/5
        [HttpGet("Many/{count}", Name = "GetMany")]
        public IEnumerable<Podcast> GetMany(int count)
        {
            return PodcastContext.GetPodcasts(count);
        }

        // GET: api/Podcast/5
        [HttpGet("{id}", Name = "Get")]
        public Podcast Get(string id)
        {            
            return PodcastContext.GetPodcast(new Guid(id));
        }
     
    }
}
