namespace borderControl
{
    public class Robot : IId
    {
        public string Model { get; set; }
        public string Id { get; }

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
    }
}