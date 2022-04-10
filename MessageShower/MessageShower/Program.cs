using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandLine;

namespace MessageShower
{
    internal static class Program
    {
        public class Options
        {
            [Option('m', "mode", Required = true, HelpText = "Choose the Message Shower mode. ('Info', 'Exe', 'ExeF')")]
            public string mode { get; set; } = "Info";

            [Option('t', "title", Required = false, HelpText = "The title of Message Shower.")]
            public string title { get; set; } = "Message Info Title";

            [Option('s', "message", Required = false, HelpText = "The message of Message Shower.")]
            public string message { get; set; } = "Message Info Message";
        }
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args).WithParsed(Run).WithNotParsed(ThrowOnParseError); ;
            
        }
        private static void Run(Options option)
        {
            switch (option.mode)
            {
                case "Info":
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new InfoForm());
                    break;
                case "Exe":
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new InfoForm());
                    break;
                case "ExeF":
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new InfoForm());
                    break;
                default: 
                    MessageBox.Show("The mode is not exist!", "Message Shower", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            
        }
        private static void ThrowOnParseError(IEnumerable<Error> errors)
        {
            /*
            foreach (var err in errors)
            {
                MessageBox.Show(err.ToString());
            }*/
            MessageBox.Show("Argument Error!", "Message Shower", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
