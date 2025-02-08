namespace Patterns.Patterns.Factory_Method
{
    internal class FireMage : Mage
    {

        public override void CastSpell()
        {
            Console.WriteLine("Fire spell");
        }
    }
}
