// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleConditionScrollView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200237D")]
  public class BattleConditionScrollView : VerticalInfiniteScrollView
  {
    [Token(Token = "0x17002E9A")]
    public RectTransform[] HeaderObjects
    {
      [Token(Token = "0x600D8C0"), Address(RVA = "0x1B99074", Offset = "0x1B99074", VA = "0x1B99074")] get
      {
        return (RectTransform[]) null;
      }
      [Token(Token = "0x600D8C1"), Address(RVA = "0x1B9907C", Offset = "0x1B9907C", VA = "0x1B9907C")] set
      {
      }
    }

    [Token(Token = "0x17002E9B")]
    public RectTransform[] FooterObjects
    {
      [Token(Token = "0x600D8C2"), Address(RVA = "0x1B99084", Offset = "0x1B99084", VA = "0x1B99084")] get
      {
        return (RectTransform[]) null;
      }
      [Token(Token = "0x600D8C3"), Address(RVA = "0x1B9908C", Offset = "0x1B9908C", VA = "0x1B9908C")] set
      {
      }
    }

    [Token(Token = "0x600D8C4")]
    [Address(RVA = "0x1B99094", Offset = "0x1B99094", VA = "0x1B99094", Slot = "18")]
    protected override void OnValueChanged(Vector2 normalizedPosition)
    {
    }

    [Token(Token = "0x600D8C5")]
    [Address(RVA = "0x1B99360", Offset = "0x1B99360", VA = "0x1B99360")]
    public BattleConditionScrollView()
    {
    }
  }
}
