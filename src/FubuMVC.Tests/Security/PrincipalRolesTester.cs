using System.Security.Principal;
using System.Threading;
using FubuMVC.Core.Security;
using FubuTestingSupport;
using NUnit.Framework;

namespace FubuMVC.Tests.Security
{
    [TestFixture]
    public class PrincipalRolesTester
    {
        [Test]
        public void read_role_off_principal()
        {
            var principal = new GenericPrincipal(new GenericIdentity("somebody"), new string[]{"a", "b"});
            Thread.CurrentPrincipal = principal;

            PrincipalRoles.Current.ShouldBeTheSameAs(principal);

            PrincipalRoles.IsInRole("a").ShouldBeTrue();
            PrincipalRoles.IsInRole("c").ShouldBeFalse();
        }
    }
}