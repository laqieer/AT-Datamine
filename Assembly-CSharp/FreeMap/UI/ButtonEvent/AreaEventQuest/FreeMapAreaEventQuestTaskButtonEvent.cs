// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.AreaEventQuest.FreeMapAreaEventQuestTaskButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam.AreaEvent;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using StaqData.AreaEvent;
using Story.APIResult;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent.AreaEventQuest
{
  [Token(Token = "0x2001745")]
  public class FreeMapAreaEventQuestTaskButtonEvent : 
    FreeMapAreaEventQuestButtonEvent<FreeMapAreaEventQuestTaskEventUIParam>
  {
    [Token(Token = "0x4006763")]
    [FieldOffset(Offset = "0x50")]
    private APIStoryAreaEventQuestAction areaEventQuestActionAPI;
    [Token(Token = "0x4006764")]
    [FieldOffset(Offset = "0x58")]
    private AreaEventQuestAction apiResultCommonProcess;
    [Token(Token = "0x4006765")]
    [FieldOffset(Offset = "0x60")]
    private APIStoryAreaEventQuestActionResponse response;
    [Token(Token = "0x4006766")]
    [FieldOffset(Offset = "0x68")]
    private ItemRewardPopupManage rewardPopupObj;
    [Token(Token = "0x4006767")]
    [FieldOffset(Offset = "0x70")]
    private FreeMapIconEventAreaEventQuestAdvStage nowAdv;

    [Token(Token = "0x170014AD")]
    private AreaEventQuestManager AreaEventQuestManager
    {
      [Token(Token = "0x60083BD"), Address(RVA = "0x4061E08", Offset = "0x4061E08", VA = "0x4061E08")] get
      {
        return (AreaEventQuestManager) null;
      }
    }

    [Token(Token = "0x60083BE")]
    [Address(RVA = "0x4061E64", Offset = "0x4061E64", VA = "0x4061E64")]
    public FreeMapAreaEventQuestTaskButtonEvent(
      FreeMapAreaEventQuestTaskEventUIParam param,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x60083BF")]
    [Address(RVA = "0x4061F70", Offset = "0x4061F70", VA = "0x4061F70", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x60083C0")]
    [Address(RVA = "0x406215C", Offset = "0x406215C", VA = "0x406215C", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x60083C1")]
    [Address(RVA = "0x406217C", Offset = "0x406217C", VA = "0x406217C", Slot = "17")]
    protected override IEnumerator PlayIconEvent(FreeMapPlayerInstance activePlayer)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60083C2")]
    [Address(RVA = "0x4062218", Offset = "0x4062218", VA = "0x4062218")]
    private IEnumerator PlayTaskReward() => (IEnumerator) null;

    [Token(Token = "0x60083C3")]
    [Address(RVA = "0x40622A8", Offset = "0x40622A8", VA = "0x40622A8", Slot = "22")]
    protected override void OnExit()
    {
    }

    [Token(Token = "0x60083C4")]
    [Address(RVA = "0x40622C4", Offset = "0x40622C4", VA = "0x40622C4")]
    private IEnumerator ConnectAPI(AdvRequest advRequest) => (IEnumerator) null;

    [Token(Token = "0x60083C5")]
    [Address(RVA = "0x4062360", Offset = "0x4062360", VA = "0x4062360")]
    protected void OnSucceededAction(APIStoryAreaEventQuestActionResponse response)
    {
    }
  }
}
