// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.UI.EquipmentPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.EquipmentDetail;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Skill;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Equipment.UI
{
  [Token(Token = "0x20035B3")]
  public class EquipmentPopup : PopupBase
  {
    [Token(Token = "0x400E9A3")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private EquipmentTitleUI titleUI;
    [Token(Token = "0x400E9A4")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private EquipmentTitleUI.WithCustomSkillInfo additionalCustomSkill;
    [Token(Token = "0x400E9A5")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private EquipmentFlavorUI flavorUI;
    [Token(Token = "0x400E9A6")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private EquipmentThumbnailUI equipmentThumbnail;
    [Token(Token = "0x400E9A7")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private EquipmentThumbnailUI customThumbnail;
    [Token(Token = "0x400E9A8")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private EquipmentThumbnailUI mindEquipment;
    [Token(Token = "0x400E9A9")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private MnemnographDetailCenter mindEquipmentDetailCenter;
    [Token(Token = "0x400E9AA")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Transform statusTab;
    [Token(Token = "0x400E9AB")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private CommonButton reinforcementButton;
    [Token(Token = "0x400E9AC")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Image reinforcementButtonIcon;
    [Token(Token = "0x400E9AD")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private EquipmentWeaponUI equipmentWeaponUI;
    [Token(Token = "0x400E9AE")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private EquipmentAccessoryUI equipmentAccessoryUI;
    [Token(Token = "0x400E9AF")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private EquipmentTrustUI equipmentTrustUI;
    [Token(Token = "0x400E9B0")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private EquipmentMnemonographUI equipmentMnemonographUI;
    [Token(Token = "0x400E9B1")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private EquipmentAdditionStatusUI equipmentAdditionStatusUI;
    [Token(Token = "0x400E9B2")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private CommonButton enhanceButton;
    [Token(Token = "0x400E9B3")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400E9B4")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private GameObject gachaObj;
    [Token(Token = "0x400E9B5")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400E9B6")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private CommonButton prevButton;
    [Token(Token = "0x400E9B7")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private GameObject memoryTab;
    [Token(Token = "0x400E9B9")]
    [FieldOffset(Offset = "0x138")]
    private int[] mindEquipments;
    [Token(Token = "0x400E9BA")]
    [FieldOffset(Offset = "0x140")]
    private EquipmentMindEquipmentModel model;
    [Token(Token = "0x400E9BB")]
    [FieldOffset(Offset = "0x148")]
    private int selectedIndex;
    [Token(Token = "0x400E9BC")]
    [FieldOffset(Offset = "0x150")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400E9BD")]
    [FieldOffset(Offset = "0x158")]
    private IAssetProvider assetProvider;

    [Token(Token = "0x1700465A")]
    public Transform StatusTab
    {
      [Token(Token = "0x6015229"), Address(RVA = "0x4AAD57C", Offset = "0x4AAD57C", VA = "0x4AAD57C")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x14000214")]
    public event Action OnClose
    {
      [Token(Token = "0x601522A"), Address(RVA = "0x4AAD584", Offset = "0x4AAD584", VA = "0x4AAD584")] add
      {
      }
      [Token(Token = "0x601522B"), Address(RVA = "0x4AAD624", Offset = "0x4AAD624", VA = "0x4AAD624")] remove
      {
      }
    }

    [Token(Token = "0x1700465B")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x601522C"), Address(RVA = "0x4AAD6C4", Offset = "0x4AAD6C4", VA = "0x4AAD6C4")] get
      {
        return (IAssetProvider) null;
      }
    }

    [Token(Token = "0x601522D")]
    [Address(RVA = "0x4AAD6CC", Offset = "0x4AAD6CC", VA = "0x4AAD6CC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x601522E")]
    [Address(RVA = "0x4AAD800", Offset = "0x4AAD800", VA = "0x4AAD800")]
    private void Update()
    {
    }

    [Token(Token = "0x601522F")]
    [Address(RVA = "0x4AAD81C", Offset = "0x4AAD81C", VA = "0x4AAD81C")]
    public EquipmentPopupViewModel GetEquipmentPopupViewModel() => (EquipmentPopupViewModel) null;

    [Token(Token = "0x6015230")]
    [Address(RVA = "0x4AAD8D4", Offset = "0x4AAD8D4", VA = "0x4AAD8D4")]
    public CustomSkillPopupViewModel GetCustomSkillPopupViewModel()
    {
      return (CustomSkillPopupViewModel) null;
    }

    [Token(Token = "0x6015231")]
    [Address(RVA = "0x4AAD990", Offset = "0x4AAD990", VA = "0x4AAD990")]
    public EquipmentPopupViewModel GetMindEquipmentPopupViewModel()
    {
      return (EquipmentPopupViewModel) null;
    }

    [Token(Token = "0x6015232")]
    [Address(RVA = "0x4AADA48", Offset = "0x4AADA48", VA = "0x4AADA48", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6015233")]
    [Address(RVA = "0x4AADA80", Offset = "0x4AADA80", VA = "0x4AADA80")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6015234")]
    [Address(RVA = "0x4AADA84", Offset = "0x4AADA84", VA = "0x4AADA84")]
    public EquipmentWeaponUI GetEquipmentWeaponUI() => (EquipmentWeaponUI) null;

    [Token(Token = "0x6015235")]
    [Address(RVA = "0x4AADA8C", Offset = "0x4AADA8C", VA = "0x4AADA8C")]
    public EquipmentAccessoryUI GetEquipmentAccessoryUI() => (EquipmentAccessoryUI) null;

    [Token(Token = "0x6015236")]
    [Address(RVA = "0x4AADA94", Offset = "0x4AADA94", VA = "0x4AADA94")]
    public EquipmentTrustUI GetEquipmentTrustUI() => (EquipmentTrustUI) null;

    [Token(Token = "0x6015237")]
    [Address(RVA = "0x4AADA9C", Offset = "0x4AADA9C", VA = "0x4AADA9C")]
    public EquipmentMnemonographUI GetEquipmentMnemonographUI() => (EquipmentMnemonographUI) null;

    [Token(Token = "0x6015238")]
    [Address(RVA = "0x4AADAA4", Offset = "0x4AADAA4", VA = "0x4AADAA4")]
    public EquipmentAdditionStatusUI GetEquipmentAdditionStatusUI()
    {
      return (EquipmentAdditionStatusUI) null;
    }

    [Token(Token = "0x6015239")]
    [Address(RVA = "0x4AADAAC", Offset = "0x4AADAAC", VA = "0x4AADAAC")]
    public CommonButton GetReinforcementButton() => (CommonButton) null;

    [Token(Token = "0x601523A")]
    [Address(RVA = "0x4AADAB4", Offset = "0x4AADAB4", VA = "0x4AADAB4")]
    public void SetReinforcementAction(Action action)
    {
    }

    [Token(Token = "0x601523B")]
    [Address(RVA = "0x4AADBA4", Offset = "0x4AADBA4", VA = "0x4AADBA4")]
    public void SetWeaponReinforcementButtonSprite()
    {
    }

    [Token(Token = "0x601523C")]
    [Address(RVA = "0x4AADCF8", Offset = "0x4AADCF8", VA = "0x4AADCF8")]
    public void SetMnemonographReinforcementButtonSprite()
    {
    }

    [Token(Token = "0x601523D")]
    [Address(RVA = "0x4AADD40", Offset = "0x4AADD40", VA = "0x4AADD40")]
    public void SetTrustReinforcementButtonSprite()
    {
    }

    [Token(Token = "0x601523E")]
    [Address(RVA = "0x4AADD88", Offset = "0x4AADD88", VA = "0x4AADD88")]
    public void SetShieldReinforcementButtonSprite()
    {
    }

    [Token(Token = "0x601523F")]
    [Address(RVA = "0x4AADBEC", Offset = "0x4AADBEC", VA = "0x4AADBEC")]
    private void SetReinforcementButtonSprite(string assetName)
    {
    }

    [Token(Token = "0x6015240")]
    [Address(RVA = "0x4AADDD8", Offset = "0x4AADDD8", VA = "0x4AADDD8")]
    public void SetMindEquipmentDetail(int masterId, Transform parent = null)
    {
    }

    [Token(Token = "0x6015241")]
    [Address(RVA = "0x4AADE34", Offset = "0x4AADE34", VA = "0x4AADE34")]
    public void StartRequestAssetCachedSpawner()
    {
    }

    [Token(Token = "0x6015242")]
    [Address(RVA = "0x4AADE50", Offset = "0x4AADE50", VA = "0x4AADE50")]
    public void SetOnGachaChange(int[] mindEquipments, EquipmentMindEquipmentModel model)
    {
    }

    [Token(Token = "0x6015243")]
    [Address(RVA = "0x4AADFD4", Offset = "0x4AADFD4", VA = "0x4AADFD4")]
    public void OnClickEnhance()
    {
    }

    [Token(Token = "0x6015244")]
    [Address(RVA = "0x4AADFD8", Offset = "0x4AADFD8", VA = "0x4AADFD8")]
    private void OnClickNext()
    {
    }

    [Token(Token = "0x6015245")]
    [Address(RVA = "0x4AAE050", Offset = "0x4AAE050", VA = "0x4AAE050")]
    private void OnClickPrev()
    {
    }

    [Token(Token = "0x6015246")]
    [Address(RVA = "0x4AADFE0", Offset = "0x4AADFE0", VA = "0x4AADFE0")]
    private void OnChange(bool isNext)
    {
    }

    [Token(Token = "0x6015247")]
    [Address(RVA = "0x4AAE058", Offset = "0x4AAE058", VA = "0x4AAE058")]
    public void DisableReinforcementButton()
    {
    }

    [Token(Token = "0x6015248")]
    [Address(RVA = "0x4AAE084", Offset = "0x4AAE084", VA = "0x4AAE084")]
    public EquipmentPopup()
    {
    }
  }
}
