// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipSetEditView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using TeamOrganization;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003297")]
  public class EquipSetEditView : MonoBehaviour
  {
    [Token(Token = "0x400D897")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EquipSetView equipSetSelectView;
    [Token(Token = "0x400D898")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private EquipSetEditSubMenuView equipSetEditSubMenuView;
    [Token(Token = "0x400D899")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI styleName;
    [Token(Token = "0x400D89A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton saveButton;
    [Token(Token = "0x400D89B")]
    private const string StyleEditAssetBundleName = "ui_page_partylist";
    [Token(Token = "0x400D89C")]
    private const string EquipmentEditPopupPrefabName = "Com_Popup_Bottom_Edit_Equip";
    [Token(Token = "0x400D89D")]
    private const string AccessoryEditPopupPrefabName = "Com_Popup_Bottom_Edit_Shield";
    [Token(Token = "0x400D89E")]
    private const string MindEquipmentEditPopupPrefabName = "Com_Popup_Bottom_Edit_Nensou";
    [Token(Token = "0x400D89F")]
    private const string UnitTrustEditPopupPrefabName = "Com_Popup_Bottom_Edit_Trust";
    [Token(Token = "0x400D8A0")]
    [FieldOffset(Offset = "0x38")]
    private EquipEditPopup equipWeaponEditPrefab;
    [Token(Token = "0x400D8A1")]
    [FieldOffset(Offset = "0x40")]
    private EquipEditPopup equipAccessoryEditPrefab;
    [Token(Token = "0x400D8A2")]
    [FieldOffset(Offset = "0x48")]
    private EquipEditPopup equipMindEditPrefab;
    [Token(Token = "0x400D8A3")]
    [FieldOffset(Offset = "0x50")]
    private EquipEditPopup equipTrustEditPrefab;
    [Token(Token = "0x400D8A4")]
    [FieldOffset(Offset = "0x58")]
    private EquipEditPopup equipEditPopup;
    [Token(Token = "0x400D8A5")]
    [FieldOffset(Offset = "0x60")]
    private Style style;
    [Token(Token = "0x400D8A6")]
    [FieldOffset(Offset = "0x68")]
    private OrganizationPartySlot organizationPartySlot;
    [Token(Token = "0x400D8A7")]
    [FieldOffset(Offset = "0x70")]
    private OrganizationPartySlot sevePartySlot;
    [Token(Token = "0x400D8A8")]
    [FieldOffset(Offset = "0x78")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6013BAC")]
    [Address(RVA = "0x185E110", Offset = "0x185E110", VA = "0x185E110")]
    public void InitEquipSetEditView(bool isNeedLp, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6013BAD")]
    [Address(RVA = "0x185E3E0", Offset = "0x185E3E0", VA = "0x185E3E0")]
    public void UpdateView(Style openStyle)
    {
    }

    [Token(Token = "0x6013BAE")]
    [Address(RVA = "0x185E51C", Offset = "0x185E51C", VA = "0x185E51C")]
    public void OnBackSceneUpdate()
    {
    }

    [Token(Token = "0x6013BAF")]
    [Address(RVA = "0x185FA08", Offset = "0x185FA08", VA = "0x185FA08")]
    public void OnFormationMenuButton()
    {
    }

    [Token(Token = "0x6013BB0")]
    [Address(RVA = "0x185FA38", Offset = "0x185FA38", VA = "0x185FA38")]
    public void OnSaveButton()
    {
    }

    [Token(Token = "0x6013BB1")]
    [Address(RVA = "0x185FAE8", Offset = "0x185FAE8", VA = "0x185FAE8")]
    protected IEnumerator ConnectAPIUnitEquipmentSet(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6013BB2")]
    [Address(RVA = "0x185FB84", Offset = "0x185FB84", VA = "0x185FB84")]
    private void OnFinishConnect()
    {
    }

    [Token(Token = "0x6013BB3")]
    [Address(RVA = "0x185E878", Offset = "0x185E878", VA = "0x185E878")]
    public void OnClickBack(Action backCallback)
    {
    }

    [Token(Token = "0x6013BB4")]
    [Address(RVA = "0x185E6E8", Offset = "0x185E6E8", VA = "0x185E6E8")]
    public void DestroyPopup()
    {
    }

    [Token(Token = "0x6013BB5")]
    [Address(RVA = "0x185FC00", Offset = "0x185FC00", VA = "0x185FC00")]
    private void EditReset()
    {
    }

    [Token(Token = "0x6013BB6")]
    [Address(RVA = "0x185FF50", Offset = "0x185FF50", VA = "0x185FF50")]
    private void EditAllClear()
    {
    }

    [Token(Token = "0x6013BB7")]
    [Address(RVA = "0x185FC94", Offset = "0x185FC94", VA = "0x185FC94")]
    private static void RequestCancelOKPopup(string titleKey, Action callback)
    {
    }

    [Token(Token = "0x6013BB8")]
    [Address(RVA = "0x185FFEC", Offset = "0x185FFEC", VA = "0x185FFEC")]
    public void OnClickCustomSkillSlot(OrganizationPartySlot partySlot)
    {
    }

    [Token(Token = "0x6013BB9")]
    [Address(RVA = "0x1860100", Offset = "0x1860100", VA = "0x1860100")]
    public void OnClickEquipmentSlot(
      OrganizationPartySlot partySlot,
      OrganizationEquipmentSlot equipmentSlot)
    {
    }

    [Token(Token = "0x6013BBA")]
    [Address(RVA = "0x1860630", Offset = "0x1860630", VA = "0x1860630")]
    private void SetEquipEditPrefab(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
    }

    [Token(Token = "0x6013BBB")]
    [Address(RVA = "0x1860AF4", Offset = "0x1860AF4", VA = "0x1860AF4")]
    public EquipSetEditView()
    {
    }
  }
}
