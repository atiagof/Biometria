using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlexCodeSDK;

namespace LeitorBiometrico
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        FlexCodeSDK.FinFPReg reg;
        string Template = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Inicializar o FlexCode SDK
            reg = new FinFPReg();
            reg.FPSamplesNeeded += new __FinFPReg_FPSamplesNeededEventHandler(reg_FPSamplesNeeded);
            reg.FPRegistrationTemplate += new __FinFPReg_FPRegistrationTemplateEventHandler(reg_FPRegistrationTemplate);
            reg.FPRegistrationImage += new __FinFPReg_FPRegistrationImageEventHandler(reg_FPRegistrationImage);
            reg.FPRegistrationStatus += new __FinFPReg_FPRegistrationStatusEventHandler(reg_FPRegistrationStatus);

            //Codigo de ativação do FlexCode SDK
            reg.AddDeviceInfo("", "", "");
        }

        private void reg_FPRegistrationStatus(RegistrationStatus Status)
        {

        }
        private void reg_FPRegistrationImage()
        {

        }
        private void reg_FPRegistrationTemplate(string FPTemplate)
        {

        }
        private void reg_FPSamplesNeeded(short Samples)
        {

        }

        

    }
}