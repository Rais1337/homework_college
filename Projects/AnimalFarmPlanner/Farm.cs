using System;

namespace AnimalFarmPlanner
{
    public class Farm
    {
        private IGrowthStrategy _growthStrategy;

        public void SetStrategy(IGrowthStrategy strategy)
        {
            _growthStrategy = strategy;
        }

        public string GeneratePlan()
        {
            if (_growthStrategy == null)
                return "⚠️ Виберіть стратегію вирощування!";

            return _growthStrategy.GetPlan();
        }
    }
}
