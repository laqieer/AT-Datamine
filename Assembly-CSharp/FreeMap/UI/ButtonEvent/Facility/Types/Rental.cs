// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Facility.Types.Rental
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using Network.API;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Facility.Types
{
  [Token(Token = "0x2001768")]
  public class Rental : FreeMapFacilityIconEvent
  {
    [Token(Token = "0x40067D1")]
    [FieldOffset(Offset = "0x68")]
    protected FreeMapIconEventFacilityAdvStage advStage;

    [Token(Token = "0x600848A")]
    [Address(RVA = "0x406699C", Offset = "0x406699C", VA = "0x406699C")]
    public Rental(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x600848B")]
    [Address(RVA = "0x40669A4", Offset = "0x40669A4", VA = "0x40669A4", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x600848C")]
    [Address(RVA = "0x40669F8", Offset = "0x40669F8", VA = "0x40669F8", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x600848D")]
    [Address(RVA = "0x4066A18", Offset = "0x4066A18", VA = "0x4066A18", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x600848E")]
    [Address(RVA = "0x4066AA8", Offset = "0x4066AA8", VA = "0x4066AA8")]
    private IEnumerator Play() => (IEnumerator) null;

    [Token(Token = "0x600848F")]
    [Address(RVA = "0x4066B38", Offset = "0x4066B38", VA = "0x4066B38")]
    private APIStoryFacilityExecutionRequest ReturnBookRequest(
      FreeMapIconEventFacilityAdvStage advStage)
    {
      return (APIStoryFacilityExecutionRequest) null;
    }

    [Token(Token = "0x6008490")]
    [Address(RVA = "0x4066BA8", Offset = "0x4066BA8", VA = "0x4066BA8")]
    private APIStoryFacilityExecutionRequest RentalBookRequest(
      FreeMapIconEventFacilityAdvStage advStage)
    {
      return (APIStoryFacilityExecutionRequest) null;
    }
  }
}
