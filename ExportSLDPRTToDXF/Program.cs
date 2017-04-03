using Patterns.Observer;
using System;
using System.Windows.Forms;

namespace ExportSLDPRTToDXF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageObserver.Instance.ReceivedMessage += Instance_ReceivedMessage;
            try
            {
                Application.EnableVisualStyles( );
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new DataForm( ));
            }
            catch(Exception ex)
            {
                MessageObserver.Instance.SetMessage(ex.Message, MessageType.Warning);
            }
        }

        /// <summary>
        /// Обработка системных сообщений
        /// </summary>
        /// <param name="massage"></param>
        private static void Instance_ReceivedMessage(Patterns.Observer.MessageEventArgs massage)
        {
            try
            {

                Logger.Instance.ToLog($"Time:{massage.time} Message: {massage.Message}");
                if (massage.Type == MessageType.Error)
                    MessageBox.Show(massage.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
