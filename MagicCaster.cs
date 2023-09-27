class MagicCaster : Enemy
{
    public MagicCaster(string name) : base(name, 80)
    {}

    public void Heal(Enemy Target)
    {
        if (Target.Health == 0)
        {
            Console.WriteLine($"{Target.Name} is incapacitated and needs to be 'Revived'!");
            return;
        }
        else
        {
            Target.Health += 40;
            Console.WriteLine($"{this.Name} uses Heal on {Target.Name}, +40 health. {Target.Name}'s health is now {Target.Health}!");
        }
    }
}