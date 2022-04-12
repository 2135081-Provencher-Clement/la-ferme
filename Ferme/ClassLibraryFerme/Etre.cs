namespace Champs
{
    /// <summary>
    /// Fait par Clément
    /// classe pour tous les êtres vivants
    /// </summary>
    public class Etre
    {
        private bool _vivant;
        private uint _age;
        private string _nom;
        /// <summary>
        /// s'ils sont en vie ou non
        /// </summary>
        protected bool Vivant { get { return _vivant; } set { _vivant = value; } }
        /// <summary>
        /// leur age en années normals (mercuriennes)
        /// </summary>
        protected uint Age { get { return _age; } }
        /// <summary>
        /// le nom de l'être
        /// </summary>
        public string Name { get { return _nom; } }
        /// <summary>
        /// le constructeur d'être
        /// </summary>
        /// <param name="nom"></param>
        public Etre(string nom)
        {
            _vivant = true;
            _age = 0;
            _nom = nom;
        }

        /// <summary>
        /// cause la mort de l'être (n'est plus en vie)
        /// </summary>
        public void Crever()
        {
            _vivant = false;
        }
        
    }
}