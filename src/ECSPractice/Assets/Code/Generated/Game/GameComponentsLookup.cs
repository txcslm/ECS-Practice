//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int Destructed = 0;
    public const int SelfDestructTimer = 1;
    public const int View = 2;
    public const int Id = 3;
    public const int SpriteRenderer = 4;
    public const int Transform = 5;
    public const int WorldPosition = 6;
    public const int Enemy = 7;
    public const int EnemyAnimator = 8;
    public const int Hero = 9;
    public const int HeroAnimator = 10;
    public const int Direction = 11;
    public const int Moving = 12;
    public const int Speed = 13;
    public const int TurnedAlongDirection = 14;
    public const int AxisInput = 15;
    public const int Input = 16;

    public const int TotalComponents = 17;

    public static readonly string[] componentNames = {
        "Destructed",
        "SelfDestructTimer",
        "View",
        "Id",
        "SpriteRenderer",
        "Transform",
        "WorldPosition",
        "Enemy",
        "EnemyAnimator",
        "Hero",
        "HeroAnimator",
        "Direction",
        "Moving",
        "Speed",
        "TurnedAlongDirection",
        "AxisInput",
        "Input"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Code.Common.Destructed),
        typeof(Code.Common.SelfDestructTimer),
        typeof(Code.Common.View),
        typeof(Code.Gameplay.Common.Id),
        typeof(Code.Gameplay.Common.SpriteRendererComponent),
        typeof(Code.Gameplay.Common.TransformComponent),
        typeof(Code.Gameplay.Common.WorldPosition),
        typeof(Code.Gameplay.Features.Enemies.Enemy),
        typeof(Code.Gameplay.Features.Enemies.EnemyAnimatorComponent),
        typeof(Code.Gameplay.Features.Hero.Hero),
        typeof(Code.Gameplay.Features.Hero.HeroAnimatorComponent),
        typeof(Code.Gameplay.Features.Movement.Direction),
        typeof(Code.Gameplay.Features.Movement.Moving),
        typeof(Code.Gameplay.Features.Movement.Speed),
        typeof(Code.Gameplay.Features.Movement.TurnedAlongDirection),
        typeof(Code.Gameplay.Input.AxisInput),
        typeof(Code.Gameplay.Input.Input)
    };
}
