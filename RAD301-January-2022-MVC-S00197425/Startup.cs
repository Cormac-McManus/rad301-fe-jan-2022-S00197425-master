using Microsoft.Owin;
using Owin;
using Tracker.WebAPIClient;

[assembly: OwinStartupAttribute(typeof(RAD301_January_2022_MVC_S00197425.Startup))]
namespace RAD301_January_2022_MVC_S00197425
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            ActivityAPIClient.Track(StudentID: "S00197425", StudentName: "Cormac McManus", activityName: "Rad301 January 2022", Task: "Exam Start");
        }
    }
}
