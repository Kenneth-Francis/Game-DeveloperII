class RangedFighter : Enemy
{
    public int Distance { get; set; } = 5;

    public RangedFighter(string name) : base(name)
    {}

    public void Dash()
    {
        this.Distance = 20;
        Console.WriteLine($"{this.Name} used Dash, creating distance from the enemy!");
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (this.Distance > 10)
        {
            base.PerformAttack(Target, ChosenAttack);
        }
        else
        {
            Console.WriteLine($"{this.Name} blanches under enemy pressure/proximity.\n{this.Name}: 'I must create distance!'");
        }
    }
}