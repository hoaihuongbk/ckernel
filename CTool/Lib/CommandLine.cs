using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace CTool.Lib
{
    public class CommandLine
    {
        /// <summary>
        /// Executes a shell command synchronously.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="arg"></param>
        public void ExecuteCommandSync(string fileName, string arg)
        {
            try
            {
                //Create process
                var pProcess = new Process
                {
                    StartInfo =
                    {
                        FileName = fileName,
                        Arguments = arg,
                    }
                };
                //Start the process
                pProcess.Start();

                //Wait for process to finish
                pProcess.WaitForExit();
            }
            catch (Exception objException)
            {
                // Log the exception
                Debug.WriteLine(objException);
            }
        }
    }
}