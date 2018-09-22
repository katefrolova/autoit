﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace addressbood_white
{
    public class ApplicationManager
    {
        public static string WINTITLE = "Free Address Book";
        private AutoItX3 aux;
        private GroupHelper groupHelper;
        public ApplicationManager()
        {
            aux = new AutoItX3();
            aux.Run(@"C:\Users\e.frolova\Desktop\AddressbookNative4\AddressBook.exe", "", aux.SW_SHOW);
            aux.WinWait(WINTITLE);
            aux.WinActivate(WINTITLE);
            aux.WinWaitActive(WINTITLE);
            groupHelper = new GroupHelper(this);
        }

        public void Stop()
        {
            aux.ControlClick("WINTITLE", "", "WindowsForms10.BUTTON.app.0.62e44910");
        }

        public AutoItX3 Aux
        {
            get
            {
                return aux;
            }
        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }

    }
}