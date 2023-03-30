namespace OODesign.Library.Models
{
    public class Car
    {
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public float SteeringPosition { get; set; }
        public float ThrottlePosition { get; set; }
        public float BrakePosition { get; set; }
        public bool Start() => true;
        public bool Stop() => true;
    }
}
