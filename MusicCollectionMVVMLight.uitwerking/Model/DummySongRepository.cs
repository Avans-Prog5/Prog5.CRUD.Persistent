using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollectionMVVMLight.Model
{
    class DummySongRepository : ISongRepository
    {
        public List<Song> GetSongs()
        {
            using(var context = new SongsEntities())
            {
                return context.Song.ToList();
            }
        }
    }
}
