using System.Text;

namespace Command_Block_Generator.UI.Extensions
{
    public class SimpleMinecraftSyntaxColorizer
    {
        private Dictionary<string, Color> KeyWords = new Dictionary<string, Color>()
        {
            {"effect", Color.FromArgb(0,150,255)},
            {"enchant", Color.FromArgb(0,150,255)},
            {"experience", Color.FromArgb(0,150,255)},
            {"execute", Color.FromArgb(0,150,255)},

            {"recipe", Color.FromArgb(0,150,255)},
            {"reload", Color.FromArgb(0,150,255)},
            {"return", Color.FromArgb(0,150,255)},
            {"ride", Color.FromArgb(0,150,255)},
            {"run", Color.FromArgb(255,0,0)},

            {"tag", Color.FromArgb(0,150,255)},
            {"team", Color.FromArgb(0,150,255)},
            {"teammsg", Color.FromArgb(0,150,255)},
            {"teleport", Color.FromArgb(0,150,255)},
            {"tell", Color.FromArgb(0,150,255)},
            {"tellraw", Color.FromArgb(0,150,255)},
            {"time", Color.FromArgb(0,150,255)},
            {"title", Color.FromArgb(0,150,255)},
            {"tm", Color.FromArgb(0,150,255)},
            {"tp", Color.FromArgb(0,150,255)},
            {"trigger", Color.FromArgb(0,150,255)},

            {"item", Color.FromArgb(0,150,255)},

            {"particle", Color.FromArgb(0,150,255)},
            {"place", Color.FromArgb(0,150,255)},
            {"playsound", Color.FromArgb(0,150,255)},
            {"publish", Color.FromArgb(0,150,255)},

            {"advancements", Color.FromArgb(0,150,255)},
            {"attribute", Color.FromArgb(0,150,255)},

            {"kill", Color.FromArgb(0,150,255)},
            {"kick", Color.FromArgb(0,150,255)},

            {"say", Color.FromArgb(0,150,255)},
            {"schedule", Color.FromArgb(0,150,255)},
            {"scoreboard", Color.FromArgb(0,150,255)},
            {"seed", Color.FromArgb(0,150,255)},
            {"setblock", Color.FromArgb(0,150,255)},
            {"setworldspawn", Color.FromArgb(0,150,255)},
            {"spawnpoint", Color.FromArgb(0,150,255)},
            {"spectate", Color.FromArgb(0,150,255)},
            {"spreadplayers", Color.FromArgb(0,150,255)},
            {"stopsound", Color.FromArgb(0,150,255)},
            {"summon", Color.FromArgb(0,150,255)},

            {"damage", Color.FromArgb(0,150,255)},
            {"data", Color.FromArgb(0,150,255)},
            {"datapack", Color.FromArgb(0,150,255)},
            {"debug", Color.FromArgb(0,150,255)},
            {"defaultgamemode", Color.FromArgb(0,150,255)},
            {"difficulty", Color.FromArgb(0,150,255)},

            {"fill", Color.FromArgb(0,150,255)},
            {"fillbiome", Color.FromArgb(0,150,255)},
            {"forceload", Color.FromArgb(0,150,255)},
            {"forge", Color.FromArgb(0,150,255)},
            {"function", Color.FromArgb(0,150,255)},

            {"gamemode", Color.FromArgb(0,150,255)},
            {"gamerule", Color.FromArgb(0,150,255)},
            {"give", Color.FromArgb(0,150,255)},

            {"help", Color.FromArgb(0,150,255)},

            {"jfr", Color.FromArgb(0,150,255)},

            {"list", Color.FromArgb(0,150,255)},
            {"locate", Color.FromArgb(0,150,255)},
            {"loot", Color.FromArgb(0,150,255)},

            {"xp", Color.FromArgb(0,150,255)},

            {"clear", Color.FromArgb(0,150,255)},
            {"clone", Color.FromArgb(0,150,255)},
            {"config", Color.FromArgb(0,150,255)},

            {"bossbar", Color.FromArgb(0,150,255)},

            {"me", Color.FromArgb(0,150,255)},
            {"msg", Color.FromArgb(0,150,255)},
            
            {"weather", Color.FromArgb(0,150,255)},
            {"worldborder", Color.FromArgb(0,150,255)},

            {"@e", Color.FromArgb(0,150,255)},
            {"@p", Color.FromArgb(0, 150, 255)},
            {"@s", Color.FromArgb(0, 150, 255)},
            {"@r", Color.FromArgb(0, 150, 255)},
            {"@a", Color.FromArgb(0, 150, 255)},

            {"at", Color.FromArgb(255,0,0)},
            {"as", Color.FromArgb(255,0,0)},
            {"in", Color.FromArgb(255,0,0)},
            {"on", Color.FromArgb(255,0,0)},
            {"align", Color.FromArgb(255,0,0)},
            {"anchored", Color.FromArgb(255,0,0)},
            {"facing", Color.FromArgb(255,0,0)},
            {"if", Color.FromArgb(255,0,0)},
            {"positioned", Color.FromArgb(255,0,0)},
            {"rotated", Color.FromArgb(255,0,0)},


            {"~", Color.FromArgb(75, 255, 75)},
            {"^", Color.FromArgb(75,255,75)},

            {"template", Color.FromArgb(0,150,255)},
        };

        private Dictionary<string, Color> PropertyColors = new Dictionary<string, Color>();

        private Dictionary<string, Color> BlockColors = new Dictionary<string, Color>();

        private Dictionary<string, Color> ItemColors = new Dictionary<string, Color>();

        private Color[] numberColors = new Color[]
        {
            Color.FromArgb(255,165,0),
            //Color.FromArgb(75,215,75),
        };

        private Color stringColor = Color.FromArgb(75, 255, 75);

        private char[] wordSeparators = new char[]
        {
            '{',
            '}',
            '(',
            ')',
            ';',
            ',',
            ' ',
            '[',
            ']',
            ':',
            '\n'
        };

        private char[] stringSeparators = new char[]
        {
            '\'',
            '"'
        };

        private int currentNumberColor = 0;

        public Color BlockIdColor = Color.Yellow;

        public Color ItemIdColor = Color.Yellow;

        public void Initialize()
        {
            string[] blockLines = File.ReadAllLines("Content/Files/blocks.txt");
            foreach (var line in blockLines)
            {
                BlockColors.Add(line, BlockIdColor);
            }

            string[] itemLines = File.ReadAllLines("Content/Files/items.txt");
            foreach (var line in itemLines)
            {
                ItemColors.Add(line, ItemIdColor);
            }
        }

        public void ResetColors()
        {
            PropertyColors = new Dictionary<string, Color>();
        }

        public void AddColor(string word, Color color)
        {
            if (PropertyColors.ContainsKey(word))
            {
                PropertyColors[word] = color;
                return;
            }
            PropertyColors.Add(word, color);
        }

        public void ColorizeText(RichTextBox box)
        {
            StringBuilder word = new StringBuilder();
            string text = box.Text;
            int index = 0;
            int textLength = text.Length;
            char currentSymbol = ' ';
            int start = box.SelectionStart;
            box.SelectionStart = 0;
            box.SelectionLength = textLength;
            box.SelectionColor = box.ForeColor;
            currentNumberColor = 0;
            bool textColorizing = false;
            while (index < textLength)
            {
                char startSymbol = text[index];
                if (wordSeparators.Contains(startSymbol) == false)
                {
                    char separator = ' ';
                    box.SelectionStart = index;
                    while (index < textLength)
                    {
                        currentSymbol = text[index];
                        word.Append(currentSymbol);

                        if (wordSeparators.Contains(currentSymbol) && !textColorizing)
                        {
                            RotateNumberColor();
                            word.Clear();
                            break;
                        }
                        if (textColorizing)
                        {
                            box.SelectionLength = index + 1 - box.SelectionStart;
                            box.SelectionColor = stringColor;
                        }
                        if (stringSeparators.Contains(currentSymbol) && Peek(index-1,text) != '\\')
                        {
                            if (separator == ' ')
                            {
                                separator = currentSymbol;
                            }
                            if (currentSymbol == separator && textColorizing)
                            {
                                textColorizing = false;
                                word.Clear();
                                break;
                            }
                            box.SelectionStart = index;
                            index++;
                            textColorizing = true;
                            continue;
                        }
                        if (BlockColors.ContainsKey(word.ToString()))
                        {
                            box.SelectionLength = index + 1 - box.SelectionStart;
                            box.SelectionColor = BlockColors[word.ToString()];
                        }
                        if (BlockColors.ContainsKey("minecraft:" + word))
                        {
                            box.SelectionLength = index + 1 - box.SelectionStart;
                            box.SelectionColor = BlockColors["minecraft:" + word.ToString()];
                        }
                        if (ItemColors.ContainsKey(word.ToString()))
                        {
                            box.SelectionLength = index + 1 - box.SelectionStart;
                            box.SelectionColor = ItemColors[word.ToString()];
                        }
                        if (ItemColors.ContainsKey("minecraft:" + word.ToString()))
                        {
                            box.SelectionLength = index + 1 - box.SelectionStart;
                            box.SelectionColor = ItemColors["minecraft:" + word.ToString()];
                        }
                        if (KeyWords.ContainsKey(word.ToString()))
                        {
                            box.SelectionLength = index + 1 - box.SelectionStart;
                            box.SelectionColor = KeyWords[word.ToString()];
                            word.Clear();
                            break;
                        }
                        if (PropertyColors.ContainsKey(word.ToString()))
                        {
                            box.SelectionLength = index + 1 - box.SelectionStart;
                            box.SelectionColor = PropertyColors[word.ToString()];
                            word.Clear();
                            break;
                        }
                        if (char.IsNumber(currentSymbol) && !textColorizing)
                        {
                            char nextSymbol = Peek(index + 1, text);
                            box.SelectionLength = index + 1 - box.SelectionStart;
                            if (nextSymbol == 'd' || nextSymbol == 'L' || nextSymbol == 'b' || nextSymbol == 'f' || char.IsDigit(nextSymbol)) 
                            { 
                                box.SelectionLength = index + 2 - box.SelectionStart;
                            }
                            box.SelectionColor = numberColors[currentNumberColor];
                            word.Clear();
                            index++;
                            continue;
                        }
                        index++;
                    }
                }
                index++;
            }

            box.SelectionStart = start;
            box.SelectionLength = 0;
            box.SelectionColor = box.ForeColor;
        }

        private char Peek(int index, string text)
        { 
            return index > 0 && index < text.Length ? text[index] : '\0';
        }

        private void RotateNumberColor()
        {
            currentNumberColor++;
            if (currentNumberColor > numberColors.Length - 1)
            {
                currentNumberColor = 0;
            }
        }
    }
}
