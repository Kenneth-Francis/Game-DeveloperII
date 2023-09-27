class MeleeFighter : Enemy
{
    public MeleeFighter(string name) : base(name, 120)
    {}

    public void Rage(Enemy Target)
    {
        if (this.Health == 0)
        {
            Console.WriteLine($"{this.Name} is incapacitated and can't attack. Turn wasted. Focus!");
            return;
        }

        Console.WriteLine($"{this.Name} rages out of control! ATK increased!");

        Attack RandAttack = RandomAttack();
        RandAttack.DamageAmount += 10;
        PerformAttack(Target, RandAttack);
        RandAttack.DamageAmount -= 10;
        
        Console.WriteLine($"{this.Name} has regained composure.");
    }
}