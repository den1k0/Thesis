using Command_Block_Generator.UI.Extensions;

namespace Command_Block_Generator.UI.Initializations
{
    public class CommandBoxInitialization
    {
        public RichTextBox Initialize(RichTextBox commandBox)
        {
            var colorizer = new SimpleMinecraftSyntaxColorizer();
            colorizer.Initialize();
            commandBox.SetInnerMargins(5, 5, 5, 5);
            commandBox.TextChanged += (s, e) =>
            {

                colorizer.ColorizeText(commandBox);
            };
            return commandBox;
        }
    }
}
