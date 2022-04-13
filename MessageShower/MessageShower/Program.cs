using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandLine;

namespace MessageShower
{
    static class Program
    {
        public class Options
        {
            [Option('m', "mode", Required = true, HelpText = "Choose the Message Shower mode. ('Info', 'Exe', 'ExeF')")]
            public string mode { get; set; } = "Info";

            [Option('t', "title", Required = false, HelpText = "The title of Message Shower.")]
            public string title { get; set; } = "Message Shower Title";

            [Option('z', "contentTW", Required = false, HelpText = "The content (zh-tw) of Message Shower.")]
            public string contentTW { get; set; } = "Message Shower Content (Traditional Chinese)";

            [Option('e', "contentUS", Required = false, HelpText = "The content (en-us) of Message Shower.")]
            public string contentUS { get; set; } = "Message Shower Content (English)";

            [Option('f', "file", Required = false, HelpText = "The execution file of Message Shower.")]
            public string file { get; set; } = String.Empty;

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
            string[] args;
            switch (option.mode)
            {
                case "Info":
                    args = new string[] { option.title, option.contentTW, option.contentUS };
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new InfoForm(args));
                    break;
                case "Exe":
                    args = new string[] { option.title, option.contentTW, option.contentUS, option.file };
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new ExeForm(args));
                    break;
                case "ExeF":
                    args = new string[] { option.title, option.contentTW, option.contentUS, option.file };
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new ExeFForm(args));
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
