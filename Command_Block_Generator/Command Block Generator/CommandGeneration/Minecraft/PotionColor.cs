namespace Command_Block_Generator.CommandGeneration.Minecraft
{
    public class PotionColor
    {
        public byte Red { get; set; }

        public byte Green { get; set; }

        public byte Blue { get; set; }

        public uint ToNumber()
        { 
            return (uint)(Red << 16 | Green << 8 | Blue);
        }
    }
}
