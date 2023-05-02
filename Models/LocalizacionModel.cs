using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Chronos.Models
{
    public class LocalizacionModel : INotifyPropertyChanged
    {
        private string error;

        public string Error
        {
            get { return error; }
            set
            {
                error = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
        private double longitud;

        public double Longitud
        {
            get { return longitud; }
            set
            {
                longitud = value;
                OnPropertyChanged();
            }
        }
        private double latitud;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Latitud
        {
            get { return latitud; }
            set
            {
                latitud = value;
                OnPropertyChanged();
            }
        }

        public DateTime FechaActual 
        {
            get
            {
                return DateTime.Now;
            }
        }

        public async Task getLocationGPS()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    Latitud = location.Latitude;
                    Longitud = location.Longitude;
                    //Console.WriteLine($"Latitud: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }
                else
                {
                    var knowLocation = await Geolocation.GetLastKnownLocationAsync();
                    Latitud = knowLocation.Latitude;
                    Longitud = knowLocation.Longitude;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not suported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                //
            }
            catch (PermissionException pEx)
            {
                //
            }
            catch (Exception ex)
            {
            }
        }
    }
}
