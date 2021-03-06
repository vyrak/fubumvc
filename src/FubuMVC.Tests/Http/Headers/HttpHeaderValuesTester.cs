using FubuMVC.Core.Http;
using FubuMVC.Core.Http.Headers;
using NUnit.Framework;
using FubuTestingSupport;

namespace FubuMVC.Tests.Http.Headers
{
    [TestFixture]
    public class HttpHeaderValuesTester
    {
        [Test]
        public void build_with_key_name_pair_in_ctor()
        {
            var values = new HttpHeaderValues(HttpResponseHeaders.Via, "something");

            values["Via"].ShouldEqual("something");
            values.Headers.ShouldHaveTheSameElementsAs(new Header("Via", "something"));
        }
    }
}