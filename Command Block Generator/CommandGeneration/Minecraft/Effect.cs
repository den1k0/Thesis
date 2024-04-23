namespace Command_Block_Generator.CommandGeneration.Minecraft
{
    public class Effect
    {
        public EffectName Id { get; set; }

        public int Duration { get; set; }

        public int Amplifier { get; set; }

        public MinecraftBool ShowParticles { get; set; } = new MinecraftBool();

        public MinecraftBool ShowIcon { get; set; } = new MinecraftBool();

        public MinecraftBool Ambient { get; set; } = new MinecraftBool();
    }
}
