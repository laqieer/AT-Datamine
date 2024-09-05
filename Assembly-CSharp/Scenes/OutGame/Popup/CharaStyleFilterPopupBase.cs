// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.CharaStyleFilterPopupBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnitList.Data;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x2003427")]
  public class CharaStyleFilterPopupBase : PopupBase
  {
    [Token(Token = "0x400E2CA")]
    private const string OpenAmimID = "Filter_In";
    [Token(Token = "0x400E2CB")]
    private const string CloseAnimID = "Filter_Out";
    [Token(Token = "0x400E2CC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject objChapter;
    [Token(Token = "0x400E2CD")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject objRarity;
    [Token(Token = "0x400E2CE")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject objMoveType;
    [Token(Token = "0x400E2CF")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject objArmorType;
    [Token(Token = "0x400E2D0")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject objRideType;
    [Token(Token = "0x400E2D1")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject objLimitBreak;
    [Token(Token = "0x400E2D2")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject objAwake;
    [Token(Token = "0x400E2D3")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject objElement;
    [Token(Token = "0x400E2D4")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject objWeaponType;
    [Token(Token = "0x400E2D5")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject objGender;
    [Token(Token = "0x400E2D6")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GameObject objAbility;
    [Token(Token = "0x400E2D7")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject objFavorite;
    [Token(Token = "0x400E2D8")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private CommonButton allBtn;
    [Token(Token = "0x400E2D9")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private CommonButton clearBtn;
    [Token(Token = "0x400E2DA")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private CommonButton decisionBtn;
    [Token(Token = "0x400E2DB")]
    [FieldOffset(Offset = "0x100")]
    private Action<bool, Dictionary<FilterCondition, List<bool>>> closeCallback;
    [Token(Token = "0x400E2DC")]
    [FieldOffset(Offset = "0x108")]
    private Dictionary<FilterCondition, List<bool>> filterDictionary;

    [Token(Token = "0x60147FA")]
    public static IEnumerator Create<T>(
      string assetBundleName,
      string prefabName,
      Action<T> callback)
      where T : CharaStyleFilterPopupBase
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60147FB")]
    [Address(RVA = "0x1899020", Offset = "0x1899020", VA = "0x1899020")]
    private void Start()
    {
    }

    [Token(Token = "0x60147FC")]
    [Address(RVA = "0x189880C", Offset = "0x189880C", VA = "0x189880C")]
    public void Open(
      CharaStyleFilterPopupBase.OpenParamBase param,
      Action<bool, Dictionary<FilterCondition, List<bool>>> callback)
    {
    }

    [Token(Token = "0x60147FD")]
    [Address(RVA = "0x1899164", Offset = "0x1899164", VA = "0x1899164")]
    private Dictionary<FilterCondition, List<bool>> CreateFilterDic(FilterCondition[] conditions)
    {
      return (Dictionary<FilterCondition, List<bool>>) null;
    }

    [Token(Token = "0x60147FE")]
    [Address(RVA = "0x1899A5C", Offset = "0x1899A5C", VA = "0x1899A5C")]
    private List<bool> CreateValue(FilterCondition condition) => (List<bool>) null;

    [Token(Token = "0x60147FF")]
    [Address(RVA = "0x1899CD8", Offset = "0x1899CD8", VA = "0x1899CD8")]
    private void UpdateFilterDic(FilterCondition condition, int index, bool isOn)
    {
    }

    [Token(Token = "0x6014800")]
    [Address(RVA = "0x1899D7C", Offset = "0x1899D7C", VA = "0x1899D7C")]
    private void UpdateFilterToggle(FilterCondition condition, int index, bool isOn)
    {
    }

    [Token(Token = "0x6014801")]
    [Address(RVA = "0x189925C", Offset = "0x189925C", VA = "0x189925C")]
    private void SetToggles(Dictionary<FilterCondition, List<bool>> filterDic)
    {
    }

    [Token(Token = "0x6014802")]
    [Address(RVA = "0x1899F5C", Offset = "0x1899F5C", VA = "0x1899F5C")]
    private void SetTogglesAll()
    {
    }

    [Token(Token = "0x6014803")]
    [Address(RVA = "0x189A158", Offset = "0x189A158", VA = "0x189A158")]
    private void SetTogglesClear()
    {
    }

    [Token(Token = "0x6014804")]
    [Address(RVA = "0x1899BF8", Offset = "0x1899BF8", VA = "0x1899BF8")]
    private Toggle[] GetConditionToggles(FilterCondition condition) => (Toggle[]) null;

    [Token(Token = "0x6014805")]
    [Address(RVA = "0x1899EBC", Offset = "0x1899EBC", VA = "0x1899EBC")]
    private GameObject GetConditionObject(FilterCondition condition) => (GameObject) null;

    [Token(Token = "0x6014806")]
    [Address(RVA = "0x18999F4", Offset = "0x18999F4", VA = "0x18999F4")]
    private IEnumerator ScrollToTop() => (IEnumerator) null;

    [Token(Token = "0x6014807")]
    [Address(RVA = "0x189A374", Offset = "0x189A374", VA = "0x189A374", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6014808")]
    [Address(RVA = "0x1898970", Offset = "0x1898970", VA = "0x1898970")]
    public CharaStyleFilterPopupBase()
    {
    }

    [Token(Token = "0x2003428")]
    public class OpenParamBase
    {
      [Token(Token = "0x400E2DD")]
      [FieldOffset(Offset = "0x10")]
      public FilterCondition[] conditions;
      [Token(Token = "0x400E2DE")]
      [FieldOffset(Offset = "0x18")]
      public Dictionary<FilterCondition, List<bool>> defaultFilterDic;

      [Token(Token = "0x601480C")]
      [Address(RVA = "0x1898804", Offset = "0x1898804", VA = "0x1898804")]
      public OpenParamBase()
      {
      }
    }
  }
}
