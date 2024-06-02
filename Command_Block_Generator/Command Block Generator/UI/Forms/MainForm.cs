using Command_Block_Generator.CommandGeneration;
using Command_Block_Generator.CommandGeneration.Minecraft;
using Command_Block_Generator.UI.Initializations;
using System.Net.Sockets;
using System.Text;

namespace Command_Block_Generator.UI.Forms
{
    public partial class MainForm : Form
    {
        private IControlContainer _runningForm;

        private ToolTip _toolTip;

        private SubjectAppliance _subjectAppliance;

        public MainForm()
        {
            InitializeComponent();
            _toolTip = new ToolTip();
            _toolTip.SetToolTip(RunButton, "Run this command in minecraft");
            _toolTip.SetToolTip(CopyButton, "Copy this command to clipboard");
            _toolTip.SetToolTip(GenerateButton, "Generate command into output");
            _subjectAppliance = new SubjectAppliance(GetSubject());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            new CommandBoxInitialization().Initialize(Output);
        }

        private void oneCommandGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindForm(new OneCommandGeneratorForm());
        }

        private void potionGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindForm(new PotionGeneratorForm((commands) => { UpdateOutput(); }));
        }

        private void UpdateOutput()
        {
            Output.Text = GenerateCommands()[1];
        }

        private void BindForm(IControlContainer form)
        {
            Output.Text = "";
            ((IDisposable)_runningForm)?.Dispose();
            Panel.Controls.Clear();
            _runningForm = form;
            LoadControls(_runningForm);
        }

        private void LoadControls(IControlContainer container)
        {
            foreach (Control control in container.Controls())
            {
                Panel.Controls.Add(control);
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Output.Text);
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private CommandSubject GetSubject()
        {
            return SubjectBox.SelectedItem == "Player" ? CommandSubject.Player : CommandSubject.Server;
        }

        private List<string> GenerateCommands()
        {
            _subjectAppliance.Subject = GetSubject();
            List<string> commands = new List<string>();
            if (_runningForm is ICommandGenerator generator)
            {
                commands = _subjectAppliance.Modify(generator);
            }
            return commands;
        }

        private async void SendCommands(List<string> commands)
        {
            await Task.Run(() =>
            {
                string serverIp = "localhost";
                int port = 9595;
                try
                {
                    TcpClient client = new TcpClient(serverIp, port);
                    NetworkStream stream = client.GetStream();

                    string result = "";

                    for (int i = 0; i < commands.Count; i++)
                    {
                        result += commands[i] + "\n";
                    }

                    byte[] data = Encoding.UTF8.GetBytes(result);

                    stream.Write(data, 0, data.Length);
                    stream.Socket.Close();
                    client.Dispose();
                    stream.Dispose();
                }
                catch
                {

                }
            });
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            var commands = GenerateCommands();
            if (commands.Count > 0)
            {
                UpdateOutput();
                SendCommands(commands);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
