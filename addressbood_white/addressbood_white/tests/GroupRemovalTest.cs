using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace addressbood_white
{
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {
            const int indexOfGroupToDelete = 2;
            var oldGroups = app.Groups.GetGroupList();
            app.Groups.RemoveGroup(indexOfGroupToDelete);
            var newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(indexOfGroupToDelete);

            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}