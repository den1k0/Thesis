using Command_Block_Generator.CommandGeneration.Minecraft;

namespace Command_Block_Generator.CommandGeneration
{
    public class SubjectAppliance
    {
        public SubjectAppliance(CommandSubject subject)
        {
            Subject = subject;
        }

        public CommandSubject Subject { get; set; }


        public List<string> Modify(ICommandGenerator commandGenerator)
        {
            List<string> modifiedCommands = new List<string>();
            foreach (var command in commandGenerator.GenerateCommands())
            {
                modifiedCommands.Add((Subject == CommandSubject.Player ? "execute at @p run " : "execute positioned ~0.5 ~ ~0.5 run ") + command);
            }
            return modifiedCommands;
        }
    }
}
