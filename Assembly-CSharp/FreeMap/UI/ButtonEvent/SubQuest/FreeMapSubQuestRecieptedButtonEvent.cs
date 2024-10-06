// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.SubQuest.FreeMapSubQuestRecieptedButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam.SubQuest;
using FreeMap.UI.Popup;
using Il2CppDummyDll;
using StaqData;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent.SubQuest
{
  [Token(Token = "0x2001739")]
  public class FreeMapSubQuestRecieptedButtonEvent : 
    FreeMapSubQuestButtonEvent<FreeMapSubQuestReceiptedEventUIParam>,
    IQuestUIEvent
  {
    [Token(Token = "0x400673D")]
    [FieldOffset(Offset = "0x58")]
    private QuestPopupHandler questPopup;
    [Token(Token = "0x400673E")]
    [FieldOffset(Offset = "0x60")]
    private IEnumerator popupReaction;

    [Token(Token = "0x17001499")]
    private SubQuestData subquestData
    {
      [Token(Token = "0x6008363"), Address(RVA = "0x4060248", Offset = "0x4060248", VA = "0x4060248")] get
      {
        return (SubQuestData) null;
      }
    }

    [Token(Token = "0x6008364")]
    [Address(RVA = "0x40602C0", Offset = "0x40602C0", VA = "0x40602C0")]
    public FreeMapSubQuestRecieptedButtonEvent(
      FreeMapSubQuestReceiptedEventUIParam param,
      FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008365")]
    [Address(RVA = "0x4060354", Offset = "0x4060354", VA = "0x4060354", Slot = "18")]
    protected override IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x6008366")]
    [Address(RVA = "0x40603E4", Offset = "0x40603E4", VA = "0x40603E4")]
    private IEnumerator ReactionIsGoto() => (IEnumerator) null;

    [Token(Token = "0x6008367")]
    [Address(RVA = "0x4060474", Offset = "0x4060474", VA = "0x4060474")]
    private IEnumerator ReactionIsClose() => (IEnumerator) null;

    [Token(Token = "0x6008368")]
    [Address(RVA = "0x4060504", Offset = "0x4060504", VA = "0x4060504")]
    private IEnumerator RectionIsOpenMap() => (IEnumerator) null;

    [Token(Token = "0x6008369")]
    [Address(RVA = "0x4060594", Offset = "0x4060594", VA = "0x4060594", Slot = "23")]
    public void OnPositive()
    {
    }

    [Token(Token = "0x600836A")]
    [Address(RVA = "0x40605AC", Offset = "0x40605AC", VA = "0x40605AC", Slot = "29")]
    public void OnPositiveSE()
    {
    }

    [Token(Token = "0x600836B")]
    [Address(RVA = "0x40605B0", Offset = "0x40605B0", VA = "0x40605B0", Slot = "24")]
    public void OnNegative()
    {
    }

    [Token(Token = "0x600836C")]
    [Address(RVA = "0x40605FC", Offset = "0x40605FC", VA = "0x40605FC", Slot = "28")]
    public void OnMap()
    {
    }

    [Token(Token = "0x600836D")]
    [Address(RVA = "0x4060614", Offset = "0x4060614", VA = "0x4060614", Slot = "25")]
    public void OnNeutral()
    {
    }

    [Token(Token = "0x600836E")]
    [Address(RVA = "0x406062C", Offset = "0x406062C", VA = "0x406062C", Slot = "26")]
    public void OnClose()
    {
    }

    [Token(Token = "0x600836F")]
    [Address(RVA = "0x4060644", Offset = "0x4060644", VA = "0x4060644", Slot = "27")]
    public void OnPocketBook()
    {
    }
  }
}
