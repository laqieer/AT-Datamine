// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapBattleEnterButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x20016CE")]
  public class FreeMapBattleEnterButtonEvent : FreeMapIconButtonEventBase<FreeMapBattleEnterUIParam>
  {
    [Token(Token = "0x60080E7")]
    [Address(RVA = "0x41F7654", Offset = "0x41F7654", VA = "0x41F7654")]
    public FreeMapBattleEnterButtonEvent(
      FreeMapBattleEnterUIParam uiParam,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x60080E8")]
    [Address(RVA = "0x41F76B4", Offset = "0x41F76B4", VA = "0x41F76B4", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;
  }
}
