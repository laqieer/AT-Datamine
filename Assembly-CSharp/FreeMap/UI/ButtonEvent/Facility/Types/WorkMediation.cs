// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Facility.Types.WorkMediation
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
  [Token(Token = "0x200176B")]
  public class WorkMediation : FreeMapFacilityIconEvent
  {
    [Token(Token = "0x40067D8")]
    [FieldOffset(Offset = "0x68")]
    protected FreeMapIconEventFacilityAdvStage advStage;

    [Token(Token = "0x600849D")]
    [Address(RVA = "0x4067050", Offset = "0x4067050", VA = "0x4067050")]
    public WorkMediation(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x600849E")]
    [Address(RVA = "0x4067058", Offset = "0x4067058", VA = "0x4067058", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x600849F")]
    [Address(RVA = "0x4067114", Offset = "0x4067114", VA = "0x4067114", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x60084A0")]
    [Address(RVA = "0x4067134", Offset = "0x4067134", VA = "0x4067134", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x60084A1")]
    [Address(RVA = "0x40671C4", Offset = "0x40671C4", VA = "0x40671C4")]
    private IEnumerator Play() => (IEnumerator) null;

    [Token(Token = "0x60084A2")]
    [Address(RVA = "0x4067254", Offset = "0x4067254", VA = "0x4067254")]
    private IEnumerator RandomWork() => (IEnumerator) null;

    [Token(Token = "0x60084A3")]
    [Address(RVA = "0x40672E4", Offset = "0x40672E4", VA = "0x40672E4")]
    private IEnumerator SelectedWork() => (IEnumerator) null;

    [Token(Token = "0x60084A4")]
    [Address(RVA = "0x4067374", Offset = "0x4067374", VA = "0x4067374")]
    protected IEnumerator PlayAdv(FreeMapIconEventFacilityAdvStage advStage) => (IEnumerator) null;
  }
}
