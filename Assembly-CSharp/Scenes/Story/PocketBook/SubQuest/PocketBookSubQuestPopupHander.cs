// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.SubQuest.PocketBookSubQuestPopupHander
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam.SubQuest;
using FreeMap.State;
using FreeMap.State.Process;
using FreeMap.UI.Popup;
using Il2CppDummyDll;
using Scenes.Story.SubQuest;
using System;

#nullable disable
namespace Scenes.Story.PocketBook.SubQuest
{
  [Token(Token = "0x2002DCB")]
  public class PocketBookSubQuestPopupHander : IQuestUIEvent
  {
    [Token(Token = "0x400C4E2")]
    [FieldOffset(Offset = "0x10")]
    private int subquestID;
    [Token(Token = "0x400C4E3")]
    [FieldOffset(Offset = "0x18")]
    private ShowPopupSubQuest showPopupSubQuest;
    [Token(Token = "0x400C4E4")]
    [FieldOffset(Offset = "0x20")]
    public Action OnPositiveAction;
    [Token(Token = "0x400C4E5")]
    [FieldOffset(Offset = "0x28")]
    public Action OnOtherAction;
    [Token(Token = "0x400C4E6")]
    [FieldOffset(Offset = "0x30")]
    public Action OnRemoveAction;
    [Token(Token = "0x400C4E7")]
    [FieldOffset(Offset = "0x38")]
    private FreeMapStateManager entity;

    [Token(Token = "0x17003D2A")]
    private QuestPopupHandler PopupHandler
    {
      [Token(Token = "0x6011E76"), Address(RVA = "0x3FABCF8", Offset = "0x3FABCF8", VA = "0x3FABCF8")] get
      {
        return (QuestPopupHandler) null;
      }
    }

    [Token(Token = "0x17003D2B")]
    private SubQuestDetailPopupToaster Toaster
    {
      [Token(Token = "0x6011E77"), Address(RVA = "0x3FABD14", Offset = "0x3FABD14", VA = "0x3FABD14")] get
      {
        return (SubQuestDetailPopupToaster) null;
      }
    }

    [Token(Token = "0x6011E78")]
    [Address(RVA = "0x3FABD30", Offset = "0x3FABD30", VA = "0x3FABD30")]
    public PocketBookSubQuestPopupHander(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x6011E79")]
    [Address(RVA = "0x3FABDE0", Offset = "0x3FABDE0", VA = "0x3FABDE0")]
    public void Initialize(int subQuestId)
    {
    }

    [Token(Token = "0x6011E7A")]
    [Address(RVA = "0x3FABEC8", Offset = "0x3FABEC8", VA = "0x3FABEC8")]
    public void Initialize(FreeMapSubQuestEventUIParam uiParam)
    {
    }

    [Token(Token = "0x6011E7B")]
    [Address(RVA = "0x3FABFBC", Offset = "0x3FABFBC", VA = "0x3FABFBC")]
    public void Begin()
    {
    }

    [Token(Token = "0x6011E7C")]
    [Address(RVA = "0x3FABFDC", Offset = "0x3FABFDC", VA = "0x3FABFDC", Slot = "4")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositive()
    {
    }

    [Token(Token = "0x6011E7D")]
    [Address(RVA = "0x3FAC18C", Offset = "0x3FAC18C", VA = "0x3FAC18C", Slot = "10")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositiveSE()
    {
    }

    [Token(Token = "0x6011E7E")]
    [Address(RVA = "0x3FAC190", Offset = "0x3FAC190", VA = "0x3FAC190", Slot = "5")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNegative()
    {
    }

    [Token(Token = "0x6011E7F")]
    [Address(RVA = "0x3FAC228", Offset = "0x3FAC228", VA = "0x3FAC228")]
    private void SubQuestCancelAction()
    {
    }

    [Token(Token = "0x6011E80")]
    [Address(RVA = "0x3FAC2B0", Offset = "0x3FAC2B0", VA = "0x3FAC2B0", Slot = "6")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNeutral()
    {
    }

    [Token(Token = "0x6011E81")]
    [Address(RVA = "0x3FAC2E8", Offset = "0x3FAC2E8", VA = "0x3FAC2E8", Slot = "8")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPocketBook()
    {
    }

    [Token(Token = "0x6011E82")]
    [Address(RVA = "0x3FAC2EC", Offset = "0x3FAC2EC", VA = "0x3FAC2EC", Slot = "9")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnMap()
    {
    }

    [Token(Token = "0x6011E83")]
    [Address(RVA = "0x3FAC170", Offset = "0x3FAC170", VA = "0x3FAC170")]
    private void End()
    {
    }

    [Token(Token = "0x6011E84")]
    [Address(RVA = "0x3FAC2F0", Offset = "0x3FAC2F0", VA = "0x3FAC2F0", Slot = "7")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnClose()
    {
    }
  }
}
