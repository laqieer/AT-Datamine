// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.FeatureDetail.UnitFeatureDetailView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.FeatureDetail
{
  [Token(Token = "0x20004FF")]
  public class UnitFeatureDetailView : MonoBehaviour
  {
    [Token(Token = "0x4001AA2")]
    private const string In = "In_ResistDetail";
    [Token(Token = "0x4001AA3")]
    private const string Out = "Out_ResistDetail";
    [Token(Token = "0x4001AA4")]
    private const string SpecialEffectCellPrefabName = "UnitDetail_SpecialEffectCell";
    [Token(Token = "0x4001AA5")]
    [FieldOffset(Offset = "0x18")]
    private UnitCustomizeStateHandler stateHandler;
    [Token(Token = "0x4001AA6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button backButton;
    [Token(Token = "0x4001AA7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button parameterDetailButton;
    [Token(Token = "0x4001AA8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button featureDetailButton;
    [Token(Token = "0x4001AA9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button informationButton;
    [Token(Token = "0x4001AAA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text[] reinforcementElements;
    [Token(Token = "0x4001AAB")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text[] reinforcementAttackTypes;
    [Token(Token = "0x4001AAC")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text[] reinforcementAbnormalStatusTypes;
    [Token(Token = "0x4001AAD")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text[] resistElements;
    [Token(Token = "0x4001AAE")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text[] resistAttackTypes;
    [Token(Token = "0x4001AAF")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text[] resistAbnormalStatusTypes;
    [Token(Token = "0x4001AB0")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001AB1")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Transform specialEffectCellPoolArea;
    [Token(Token = "0x4001AB2")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Transform specialAttackCellRoot;
    [Token(Token = "0x4001AB3")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Transform specialDefenceCellRoot;
    [Token(Token = "0x4001AB4")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Color valueChangeColor;
    [Token(Token = "0x4001AB5")]
    [FieldOffset(Offset = "0xA0")]
    private SpecialEffectCell specialEffectCellPrefab;
    [Token(Token = "0x4001AB6")]
    [FieldOffset(Offset = "0xA8")]
    private Stack<SpecialEffectCell> cellPool;
    [Token(Token = "0x4001AB7")]
    [FieldOffset(Offset = "0xB0")]
    private List<SpecialEffectCell> specialAttackCellList;
    [Token(Token = "0x4001AB8")]
    [FieldOffset(Offset = "0xB8")]
    private List<SpecialEffectCell> specialDefenceCellList;
    [Token(Token = "0x4001AB9")]
    [FieldOffset(Offset = "0xC0")]
    private bool isFirstView;

    [Token(Token = "0x17000397")]
    public UITweenGroup TweenGroup
    {
      [Token(Token = "0x6001C8D"), Address(RVA = "0x29F2D60", Offset = "0x29F2D60", VA = "0x29F2D60")] get
      {
        return (UITweenGroup) null;
      }
    }

    [Token(Token = "0x6001C8E")]
    [Address(RVA = "0x29F2D68", Offset = "0x29F2D68", VA = "0x29F2D68")]
    public void Initialize(UnitCustomizeStateHandler stateHandler)
    {
    }

    [Token(Token = "0x6001C8F")]
    [Address(RVA = "0x29F2F6C", Offset = "0x29F2F6C", VA = "0x29F2F6C")]
    public void UpdateView(UnitDetailInfo unitDetailInfo)
    {
    }

    [Token(Token = "0x6001C90")]
    [Address(RVA = "0x29F3544", Offset = "0x29F3544", VA = "0x29F3544")]
    public void UpdateCheckEquipment(Style style, ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001C91")]
    [Address(RVA = "0x29F3854", Offset = "0x29F3854", VA = "0x29F3854")]
    public void PlayIn(UIAnimationController animationController)
    {
    }

    [Token(Token = "0x6001C92")]
    [Address(RVA = "0x29F3928", Offset = "0x29F3928", VA = "0x29F3928")]
    public void PlayOut(UIAnimationController animationController)
    {
    }

    [Token(Token = "0x6001C93")]
    [Address(RVA = "0x29F39DC", Offset = "0x29F39DC", VA = "0x29F39DC")]
    private void OnClickBackButton()
    {
    }

    [Token(Token = "0x6001C94")]
    [Address(RVA = "0x29F39F8", Offset = "0x29F39F8", VA = "0x29F39F8")]
    private void OnClickParameterDetailButton()
    {
    }

    [Token(Token = "0x6001C95")]
    [Address(RVA = "0x29F3A14", Offset = "0x29F3A14", VA = "0x29F3A14")]
    private void OnClickInformationButton()
    {
    }

    [Token(Token = "0x6001C96")]
    [Address(RVA = "0x29F38B8", Offset = "0x29F38B8", VA = "0x29F38B8")]
    public void ShowButtons()
    {
    }

    [Token(Token = "0x6001C97")]
    [Address(RVA = "0x29F3A30", Offset = "0x29F3A30", VA = "0x29F3A30")]
    public void HideButtons()
    {
    }

    [Token(Token = "0x6001C98")]
    [Address(RVA = "0x29F304C", Offset = "0x29F304C", VA = "0x29F304C")]
    private void UpdateSpecialEffect(
      List<SpecialEffectCell> cells,
      IList<UnitDetailInfo.SpecialInfo> specialList,
      Transform placement)
    {
    }

    [Token(Token = "0x6001C99")]
    private void UpdateEffectValue<TEnum>(
      TEnum reinforcementType,
      Text[] textList,
      FeatureWraper<TEnum, int> wraper,
      FeatureWraper<TEnum, int> equipmentWrapper,
      TEnum defaultValue = null)
      where TEnum : Enum
    {
    }

    [Token(Token = "0x6001C9A")]
    private int GetValue<TEnum>(TEnum reinforcementType, FeatureWraper<TEnum, int> wraper) where TEnum : Enum
    {
      return new int();
    }

    [Token(Token = "0x6001C9B")]
    [Address(RVA = "0x29F32DC", Offset = "0x29F32DC", VA = "0x29F32DC")]
    private void UpdateReinforcementView(
      Style style,
      StyleParameter.EquipmentParameter equipmentParameter)
    {
    }

    [Token(Token = "0x6001C9C")]
    [Address(RVA = "0x29F35EC", Offset = "0x29F35EC", VA = "0x29F35EC")]
    private void UpdateReinforcementViewByCheckEquipment(
      Style style,
      StyleParameter.EquipmentParameter beforeEquipmentParameter)
    {
    }

    [Token(Token = "0x6001C9D")]
    [Address(RVA = "0x29F3410", Offset = "0x29F3410", VA = "0x29F3410")]
    private void UpdateResistView(
      Style style,
      StyleParameter.EquipmentParameter equipmentParameter)
    {
    }

    [Token(Token = "0x6001C9E")]
    [Address(RVA = "0x29F3720", Offset = "0x29F3720", VA = "0x29F3720")]
    private void UpdateResistViewByCheckEquipment(
      Style style,
      StyleParameter.EquipmentParameter beforeEquipmentParameter)
    {
    }

    [Token(Token = "0x6001C9F")]
    [Address(RVA = "0x29F3AA0", Offset = "0x29F3AA0", VA = "0x29F3AA0")]
    private SpecialEffectCell GetSpecialEffectCell() => (SpecialEffectCell) null;

    [Token(Token = "0x6001CA0")]
    [Address(RVA = "0x29F3B80", Offset = "0x29F3B80", VA = "0x29F3B80")]
    private void ReclaimSpecialEffectCell(SpecialEffectCell cell)
    {
    }

    [Token(Token = "0x6001CA1")]
    [Address(RVA = "0x29F3C18", Offset = "0x29F3C18", VA = "0x29F3C18")]
    public UnitFeatureDetailView()
    {
    }
  }
}
