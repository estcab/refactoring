namespace Refactoring.OrganizingData.ReplaceMagicNumberWithSymbolicConstant
{
    public class After
    {
        public const double GravitationalConstant = 9.81;

        public double PotentialEnergy(double mass, double height)
        {
            return mass * GravitationalConstant * height;
        }
    }
}
