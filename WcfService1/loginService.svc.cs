﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "loginService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select loginService.svc or loginService.svc.cs at the Solution Explorer and start debugging.
    public class loginService : IloginService
    {
        public bool boolValidateLogin(string strUser, string strPass)
        {
            bool boolSuccess = false;
            if (
                strUser == "cesar@hotmail.com" &&
                strPass == "root"
                )
            {
                boolSuccess = true;
            }

            return boolSuccess;
        }
    }
}
