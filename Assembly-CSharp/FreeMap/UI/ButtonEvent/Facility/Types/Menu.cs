// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Facility.Types.Menu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Facility.Types
{
  [Token(Token = "0x2001761")]
  public class Menu : FreeMapFacilityIconEvent
  {
    [Token(Token = "0x40067BD")]
    [FieldOffset(Offset = "0x68")]
    protected FreeMapIconEventFacilityAdvStage advStage;

    [Token(Token = "0x6008461")]
    [Address(RVA = "0x4065D18", Offset = "0x4065D18", VA = "0x4065D18")]
    public Menu(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008462")]
    [Address(RVA = "0x4065D20", Offset = "0x4065D20", VA = "0x4065D20", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x6008463")]
    [Address(RVA = "0x4065D74", Offset = "0x4065D74", VA = "0x4065D74", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x6008464")]
    [Address(RVA = "0x4065D94", Offset = "0x4065D94", VA = "0x4065D94", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x6008465")]
    [Address(RVA = "0x4065E24", Offset = "0x4065E24", VA = "0x4065E24")]
    private IEnumerator Play() => (IEnumerator) null;
  }
}
