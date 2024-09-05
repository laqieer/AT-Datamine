// Decompiled with JetBrains decompiler
// Type: StaqData.StyleOnlyParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002103")]
  public sealed class StyleOnlyParameter : StyleParameter
  {
    [Token(Token = "0x600C940")]
    [Address(RVA = "0x1B9CBC0", Offset = "0x1B9CBC0", VA = "0x1B9CBC0", Slot = "22")]
    public override void Update(StyleData style, PlayerUnitType unit, Character character)
    {
    }

    [Token(Token = "0x600C941")]
    [Address(RVA = "0x1B9D878", Offset = "0x1B9D878", VA = "0x1B9D878", Slot = "23")]
    public override void Update(IBasicParameter source, List<Equipment> equipments, Style style)
    {
    }

    [Token(Token = "0x600C942")]
    [Address(RVA = "0x1B9E764", Offset = "0x1B9E764", VA = "0x1B9E764", Slot = "24")]
    public override void Update(
      int life,
      int strength,
      int intelligence,
      int vitality,
      int mind,
      int agility,
      int dexterity,
      int lucky,
      List<Equipment> equipments,
      Style style)
    {
    }

    [Token(Token = "0x600C943")]
    [Address(RVA = "0x1B9E8D0", Offset = "0x1B9E8D0", VA = "0x1B9E8D0")]
    public StyleOnlyParameter()
    {
    }
  }
}
