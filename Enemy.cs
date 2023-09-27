class Enemy
{ 
    public string       Name       { get; set; }
    public int          Health     { get; set; }
    public List<Attack> AttackList { get; set; }

    public Enemy(string name, int health = 100)
    {
        Name       = name;
        Health     = health;
        AttackList = new();
    }

    public void AddAttack(Attack NewAttack)
    {
        AttackList.Add(NewAttack);
    }

    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (this.Health == 0)
        {
            Console.WriteLine($"{this.Name} is incapacitated and can't attack. Turn wasted. Focus!");
        }
        else if (Target.Health == 0)
        {
            Console.WriteLine($"{this.Name} experiences bloodlust, uses {ChosenAttack} on an incapacitated {Target.Name}. Turn wasted. Focus!");
        }
        else if (Target.Health - ChosenAttack.DamageAmount <= 0)
        {
            Target.Health = 0;
            Console.WriteLine($"{this.Name} uses {ChosenAttack} on {Target.Name}, inflicting {ChosenAttack.DamageAmount} damage and dealing the finishing blow. {Target.Name} is incapacitated!");
        }
        else
        {
            Target.Health -= ChosenAttack.DamageAmount;
            Console.WriteLine($"{this.Name} uses {ChosenAttack.Name} on {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!");
        }
    }

    public Attack RandomAttack()
    {
        Random random = new();
        Attack randomAttack = AttackList[ random.Next(AttackList.Count) ];
        // Console.WriteLine($"{Name} uses {randAttack.Name}, it deals {randAttack.DamageAmount} damage!");
        return randomAttack;
    }
}