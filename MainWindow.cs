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

        private void Trigger(object sender, HotkeyEventArgs e)
        {
            e.Handled = true;

            IntPtr currentWindowHandle = GetForegroundWindow();

            var processes = Process.GetProcessesByName("ELEMENTCLIENT");

            if (processes.Length == 0)
            {
                MessageBox.Show("Não existe nenhum elementclient sendo executado.");
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

                SendKeys.SendWait($"{{{MacroKey1TextBox.Text}}}");

                if (MacroKey2TextBox.Text.Trim().Length != 0)
                {
                    Thread.Sleep((int)MacroDelay.Value);

                    SendKeys.SendWait($"{{{MacroKey2TextBox.Text}}}");
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
                if (AuxAtkKeyTextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ataque Auxiliar Key é requerido.");
                    return;
                }

                if (MacroKey1TextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Macro Key 1 é requerido.");
                    return;
                }

                var hotKey = (Keys)Enum.Parse(typeof(Keys), HotKeyTextBox.Text);

                HotkeyManager.Current.AddOrReplace("Trigger", hotKey, Trigger);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Erro ao setar hotkey.");
            }
        }
    }
}
