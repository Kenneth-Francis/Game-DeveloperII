Console.WriteLine("**********  Game Developer I  **********");

// ENEMY IHERITED INSTANCES
MagicCaster   Hecate = new("Hecate");
MeleeFighter  Ares   = new("Ares");
RangedFighter Apollo = new("Apollo");

// ATTACK INSTANCES
Attack ArrowShot    = new("Arrow Shot",     15);
Attack Fireball     = new("Fireball",       25);
Attack Kick         = new("Kick",           15);
Attack KnifeThrow   = new("Knife Throw",    15);
Attack LightingBolt = new("Lightning Bolt", 20);
Attack Punch        = new("Punch",          20);
Attack StaffStrike  = new("Staff Strike",   10);
Attack Tackle       = new("Tackle",         25);

// ATTACK ASSIGNMENT
Apollo.AddAttack(ArrowShot);
Apollo.AddAttack(KnifeThrow);

Ares.AddAttack(Kick);
Ares.AddAttack(Punch);
Ares.AddAttack(Tackle);

Hecate.AddAttack(Fireball);
Hecate.AddAttack(LightingBolt);
Hecate.AddAttack(StaffStrike);


// ACTIONS
Ares.PerformAttack(Apollo, Kick);
Ares.Rage(Hecate);
Apollo.PerformAttack(Ares, ArrowShot);
Apollo.Dash();
Apollo.PerformAttack(Ares, ArrowShot);
Hecate.PerformAttack(Ares, Fireball);
Hecate.Heal(Apollo);
Hecate.Heal(Hecate);


