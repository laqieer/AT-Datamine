// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapFacilityIconEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using Network.API;
using StaqData;
using Story.APIResult;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x20016E5")]
  public abstract class FreeMapFacilityIconEvent : 
    FreeMapIconButtonEventBase<FreeMapFacilityEventUIParam>
  {
    [Token(Token = "0x400664A")]
    [FieldOffset(Offset = "0x50")]
    protected APIStoryFacilityExecution facilityAPI;
    [Token(Token = "0x400664B")]
    [FieldOffset(Offset = "0x58")]
    protected FacilityExecution facilityAPIresultCommon;

    [Token(Token = "0x17001420")]
    protected Facility CurrentFacility
    {
      [Token(Token = "0x6008166"), Address(RVA = "0x41FB7AC", Offset = "0x41FB7AC", VA = "0x41FB7AC")] get
      {
        return (Facility) null;
      }
    }

    [Token(Token = "0x17001421")]
    protected bool canceled
    {
      [Token(Token = "0x6008167"), Address(RVA = "0x41FB824", Offset = "0x41FB824", VA = "0x41FB824")] private set
      {
      }
      [Token(Token = "0x6008168"), Address(RVA = "0x41FB830", Offset = "0x41FB830", VA = "0x41FB830")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008169")]
    [Address(RVA = "0x41FB838", Offset = "0x41FB838", VA = "0x41FB838")]
    public FreeMapFacilityIconEvent(
      FreeMapFacilityEventUIParam param,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x600816A")]
    [Address(RVA = "0x41FB914", Offset = "0x41FB914", VA = "0x41FB914", Slot = "23")]
    protected virtual IEnumerator OnIconEventBegin() => (IEnumerator) null;

    [Token(Token = "0x600816B")]
    [Address(RVA = "0x41FB9A4", Offset = "0x41FB9A4", VA = "0x41FB9A4", Slot = "24")]
    protected virtual IEnumerator OnIconEventFinish() => (IEnumerator) null;

    [Token(Token = "0x600816C")]
    [Address(RVA = "0x41FBA34", Offset = "0x41FBA34", VA = "0x41FBA34")]
    private void NewBudgeFlagOff()
    {
    }

    [Token(Token = "0x600816D")]
    [Address(RVA = "0x41FBB34", Offset = "0x41FBB34", VA = "0x41FBB34", Slot = "25")]
    protected virtual void OnCancel()
    {
    }

    [Token(Token = "0x600816E")]
    [Address(RVA = "0x41FBB44", Offset = "0x41FBB44", VA = "0x41FBB44")]
    protected FreeMapIconEventFacilityAdvStage ADVCommonSetting(int advID)
    {
      return (FreeMapIconEventFacilityAdvStage) null;
    }

    [Token(Token = "0x600816F")]
    [Address(RVA = "0x41FBC70", Offset = "0x41FBC70", VA = "0x41FBC70")]
    protected void OnPlayedIconEvent()
    {
    }

    [Token(Token = "0x6008170")]
    [Address(RVA = "0x41FBC74", Offset = "0x41FBC74", VA = "0x41FBC74")]
    protected bool IsCancel(FreeMapIconEventAdvStage advStage) => new bool();

    [Token(Token = "0x6008171")]
    [Address(RVA = "0x41FBC8C", Offset = "0x41FBC8C", VA = "0x41FBC8C", Slot = "26")]
    protected virtual IEnumerator FacilityAPI(APIStoryFacilityExecutionRequest request)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008172")]
    [Address(RVA = "0x41FBD28", Offset = "0x41FBD28", VA = "0x41FBD28", Slot = "27")]
    protected virtual void OnSuccessFacilityAPI(APIStoryFacilityExecutionResponse response)
    {
    }
  }
}
