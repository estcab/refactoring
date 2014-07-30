namespace Refactoring.DealingWithGeneralization.ExtractInterface.Before
{
    public class TimeSheet
    {
        public double Charge(Employee emp, int days)
        {
            var baseCharge = emp.GetRate() * days;

            return emp.HasSpecialSkill() ? baseCharge * 1.05 : baseCharge;
        }
    }
}
