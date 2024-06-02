namespace Command_Block_Generator.CommandGeneration.Minecraft
{
    public class MinecraftBool
    {
        public MinecraftBool(bool value)
        {
            Value = value;
        }

        public MinecraftBool()
        {
            Value = false;
        }

        public bool Value { get; set; }

        public static implicit operator bool(MinecraftBool value)
        {
            return value.Value;
        }

        public static implicit operator string(MinecraftBool value)
        {
            return value.Value ? "1b" : "0b";
        }

        public override string ToString() 
        {
            return (string)this;
        }
    }
}
