// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Facility.Types.Difficulty
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
  [Token(Token = "0x200175F")]
  public class Difficulty : FreeMapFacilityIconEvent
  {
    [Token(Token = "0x40067B9")]
    [FieldOffset(Offset = "0x68")]
    protected FreeMapIconEventFacilityAdvStage advStage;

    [Token(Token = "0x6008456")]
    [Address(RVA = "0x40659DC", Offset = "0x40659DC", VA = "0x40659DC")]
    public Difficulty(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008457")]
    [Address(RVA = "0x40659E4", Offset = "0x40659E4", VA = "0x40659E4", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x6008458")]
    [Address(RVA = "0x4065A38", Offset = "0x4065A38", VA = "0x4065A38", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x6008459")]
    [Address(RVA = "0x4065A58", Offset = "0x4065A58", VA = "0x4065A58", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;
  }
}
