using System;

namespace AnimalFarmPlanner
{
    public class PigStrategy : IGrowthStrategy
    {
        public string GetPlan()
        {
            return "🐷 План вирощування свиней:\n" +
                   "- Забезпечити просторий загін\n" +
                   "- Підтримувати чистоту в хліві\n" +
                   "- Годувати збалансованим кормом\n" +
                   "- Контролювати вагу та здоров'я\n" +
                   "- Очікуване зростання: 6-8 місяців";
        }
    }
}
