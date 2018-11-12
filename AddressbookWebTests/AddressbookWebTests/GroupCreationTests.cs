﻿using NUnit.Framework;

namespace AddressbookWebTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        

        [Test]
        public void GroupCreationTest()
        {
            Navigator.GoToHomePage();
            LoginHelper.Login(new AccountData("admin", "secret"));
            Navigator.GoToGroupsPage();
            CreateNewGroup();
            FillGroupForm(new GroupData("group_name", "group_header", "group_footer"));
            SubmitGroupCreation();
            ReturnToGroupsPage();
        }
    }
}