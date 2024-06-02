using Command_Block_Generator.CommandGeneration;
using Command_Block_Generator.UI.Initializations;

namespace Command_Block_Generator.UI.Forms
{
    public partial class OneCommandGeneratorForm : Form, ICommandGenerator, IControlContainer
    {
        private readonly ToolTip _toolTip;

        public OneCommandGeneratorForm()
        {
            InitializeComponent();
            new CommandBoxInitialization().Initialize(Input);
            _toolTip = new ToolTip();
            _toolTip.SetToolTip(checkBox1, "To generate wall of command blocks");
        }

        private string GenerateSimple()
        {
            string startpart = "";
            startpart += "summon falling_block ~ ~1 ~ {BlockState:{Name:activator_rail},Time:1,Passengers:[";
            string[] lines = Input.Lines;
            for (int i = 0; i < lines.Length; i++)
            {
                string midpart = "{id:command_block_minecart,Command:\"";
                midpart = midpart + lines[i];
                midpart = midpart + "\"},";
                startpart = startpart + midpart;
            }
            string endpart = startpart + "{id:command_block_minecart,Command:\"setblock ~ ~ ~1 command_block{Command:\\\"fill ~ ~-1 ~-1 ~ ~ ~ air\\\"} replace\"},{id:command_block_minecart,Command:\"setblock ~ ~-1 ~1 redstone_block\"},{id:command_block_minecart,Command:\"kill @e[type=command_block_minecart,distance=0..2]\"}]}";
            return endpart;
        }

        private string GenerateAdvanced()
        {
            string startpart = "";
            string[] lines = Input.Lines;
            startpart += "summon falling_block ~ ~1 ~ {BlockState:{Name:activator_rail},Time:1,Passengers:[";
            //string endpart = "{id:command_block_minecart,Command:\"setblock ~ ~ ~1 command_block{Command:\\\"fill ~ ~-1 ~-1 ~ ~ ~ air\\\"} replace\"},{id:command_block_minecart,Command:\"setblock ~ ~-1 ~1 redstone_block\"},{id:command_block_minecart,Command:\"kill @e[type=command_block_minecart,distance=0..2]\"}]}";
            string endpart = "{id:command_block_minecart,Command:\"setblock ~ ~-1 ~1 redstone_block\"},{id:command_block_minecart,Command:\"kill @e[type=command_block_minecart,distance=0..2]\"}]}";
            int k = 0;

            string increasewhat = textBox4.Text;
            int increaseby = int.Parse(textBox7.Text);
            int increasefrom = int.Parse(textBox9.Text);
            string increasewhat2 = textBox5.Text;
            int increaseby2 = int.Parse(textBox10.Text);
            int increasefrom2 = int.Parse(textBox8.Text);

            int width = 0;
            int height = 0;
            string facing;
            string themidpart;
            int skip = int.Parse(textBox6.Text);
            string chain;
            bool first = true;
            string auto = "";

            for (int i = 0; i < int.Parse(textBox3.Text); i++)
            {
                for (int j = 0; j < int.Parse(textBox2.Text); j++)
                {
                    facing = (textBox11.Text).ToLower();
                    string facingtemp = facing;
                    if (i % 2 == 1 && checkBox3.Checked == true && checkBox6.Checked == true)
                    {
                        if (facing == "north")
                        {
                            facingtemp = "south";
                        }
                        if (facing == "south")
                        {
                            facingtemp = "north";
                        }
                        if (facing == "east")
                        {
                            facingtemp = "west";
                        }
                        if (facing == "west")
                        {
                            facingtemp = "east";
                        }
                    }
                    facing = facingtemp;
                    if (j == (int.Parse(textBox2.Text) - 1) && checkBox3.Checked == true && checkBox6.Checked == true)
                    {
                        facing = "up";
                    }
                    chain = "";
                    if (checkBox6.Checked == true && first == false)
                    {
                        chain = "chain_";
                        auto = "auto:1b,";
                    }
                    int height_temp = height * skip;
                    int width_temp = width * skip;
                    if (i % 2 == 1 && checkBox2.Checked == true)
                    {
                        width_temp = (int.Parse(textBox2.Text) - width - 1) * skip;
                    }
                    string midpart = "";

                    if (checkBox4.Checked == true)
                    {
                        midpart = "{id:command_block_minecart,Command:\"setblock ~" + (1 + width_temp) + " ~" + (1 + height_temp) + " ~ " + chain + "command_block[facing=" + facing + "]{" + auto + "Command:\\\"";
                    }
                    else
                    {
                        midpart = "{id:command_block_minecart,Command:\"setblock ~ ~" + (1 + height_temp) + " ~" + (1 + width_temp) + " " + chain + "command_block[facing=" + facing + "]{" + auto + "Command:\\\"";
                    }

                    string templines = lines[k].Replace(increasewhat, increasefrom.ToString());
                    increasefrom += increaseby;
                    templines = templines.Replace(increasewhat2, increasefrom2.ToString());
                    increasefrom2 += increaseby2;
                    templines = templines.Replace("\"", "\\\\\\\"");

                    themidpart = midpart + templines;
                    themidpart = themidpart + "\\\"}\"},";
                    startpart = startpart + themidpart;
                    k++;
                    width++;
                    first = false;
                    if (k == lines.Length)
                    {
                        k = 0;
                    }
                }
                width = 0;
                height++;
            }
            startpart = startpart + endpart;
            return startpart;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = !checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = !checkBox5.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                checkBox5.Visible = true;
                checkBox6.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
            }
            else
            {
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;
            }
        }

        public List<string> GenerateCommands()
        {
            string resultCommand = "";
            if (Input.Text.Length > 0)
            {
                if (checkBox1.Checked == false)
                {
                    resultCommand = GenerateSimple();
                }
                else
                {
                    resultCommand = GenerateAdvanced();
                }
            }
            else
            {
                MessageBox.Show("You have to input your command!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return new List<string> 
            {
                "setblock ~ ~ ~ redstone_block",
                resultCommand ,
            };
        }

        private void OneCommandGeneratorForm_Load(object sender, EventArgs e)
        {

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
    }
}