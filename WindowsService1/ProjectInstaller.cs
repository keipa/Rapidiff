using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsService1
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
            this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            this.RapiDiff = new System.ServiceProcess.ServiceInstaller();

            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;


            //Set the ServiceName of the Windows Service.
            this.RapiDiff.ServiceName = "SimpleService";

            //Set its StartType to Automatic.
            this.RapiDiff.StartType = System.ServiceProcess.ServiceStartMode.Automatic;

            //
            // ProjectInstaller
            //
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
                this.serviceProcessInstaller1,
                this.RapiDiff});
        }
        private void serviceProcessInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {
            using (System.ServiceProcess.ServiceController serviceController = new System.ServiceProcess.ServiceController(RapiDiff.ServiceName))
            {
                serviceController.Start();
            }
        }
    }
}
