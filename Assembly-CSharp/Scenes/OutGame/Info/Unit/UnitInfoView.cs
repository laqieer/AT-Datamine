// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Unit.UnitInfoView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Info.Skill.UI;
using Scenes.OutGame.Info.Style;
using Scenes.OutGame.Info.Style.UI;
using System;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Unit
{
  [Token(Token = "0x200354C")]
  public class UnitInfoView
  {
    [Token(Token = "0x400E7BE")]
    [FieldOffset(Offset = "0x0")]
    public static Func<string> FierceSkillLabel;
    [Token(Token = "0x400E7BF")]
    [FieldOffset(Offset = "0x8")]
    public static Func<string> LatentSkillLabel;
    [Token(Token = "0x400E7C0")]
    [FieldOffset(Offset = "0x10")]
    public static Func<string> EquipmentSkillLabel;
    [Token(Token = "0x400E7C1")]
    [FieldOffset(Offset = "0x18")]
    public static Func<string> StyleSkillLabel;
    [Token(Token = "0x400E7C2")]
    [FieldOffset(Offset = "0x20")]
    public static Func<string> CustomSkillLabel;
    [Token(Token = "0x400E7C3")]
    [FieldOffset(Offset = "0x28")]
    public static Func<string> CommunicationSkillLabel;

    [Token(Token = "0x17004557")]
    public StyleStatusView StyleStatusView
    {
      [Token(Token = "0x6014E89"), Address(RVA = "0x1B4AEE0", Offset = "0x1B4AEE0", VA = "0x1B4AEE0")] get
      {
        return (StyleStatusView) null;
      }
      [Token(Token = "0x6014E8A"), Address(RVA = "0x1B4AEE8", Offset = "0x1B4AEE8", VA = "0x1B4AEE8")] set
      {
      }
    }

    [Token(Token = "0x17004558")]
    public ParameterView ParametersView
    {
      [Token(Token = "0x6014E8B"), Address(RVA = "0x1B4AEF0", Offset = "0x1B4AEF0", VA = "0x1B4AEF0")] get
      {
        return (ParameterView) null;
      }
      [Token(Token = "0x6014E8C"), Address(RVA = "0x1B4AEF8", Offset = "0x1B4AEF8", VA = "0x1B4AEF8")] set
      {
      }
    }

    [Token(Token = "0x17004559")]
    public AdditionalParameterView AdditionalParametersView
    {
      [Token(Token = "0x6014E8D"), Address(RVA = "0x1B4AF00", Offset = "0x1B4AF00", VA = "0x1B4AF00")] get
      {
        return (AdditionalParameterView) null;
      }
      [Token(Token = "0x6014E8E"), Address(RVA = "0x1B4AF08", Offset = "0x1B4AF08", VA = "0x1B4AF08")] set
      {
      }
    }

    [Token(Token = "0x1700455A")]
    public IUnitEquipmentView EquipmentSlotView
    {
      [Token(Token = "0x6014E8F"), Address(RVA = "0x1B4AF10", Offset = "0x1B4AF10", VA = "0x1B4AF10")] get
      {
        return (IUnitEquipmentView) null;
      }
      [Token(Token = "0x6014E90"), Address(RVA = "0x1B4AF18", Offset = "0x1B4AF18", VA = "0x1B4AF18")] set
      {
      }
    }

    [Token(Token = "0x1700455B")]
    public StyleDotUI StyleDot
    {
      [Token(Token = "0x6014E91"), Address(RVA = "0x1B4AF20", Offset = "0x1B4AF20", VA = "0x1B4AF20")] private get
      {
        return (StyleDotUI) null;
      }
      [Token(Token = "0x6014E92"), Address(RVA = "0x1B4AF28", Offset = "0x1B4AF28", VA = "0x1B4AF28")] set
      {
      }
    }

    [Token(Token = "0x1700455C")]
    public TextAccessor CombatPower
    {
      [Token(Token = "0x6014E93"), Address(RVA = "0x1B4AF30", Offset = "0x1B4AF30", VA = "0x1B4AF30")] private get
      {
        return (TextAccessor) null;
      }
      [Token(Token = "0x6014E94"), Address(RVA = "0x1B4AF38", Offset = "0x1B4AF38", VA = "0x1B4AF38")] set
      {
      }
    }

    [Token(Token = "0x1700455D")]
    public CurrentMaxGaugeUI UnitHP
    {
      [Token(Token = "0x6014E95"), Address(RVA = "0x1B4AF40", Offset = "0x1B4AF40", VA = "0x1B4AF40")] private get
      {
        return (CurrentMaxGaugeUI) null;
      }
      [Token(Token = "0x6014E96"), Address(RVA = "0x1B4AF48", Offset = "0x1B4AF48", VA = "0x1B4AF48")] set
      {
      }
    }

    [Token(Token = "0x1700455E")]
    public BarrierStockUI BarrierStock
    {
      [Token(Token = "0x6014E97"), Address(RVA = "0x1B4AF50", Offset = "0x1B4AF50", VA = "0x1B4AF50")] private get
      {
        return (BarrierStockUI) null;
      }
      [Token(Token = "0x6014E98"), Address(RVA = "0x1B4AF58", Offset = "0x1B4AF58", VA = "0x1B4AF58")] set
      {
      }
    }

    [Token(Token = "0x1700455F")]
    public SkillListUI SkillList
    {
      [Token(Token = "0x6014E99"), Address(RVA = "0x1B4AF60", Offset = "0x1B4AF60", VA = "0x1B4AF60")] private get
      {
        return (SkillListUI) null;
      }
      [Token(Token = "0x6014E9A"), Address(RVA = "0x1B4AF68", Offset = "0x1B4AF68", VA = "0x1B4AF68")] set
      {
      }
    }

    [Token(Token = "0x17004560")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x6014E9B"), Address(RVA = "0x1B4AF70", Offset = "0x1B4AF70", VA = "0x1B4AF70")] private get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x6014E9C"), Address(RVA = "0x1B4AF78", Offset = "0x1B4AF78", VA = "0x1B4AF78")] set
      {
      }
    }

    [Token(Token = "0x6014E9D")]
    [Address(RVA = "0x1B48690", Offset = "0x1B48690", VA = "0x1B48690")]
    public void SetCombatPower(int value)
    {
    }

    [Token(Token = "0x6014E9E")]
    [Address(RVA = "0x1B49618", Offset = "0x1B49618", VA = "0x1B49618")]
    public void SetDot(GameObject dotUnit)
    {
    }

    [Token(Token = "0x6014E9F")]
    [Address(RVA = "0x1B48C74", Offset = "0x1B48C74", VA = "0x1B48C74")]
    public void SetHP(int hp, int max)
    {
    }

    [Token(Token = "0x6014EA0")]
    [Address(RVA = "0x1B48C98", Offset = "0x1B48C98", VA = "0x1B48C98")]
    public void SetBarrierStock(int stock, int max, string barrierIndex = "")
    {
    }

    [Token(Token = "0x6014EA1")]
    [Address(RVA = "0x1B48F74", Offset = "0x1B48F74", VA = "0x1B48F74")]
    public SkillListCategoryUI AddSkillCategory(int index, string category)
    {
      return (SkillListCategoryUI) null;
    }

    [Token(Token = "0x6014EA2")]
    [Address(RVA = "0x1B492B0", Offset = "0x1B492B0", VA = "0x1B492B0")]
    public SkillView AddSkillElement(int index) => (SkillView) null;

    [Token(Token = "0x6014EA3")]
    [Address(RVA = "0x1B48F58", Offset = "0x1B48F58", VA = "0x1B48F58")]
    public void ResetSkills()
    {
    }

    [Token(Token = "0x6014EA4")]
    [Address(RVA = "0x1B4AF80", Offset = "0x1B4AF80", VA = "0x1B4AF80")]
    public UnitInfoView()
    {
    }

    [Token(Token = "0x6014EA5")]
    [Address(RVA = "0x1B4AF88", Offset = "0x1B4AF88", VA = "0x1B4AF88")]
    static UnitInfoView()
    {
    }
  }
}
