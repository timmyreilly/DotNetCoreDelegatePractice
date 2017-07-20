using System; 
using System.IO; 

namespace DelegatePractice{

    public class FileLogger
    {
        private readonly string logPath;

        public FileLogger(string path){
            logPath = path; 
            Logger.WriteMessage += LogMessage; 
        }

        public void DetachLog() => Logger.WriteMessage -= LogMessage; 
        // make sure this can't throw. 

        private void LogMessage(string msg){
            try {
                using (var log = File.AppendText(logPath)){
                    log.WriteLine(msg); 
                    log.Flush(); 
                }
            }catch(Exception){
                // can't log if you can't log
            }
        }
    }

}