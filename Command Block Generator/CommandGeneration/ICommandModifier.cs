namespace Command_Block_Generator.CommandGeneration
{
    public interface ICommandModifier
    {
        List<string> Modify(ICommandGenerator commandGenerator);
    }
}
