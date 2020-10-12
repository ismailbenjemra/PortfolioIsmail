namespace Core.Entities
{
    class Owner :EntityBase
    {
        public string FullName { get; set; }
        //avatar,Profil
        public string Avatar { get; set; }
        public string Profil { get; set; }

        public Adresse adresse { get; set; }
    }
}
