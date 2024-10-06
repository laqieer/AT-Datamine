// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.Popup.EnhancedResistanceIconController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.Popup
{
  [Token(Token = "0x200334B")]
  public class EnhancedResistanceIconController : MonoBehaviour
  {
    [Token(Token = "0x400DE2F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EnhancedResistanceTypeIconItem[] elementEnhanceTypeIcons;
    [Token(Token = "0x400DE30")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text elementEnhanceTitle;
    [Token(Token = "0x400DE31")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private EnhancedResistanceTypeIconItem[] elementEnhanceResistTypeIcons;
    [Token(Token = "0x400DE32")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text elementEnhanceResistTitle;
    [Token(Token = "0x400DE33")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private EnhancedResistanceTypeIconItem[] attackCategoryTypeIcons;
    [Token(Token = "0x400DE34")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text attackCategoryTitle;
    [Token(Token = "0x400DE35")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private EnhancedResistanceTypeIconItem[] attackCategoryResistTypeIcons;
    [Token(Token = "0x400DE36")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text attackCategoryResistTitle;
    [Token(Token = "0x400DE37")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private EnhancedResistanceStatusEffectIconItem[] statusEffectIcons;
    [Token(Token = "0x400DE38")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text statusEffectTitle;
    [Token(Token = "0x400DE39")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private EnhancedResistanceStatusEffectIconItem[] statusEffectResistIcons;
    [Token(Token = "0x400DE3A")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text statusEffectResistTitle;
    [Token(Token = "0x400DE3B")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6014288")]
    [Address(RVA = "0x1E0F058", Offset = "0x1E0F058", VA = "0x1E0F058")]
    public void InitializeIcon(StyleParameter styleParameter)
    {
    }

    [Token(Token = "0x6014289")]
    [Address(RVA = "0x1E0F0E0", Offset = "0x1E0F0E0", VA = "0x1E0F0E0")]
    private void InitializeTitle()
    {
    }

    [Token(Token = "0x601428A")]
    [Address(RVA = "0x1E0F31C", Offset = "0x1E0F31C", VA = "0x1E0F31C")]
    public void InitializeSpecialAttackIcon(StyleParameter styleParameter)
    {
    }

    [Token(Token = "0x601428B")]
    [Address(RVA = "0x1E100F0", Offset = "0x1E100F0", VA = "0x1E100F0")]
    public void InitializeSpecialAttackResistIcon(StyleParameter styleParameter)
    {
    }

    [Token(Token = "0x601428C")]
    [Address(RVA = "0x1E10EC4", Offset = "0x1E10EC4", VA = "0x1E10EC4")]
    public void InitializeElementEnhanceIcon(StyleParameter styleParameter)
    {
    }

    [Token(Token = "0x601428D")]
    [Address(RVA = "0x1E11294", Offset = "0x1E11294", VA = "0x1E11294")]
    public void InitializeElementEnhanceResistIcon(StyleParameter styleParameter)
    {
    }

    [Token(Token = "0x601428E")]
    [Address(RVA = "0x1E11660", Offset = "0x1E11660", VA = "0x1E11660")]
    public void InitializeAttackCategoryIcon(StyleParameter styleParameter)
    {
    }

    [Token(Token = "0x601428F")]
    [Address(RVA = "0x1E11A2C", Offset = "0x1E11A2C", VA = "0x1E11A2C")]
    public void InitializeAttackCategoryResistIcon(StyleParameter styleParameter)
    {
    }

    [Token(Token = "0x6014290")]
    [Address(RVA = "0x1E11DF8", Offset = "0x1E11DF8", VA = "0x1E11DF8")]
    public void InitializeStatusEffectIcon(StyleParameter styleParameter)
    {
    }

    [Token(Token = "0x6014291")]
    [Address(RVA = "0x1E12258", Offset = "0x1E12258", VA = "0x1E12258")]
    public void InitializeStatusEffectResistIcon(StyleParameter styleParameter)
    {
    }

    [Token(Token = "0x6014292")]
    [Address(RVA = "0x1E126F8", Offset = "0x1E126F8", VA = "0x1E126F8")]
    public EnhancedResistanceIconController()
    {
    }
  }
}
