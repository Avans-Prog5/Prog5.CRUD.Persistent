using GalaSoft.MvvmLight;
using MusicCollectionMVVMLight.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System;

namespace MusicCollectionMVVMMVVMLight.Model
{
    public class SongViewModel : ViewModelBase
    {
        public int Id
        {
            get { return _song.Id; }
            set { _song.Id = value; RaisePropertyChanged("Id"); }
        }


        public string Artist
        {
            get { return _song.Artist; }
            set { _song.Artist = value; RaisePropertyChanged("Artist"); }
        }


        public string Title
        {
            get { return _song.Title; }
            set { _song.Title = value; RaisePropertyChanged("Title"); }
        }

        internal Song ToModel()
        {
            return _song;
        }

        private Song _song;

        public SongViewModel()
        {
            this._song = new Song();
        }

        public SongViewModel(Song song)
        {
            this._song = song;
        }
    }
}
