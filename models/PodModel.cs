namespace Banbridge_Academy_SSD_Coursework.models
{
    internal class PodModel
    {
        int podId;
        int podCapacity;
        string podType;

        public PodModel() { }

        public PodModel(int podId, int podCapacity, string podType)
        {
            this.podId = podId;
            this.podCapacity = podCapacity;
            this.podType = podType;
        }

        public int PodId { get { return podId; } set { podId = value; } }
        public int PodCapacity { get { return podCapacity; } set { podCapacity = value; } }
        public string PodType { get { return podType; } set { podType = value; } }
    }
}
