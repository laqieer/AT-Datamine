// Decompiled with JetBrains decompiler
// Type: TeamOrganization.PartySlotView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007FD")]
  public class PartySlotView : MonoBehaviour
  {
    [Token(Token = "0x4002597")]
    public const string ComStyleThumbAssetBundleName = "ui_common_thumb";
    [Token(Token = "0x4002598")]
    public const string ComStyleThumbPrefabName = "Com_StyleThumb";
    [Token(Token = "0x4002599")]
    protected const string UnitNumberAssetBundleName = "ui_page_partylist_texture";
    [Token(Token = "0x400259A")]
    protected const string UnitNumberAssetName = "Img_Num_UnitNumber_Atlas";
    [Token(Token = "0x400259B")]
    [FieldOffset(Offset = "0x18")]
    private StyleThumb styleThumbPrefab;
    [Token(Token = "0x400259C")]
    [FieldOffset(Offset = "0x20")]
    protected StyleThumb styleThumb;
    [Token(Token = "0x400259D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PartySlotEquipmentView partySlotEquipmentView;
    [Token(Token = "0x400259E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PartySlotCustomSkillView partySlotCustomSkillView;
    [Token(Token = "0x400259F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected PartySlotUI ui;
    [Token(Token = "0x40025A0")]
    [FieldOffset(Offset = "0x40")]
    private Action<OrganizationPartySlot, PartySlotView> onClickUnitSlot;
    [Token(Token = "0x40025A1")]
    [FieldOffset(Offset = "0x48")]
    private Action<OrganizationPartySlot> onClickEquipSetButton;
    [Token(Token = "0x40025A2")]
    [FieldOffset(Offset = "0x50")]
    protected OrganizationPartySlot partySlot;
    [Token(Token = "0x40025A3")]
    [FieldOffset(Offset = "0x58")]
    protected TeamView teamView;
    [Token(Token = "0x40025A4")]
    [FieldOffset(Offset = "0x60")]
    private UnitNodeDotCell unitNodeDot;
    [Token(Token = "0x40025A5")]
    [FieldOffset(Offset = "0x68")]
    private bool isNeedLp;
    [Token(Token = "0x40025A6")]
    [FieldOffset(Offset = "0x70")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x170006D7")]
    public StyleThumb StyleThumb
    {
      [Token(Token = "0x6002DB4"), Address(RVA = "0x3A89ECC", Offset = "0x3A89ECC", VA = "0x3A89ECC")] get
      {
        return (StyleThumb) null;
      }
    }

    [Token(Token = "0x170006D8")]
    public GameObject SlotSelectObj
    {
      [Token(Token = "0x6002DB5"), Address(RVA = "0x3A89ED4", Offset = "0x3A89ED4", VA = "0x3A89ED4")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170006D9")]
    public bool IsEmpty
    {
      [Token(Token = "0x6002DB6"), Address(RVA = "0x3A89EF0", Offset = "0x3A89EF0", VA = "0x3A89EF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6002DB7")]
    [Address(RVA = "0x3A89F14", Offset = "0x3A89F14", VA = "0x3A89F14")]
    private void Start()
    {
    }

    [Token(Token = "0x6002DB8")]
    [Address(RVA = "0x3A89F94", Offset = "0x3A89F94", VA = "0x3A89F94", Slot = "4")]
    public virtual void Initialize(
      UnitNodeDotCell unitNodeDotCell,
      TeamView teamView,
      bool isNeedLp)
    {
    }

    [Token(Token = "0x6002DB9")]
    [Address(RVA = "0x3A8A17C", Offset = "0x3A8A17C", VA = "0x3A8A17C")]
    protected StyleThumb CreateStyleThumb() => (StyleThumb) null;

    [Token(Token = "0x6002DBA")]
    [Address(RVA = "0x3A8A2EC", Offset = "0x3A8A2EC", VA = "0x3A8A2EC", Slot = "5")]
    public virtual void UpdateView(OrganizationPartySlot organizationPartySlot, bool checkAttention)
    {
    }

    [Token(Token = "0x6002DBB")]
    [Address(RVA = "0x3A8AA74", Offset = "0x3A8AA74", VA = "0x3A8AA74")]
    public void CheckSlotAttention()
    {
    }

    [Token(Token = "0x6002DBC")]
    [Address(RVA = "0x3A8AAFC", Offset = "0x3A8AAFC", VA = "0x3A8AAFC")]
    public void UpdateAttentionIcon(PartySlotAttentionData attentionData)
    {
    }

    [Token(Token = "0x6002DBD")]
    [Address(RVA = "0x3A8ABF0", Offset = "0x3A8ABF0", VA = "0x3A8ABF0")]
    public int GetSlotIndex() => new int();

    [Token(Token = "0x6002DBE")]
    [Address(RVA = "0x3A8A35C", Offset = "0x3A8A35C", VA = "0x3A8A35C")]
    protected void UpdateUnitNumber()
    {
    }

    [Token(Token = "0x6002DBF")]
    [Address(RVA = "0x3A8AC18", Offset = "0x3A8AC18", VA = "0x3A8AC18")]
    private void OnStyleThumbButton(int index)
    {
    }

    [Token(Token = "0x6002DC0")]
    [Address(RVA = "0x3A8AC50", Offset = "0x3A8AC50", VA = "0x3A8AC50")]
    private void OnLongPressStyleThumbButton(int index)
    {
    }

    [Token(Token = "0x6002DC1")]
    [Address(RVA = "0x3A8AC68", Offset = "0x3A8AC68", VA = "0x3A8AC68")]
    public void OnUnitDetailButton(int index)
    {
    }

    [Token(Token = "0x6002DC2")]
    [Address(RVA = "0x3A8ADF0", Offset = "0x3A8ADF0", VA = "0x3A8ADF0")]
    public void SetStyleSlotAction(
      Action<OrganizationPartySlot, PartySlotView> onClickUnitSlot)
    {
    }

    [Token(Token = "0x6002DC3")]
    [Address(RVA = "0x3A8A518", Offset = "0x3A8A518", VA = "0x3A8A518")]
    protected void UpdateUnitView()
    {
    }

    [Token(Token = "0x6002DC4")]
    [Address(RVA = "0x3A8B15C", Offset = "0x3A8B15C", VA = "0x3A8B15C")]
    public void UpdateUnitName()
    {
    }

    [Token(Token = "0x6002DC5")]
    [Address(RVA = "0x3A8ADF8", Offset = "0x3A8ADF8", VA = "0x3A8ADF8")]
    private void UnitEmpty()
    {
    }

    [Token(Token = "0x6002DC6")]
    [Address(RVA = "0x3A8B2B4", Offset = "0x3A8B2B4", VA = "0x3A8B2B4")]
    private void OnUnitEquipmentSetButton(int index)
    {
    }

    [Token(Token = "0x6002DC7")]
    [Address(RVA = "0x3A8B2F0", Offset = "0x3A8B2F0", VA = "0x3A8B2F0")]
    public void SetEquipSetAction(
      Action<OrganizationPartySlot> onClickEquipSetButton)
    {
    }

    [Token(Token = "0x6002DC8")]
    [Address(RVA = "0x3A8B2F8", Offset = "0x3A8B2F8", VA = "0x3A8B2F8")]
    public void SetCustomSkillSlotAction(
      Action<OrganizationPartySlot> onClickCustomSkillSlotButton)
    {
    }

    [Token(Token = "0x6002DC9")]
    [Address(RVA = "0x3A8B314", Offset = "0x3A8B314", VA = "0x3A8B314")]
    public void SetEquipmentSlotAction(
      Action<OrganizationPartySlot, OrganizationEquipmentSlot, PartySlotEquipmentView> onClickEquipmentSlot = null)
    {
    }

    [Token(Token = "0x6002DCA")]
    [Address(RVA = "0x3A8B330", Offset = "0x3A8B330", VA = "0x3A8B330")]
    public void SetEquipmentSlotAction(
      Action<OrganizationPartySlot, OrganizationEquipmentSlot> onClickEquipmentSlot = null)
    {
    }

    [Token(Token = "0x6002DCB")]
    [Address(RVA = "0x3A8B130", Offset = "0x3A8B130", VA = "0x3A8B130")]
    private bool IsUnlock(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return new bool();
    }

    [Token(Token = "0x6002DCC")]
    [Address(RVA = "0x3A8B3F8", Offset = "0x3A8B3F8", VA = "0x3A8B3F8")]
    public PartySlotView()
    {
    }
  }
}
