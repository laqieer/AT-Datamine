// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaSubQuestPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Popup;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using StaqData;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EF8")]
  [MoonSharpUserData]
  public class LuaSubQuestPopup : LuaSignal, IQuestUIEvent
  {
    [Token(Token = "0x401141F")]
    [FieldOffset(Offset = "0x18")]
    private SubQuestData quest;
    [Token(Token = "0x4011420")]
    [FieldOffset(Offset = "0x20")]
    private QuestPopupHandler popupHandler;
    [Token(Token = "0x4011421")]
    [FieldOffset(Offset = "0x28")]
    private Adv2Manager.OnProccessSignal signalInputWait;

    [Token(Token = "0x6019728")]
    [Address(RVA = "0x373E4E0", Offset = "0x373E4E0", VA = "0x373E4E0")]
    public LuaSubQuestPopup(int subquestTaskID)
    {
    }

    [Token(Token = "0x6019729")]
    [Address(RVA = "0x373E790", Offset = "0x373E790", VA = "0x373E790")]
    public LuaSignalMini Load() => (LuaSignalMini) null;

    [Token(Token = "0x601972A")]
    [Address(RVA = "0x373E90C", Offset = "0x373E90C", VA = "0x373E90C")]
    public LuaSignalMini InputWait() => (LuaSignalMini) null;

    [Token(Token = "0x601972B")]
    [Address(RVA = "0x373E980", Offset = "0x373E980", VA = "0x373E980")]
    public void In()
    {
    }

    [Token(Token = "0x601972C")]
    [Address(RVA = "0x373E994", Offset = "0x373E994", VA = "0x373E994")]
    public void Out()
    {
    }

    [Token(Token = "0x601972D")]
    [Address(RVA = "0x373E898", Offset = "0x373E898", VA = "0x373E898")]
    private IEnumerator LoadInternal(Adv2Manager.OnProccessSignal signal) => (IEnumerator) null;

    [Token(Token = "0x601972E")]
    [Address(RVA = "0x373E9E0", Offset = "0x373E9E0", VA = "0x373E9E0", Slot = "7")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNeutral()
    {
    }

    [Token(Token = "0x601972F")]
    [Address(RVA = "0x373EAFC", Offset = "0x373EAFC", VA = "0x373EAFC", Slot = "5")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositive()
    {
    }

    [Token(Token = "0x6019730")]
    [Address(RVA = "0x373EB40", Offset = "0x373EB40", VA = "0x373EB40", Slot = "11")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPositiveSE()
    {
    }

    [Token(Token = "0x6019731")]
    [Address(RVA = "0x373EB44", Offset = "0x373EB44", VA = "0x373EB44", Slot = "8")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnClose()
    {
    }

    [Token(Token = "0x6019732")]
    [Address(RVA = "0x373EB88", Offset = "0x373EB88", VA = "0x373EB88", Slot = "10")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnMap()
    {
    }

    [Token(Token = "0x6019733")]
    [Address(RVA = "0x373EBD8", Offset = "0x373EBD8", VA = "0x373EBD8", Slot = "6")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnNegative()
    {
    }

    [Token(Token = "0x6019734")]
    [Address(RVA = "0x373EC28", Offset = "0x373EC28", VA = "0x373EC28", Slot = "9")]
    private void FreeMap\u002EUI\u002EPopup\u002EIQuestUIEvent\u002EOnPocketBook()
    {
    }

    [Token(Token = "0x6019735")]
    [Address(RVA = "0x373EA24", Offset = "0x373EA24", VA = "0x373EA24")]
    private void OpenRewardPopup()
    {
    }

    [Token(Token = "0x6019736")]
    [Address(RVA = "0x373EC78", Offset = "0x373EC78", VA = "0x373EC78")]
    private IEnumerator RewardPopup(
      Adv2Manager.OnProccessSignal signal,
      IEnumerable<StaqData.RewardData> items)
    {
      return (IEnumerator) null;
    }
  }
}
