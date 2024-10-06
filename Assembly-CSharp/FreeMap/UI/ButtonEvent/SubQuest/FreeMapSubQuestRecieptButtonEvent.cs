// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.SubQuest.FreeMapSubQuestRecieptButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam.SubQuest;
using FreeMap.UI.Popup;
using Il2CppDummyDll;
using Network.API;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent.SubQuest
{
  [Token(Token = "0x2001730")]
  public class FreeMapSubQuestRecieptButtonEvent : 
    FreeMapSubQuestButtonEvent<FreeMapSubQuestReceiptEventUIParam>,
    IQuestUIEvent
  {
    [Token(Token = "0x4006722")]
    [FieldOffset(Offset = "0x58")]
    private FreeMapIconEventAdvStage nowAdv;
    [Token(Token = "0x4006723")]
    [FieldOffset(Offset = "0x60")]
    private QuestPopupHandler questPopup;
    [Token(Token = "0x4006724")]
    [FieldOffset(Offset = "0x68")]
    private IEnumerator popupReaction;

    [Token(Token = "0x6008327")]
    [Address(RVA = "0x405ED64", Offset = "0x405ED64", VA = "0x405ED64")]
    public FreeMapSubQuestRecieptButtonEvent(
      FreeMapSubQuestReceiptEventUIParam param,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008328")]
    [Address(RVA = "0x405EDF8", Offset = "0x405EDF8", VA = "0x405EDF8", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x6008329")]
    [Address(RVA = "0x405EEE8", Offset = "0x405EEE8", VA = "0x405EEE8", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x600832A")]
    [Address(RVA = "0x405EF08", Offset = "0x405EF08", VA = "0x405EF08", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x600832B")]
    [Address(RVA = "0x405EF98", Offset = "0x405EF98", VA = "0x405EF98")]
    private IEnumerator AdvCancel() => (IEnumerator) null;

    [Token(Token = "0x600832C")]
    [Address(RVA = "0x405F020", Offset = "0x405F020", VA = "0x405F020")]
    private IEnumerator AdvSuccess(FreeMapIconEventAdvStage advstage) => (IEnumerator) null;

    [Token(Token = "0x600832D")]
    [Address(RVA = "0x405F0B0", Offset = "0x405F0B0", VA = "0x405F0B0")]
    private IEnumerator ReactionIsReceipt() => (IEnumerator) null;

    [Token(Token = "0x600832E")]
    [Address(RVA = "0x405F140", Offset = "0x405F140", VA = "0x405F140")]
    private IEnumerator ReceiptingSubQuestCancel() => (IEnumerator) null;

    [Token(Token = "0x600832F")]
    [Address(RVA = "0x405F1C8", Offset = "0x405F1C8", VA = "0x405F1C8")]
    private IEnumerator ReactionIsClose() => (IEnumerator) null;

    [Token(Token = "0x6008330")]
    [Address(RVA = "0x405F258", Offset = "0x405F258", VA = "0x405F258")]
    protected void OnSucceededSubQuestReceipt(APIStorySubquestReceiptResponse response)
    {
    }

    [Token(Token = "0x6008331")]
    [Address(RVA = "0x405F3A8", Offset = "0x405F3A8", VA = "0x405F3A8", Slot = "23")]
    public void OnPositive()
    {
    }

    [Token(Token = "0x6008332")]
    [Address(RVA = "0x405F3D8", Offset = "0x405F3D8", VA = "0x405F3D8", Slot = "29")]
    public void OnPositiveSE()
    {
    }

    [Token(Token = "0x6008333")]
    [Address(RVA = "0x405F46C", Offset = "0x405F46C", VA = "0x405F46C", Slot = "25")]
    public void OnNeutral()
    {
    }

    [Token(Token = "0x6008334")]
    [Address(RVA = "0x405F484", Offset = "0x405F484", VA = "0x405F484", Slot = "26")]
    public void OnClose()
    {
    }

    [Token(Token = "0x6008335")]
    [Address(RVA = "0x405F49C", Offset = "0x405F49C", VA = "0x405F49C", Slot = "24")]
    public void OnNegative()
    {
    }

    [Token(Token = "0x6008336")]
    [Address(RVA = "0x405F4B4", Offset = "0x405F4B4", VA = "0x405F4B4", Slot = "27")]
    public void OnPocketBook()
    {
    }

    [Token(Token = "0x6008337")]
    [Address(RVA = "0x405F4CC", Offset = "0x405F4CC", VA = "0x405F4CC", Slot = "28")]
    public void OnMap()
    {
    }
  }
}
