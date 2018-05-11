namespace ICTOOP.Lib
{
    class GameObject
    {
        public string Name { get; set; }
        public GameObject() => Name = string.Empty;
        public GameObject(string name) => Name = name;
    }
}
