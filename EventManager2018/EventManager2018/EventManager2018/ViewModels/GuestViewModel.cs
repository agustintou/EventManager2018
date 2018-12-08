using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace EventManager2018.ViewModels
{
    public class GuestViewModel : BaseViewModel
    {
        #region Attributes

        #endregion

        #region Properties
        public ICommand CommandLoadingImage { get { return new RelayCommand(LodingImage); } }
        #endregion

        #region Builders
        public GuestViewModel()
        {

        }
        #endregion

        #region Commands
        async void LodingImage()
        {
            await CrossMedia.Current.Initialize();

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                SaveToAlbum = true
            });

            var aPpath = file.AlbumPath;

            var path = file.Path;
        }
        #endregion

        #region Methods

        #endregion
    }
}
