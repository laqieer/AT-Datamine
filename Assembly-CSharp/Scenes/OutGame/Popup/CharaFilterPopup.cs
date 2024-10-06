// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.CharaFilterPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnitList.Data;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x2003425")]
  public class CharaFilterPopup : CharaStyleFilterPopupBase
  {
    [Token(Token = "0x400E2C4")]
    private const string AssetBundleName = "ui_page_outgame_popup";
    [Token(Token = "0x400E2C5")]
    private const string PrefabName = "Com_Popup_CharaFilter";
    [Token(Token = "0x400E2C6")]
    [FieldOffset(Offset = "0x0")]
    public static FilterCondition[] CharacterFilter;

    [Token(Token = "0x60147F2")]
    [Address(RVA = "0x18986D8", Offset = "0x18986D8", VA = "0x18986D8")]
    public static IEnumerator Create(Action<CharaFilterPopup> callback) => (IEnumerator) null;

    [Token(Token = "0x60147F3")]
    [Address(RVA = "0x1898758", Offset = "0x1898758", VA = "0x1898758")]
    public void Open(
      Dictionary<FilterCondition, List<bool>> filterDic,
      Action<bool, Dictionary<FilterCondition, List<bool>>> callback)
    {
    }

    [Token(Token = "0x60147F4")]
    [Address(RVA = "0x189896C", Offset = "0x189896C", VA = "0x189896C")]
    public CharaFilterPopup()
    {
    }

    [Token(Token = "0x60147F5")]
    [Address(RVA = "0x18989EC", Offset = "0x18989EC", VA = "0x18989EC")]
    static CharaFilterPopup()
    {
    }
  }
}
