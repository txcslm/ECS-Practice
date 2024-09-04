using System;
using System.Linq;
using Code.Common.Entity.ToStrings;
using Entitas;
using UnityEngine;

// ReSharper disable once CheckNamespace
public sealed partial class GameEntity : INamedEntity
{
  private EntityPrinter _printer;

  public override string ToString()
  {
    if (_printer == null)
      _printer = new EntityPrinter(this);

    _printer.InvalidateCache();

    return _printer.BuildToString();
  }

  public string EntityName(IComponent[] components)
  {
    try
    {
      if (components.Length == 1)
        return components[0].GetType().Name;

      foreach (IComponent component in components)
      {
        switch (component.GetType().Name)
        {
          // case nameof(Hero):
          //   return PrintHero();

          // case nameof(Enemy):
          //   return PrintEnemy();
        }
      }
    }
    catch (Exception exception)
    {
      Debug.LogError(exception.Message);
    }

    return components.First().GetType().Name;
  }

  // private string PrintHero()
  // {
  //   return new StringBuilder($"Hero ")
  //     .With(s => s.Append($"Id:{Id}"), when: hasId)
  //     .ToString();
  // }
  //
  // private string PrintEnemy() =>
  //   new StringBuilder($"Enemy ")
  //     .With(s => s.Append($"Id:{Id}"), when: hasId)
  //     .ToString();
  
  public string BaseToString() => base.ToString();
  
  
// В былые времена, когда мечи пели свои смертельные баллады, этот ритуал стирал из памяти былых воинов.
// Оставляет лишь шепот их былого величия, унося их в забытье.
// Введите ID и услышите их последний вздох в мире тленном.
  private void RemovePlayer()
  {
    Console.WriteLine("Введите ID игрока");
    if (TryGetPlayer(out Player player))
    {
      _players.Remove(player); // Удаление игрока из списка
    }
    else
    {
      Console.WriteLine("Ошибка");
    }
  }
}
