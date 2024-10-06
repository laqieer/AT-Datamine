// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.Adv2LuaPopupReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using Story.Adv.Facility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EC1")]
  [MoonSharpUserData]
  public class Adv2LuaPopupReward : LuaSignal
  {
    [Token(Token = "0x4011349")]
    [FieldOffset(Offset = "0x18")]
    private Adv2ProjectFilePlayer advPlayer;
    [Token(Token = "0x401134A")]
    [FieldOffset(Offset = "0x20")]
    private Transform parent;
    [Token(Token = "0x401134B")]
    [FieldOffset(Offset = "0x28")]
    private List<DisplayItemRewardInfoData> rewardInfos;

    [Token(Token = "0x60194C0")]
    [Address(RVA = "0x2FF6E8C", Offset = "0x2FF6E8C", VA = "0x2FF6E8C")]
    public Adv2LuaPopupReward(Adv2ProjectFilePlayer advPlayer, Transform parent)
    {
    }

    [Token(Token = "0x60194C1")]
    [Address(RVA = "0x2FF6EB8", Offset = "0x2FF6EB8", VA = "0x2FF6EB8")]
    public LuaSignalMini Play(LuaFunction.Object facilityObj) => (LuaSignalMini) null;

    [Token(Token = "0x60194C2")]
    [Address(RVA = "0x2FF7028", Offset = "0x2FF7028", VA = "0x2FF7028")]
    public LuaSignalMini PlayItems(LuaRewardItem[] items) => (LuaSignalMini) null;

    [Token(Token = "0x60194C3")]
    [Address(RVA = "0x2FF6FB4", Offset = "0x2FF6FB4", VA = "0x2FF6FB4")]
    private IEnumerator PlayPopup(Adv2Manager.OnProccessSignal signal) => (IEnumerator) null;
  }
}
