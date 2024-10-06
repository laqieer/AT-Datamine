// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Facility.Types.Lottery
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2;
using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using Network.API;
using Network.Param;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Facility.Types
{
  [Token(Token = "0x200175A")]
  public class Lottery : FreeMapFacilityIconEvent
  {
    [Token(Token = "0x40067AC")]
    [FieldOffset(Offset = "0x68")]
    protected FreeMapIconEventFacilityAdvStage advStage;
    [Token(Token = "0x40067AD")]
    [FieldOffset(Offset = "0x70")]
    private Adv2Manager.OnProccessSignal signal;

    [Token(Token = "0x600843A")]
    [Address(RVA = "0x4064EE8", Offset = "0x4064EE8", VA = "0x4064EE8")]
    public Lottery(FreeMapFacilityEventUIParam param, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x600843B")]
    [Address(RVA = "0x4064EF0", Offset = "0x4064EF0", VA = "0x4064EF0", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x600843C")]
    [Address(RVA = "0x4064F44", Offset = "0x4064F44", VA = "0x4064F44", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x600843D")]
    [Address(RVA = "0x4064F64", Offset = "0x4064F64", VA = "0x4064F64", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x600843E")]
    [Address(RVA = "0x4064FF4", Offset = "0x4064FF4", VA = "0x4064FF4")]
    private IEnumerator PlayADV() => (IEnumerator) null;

    [Token(Token = "0x600843F")]
    [Address(RVA = "0x4065084", Offset = "0x4065084", VA = "0x4065084", Slot = "28")]
    protected virtual void ApiCall(Adv2Manager.OnProccessSignal signal)
    {
    }

    [Token(Token = "0x6008440")]
    [Address(RVA = "0x4065128", Offset = "0x4065128", VA = "0x4065128")]
    private IEnumerator ApiExecute() => (IEnumerator) null;

    [Token(Token = "0x6008441")]
    [Address(RVA = "0x40651B8", Offset = "0x40651B8", VA = "0x40651B8", Slot = "27")]
    protected override void OnSuccessFacilityAPI(APIStoryFacilityExecutionResponse response)
    {
    }

    [Token(Token = "0x6008442")]
    [Address(RVA = "0x4065228", Offset = "0x4065228", VA = "0x4065228")]
    private Lottery.LotteryResultLuaObject CreateResultObject(StoryFacilityUseResult result)
    {
      return (Lottery.LotteryResultLuaObject) null;
    }

    [Token(Token = "0x200175B")]
    [MoonSharpUserData]
    public class LotteryResultLuaObject
    {
      [Token(Token = "0x40067AE")]
      [FieldOffset(Offset = "0x10")]
      public bool Success;
      [Token(Token = "0x40067AF")]
      [FieldOffset(Offset = "0x18")]
      public string CharaName;

      [Token(Token = "0x6008443")]
      [Address(RVA = "0x40653AC", Offset = "0x40653AC", VA = "0x40653AC")]
      public LotteryResultLuaObject()
      {
      }
    }
  }
}
