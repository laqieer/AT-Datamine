// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitStatusBasicFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200234C")]
  public sealed class UnitStatusBasicFactor : UnitStatusFactorBase
  {
    [Token(Token = "0x40095D4")]
    private const float expMaskMinOffsetX = 5f;
    [Token(Token = "0x40095D5")]
    private const float expMaskMaxOffsetX = 102f;
    [Token(Token = "0x40095D6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [HideInInspector]
    private UnitStatusBasicTween tweener;
    [Token(Token = "0x40095D7")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image classNameIcon;
    [Token(Token = "0x40095D8")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UnitStatusBasicFactor.UnitStatusBasicSpeciesUISet[] species;
    [Token(Token = "0x40095D9")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UnitStatusBasicFactor.UnitStatusBasicArmyUISet[] army;
    [Token(Token = "0x40095DA")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject expRootObject;
    [Token(Token = "0x40095DB")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text level;
    [Token(Token = "0x40095DC")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text exp;
    [Token(Token = "0x40095DD")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Slider expSlider;
    [Token(Token = "0x40095DE")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RectTransform expMask;
    [Token(Token = "0x40095DF")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject hpStockRoot;
    [Token(Token = "0x40095E0")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text hpStockText;
    [Token(Token = "0x40095E1")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Image hpStockImage;
    [Token(Token = "0x40095E2")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private List<Sprite> hpStockSprites;
    [Token(Token = "0x40095E3")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text hp;
    [Token(Token = "0x40095E4")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text maxhp;
    [Token(Token = "0x40095E5")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Slider slider;
    [Token(Token = "0x40095E6")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject shieldObject;
    [Token(Token = "0x40095E7")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private ActiveObjectContainers barrierTypeObjects;
    [Token(Token = "0x40095E8")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private ActiveObjectContainers barrierMaps;
    [Token(Token = "0x40095E9")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Image shieldIcon;
    [Token(Token = "0x40095EA")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Text move;
    [Token(Token = "0x40095EB")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private Text combatPower;
    [Token(Token = "0x40095EC")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private GameObject hpGaugeColorObj;
    [Token(Token = "0x40095ED")]
    [FieldOffset(Offset = "0x100")]
    private UnitParameterData unit;
    [Token(Token = "0x40095EE")]
    [FieldOffset(Offset = "0x108")]
    private List<UIGradient.UIGradient> gradients;

    [Token(Token = "0x600D7A8")]
    [Address(RVA = "0x1B89368", Offset = "0x1B89368", VA = "0x1B89368", Slot = "4")]
    public override void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600D7A9")]
    [Address(RVA = "0x1B895C4", Offset = "0x1B895C4", VA = "0x1B895C4", Slot = "5")]
    public override void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600D7AA")]
    [Address(RVA = "0x1B89FD4", Offset = "0x1B89FD4", VA = "0x1B89FD4")]
    private void SetExp(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D7AB")]
    [Address(RVA = "0x1B8A264", Offset = "0x1B8A264", VA = "0x1B8A264")]
    private void SetHp(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D7AC")]
    [Address(RVA = "0x1B8A59C", Offset = "0x1B8A59C", VA = "0x1B8A59C")]
    private void SetShield(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D7AD")]
    [Address(RVA = "0x1B8AB60", Offset = "0x1B8AB60", VA = "0x1B8AB60", Slot = "7")]
    public override void SetActiveFactor(bool active)
    {
    }

    [Token(Token = "0x600D7AE")]
    [Address(RVA = "0x1B8984C", Offset = "0x1B8984C", VA = "0x1B8984C")]
    private void SetSpecies(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D7AF")]
    [Address(RVA = "0x1B8AD68", Offset = "0x1B8AD68", VA = "0x1B8AD68")]
    private void SetSpeciesIconTo(
      UnitStatusBasicFactor.UnitStatusBasicSpeciesUISet ui,
      SpeciesTypeEnum type)
    {
    }

    [Token(Token = "0x600D7B0")]
    [Address(RVA = "0x1B89AFC", Offset = "0x1B89AFC", VA = "0x1B89AFC")]
    private void SetArmy(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D7B1")]
    [Address(RVA = "0x1B8AE90", Offset = "0x1B8AE90", VA = "0x1B8AE90")]
    public UnitStatusBasicFactor()
    {
    }

    [Token(Token = "0x200234D")]
    [Serializable]
    private class UnitStatusBasicSpeciesUISet
    {
      [Token(Token = "0x40095EF")]
      [FieldOffset(Offset = "0x10")]
      public GameObject root;
      [Token(Token = "0x40095F0")]
      [FieldOffset(Offset = "0x18")]
      public Image icon;

      [Token(Token = "0x600D7B2")]
      [Address(RVA = "0x1B8AF14", Offset = "0x1B8AF14", VA = "0x1B8AF14")]
      public UnitStatusBasicSpeciesUISet()
      {
      }
    }

    [Token(Token = "0x200234E")]
    [Serializable]
    private class UnitStatusBasicArmyUISet
    {
      [Token(Token = "0x40095F1")]
      [FieldOffset(Offset = "0x10")]
      public GameObject root;
      [Token(Token = "0x40095F2")]
      [FieldOffset(Offset = "0x18")]
      public Text text;

      [Token(Token = "0x600D7B3")]
      [Address(RVA = "0x1B8AF1C", Offset = "0x1B8AF1C", VA = "0x1B8AF1C")]
      public UnitStatusBasicArmyUISet()
      {
      }
    }
  }
}
