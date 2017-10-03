using GalaSoft.MvvmLight.Command;
using MusicCollectionMVVMLight.Model;
using MusicCollectionMVVMMVVMLight.Model;
using System.Windows.Input;

namespace MusicCollectionMVVMLight.ViewModel
{
    public class AddSongViewModel
    {
        private SongListViewModel _songList;

        public SongViewModel Song { get; set; }

        public ICommand AddSongCommand { get; set;}

        public AddSongViewModel(SongListViewModel songList)
        {
            this._songList = songList;
            this.Song = new SongViewModel();
            AddSongCommand = new RelayCommand(AddSong, CanAddSong);
        }

        private void AddSong()
        {
            _songList.Songs.Add(Song);

            using (var context = new SongsEntities())
            {
                context.Song.Add(Song.ToModel());
                context.SaveChanges();
            }

            _songList.HideAddSong();       
        }

        public bool CanAddSong()
        {
            return true;
        }
    }
}