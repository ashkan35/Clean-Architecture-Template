using NetArchTest.Rules;
using System.Reflection;
using System.Reflection.Metadata;

namespace CleanArc.ArchitectureTests
{
    public class ArchitectureTests
    {
        private const string DomainNameSpace = "CleanArc.Domain";
        private const string ApplicationNameSpace = "CleanArc.Domain";
        private const string CrossCuttingSpace = "CleanArc.Infrustructure.CrossCutting";
        private const string IdentityNameSpace = "CleanArc.Infrustructure.Identity";

        [Fact]
        public void AppDomain_ShouldHave_ProjectWithName_Domain()
        {

            //Arrange
            var projects = Assembly.Load(DomainNameSpace);
            var cc = projects.GetReferencedAssemblies();
            var dependencyResult = Types.InAssembly(projects).ShouldNot()
                .HaveDependencyOnAll(ApplicationNameSpace, CrossCuttingSpace, IdentityNameSpace).GetResult();
            Assert.True(dependencyResult.IsSuccessful);
        }
        //[Fact]
        //public void Domain_Should_Not_HaveDependencyOnOtherProjects()
        //{
        //    var assembly=AppDomain.CurrentDomain.GetAssemblies().Where(x=>x.FullName.Contains("Domain"));
        //}
    }
}