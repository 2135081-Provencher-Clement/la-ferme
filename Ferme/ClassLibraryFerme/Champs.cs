namespace Champs
{
    /// <summary>
    /// fait par Clément
    /// classe qui représente un champs sur une ferme
    /// </summary>
    public class Champs
    {
        private CoordonneeGPS _coordonnesGPS; //du point en haut à gauche
        private int _longeur; //en pieds
        private int _largeur; //en pied

        /// <summary>
        /// constructeur du champs
        /// </summary>
        /// <param name="coordonneeGPS">coordonnées GPS du point en haut a gauche du champs</param>
        public Champs(CoordonneeGPS coordonneeGPS)
        {
            _coordonnesGPS = coordonneeGPS;
        }

        /// <summary>
        /// constructeur du champs
        /// </summary>
        /// <param name="longitude">longitude du champs</param>
        /// <param name="latitude">latitude du champs</param>
        /// <exception cref="ArgumentOutOfRangeException">Les coordonnées sont invalides (-180/-90 à 180/90)</exception>
        public Champs(double longitude, double latitude)
        {
            _coordonnesGPS = new CoordonneeGPS(longitude, latitude);
        }

        /// <summary>
        /// constructeur du champs
        /// </summary>
        /// <param name="coordonneeGPS">coordonnées GPS du champs</param>
        /// <param name="longeur">longeur du champs en pieds</param>
        /// <param name="largeur">largeur du champs en pieds</param>
        public Champs(CoordonneeGPS coordonneeGPS, int longeur, int largeur) : this(coordonneeGPS)
        {
            _longeur = longeur;
            _largeur = largeur;
        }

        /// <summary>
        /// le constructeur du champs
        /// </summary>
        /// <param name="longitude">longitude du champs</param>
        /// <param name="latitude">latitude du champs</param>
        /// <param name="longeur">longeur du champs en pieds</param>
        /// <param name="largeur">largeur du champs en pieds</param>
        /// <exception cref="ArgumentOutOfRangeException">Les coordonnées sont invalides (-180/-90 à 180/90)</exception>
        public Champs(double longitude, double latitude, int longeur, int largeur) : this(longitude, latitude)
        {
            _longeur = longeur;
            _largeur = largeur;
        }
    }
}