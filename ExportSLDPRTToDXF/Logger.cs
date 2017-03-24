using Patterns;
using System;
using System.IO;
using System.Windows.Forms;

namespace ExportSLDPRTToDXF
{
    public  class Logger : Singeton <Logger>
    {
        #region Log

        private   string rootDir;
        public  string RootDirectory
        {
            get
            {
                if (rootDir == null || rootDir == string.Empty)
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                } 
                return rootDir;
            }
            set
            {
                rootDir = value;
            }
        }
        private  string LogPath { get { return RootDirectory + "\\Log.txt"; } }
        protected  Logger( ) : base()
        {

        }
        string log;
        public  void ToLog(string Message)
        {

            ToLog(Message, 0);
        }
        public  void ToLog(string errMessage, int errors)
        {
            try
            {
                if (!Directory.Exists(RootDirectory))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(RootDirectory));
                }
                else
                {
                    using (StreamWriter writetext = File.AppendText(LogPath))
                    {
                        writetext.WriteLine(errMessage);

                        #region errors for OpenDoc
                        if (errors == 1)
                        {
                            log = "The file '" + errMessage + "' swGenericError, код ошибки: " + 1;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 2)
                        {
                            log = "The file '" + errMessage + "' not found, код ошибки: " + 2;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 8192)
                        {
                            log = "The file '" + errMessage + "' is future version, код ошибки: " + 8192;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 65536)
                        {
                            log = "The file '" + errMessage + "' with the same name is already open, код ошибки: " + 65536;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 131072)
                        {
                            log = "The file '" + errMessage + "' encrypted by Liquid Machines, код ошибки: " + 131072;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 262144)
                        {
                            log = "The file '" + errMessage + "' is open and blocked because the system memory is low, or the number of GDI handles has exceeded the allowed maximum, код ошибки: " + 262144;
                            writetext.WriteLine(log);
                            return;
                        }
                        #endregion

                        #region erros for SaveAs
                        if (errors == 16)
                        {
                            log = "The file '" + errMessage + "' swFileLockError, код ошибки: " + 16;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 8)
                        {
                            log = "The file '" + errMessage + "' cannot contain the at symbol (@), код ошибки: " + 8;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 4)
                        {
                            log = "The file '" + errMessage + "' filename cannot be empty, код ошибки: " + 4;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 1024)
                        {
                            log = "The file '" + errMessage + "' do not overwrite an existing file, код ошибки: " + 1024;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 256)
                        {
                            log = "The file '" + errMessage + "' filename extension does not match the SOLIDWORKS document type, код ошибки: " + 256;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 2084)
                        {
                            log = "The file '" + errMessage + "' filename cannot exceed 255 characters, код ошибки: " + 2084;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 512)
                        {
                            log = "The file '" + errMessage + "' save the selected bodies in a part document. Valid option for IPartDoc::SaveToFile2; however, not a valid option for IModelDocExtension::SaveAs, код ошибки: " + 512;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 4096)
                        {
                            log = "The file '" + errMessage + "' Save As operation is not supported, код ошибки: " + 4096;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 32)
                        {
                            log = "The file '" + errMessage + "' Save As file type is not valid, код ошибки: " + 32;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 1)
                        {
                            log = "The file '" + errMessage + "' swGenericSaveError, код ошибки: " + 1;
                            writetext.WriteLine(log);
                            return;
                        }
                        if (errors == 2)
                        {
                            log = "The file '" + errMessage + "' swReadOnlySaveError, код ошибки: " + 2;
                            writetext.WriteLine(log);
                            return;
                        }
                        #endregion

                        #region AllErrors
                        if (errors == 1000)
                        {
                            log = errMessage + ", код ошибки: " + 1000;
                            writetext.WriteLine(log);
                        }
                        if (errors == 1001)
                        {
                            log = "ModelDoc2 '" + errMessage + "' failed, код ошибки: " + 1001;
                            writetext.WriteLine(log);
                        }
                        if (errors == 10001)
                        {
                            log = errMessage + ", код ошибки: " + 10001;
                            writetext.WriteLine(log);
                        }

                        DateTime _date = DateTime.Now;
                        var _dateString = _date.ToString("dd.MM.yy");
                        var _time = DateTime.Now;
                        var _timeString = _time.ToString("HH:mm:ss tt");
                        if (errors == 1002)
                        {
                            writetext.WriteLine("--- " + _dateString + " / " + _timeString);
                            log = errMessage;
                            writetext.WriteLine(log);
                        }

                        // Проверка пачек

                        if (errors == 123)
                        {
                            log = errMessage;
                            writetext.WriteLine(log);
                        }
                        if (errors == 10003)
                        {
                            log = _timeString + ": " + errMessage;
                            writetext.WriteLine(log);
                        }

                        #endregion

                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + "; \n" + exception.StackTrace);
            }
        }
        #endregion
    }
}