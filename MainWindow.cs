using NHotkey;
using NHotkey.WindowsForms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace KiraKeyPresser
{
    public partial class MainWindow : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TriggerMacro(object ?sender, HotkeyEventArgs e)
        {
            e.Handled = true;

            IntPtr currentWindowHandle = GetForegroundWindow();

            var processes = Process.GetProcessesByName("elementclient");

            if (processes.Length == 0)
            {
                MessageBox.Show("Não existe nenhum elementclient sendo executado.", "Processo não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Process process in processes)
            {
                if (process.MainWindowHandle == currentWindowHandle)
                {
                    continue;
                }

                if (process.MainWindowTitle.Length == 0)
                {
                    continue;
                }

                SetForegroundWindow(process.MainWindowHandle);

                SendKeys.SendWait("(+{1})");
                SendKeys.SendWait($"{{{AuxAtkKeyTextBox.Text}}}");

                Thread.Sleep(500);

                switch (e.Name)
                {
                    case "TriggerMacro1":
                        SendKeys.SendWait($"{{{MacroKey1TextBox.Text}}}");
                        break;

                    case "TriggerMacro2":
                        SendKeys.SendWait($"{{{MacroKey2TextBox.Text}}}");
                        break;
                }
            }

            SetForegroundWindow(currentWindowHandle);
        }

        private void PreviewHotKeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            if (e.Control || e.Shift || e.Alt || e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin || e.KeyCode == Keys.Control)
            {
                return;
            }

            TextBox? textBox = sender as TextBox;

            if (textBox == null)
            {
                return;
            }

            textBox.Text = (new KeysConverter()).ConvertToString(e.KeyCode);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                var textBoxes = GetAll(this, typeof(TextBox));

                foreach (TextBox tb in textBoxes)
                {
                    if (tb.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Todos os campos são requeridos.", "Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                var hotKey1 = (Keys)Enum.Parse(typeof(Keys), HotKey1TextBox.Text);
                var hotKey2 = (Keys)Enum.Parse(typeof(Keys), HotKey2TextBox.Text);

                HotkeyManager.Current.AddOrReplace("TriggerMacro1", hotKey1, TriggerMacro);
                HotkeyManager.Current.AddOrReplace("TriggerMacro2", hotKey2, TriggerMacro);
            }
            catch (HotkeyAlreadyRegisteredException)
            {
                MessageBox.Show("A hotkey não pode repetir.", "Hotkey", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
    }
}
