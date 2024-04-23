namespace Command_Block_Generator.CommandGeneration.Minecraft.Parsers.PotionParsers
{
    public class _1201Parser : IPotionParser
    {
        private Dictionary<EffectName, string> _toEffectID = new Dictionary<EffectName, string>
        {
            { EffectName.Poison, "19" },
            { EffectName.FireResistance , "12" },
            { EffectName.HealthBoost , "21" },
            { EffectName.Blindness , "15" },
        };

        private Dictionary<PotionType, string> _toPotionType = new Dictionary<PotionType, string>
        {
            { PotionType.Potion ,"potion"},
            { PotionType.Splash , "splash_potion" },
            { PotionType.Tipped , "tipped_arrow" },
            { PotionType.Lingering , "lingering_potion" },
        };

        public string Parse(Potion potion)
        {
            string potionCommand =
             "give @p " + _toPotionType[potion.Type] +
             "{CustomPotionColor:" + potion.Color.ToNumber() + ",CustomPotionEffects:[";

            bool isFirstEffectApplied = false;

            foreach (var effect in potion.Effects)
            {
                potionCommand +=
                    isFirstEffectApplied ? "," : "" +
                    "{" +
                    $"Id:{_toEffectID[effect.Id]}," +
                    $"Duration:{effect.Duration}," +
                    $"Amplifier:{effect.Amplifier}," +
                    $"Ambient:{effect.Ambient}," +
                    $"ShowParticles:{effect.ShowParticles}," +
                    $"ShowIcon:{effect.ShowIcon}" +
                    "}";
                isFirstEffectApplied = true;
            }

            return potionCommand + "],display:{Name:'[{\"text\":\"" + potion.Name + "\",\"italic\":false}]'}" + "}";
        }
    }
}
