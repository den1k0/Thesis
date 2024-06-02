using Command_Block_Generator.CommandGeneration;
using Command_Block_Generator.CommandGeneration.Minecraft;
using Command_Block_Generator.CommandGeneration.Minecraft.Parsers;
using Command_Block_Generator.CommandGeneration.Minecraft.Parsers.PotionParsers;

namespace Command_Block_Generator.UI.Forms
{
    public partial class PotionGeneratorForm : Form, IControlContainer, ICommandGenerator
    {
        private readonly Action<List<string>> _onAddToQueue;

        private Potion _potion = new Potion();

        private IPotionParser _potionParser;

        private Dictionary<EffectName, string> _toEffectID = new Dictionary<EffectName, string>
        {
            { EffectName.Poison, "poison" },
            { EffectName.FireResistance , "fire_resistance" },
            { EffectName.HealthBoost , "health_boost" },
            { EffectName.Blindness , "blindness" },
            { EffectName.Speed, "speed" },
            { EffectName.Slowness , "slowness" },
            { EffectName.InstantDamage , "instant_damage" },
            { EffectName.InstantHealth , "instant_health" },
            { EffectName.Strength , "strength" },
            { EffectName.JumpBoost , "jump_boost" },
            { EffectName.Regeneration , "regeneration" },
            { EffectName.Resistance , "resistance" },
        };

        private Dictionary<string, EffectName> _toEffectName = new Dictionary<string, EffectName>
        {
            { "poison", EffectName.Poison },
            { "fire_resistance", EffectName.FireResistance },
            { "health_boost", EffectName.HealthBoost },
            { "blindness", EffectName.Blindness },
            { "speed" ,EffectName.Speed },
            { "slowness" ,EffectName.Slowness },
            { "instant_damage" , EffectName.InstantDamage },
            { "instant_health", EffectName.InstantHealth },
            { "strength" , EffectName.Strength },
            { "jump_boost",EffectName.JumpBoost },
            { "regeneration" , EffectName.Regeneration },
            { "resistance" , EffectName.Resistance },
        };

        private Dictionary<string, PotionType> _toPotionType = new Dictionary<string, PotionType>
        {
            { "potion", PotionType.Potion },
            { "splash_potion", PotionType.Splash },
            { "tipped_arrow", PotionType.Tipped },
            { "lingering_potion", PotionType.Lingering },
        };

        public PotionGeneratorForm(Action<List<string>> action)
        {
            InitializeComponent();
            _onAddToQueue = action;

            _potionParser = new _1201Parser();

            UpdatePotionTree(_potion);
        }

        private void AddToQueueButton_Click(object sender, EventArgs e)
        {
            var effect = new Effect
            {
                Id = _toEffectName[PotionEffectBox.Text],
                ShowIcon = new MinecraftBool(ShowIconSwitch.Checked),
                ShowParticles = new MinecraftBool(ShowParticlesSwitch.Checked),
                Ambient = new MinecraftBool(AmpbientSwitch.Checked),
                Amplifier = int.Parse(AmplifierBox.Text),
                Duration = int.Parse(DurationBox.Text)
            };
            _potion.Effects.Add(effect);

            _onAddToQueue?.Invoke(GenerateCommands());

            AddEffectNode(effect, GetEffectsNode());
        }

        private TreeNode GetEffectsNode()
        {
            return PotionTree.Nodes[0].Nodes[2];
        }

        List<Control> IControlContainer.Controls()
        {
            List<Control> exportingControls = new List<Control>();

            foreach (Control control in Controls)
            {
                exportingControls.Add(control);
            }
            return exportingControls;
        }

        public List<string> GenerateCommands()
        {

            _potion.Type = _toPotionType[PotionTypeBox.Text];
            _potion.Name = PotionNameBox.Text;
            return new List<string> {"", ParseCommand(_potion) };
        }

        private string ParseCommand(Potion potion)
        {
            return _potionParser.Parse(potion);
        }

        private void UpdatePotionTree(Potion potion)
        {
            PotionTree.Nodes.Clear();
            InitPotionTree(potion);
            ExpandNodes(PotionTree.Nodes);
        }

        private void ExpandNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Expand();
                if (node.Nodes.Count > 0)
                {
                    ExpandNodes(node.Nodes);
                }
            }
        }

        private void InitPotionTree(Potion potion)
        {
            TreeNode root = new TreeNode("Potion");

            root.Nodes.Add("Type : " + potion.Type);

            TreeNode colorNode = new TreeNode("Color");
            colorNode.Nodes.Add("red   : " + potion.Color.Red);
            colorNode.Nodes.Add("green : " + potion.Color.Green);
            colorNode.Nodes.Add("blue  : " + potion.Color.Blue);
            root.Nodes.Add(colorNode);

            TreeNode effectsNode = new TreeNode("Effects");

            foreach (var effect in potion.Effects)
            {
                AddEffectNode(effect, effectsNode);
            }

            root.Nodes.Add(effectsNode);
            PotionTree.Nodes.Add(root);
        }

        private void AddEffectNode(Effect effect, TreeNode parent)
        {
            TreeNode effectNode = new TreeNode(_toEffectID[effect.Id]);
            effectNode.Nodes.Add("Duration       : " + effect.Duration);
            effectNode.Nodes.Add("Amplifier      : " + effect.Amplifier);
            effectNode.Nodes.Add("Ambient        : " + effect.Ambient);
            effectNode.Nodes.Add("Show icon      : " + effect.ShowIcon);
            effectNode.Nodes.Add("Show particles : " + effect.ShowParticles);
            parent.Nodes.Add(effectNode);
            parent.Expand();
            effectNode.Expand();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            RedBox.Text = "0";
            GreenBox.Text = "0";
            BlueBox.Text = "0";
            _potion.Clear();
            UpdatePotionTree(_potion);
            _onAddToQueue?.Invoke(GenerateCommands());
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdatePotionTree(_potion);
            _onAddToQueue?.Invoke(GenerateCommands());
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedNode = PotionTree.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("You have to select effect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedNode.Parent != null && selectedNode.Parent.Text == "Effects")
            {
                selectedNode.Remove();
                int index = selectedNode.Index;
                _potion.Effects.RemoveAt(index);
                _onAddToQueue?.Invoke(GenerateCommands());
            }
            else
            {
                MessageBox.Show("You can remove only effect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void PotionTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _potion.Type = _toPotionType[(string)PotionTypeBox.SelectedItem];
            var root = GetRootNode();
            root.Nodes[0].Text = "Type : " + _potion.Type;
        }

        private TreeNode GetRootNode()
        {
            return PotionTree.Nodes[0];
        }

        private void RedBox_TextChanged(object sender, EventArgs e)
        {
            if (RedBox.Text.Length > 0)
            {
                if (IsValidNumber(RedBox.Text))
                {
                    var root = GetRootNode();
                    root.Nodes[1].Nodes[0].Text = "red   : " + RedBox.Text;
                    _potion.Color.Red = byte.Parse(RedBox.Text);
                }
                else
                {
                    RedBox.Text = "";
                }
            }
            else
            {
                var root = GetRootNode();
                root.Nodes[1].Nodes[0].Text = "red   : " + "0";
                _potion.Color.Red = 0;
            }
        }

        private void GreenBox_TextChanged(object sender, EventArgs e)
        {
            if (GreenBox.Text.Length > 0)
            {
                if (IsValidNumber(GreenBox.Text))
                {
                    var root = GetRootNode();
                    root.Nodes[1].Nodes[1].Text = "green : " + GreenBox.Text;
                    _potion.Color.Green = byte.Parse(GreenBox.Text);
                }
                else
                {
                    GreenBox.Text = "";
                }
            }
            else
            {
                var root = GetRootNode();
                root.Nodes[1].Nodes[1].Text = "green : " + "0";
                _potion.Color.Green = 0;
            }
        }

        private void BlueBox_TextChanged(object sender, EventArgs e)
        {
            var root = GetRootNode();
            if (BlueBox.Text.Length != 0)
            {
                if (IsValidNumber(BlueBox.Text))
                {
                    root.Nodes[1].Nodes[2].Text = "blue  : " + BlueBox.Text;
                    _potion.Color.Blue = byte.Parse(BlueBox.Text);
                }
                else
                {
                    BlueBox.Text = "";
                }
            }
            else
            {
                root.Nodes[1].Nodes[2].Text = "blue  : " + "0";
                _potion.Color.Blue = 0;
            }
        }

        private bool IsValidNumber(string number)
        {
            try
            {
                byte.Parse(number);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void RedBox_Leave(object sender, EventArgs e)
        {
            if (RedBox.Text.Length == 0)
            {
                var root = GetRootNode();
                root.Nodes[1].Nodes[1].Text = "green : " + "0";
                _potion.Color.Green = 0;
                RedBox.Text = "0";
            }
        }

        private void GreenBox_Leave(object sender, EventArgs e)
        {
            if (GreenBox.Text.Length == 0)
            {
                var root = GetRootNode();
                root.Nodes[1].Nodes[1].Text = "green : " + "0";
                _potion.Color.Green = 0;
                GreenBox.Text = "0";
            }
        }

        private void BlueBox_Leave(object sender, EventArgs e)
        {
            if (BlueBox.Text.Length == 0)
            {
                var root = GetRootNode();
                root.Nodes[1].Nodes[2].Text = "blue  : " + "0";
                _potion.Color.Blue = 0;
                BlueBox.Text = "0";
            }
        }

        private void PotionGeneratorForm_Load(object sender, EventArgs e)
        {

        }
    }
}