namespace GameConsole
{
    class IronBonesDefence : SpecialDefence
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 5;
        }
    }
}
