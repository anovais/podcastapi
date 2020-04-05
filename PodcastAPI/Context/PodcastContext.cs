using Microsoft.EntityFrameworkCore;
using PodcastAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PodcastAPI.Context
{
    public static class PodcastContext
    {
        public static List<Podcast> Podcasts = Init();

        public static List<Podcast> GetPodcasts(int maxElements = 0)
        {
            Podcasts.Shuffle();
            if (maxElements > 0 && maxElements < Podcasts.Count)
                return Podcasts.GetRange(0, maxElements);
                
            return Podcasts;
        }

        public static Podcast GetPodcast(Guid id)
        {
            return Podcasts.Where(p => p.Id == id).SingleOrDefault();
        }

        public static List<Podcast> Init()
        {
            var podcasts = new List<Podcast>() {
                new Podcast(name: "NerdCast",   thumb: "nerdcast.png"),
                new Podcast(name: "Mamilos", thumb: "mamilos.png"),
                new Podcast(name: "Nao Ouvo", thumb: "naoouvo.png"),
                new Podcast(name: "Gugacast", thumb: "gugacast.png"),
                new Podcast(name: "Inglês do Zero", thumb: "ingles.png"),
                new Podcast(name: "Braincast",  thumb: "braincast.png"),
                new Podcast(name: "Poupecast",  thumb: "poupecast.png"),
                new Podcast(name: "Decrépitos"),
            };

            return podcasts;
        }


        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }


}
