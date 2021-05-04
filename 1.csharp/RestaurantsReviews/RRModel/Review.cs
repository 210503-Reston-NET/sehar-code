namespace RRModel
{
    public class Review
    {
        public int Rating{ get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"\t Rating: {Rating} \n\t Description: {Description}";
        }
    }
}