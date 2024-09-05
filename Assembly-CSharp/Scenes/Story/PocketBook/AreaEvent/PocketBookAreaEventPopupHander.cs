// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.AreaEvent.PocketBookAreaEventPopupHander
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State;
using FreeMap.State.Process;
using FreeMap.UI.Popup;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Story.PocketBook.AreaEvent
{
  [Token(Token = "0x2002DCC")]
  public class PocketBookAreaEventPopupHander : FreeMapMethodProcess, IQuestUIEvent
  {
    [Token(Token = "0x400C4E8")]
    [FieldOffset(Offset = "0x20")]
    private QuestUIStateHandler questUIStateHandler;
    [Token(Token = "0x400C4E9")]
    [FieldOffset(Offset = "0x28")]
    private AreaEventQuestDataSetter dataSetter;
    [Token(Token = "0x400C4EA")]
    [FieldOffset(Offset = "0x30")]
    private QuestPopupHandler popupHandler;
    [Token(Token = "0x400C4EB")]
    [FieldOffset(Offset = "0x38")]
    private int areaEventQuestId;
    [Token(Token = "0x400C4EC")]
    [FieldOffset(Offset = "0x40")]
    public Action OnPositiveAction;
    [Token(Token = "0x400C4ED")]
    [FieldOffset(Offset = "0x48")]
    public Action OnOtherAction;

    [Token(Token = "0x6011E85")]
    [Address(RVA = "0x3FAC328", Offset = "0x3FAC328", VA = "0x3FAC328")]
    public PocketBookAreaEventPopupHander(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x6011E86")]
    [Address(RVA = "0x3FAC3A0", Offset = "0x3FAC3A0", VA = "0x3FAC3A0")]
    public void Initialize(int areaEventQuestId)
    {
    }

    [Token(Token = "0x6011E87")]
    [Address(RVA = "0x3FAC470", Offset = "0x3FAC470", VA = "0x3FAC470", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x6011E88")]
    [Address(RVA = "0x3FAC558", Offset = "0x3FAC558", VA = "0x3FAC558")]
    private void OnPopupInitialized()
    {
    }

    [Token(Token = "0x6011E89")]
    [Address(RVA = "0x3FAC574", Offset = "0x3FAC574", VA = "0x3FAC574", Slot = "5")]
    protected override void OnEnd()
    {
    }

    [Token(Token = "0x6011E8A")]
    [Address(RVA = "0x3FAC590", Offset = "0x3FAC590", VA = "0x3FAC590", Slot = "7")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositive()
    {
    }

    [Token(Token = "0x6011E8B")]
    [Address(RVA = "0x3FAC634", Offset = "0x3FAC634", VA = "0x3FAC634", Slot = "13")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositiveSE()
    {
    }

    [Token(Token = "0x6011E8C")]
    [Address(RVA = "0x3FAC638", Offset = "0x3FAC638", VA = "0x3FAC638")]
    private void Close()
    {
    }

    [Token(Token = "0x6011E8D")]
    [Address(RVA = "0x3FAC668", Offset = "0x3FAC668", VA = "0x3FAC668", Slot = "8")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNegative()
    {
    }

    [Token(Token = "0x6011E8E")]
    [Address(RVA = "0x3FAC698", Offset = "0x3FAC698", VA = "0x3FAC698", Slot = "9")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNeutral()
    {
    }

    [Token(Token = "0x6011E8F")]
    [Address(RVA = "0x3FAC6C8", Offset = "0x3FAC6C8", VA = "0x3FAC6C8", Slot = "11")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPocketBook()
    {
    }

    [Token(Token = "0x6011E90")]
    [Address(RVA = "0x3FAC6F8", Offset = "0x3FAC6F8", VA = "0x3FAC6F8", Slot = "12")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnMap()
    {
    }

    [Token(Token = "0x6011E91")]
    [Address(RVA = "0x3FAC728", Offset = "0x3FAC728", VA = "0x3FAC728", Slot = "10")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnClose()
    {
    }
  }
}
