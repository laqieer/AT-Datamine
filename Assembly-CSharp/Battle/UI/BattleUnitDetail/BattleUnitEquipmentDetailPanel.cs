// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleUnitDetail.BattleUnitEquipmentDetailPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using StaqData.StatusIcon;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI.BattleUnitDetail
{
  [Token(Token = "0x2002440")]
  public sealed class BattleUnitEquipmentDetailPanel : MonoBehaviour
  {
    [Token(Token = "0x4009B34")]
    private const string TEXT_UNKNOWN = "―";
    [Token(Token = "0x4009B35")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x4009B36")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x4009B37")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject levelViewRoot;
    [Token(Token = "0x4009B38")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text levelText;
    [Token(Token = "0x4009B39")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject lpViewRoot;
    [Token(Token = "0x4009B3A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text lpCurrentText;
    [Token(Token = "0x4009B3B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text lpMaxText;
    [Token(Token = "0x4009B3C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject durableViewRoot;
    [Token(Token = "0x4009B3D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text durableCurrentText;
    [Token(Token = "0x4009B3E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text durableMaxText;
    [Token(Token = "0x4009B3F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image weaponTypeIcon;
    [Token(Token = "0x4009B40")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image attackTypeIcon;
    [Token(Token = "0x4009B41")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private List<BattleUnitEquipmentDetailPanel.ParameterViewSet> paramViewList;
    [Token(Token = "0x4009B42")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject inscriptionViewRoot;
    [Token(Token = "0x4009B43")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text inscriptionDetailText;
    [Token(Token = "0x4009B44")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject enhancementViewRoot;
    [Token(Token = "0x4009B45")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text enhancementDetailText;
    [Token(Token = "0x4009B46")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject equipmentSkillViewRoot;
    [Token(Token = "0x4009B47")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private SkillIcon equipmentSkillIcon;
    [Token(Token = "0x4009B48")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text equipmentSkillName;
    [Token(Token = "0x4009B49")]
    [FieldOffset(Offset = "0xB8")]
    private SpriteAtlas spriteAtlasForIcons;
    [Token(Token = "0x4009B4A")]
    [FieldOffset(Offset = "0xC0")]
    private StatusIconConfig iconConfig;
    [Token(Token = "0x4009B4B")]
    [FieldOffset(Offset = "0xC8")]
    private int usedParamViewCount;

    [Token(Token = "0x600DE29")]
    [Address(RVA = "0x1E2EB80", Offset = "0x1E2EB80", VA = "0x1E2EB80")]
    public void Initialize(StatusIconConfig config, SpriteAtlas iconAtlas)
    {
    }

    [Token(Token = "0x600DE2A")]
    [Address(RVA = "0x1E2EB88", Offset = "0x1E2EB88", VA = "0x1E2EB88")]
    private void SetCommonInformations(IItemData itemData)
    {
    }

    [Token(Token = "0x600DE2B")]
    [Address(RVA = "0x1E2ED1C", Offset = "0x1E2ED1C", VA = "0x1E2ED1C")]
    public void Set(IItemData itemData)
    {
    }

    [Token(Token = "0x600DE2C")]
    [Address(RVA = "0x1E2EFE8", Offset = "0x1E2EFE8", VA = "0x1E2EFE8")]
    private void SetAsWeaponView(WeaponParameterData weapon)
    {
    }

    [Token(Token = "0x600DE2D")]
    [Address(RVA = "0x1E2F2E4", Offset = "0x1E2F2E4", VA = "0x1E2F2E4")]
    private void SetAsAcccessoryView(AccessoryData accessory)
    {
    }

    [Token(Token = "0x600DE2E")]
    [Address(RVA = "0x1E2F56C", Offset = "0x1E2F56C", VA = "0x1E2F56C")]
    private void SetAsMindView(MindEquipmentData mind)
    {
    }

    [Token(Token = "0x600DE2F")]
    [Address(RVA = "0x1E2F708", Offset = "0x1E2F708", VA = "0x1E2F708")]
    private void SetAsTrustView(TrustData trust)
    {
    }

    [Token(Token = "0x600DE30")]
    [Address(RVA = "0x1E2F970", Offset = "0x1E2F970", VA = "0x1E2F970")]
    private void SetEquipmentSkill(SkillData skill)
    {
    }

    [Token(Token = "0x600DE31")]
    [Address(RVA = "0x1E2EE9C", Offset = "0x1E2EE9C", VA = "0x1E2EE9C")]
    private void ResetParamViews()
    {
    }

    [Token(Token = "0x600DE32")]
    [Address(RVA = "0x1E2FA28", Offset = "0x1E2FA28", VA = "0x1E2FA28")]
    private void SetParamView(BasicParameterType paramType, int value)
    {
    }

    [Token(Token = "0x600DE33")]
    [Address(RVA = "0x1E2F914", Offset = "0x1E2F914", VA = "0x1E2F914")]
    private void SetParamView(BattleParameterType paramType, int value)
    {
    }

    [Token(Token = "0x600DE34")]
    [Address(RVA = "0x1E2F94C", Offset = "0x1E2F94C", VA = "0x1E2F94C")]
    private void SetParamViewAsWeight(int value)
    {
    }

    [Token(Token = "0x600DE35")]
    [Address(RVA = "0x1E2FA8C", Offset = "0x1E2FA8C", VA = "0x1E2FA8C")]
    private BattleUnitEquipmentDetailPanel.ParameterViewSet GetNextParamView()
    {
      return (BattleUnitEquipmentDetailPanel.ParameterViewSet) null;
    }

    [Token(Token = "0x600DE36")]
    [Address(RVA = "0x1E2FCCC", Offset = "0x1E2FCCC", VA = "0x1E2FCCC")]
    public BattleUnitEquipmentDetailPanel()
    {
    }

    [Token(Token = "0x2002441")]
    [Serializable]
    internal sealed class ParameterViewSet
    {
      [Token(Token = "0x4009B4C")]
      [FieldOffset(Offset = "0x10")]
      private Func<string> WEIGHT_LABEL;
      [Token(Token = "0x4009B4D")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private GameObject root;
      [Token(Token = "0x4009B4E")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private Text label;
      [Token(Token = "0x4009B4F")]
      [FieldOffset(Offset = "0x28")]
      [SerializeField]
      private Text value;

      [Token(Token = "0x600DE37")]
      [Address(RVA = "0x1E2FB1C", Offset = "0x1E2FB1C", VA = "0x1E2FB1C")]
      public void Set(BasicParameterType paramType, int value)
      {
      }

      [Token(Token = "0x600DE38")]
      [Address(RVA = "0x1E2FBBC", Offset = "0x1E2FBBC", VA = "0x1E2FBBC")]
      public void Set(BattleParameterType paramType, int value)
      {
      }

      [Token(Token = "0x600DE39")]
      [Address(RVA = "0x1E2FC5C", Offset = "0x1E2FC5C", VA = "0x1E2FC5C")]
      public void SetWeight(int value)
      {
      }

      [Token(Token = "0x600DE3A")]
      [Address(RVA = "0x1E2FD48", Offset = "0x1E2FD48", VA = "0x1E2FD48")]
      private void Set(string label, int value)
      {
      }

      [Token(Token = "0x600DE3B")]
      [Address(RVA = "0x1E2FCA0", Offset = "0x1E2FCA0", VA = "0x1E2FCA0")]
      public void Show()
      {
      }

      [Token(Token = "0x600DE3C")]
      [Address(RVA = "0x1E2FA60", Offset = "0x1E2FA60", VA = "0x1E2FA60")]
      public void Hide()
      {
      }

      [Token(Token = "0x600DE3D")]
      [Address(RVA = "0x1E2FD90", Offset = "0x1E2FD90", VA = "0x1E2FD90")]
      public ParameterViewSet()
      {
      }
    }
  }
}
