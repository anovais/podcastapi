using System;

namespace PodcastAPI.Model
{
    public class Episode
    {
        private const string Lorem = "Lorem Ipsum é simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos. Lorem Ipsum sobreviveu não só a cinco séculos, como também ao salto para a editoração eletrônica, permanecendo essencialmente inalterado. Se popularizou na década de 60, quando a Letraset lançou decalques contendo passagens de Lorem Ipsum, e mais recentemente quando passou a ser integrado a softwares de editoração eletrônica como Aldus PageMaker.";

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Seconds { get; set; }
        public DateTime LaunchDay { get; set; }
        public string Thumbnail { get; set; }

        public Episode()
        {
            Id = new Guid();
            Name = "S01 E" +  new Random().Next(100) + 1;
            Seconds = new Random().Next(7200) + 120;
            Description = Lorem;
            LaunchDay = DateTime.Now;
        }
        public Episode(string thumb):this()
        {
            Thumbnail = thumb;
        }

    }
}