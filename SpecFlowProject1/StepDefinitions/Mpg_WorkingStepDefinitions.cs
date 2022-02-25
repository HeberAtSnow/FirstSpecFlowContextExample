using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Mpg_WorkingStepDefinitions
    {
        private readonly ScenarioContext context;
        public Mpg_WorkingStepDefinitions(ScenarioContext context)
        {
            this.context=context;
        }
        [Given(@"Miles driven is (.*) and gallons uses is (.*)")]
        public void GivenMilesDrivenIsAndGallonsUsesIs(int miles, int gallons)
        {
            context.Add("miles", miles);
            context.Add("gallons",gallons);
        }

        [When(@"calculating mpg")]
        public void WhenCalculatingMpg()
        {
            MPG m = new();
            var res=m.calc_mpg(context.Get<int>("miles"), context.Get<int>("gallons"));
            context.Add("daAnswer", res);
        }

        [Then(@"computed mpg is (.*)")]
        public void ThenComputedMpgIs(double p0)
        {
            context.Get<double>("daAnswer").Should().Be(p0);
        }


        [Then(@"flag is true")]
        public void ThenFlagIsTrue()
        {
            throw new PendingStepException();
        }

    }
}
