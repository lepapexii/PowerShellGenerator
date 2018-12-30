using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Runtime.InteropServices;
using System.Text;

namespace NetConsole
{
    public class PSFactory
    {
        public PowerShell PowerShellz;
        private PowerShell PowerShellInstance
        {
            get { return this.PowerShellz; }
            set { this.PowerShellz = value; }
        }
        public PSFactory([Optional] string profile)
        {



        }


        //SYNChronous
        public void FireNForget()
        {

     

            using (this.PowerShellz)
            {
                PowerShellz = PowerShell.Create();

                // invoke execution on the pipeline (ignore output) Synchronous execution
                //generate empty PS pipeline
                // use "AddScript" to add the contents of a script file to the end of the execution pipeline.
                // use "AddCommand" to add individual commands/cmdlets to the end of the execution pipeline.
                PowerShellz.AddScript("Set-ExecutionPolicy 'AllSigned'");
                PowerShellz.AddScript("param($param1) $d = get-date; $s = 'test string value'; " +
                      "$d; $s; $param1; get-service");

               

                // use "AddParameter" to add a single parameter to the last command/script on the pipeline.
                PowerShellz.AddParameter("param1", "parameter 1 value!");
                PowerShellz.Invoke();

            }

            using (this.PowerShellz)
            {
                PowerShellz = PowerShell.Create();
                var go = PowerShellz.AddCommand("Set-ExecutionPolicy");
                go.InvocationStateInfo.Reason.Message.ToString();
                PowerShellz.Invoke();

            }



        }

        //SYNChronous
        public void CustomFire()
        {

            // invoke execution on the pipeline (collecting output)
            // Collection<PSObject> PSOutput = pipe.Invoke();

            // loop through each output object item
            // foreach (PSObject outputItem in PSOutput)
            {
                // if null object was dumped to the pipeline during the script then a null
                // object may be present here. check for null to prevent potential NRE.
                //   if (outputItem != null)
                {
                    //TODO: do something with the output item 
                    // outputItem.BaseOBject
                    //      Console.WriteLine(outputItem.BaseObject.GetType().FullName);
                    //   Console.WriteLine(outputItem.BaseObject.ToString() + "\n");
                }
            }

            VerifyOutput();
        }

        private void VerifyOutput()
        {

            // invoke execution on the pipeline (collecting output)
            // Collection<PSObject> PSOutput = pipe.Invoke();

            // check the other output streams (for example, the error stream)
            //    if (pipe.Streams.Error.Count > 0)
            {
                // error records were written to the error stream.
                // do something with the items found.
            }
        }
    }
}
