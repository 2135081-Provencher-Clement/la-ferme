namespace Champs
{
    /// <summary>
    /// Fait par Clément
    /// Classe qui représente des coordonnées GPS de longitude et latitude
    /// </summary>
    public class CoordonneeGPS
    {
        private double _longitude;
        private double _latitude;

        /// <summary>
        /// axe des x (de -180 à 180)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">la longitude ne peut est inférieure à -180 ou supérieure à 180</exception>
        public double Longitude { get => _longitude;
            set {
                VerifierLongitude(value);
                _longitude = value;
            }
        }

        /// <summary>
        /// axe des y (de -90 à 90)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">la latitude ne peut est inférieure à -90 ou supérieure à 90</exception>
        public double Latitude { get => _latitude; 
            set { 
                VerifierLatitude(value);
                _latitude = value;
            } 
        }

        /// <summary>
        /// constructeur des coordonnées GPS
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        /// <exception cref="ArgumentOutOfRangeException">Les coordonnées sont invalides (-180/-90 à 180/90)</exception>
        public CoordonneeGPS(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        /// <summary>
        /// Vérifie si la latitude est inférieure à -90 ou supérieure à 90
        /// </summary>
        /// <param name="latitude">la latitude à vérifier</param>
        /// <exception cref="ArgumentOutOfRangeException">la latitude ne peut est inférieure à -90 ou supérieure à 90</exception>
        private void VerifierLatitude(double latitude)
        {
            if (latitude < -90 || latitude > 90)
                throw new ArgumentOutOfRangeException("La latitude est invalide"); 
        }

        /// <summary>
        /// Vérifie si la longitude est inférieure à -180 ou supérieure à 180
        /// </summary>
        /// <param name="longitude">la longitude à vérifier</param>
        /// <exception cref="ArgumentOutOfRangeException">la longitude ne peut est inférieure à -180 ou supérieure à 180</exception>
        private void VerifierLongitude(double longitude)
        {
            if (longitude < -180 || longitude > 180)
                throw new ArgumentOutOfRangeException("La longitude est invalide");
        }
    }
}