namespace Command_Block_Generator.CommandGeneration.Minecraft.Parsers.PotionParsers
{
    public class _1202Parser : IPotionParser
    {
        public string Parse(Potion potion)
        {
            string potionCommand =
                "give @p " + potion.Type +
                "{CustomPotionColor:" + potion.Color.ToNumber() + ",custom_potion_effects:[";

            bool isFirstEffectApplied = false;

            foreach (var effect in potion.Effects)
            {
                potionCommand +=
                    isFirstEffectApplied ? "," : "" +
                    "{" +
                    $"id:{effect.Id}," +
                    $"duration:{effect.Duration}," +
                    $"amplifier:{effect.Amplifier}," +
                    $"ambient:{effect.Ambient}," +
                    $"show_particles:{effect.ShowParticles}," +
                    $"show_icon:{effect.ShowIcon}" +
                    "}";
                isFirstEffectApplied = true;
            }

            return potionCommand + "]}";
        }
    }
}
