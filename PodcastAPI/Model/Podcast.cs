using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PodcastAPI.Model
{
    public class Podcast
    {
        private const string Lorem = "Lorem Ipsum é simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos. Lorem Ipsum sobreviveu não só a cinco séculos, como também ao salto para a editoração eletrônica, permanecendo essencialmente inalterado. Se popularizou na década de 60, quando a Letraset lançou decalques contendo passagens de Lorem Ipsum, e mais recentemente quando passou a ser integrado a softwares de editoração eletrônica como Aldus PageMaker.";
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public int Downloads { get; set; }
        public int Stars { get; set; }
        public List<Episode> Episodes { get; set; }

        public Podcast(int countEpisodes)
        {
            Episodes = new List<Episode>();
        }
        public Podcast(string name, int countEpisodes = 105, 
            string thumb = "", string description = Lorem) : this(countEpisodes)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Downloads = new Random().Next(10000000) + 100;
            Stars = new Random().Next(4) + 1;
            Thumbnail = thumb;
        }

        private static List<Episode> GetEpisodes(int count)
        {
            var ep = new List<Episode>();
            for (int i = 0; i < count; i++)
            {
                ep.Add(new Episode());
            }
            return ep;
        }
    }
}
