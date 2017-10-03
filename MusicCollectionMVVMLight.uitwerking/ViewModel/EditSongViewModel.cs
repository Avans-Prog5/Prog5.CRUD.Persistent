using GalaSoft.MvvmLight.Command;
using MusicCollectionMVVMLight.Model;
using MusicCollectionMVVMLight.View;
using MusicCollectionMVVMMVVMLight.Model;
using System.Data.Entity;
using System.Windows.Input;
using System;

namespace MusicCollectionMVVMLight.ViewModel
{
    public class EditSongViewModel
    {
        //Todo: Afmaken van deze klasse
        public SongViewModel Song { get; set; }

        public ICommand SaveCommand { get; set; }

        public EditSongViewModel(SongViewModel selectedSong)
        {
            this.Song = selectedSong;
            //Een relay command met een Window als parameter! Super handig :)
            SaveCommand = new RelayCommand<EditSongWindow>(Save);
        }

        private void Save(EditSongWindow window)
        {
            using (var context = new SongsEntities())
            {
                var song = Song.ToModel();
                //Even aan entity framework laten weten dat we dingen hebben aangepast!
                context.Entry(song).State = EntityState.Modified;
                context.SaveChanges();
            }

            window.Hide();
        }
    }
}