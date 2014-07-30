namespace Refactoring.DealingWithGeneralization.ExtractInterface.After
{
    public class TimeSheet
    {
        public double Charge(IBillable emp, int days)
        {
            var baseCharge = emp.GetRate() * days;

            return emp.HasSpecialSkill() ? baseCharge * 1.05 : baseCharge;
        }
    }
}
