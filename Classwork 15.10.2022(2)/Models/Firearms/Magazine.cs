namespace Classwork_15._10._2022_2_.Models.Firearms
{
    internal class Magazine
    {
        public int Size { get; set; }

        private Magazine() { }

        public Magazine(int size)
        {
            Size = size;
        }
    }
}
