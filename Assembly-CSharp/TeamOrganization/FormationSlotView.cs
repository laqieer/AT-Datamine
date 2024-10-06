// Decompiled with JetBrains decompiler
// Type: TeamOrganization.FormationSlotView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.Icon;
using Scenes.OutGame.Info.Common.UI;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000821")]
  public class FormationSlotView : MonoBehaviour
  {
    [Token(Token = "0x400268D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton styleButton;
    [Token(Token = "0x400268E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image styleFullImage;
    [Token(Token = "0x400268F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton styleDetailButton;
    [Token(Token = "0x4002690")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x4002691")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TypeIcon elementTypeIcon;
    [Token(Token = "0x4002692")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TypeIcon moveTypeIcon;
    [Token(Token = "0x4002693")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI styleLvText;
    [Token(Token = "0x4002694")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject[] starObjs;
    [Token(Token = "0x4002695")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject styleEmptyObject;
    [Token(Token = "0x4002696")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject[] emptyOffObjects;
    [Token(Token = "0x4002697")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private FormationSlotEquipmentView partySlotEquipmentView;
    [Token(Token = "0x4002698")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private FormationSlotCustomSkillView partySlotCustomSkillView;
    [Token(Token = "0x4002699")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject LostObject;
    [Token(Token = "0x400269A")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject commuRankObj;
    [Token(Token = "0x400269B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text commuRankText;
    [Token(Token = "0x400269C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject alreadyDispatched;
    [Token(Token = "0x400269D")]
    [FieldOffset(Offset = "0x98")]
    private Action<OrganizationPartySlot, FormationSlotView> onClickUnitSlot;
    [Token(Token = "0x400269E")]
    [FieldOffset(Offset = "0xA0")]
    private Action<OrganizationPartySlot> onClickUnitSlotEnchanceButton;
    [Token(Token = "0x400269F")]
    [FieldOffset(Offset = "0xA8")]
    private OrganizationPartySlot partySlot;
    [Token(Token = "0x40026A0")]
    [FieldOffset(Offset = "0xB0")]
    private TeamView teamView;
    [Token(Token = "0x40026A1")]
    [FieldOffset(Offset = "0xB8")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x40026A2")]
    [FieldOffset(Offset = "0xC0")]
    private bool isNeedLp;
    [Token(Token = "0x40026A3")]
    [FieldOffset(Offset = "0xC1")]
    private bool isGuildRaid;
    [Token(Token = "0x40026A4")]
    [FieldOffset(Offset = "0xC8")]
    private List<string> usedStyleIds;

    [Token(Token = "0x170006E5")]
    public bool IsEmpty
    {
      [Token(Token = "0x6002EA6"), Address(RVA = "0x3E67684", Offset = "0x3E67684", VA = "0x3E67684")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170006E6")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x6002EA7"), Address(RVA = "0x3E676A8", Offset = "0x3E676A8", VA = "0x3E676A8")] get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x6002EA8"), Address(RVA = "0x3E676B0", Offset = "0x3E676B0", VA = "0x3E676B0")] set
      {
      }
    }

    [Token(Token = "0x6002EA9")]
    [Address(RVA = "0x3E676B8", Offset = "0x3E676B8", VA = "0x3E676B8")]
    public void Initialize(
      TeamView teamView,
      bool isNeedLp,
      bool isGuildRaid,
      List<string> usedStyleIds,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002EAA")]
    [Address(RVA = "0x3E67834", Offset = "0x3E67834", VA = "0x3E67834")]
    public void UpdateView(
      OrganizationPartySlot organizationPartySlot,
      bool isCallSpawnerStartRequest)
    {
    }

    [Token(Token = "0x6002EAB")]
    [Address(RVA = "0x3E68068", Offset = "0x3E68068", VA = "0x3E68068")]
    public void SetStyleSlotAction(
      Action<OrganizationPartySlot, FormationSlotView> onClickUnitSlot)
    {
    }

    [Token(Token = "0x6002EAC")]
    [Address(RVA = "0x3E68070", Offset = "0x3E68070", VA = "0x3E68070")]
    public void SetCustomSkillSlotAction(
      Action<OrganizationPartySlot> onClickCustomSkillSlotButton)
    {
    }

    [Token(Token = "0x6002EAD")]
    [Address(RVA = "0x3E6808C", Offset = "0x3E6808C", VA = "0x3E6808C")]
    public void SetEquipemntSlotAction(
      Action<OrganizationPartySlot, OrganizationEquipmentSlot, FormationSlotEquipmentView> onClickEquipmentSlot = null)
    {
    }

    [Token(Token = "0x6002EAE")]
    [Address(RVA = "0x3E680A8", Offset = "0x3E680A8", VA = "0x3E680A8")]
    public void SetStyleSlotEnchanceAction(
      Action<OrganizationPartySlot> onClickUnitSlotEnchance)
    {
    }

    [Token(Token = "0x6002EAF")]
    [Address(RVA = "0x3E680B0", Offset = "0x3E680B0", VA = "0x3E680B0")]
    private void OnStyleThumbButton(int index)
    {
    }

    [Token(Token = "0x6002EB0")]
    [Address(RVA = "0x3E680E8", Offset = "0x3E680E8", VA = "0x3E680E8")]
    public void OnUnitDetailButton(int index)
    {
    }

    [Token(Token = "0x6002EB1")]
    [Address(RVA = "0x3E68270", Offset = "0x3E68270", VA = "0x3E68270")]
    public void OnStyleEnhanceButton()
    {
    }

    [Token(Token = "0x6002EB2")]
    [Address(RVA = "0x3E6789C", Offset = "0x3E6789C", VA = "0x3E6789C")]
    private void UpdateUnitView()
    {
    }

    [Token(Token = "0x6002EB3")]
    [Address(RVA = "0x3E682A4", Offset = "0x3E682A4", VA = "0x3E682A4")]
    private void UnitEmpty()
    {
    }

    [Token(Token = "0x6002EB4")]
    [Address(RVA = "0x3E683E8", Offset = "0x3E683E8", VA = "0x3E683E8")]
    private void ResetRaritySter()
    {
    }

    [Token(Token = "0x6002EB5")]
    [Address(RVA = "0x3E68380", Offset = "0x3E68380", VA = "0x3E68380")]
    private void UpdateRarityStar(int rarityStar)
    {
    }

    [Token(Token = "0x6002EB6")]
    [Address(RVA = "0x3E682FC", Offset = "0x3E682FC", VA = "0x3E682FC")]
    private void UpdateEmptyOffObjects(bool isActive)
    {
    }

    [Token(Token = "0x6002EB7")]
    [Address(RVA = "0x3E6844C", Offset = "0x3E6844C", VA = "0x3E6844C")]
    private bool IsUnlock(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return new bool();
    }

    [Token(Token = "0x6002EB8")]
    [Address(RVA = "0x3E68478", Offset = "0x3E68478", VA = "0x3E68478")]
    public FormationSlotView()
    {
    }
  }
}
