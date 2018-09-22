﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbood_white
{
    public class TestBase
    {
        public ApplicationManager app;

        [TestFixtureSetUp]
        public void initApplication()
        {
            app = new ApplicationManager();
        }

        [TestFixtureTearDown]
        public void stopApplication()
        {
            app.Stop();
        }

    }
}
