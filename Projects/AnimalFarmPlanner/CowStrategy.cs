using System;

namespace AnimalFarmPlanner
{
    public class CowStrategy : IGrowthStrategy
    {
        public string GetPlan()
        {
            return "🐮 План вирощування корів:\n" +
                   "- Облаштувати пасовище\n" +
                   "- Забезпечити доступ до води\n" +
                   "- Годувати сіном і комбікормами\n" +
                   "- Робити регулярні ветеринарні огляди\n" +
                   "- Очікуване зростання: 12-18 місяців";
        }
    }
}
