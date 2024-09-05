// Decompiled with JetBrains decompiler
// Type: TeamOrganization.PartySlotSortingCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007F9")]
  public class PartySlotSortingCell : MonoBehaviour
  {
    [Token(Token = "0x4002563")]
    public const string ComStyleThumbAssetBundleName = "ui_common_thumb";
    [Token(Token = "0x4002564")]
    public const string ComStyleThumbPrefabName = "Com_StyleThumb";
    [Token(Token = "0x4002565")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected GameObject[] UnitTags;
    [Token(Token = "0x4002566")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image UnitNumber1;
    [Token(Token = "0x4002567")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image UnitNumber2;
    [Token(Token = "0x4002568")]
    protected const string UnitNumberAssetBundleName = "ui_page_partylist_texture";
    [Token(Token = "0x4002569")]
    protected const string UnitNumberAssetName = "Img_Num_UnitNumber_Atlas";
    [Token(Token = "0x400256A")]
    [FieldOffset(Offset = "0x30")]
    private readonly List<string> UnitNumberImageNameList;
    [Token(Token = "0x400256B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button styleThumbButton;
    [Token(Token = "0x400256C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Transform styleThumbParent;
    [Token(Token = "0x400256D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject[] styleSlotObjs;
    [Token(Token = "0x400256E")]
    [FieldOffset(Offset = "0x50")]
    private StyleThumb styleThumbPrefab;
    [Token(Token = "0x400256F")]
    [FieldOffset(Offset = "0x58")]
    protected StyleThumb styleThumb;
    [Token(Token = "0x4002570")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI UnitCharaNameText;
    [Token(Token = "0x4002571")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI UnitStyleNameText;
    [Token(Token = "0x4002572")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x4002573")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    protected GameObject slotSelectObj;
    [Token(Token = "0x4002574")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject alreadyDispatched;
    [Token(Token = "0x4002575")]
    [FieldOffset(Offset = "0x88")]
    private Action<int> onClickUnitSlot;
    [Token(Token = "0x4002576")]
    [FieldOffset(Offset = "0x90")]
    protected OrganizationPartySlot partySlot;
    [Token(Token = "0x4002577")]
    [FieldOffset(Offset = "0x98")]
    private bool isNeedLp;
    [Token(Token = "0x4002578")]
    [FieldOffset(Offset = "0x99")]
    private bool isGuildRaid;
    [Token(Token = "0x4002579")]
    [FieldOffset(Offset = "0xA0")]
    private List<string> usedStyleIds;

    [Token(Token = "0x6002D84")]
    [Address(RVA = "0x3A886DC", Offset = "0x3A886DC", VA = "0x3A886DC")]
    public void Initialize(bool isNeedLp, bool isGuildRaid, List<string> usedStyleIds)
    {
    }

    [Token(Token = "0x6002D85")]
    [Address(RVA = "0x3A88818", Offset = "0x3A88818", VA = "0x3A88818")]
    private StyleThumb CreateStyleThumb() => (StyleThumb) null;

    [Token(Token = "0x6002D86")]
    [Address(RVA = "0x3A88980", Offset = "0x3A88980", VA = "0x3A88980")]
    public void UpdateView(
      OrganizationPartySlot organizationPartySlot,
      AssetCachedSpawner assetCachedSpawner,
      bool isSelect = false)
    {
    }

    [Token(Token = "0x6002D87")]
    [Address(RVA = "0x3A88B98", Offset = "0x3A88B98", VA = "0x3A88B98")]
    private void UpdateUnitView(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002D88")]
    [Address(RVA = "0x3A8900C", Offset = "0x3A8900C", VA = "0x3A8900C")]
    private void UnitEmpty()
    {
    }

    [Token(Token = "0x6002D89")]
    [Address(RVA = "0x3A889C8", Offset = "0x3A889C8", VA = "0x3A889C8")]
    private void UpdateUnitNumber()
    {
    }

    [Token(Token = "0x6002D8A")]
    [Address(RVA = "0x3A891B8", Offset = "0x3A891B8", VA = "0x3A891B8")]
    private bool IsUnlock(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return new bool();
    }

    [Token(Token = "0x6002D8B")]
    [Address(RVA = "0x3A891E4", Offset = "0x3A891E4", VA = "0x3A891E4")]
    public void SetStyleSlotAction(Action<int> onClickUnitSlot)
    {
    }

    [Token(Token = "0x6002D8C")]
    [Address(RVA = "0x3A891EC", Offset = "0x3A891EC", VA = "0x3A891EC")]
    private void OnStyleThumbButton(int index)
    {
    }

    [Token(Token = "0x6002D8D")]
    [Address(RVA = "0x3A89230", Offset = "0x3A89230", VA = "0x3A89230")]
    public PartySlotSortingCell()
    {
    }
  }
}
