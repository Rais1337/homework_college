using System;

namespace AnimalFarmPlanner
{
    public class ChickenStrategy : IGrowthStrategy
    {
        public string GetPlan()
        {
            return "🐔 План вирощування курей:\n" +
                   "- Побудувати курник\n" +
                   "- Підтримувати температуру 18-22°C\n" +
                   "- Годувати зерновими культурами\n" +
                   "- Проводити вакцинацію\n" +
                   "- Очікуване зростання: 2-3 місяці";
        }
    }
}
