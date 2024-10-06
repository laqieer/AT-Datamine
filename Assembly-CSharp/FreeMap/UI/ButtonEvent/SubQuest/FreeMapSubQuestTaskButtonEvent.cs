// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.SubQuest.FreeMapSubQuestTaskButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam.SubQuest;
using FreeMap.UI.Popup;
using Il2CppDummyDll;
using Network.API;
using StaqData;
using Story.APIResult;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent.SubQuest
{
  [Token(Token = "0x200173E")]
  public class FreeMapSubQuestTaskButtonEvent : 
    FreeMapSubQuestButtonEvent<FreeMapSubQuestTaskEventUIParam>,
    IQuestUIEvent
  {
    [Token(Token = "0x400674B")]
    [FieldOffset(Offset = "0x58")]
    private APIStorySubquestAction subquestActionAPI;
    [Token(Token = "0x400674C")]
    [FieldOffset(Offset = "0x60")]
    private SubQuestAction actionAPIresultCommon;
    [Token(Token = "0x400674D")]
    [FieldOffset(Offset = "0x68")]
    private FreeMapIconEventAdvStage nowAdv;
    [Token(Token = "0x400674E")]
    [FieldOffset(Offset = "0x70")]
    private QuestPopupHandler popupHandler;
    [Token(Token = "0x400674F")]
    [FieldOffset(Offset = "0x78")]
    private IEnumerator completePopupReaction;

    [Token(Token = "0x6008389")]
    [Address(RVA = "0x4060BC8", Offset = "0x4060BC8", VA = "0x4060BC8")]
    public FreeMapSubQuestTaskButtonEvent(
      FreeMapSubQuestTaskEventUIParam param,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x600838A")]
    [Address(RVA = "0x4060CD4", Offset = "0x4060CD4", VA = "0x4060CD4", Slot = "19")]
    protected override void LoadIconEvent(FreeMapPlayerInstance activePlayer)
    {
    }

    [Token(Token = "0x600838B")]
    [Address(RVA = "0x4060E5C", Offset = "0x4060E5C", VA = "0x4060E5C", Slot = "20")]
    protected override bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x600838C")]
    [Address(RVA = "0x4060E7C", Offset = "0x4060E7C", VA = "0x4060E7C", Slot = "17")]
    protected override IEnumerator PlayIconEvent(FreeMapPlayerInstance activePlayer)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600838D")]
    [Address(RVA = "0x4060F18", Offset = "0x4060F18", VA = "0x4060F18")]
    private IEnumerator OnAction(SubQuestData subquest) => (IEnumerator) null;

    [Token(Token = "0x600838E")]
    [Address(RVA = "0x4060FA8", Offset = "0x4060FA8", VA = "0x4060FA8")]
    private IEnumerator OnComplete(SubQuestData subquest) => (IEnumerator) null;

    [Token(Token = "0x600838F")]
    [Address(RVA = "0x4061044", Offset = "0x4061044", VA = "0x4061044")]
    private IEnumerator ConnectSubQuestAPI() => (IEnumerator) null;

    [Token(Token = "0x6008390")]
    [Address(RVA = "0x40610D4", Offset = "0x40610D4", VA = "0x40610D4")]
    protected void OnSucceededSubQuestAction(APIStorySubquestActionResponse response)
    {
    }

    [Token(Token = "0x6008391")]
    [Address(RVA = "0x4061290", Offset = "0x4061290", VA = "0x4061290")]
    private void OnActioned(SubQuestData subQuest, APIStorySubquestActionResponse response)
    {
    }

    [Token(Token = "0x6008392")]
    [Address(RVA = "0x4061188", Offset = "0x4061188", VA = "0x4061188")]
    private void OnCompleted(SubQuestData subQuest, APIStorySubquestActionResponse response)
    {
    }

    [Token(Token = "0x6008393")]
    [Address(RVA = "0x4061294", Offset = "0x4061294", VA = "0x4061294", Slot = "25")]
    public void OnNeutral()
    {
    }

    [Token(Token = "0x6008394")]
    [Address(RVA = "0x40612C4", Offset = "0x40612C4", VA = "0x40612C4", Slot = "23")]
    public void OnPositive()
    {
    }

    [Token(Token = "0x6008395")]
    [Address(RVA = "0x40612F4", Offset = "0x40612F4", VA = "0x40612F4", Slot = "29")]
    public void OnPositiveSE()
    {
    }

    [Token(Token = "0x6008396")]
    [Address(RVA = "0x4061388", Offset = "0x4061388", VA = "0x4061388", Slot = "24")]
    public void OnNegative()
    {
    }

    [Token(Token = "0x6008397")]
    [Address(RVA = "0x4061448", Offset = "0x4061448", VA = "0x4061448", Slot = "27")]
    public void OnPocketBook()
    {
    }

    [Token(Token = "0x6008398")]
    [Address(RVA = "0x406148C", Offset = "0x406148C", VA = "0x406148C", Slot = "28")]
    public void OnMap()
    {
    }

    [Token(Token = "0x6008399")]
    [Address(RVA = "0x40614D0", Offset = "0x40614D0", VA = "0x40614D0", Slot = "26")]
    public void OnClose()
    {
    }

    [Token(Token = "0x600839A")]
    [Address(RVA = "0x40613E0", Offset = "0x40613E0", VA = "0x40613E0")]
    private IEnumerator Error(string title) => (IEnumerator) null;
  }
}
