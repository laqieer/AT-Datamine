// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.StyleSortPopup
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
  [Token(Token = "0x2003461")]
  public class StyleSortPopup : CharaStyleSortPopupBase
  {
    [Token(Token = "0x400E3DB")]
    private const string AssetBundleName = "ui_page_outgame_popup";
    [Token(Token = "0x400E3DC")]
    private const string PrefabName = "Com_Popup_StyleSort";
    [Token(Token = "0x400E3DD")]
    [FieldOffset(Offset = "0x0")]
    public static readonly SortCondition[] StyleSort;

    [Token(Token = "0x60148EE")]
    [Address(RVA = "0x1AA4E50", Offset = "0x1AA4E50", VA = "0x1AA4E50")]
    public static IEnumerator Create(Action<StyleSortPopup> callback) => (IEnumerator) null;

    [Token(Token = "0x60148EF")]
    [Address(RVA = "0x1AA4EF4", Offset = "0x1AA4EF4", VA = "0x1AA4EF4")]
    public void Open(
      SortCondition condition,
      Order order,
      bool organization,
      Action<bool, SortCondition, Order, bool> callback)
    {
    }

    [Token(Token = "0x60148F0")]
    [Address(RVA = "0x1AA4FC0", Offset = "0x1AA4FC0", VA = "0x1AA4FC0")]
    public StyleSortPopup()
    {
    }

    [Token(Token = "0x60148F1")]
    [Address(RVA = "0x1AA5018", Offset = "0x1AA5018", VA = "0x1AA5018")]
    static StyleSortPopup()
    {
    }
  }
}
