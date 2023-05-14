namespace Test3
{
    struct Car
    {
        string _brand;
        string _type;
        int _prise;
        public string Brand { get { return _brand; } set { _brand = value; }}
        public string Type { get { return _type; } set { _type = value; }}
        public int Price{ get { return _prise; } set { _prise = value; }}
    }
}
