// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.CharaSortPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnitList.Data;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x2003426")]
  public class CharaSortPopup : CharaStyleSortPopupBase
  {
    [Token(Token = "0x400E2C7")]
    private const string AssetBundleName = "ui_page_outgame_popup";
    [Token(Token = "0x400E2C8")]
    private const string PrefabName = "Com_Popup_CharaSort";
    [Token(Token = "0x400E2C9")]
    [FieldOffset(Offset = "0x0")]
    public static readonly SortCondition[] CharacterSort;

    [Token(Token = "0x60147F6")]
    [Address(RVA = "0x1898A74", Offset = "0x1898A74", VA = "0x1898A74")]
    public static IEnumerator Create(Action<CharaSortPopup> callback) => (IEnumerator) null;

    [Token(Token = "0x60147F7")]
    [Address(RVA = "0x1898B18", Offset = "0x1898B18", VA = "0x1898B18")]
    public void Open(
      SortCondition condition,
      Order order,
      bool organization,
      Action<bool, SortCondition, Order, bool> callback)
    {
    }

    [Token(Token = "0x60147F8")]
    [Address(RVA = "0x1898EBC", Offset = "0x1898EBC", VA = "0x1898EBC")]
    public CharaSortPopup()
    {
    }

    [Token(Token = "0x60147F9")]
    [Address(RVA = "0x1898F8C", Offset = "0x1898F8C", VA = "0x1898F8C")]
    static CharaSortPopup()
    {
    }
  }
}
