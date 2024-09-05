// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003265")]
  public class UnitItem : MonoBehaviour
  {
    [Token(Token = "0x400D7A0")]
    private const int OnePartyUnitMax = 5;
    [Token(Token = "0x400D7A1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400D7A2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400D7A3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image unitThumb;
    [Token(Token = "0x400D7A4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject emptyObj;
    [Token(Token = "0x400D7A5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI[] limitObjects;
    [Token(Token = "0x400D7A6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject[] unitTags;
    [Token(Token = "0x400D7A7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject lostGroup;
    [Token(Token = "0x400D7A8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject[] lpIcons;
    [Token(Token = "0x400D7A9")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject alreadyDispatched;
    [Token(Token = "0x400D7AA")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject lpIconParent;
    [Token(Token = "0x400D7AC")]
    [FieldOffset(Offset = "0x70")]
    private OrganizationPartySlot partySlot;
    [Token(Token = "0x400D7AD")]
    [FieldOffset(Offset = "0x78")]
    private bool isViewLp;
    [Token(Token = "0x400D7AE")]
    [FieldOffset(Offset = "0x79")]
    private bool isGuildRaid;
    [Token(Token = "0x400D7AF")]
    [FieldOffset(Offset = "0x80")]
    private List<string> usedStyleIds;
    [Token(Token = "0x400D7B0")]
    [FieldOffset(Offset = "0x88")]
    private Dictionary<UnitItem.LimitType, string> limitTextMap;

    [Token(Token = "0x17004159")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6013A7B"), Address(RVA = "0x4621D38", Offset = "0x4621D38", VA = "0x4621D38")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x1700415A")]
    public bool IsNoLpMax
    {
      [Token(Token = "0x6013A7C"), Address(RVA = "0x4621D40", Offset = "0x4621D40", VA = "0x4621D40")] get
      {
        return new bool();
      }
      [Token(Token = "0x6013A7D"), Address(RVA = "0x4621D48", Offset = "0x4621D48", VA = "0x4621D48")] private set
      {
      }
    }

    [Token(Token = "0x6013A7E")]
    [Address(RVA = "0x4621D54", Offset = "0x4621D54", VA = "0x4621D54")]
    public void Delete()
    {
    }

    [Token(Token = "0x6013A7F")]
    [Address(RVA = "0x4621D74", Offset = "0x4621D74", VA = "0x4621D74")]
    public void EmptySlot(OrganizationPartySlot partySlot, bool overSlot)
    {
    }

    [Token(Token = "0x6013A80")]
    [Address(RVA = "0x4622008", Offset = "0x4622008", VA = "0x4622008")]
    private void SetActiveTagObjects(OrganizationPartySlot.SlotType slotType)
    {
    }

    [Token(Token = "0x6013A81")]
    [Address(RVA = "0x4622070", Offset = "0x4622070", VA = "0x4622070")]
    public void Initialize(
      OrganizationPartySlot partySlot,
      SpriteAtlas teamNoAtlas,
      bool isViewLp,
      bool isForceSortie,
      bool isLimitSortie,
      bool isEquipeDuplication,
      bool isOrganizationDuplication,
      bool isOverSlot,
      bool isGuildRaid,
      List<string> usedStyleIds)
    {
    }

    [Token(Token = "0x6013A82")]
    [Address(RVA = "0x4622858", Offset = "0x4622858", VA = "0x4622858")]
    public void OnClickToDetal()
    {
    }

    [Token(Token = "0x6013A83")]
    [Address(RVA = "0x4622898", Offset = "0x4622898", VA = "0x4622898")]
    private IEnumerator OpenUnitDetail() => (IEnumerator) null;

    [Token(Token = "0x6013A84")]
    [Address(RVA = "0x4622928", Offset = "0x4622928", VA = "0x4622928")]
    public UnitItem()
    {
    }

    [Token(Token = "0x2003266")]
    public enum LimitType
    {
      [Token(Token = "0x400D7B2")] ForceSortie,
      [Token(Token = "0x400D7B3")] Sortie,
      [Token(Token = "0x400D7B4")] Organization,
    }
  }
}
