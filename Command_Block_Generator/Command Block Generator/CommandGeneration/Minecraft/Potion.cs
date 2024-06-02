namespace Command_Block_Generator.CommandGeneration.Minecraft
{
    public class Potion
    {
        public PotionType Type { get; set; }

        public string Name { get; set; }

        public List<Effect> Effects;

        public PotionColor Color { get; set; }

        public Potion() 
        {
            Clear();
        }

        public void Clear()
        {
            Type = PotionType.Potion;
            Effects = new List<Effect>();
            Color = new PotionColor { Red = 0, Green = 0, Blue = 0 };
        }
    }
}
