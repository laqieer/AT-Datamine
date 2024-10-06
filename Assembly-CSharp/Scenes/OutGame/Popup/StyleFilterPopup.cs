// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.StyleFilterPopup
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
  [Token(Token = "0x2003460")]
  public class StyleFilterPopup : CharaStyleFilterPopupBase
  {
    [Token(Token = "0x400E3D8")]
    private const string AssetBundleName = "ui_page_outgame_popup";
    [Token(Token = "0x400E3D9")]
    private const string PrefabName = "Com_Popup_StyleFilter";
    [Token(Token = "0x400E3DA")]
    [FieldOffset(Offset = "0x0")]
    public static readonly FilterCondition[] StyleFilter;

    [Token(Token = "0x60148EA")]
    [Address(RVA = "0x1AA4C84", Offset = "0x1AA4C84", VA = "0x1AA4C84")]
    public static IEnumerator Create(Action<StyleFilterPopup> callback) => (IEnumerator) null;

    [Token(Token = "0x60148EB")]
    [Address(RVA = "0x1AA4D04", Offset = "0x1AA4D04", VA = "0x1AA4D04")]
    public void Open(
      Dictionary<FilterCondition, List<bool>> filterDic,
      Action<bool, Dictionary<FilterCondition, List<bool>>> callback)
    {
    }

    [Token(Token = "0x60148EC")]
    [Address(RVA = "0x1AA4DB4", Offset = "0x1AA4DB4", VA = "0x1AA4DB4")]
    public StyleFilterPopup()
    {
    }

    [Token(Token = "0x60148ED")]
    [Address(RVA = "0x1AA4DBC", Offset = "0x1AA4DBC", VA = "0x1AA4DBC")]
    static StyleFilterPopup()
    {
    }
  }
}
