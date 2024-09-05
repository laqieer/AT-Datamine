// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.SkillModelBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.OutGame.Info.Skill
{
  [Token(Token = "0x2003578")]
  public abstract class SkillModelBase
  {
    [Token(Token = "0x400E880")]
    [FieldOffset(Offset = "0x10")]
    public Action OnChange;

    [Token(Token = "0x17004594")]
    public SkillData SkillBase
    {
      [Token(Token = "0x6014FBE"), Address(RVA = "0x4AA1B20", Offset = "0x4AA1B20", VA = "0x4AA1B20")] get
      {
        return (SkillData) null;
      }
      [Token(Token = "0x6014FBF"), Address(RVA = "0x4AA1B28", Offset = "0x4AA1B28", VA = "0x4AA1B28")] set
      {
      }
    }

    [Token(Token = "0x17004595")]
    public SkillDetailData SkillDetail
    {
      [Token(Token = "0x6014FC0"), Address(RVA = "0x4AA1B30", Offset = "0x4AA1B30", VA = "0x4AA1B30")] get
      {
        return (SkillDetailData) null;
      }
      [Token(Token = "0x6014FC1"), Address(RVA = "0x4AA1B38", Offset = "0x4AA1B38", VA = "0x4AA1B38")] set
      {
      }
    }

    [Token(Token = "0x17004596")]
    public int ID
    {
      [Token(Token = "0x6014FC2"), Address(RVA = "0x4AA1B40", Offset = "0x4AA1B40", VA = "0x4AA1B40")] get
      {
        return new int();
      }
      [Token(Token = "0x6014FC3"), Address(RVA = "0x4AA1B48", Offset = "0x4AA1B48", VA = "0x4AA1B48")] protected set
      {
      }
    }

    [Token(Token = "0x17004597")]
    public string Title
    {
      [Token(Token = "0x6014FC4"), Address(RVA = "0x4AA1B50", Offset = "0x4AA1B50", VA = "0x4AA1B50")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17004598")]
    public string Description
    {
      [Token(Token = "0x6014FC5"), Address(RVA = "0x4AA1BB0", Offset = "0x4AA1BB0", VA = "0x4AA1BB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17004599")]
    public int Level
    {
      [Token(Token = "0x6014FC6"), Address(RVA = "0x4AA1C10", Offset = "0x4AA1C10", VA = "0x4AA1C10")] get
      {
        return new int();
      }
      [Token(Token = "0x6014FC7"), Address(RVA = "0x4AA1C18", Offset = "0x4AA1C18", VA = "0x4AA1C18")] protected set
      {
      }
    }

    [Token(Token = "0x1700459A")]
    public int Cost
    {
      [Token(Token = "0x6014FC8"), Address(RVA = "0x4AA1C20", Offset = "0x4AA1C20", VA = "0x4AA1C20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700459B")]
    public int ConsumeDurability
    {
      [Token(Token = "0x6014FC9"), Address(RVA = "0x4AA1C38", Offset = "0x4AA1C38", VA = "0x4AA1C38")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700459C")]
    public int CoolTime
    {
      [Token(Token = "0x6014FCA"), Address(RVA = "0x4AA1C50", Offset = "0x4AA1C50", VA = "0x4AA1C50")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700459D")]
    public int UsableCount
    {
      [Token(Token = "0x6014FCB"), Address(RVA = "0x4AA1C68", Offset = "0x4AA1C68", VA = "0x4AA1C68")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700459E")]
    public SkillTypeEnum SkillType
    {
      [Token(Token = "0x6014FCC"), Address(RVA = "0x4AA1C80", Offset = "0x4AA1C80", VA = "0x4AA1C80")] get
      {
        return new SkillTypeEnum();
      }
    }

    [Token(Token = "0x1700459F")]
    public string[] Tags
    {
      [Token(Token = "0x6014FCD"), Address(RVA = "0x4AA1C98", Offset = "0x4AA1C98", VA = "0x4AA1C98")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x6014FCE"), Address(RVA = "0x4AA1CA0", Offset = "0x4AA1CA0", VA = "0x4AA1CA0")] protected set
      {
      }
    }

    [Token(Token = "0x170045A0")]
    public RarityTypeEnum? Rarity
    {
      [Token(Token = "0x6014FCF"), Address(RVA = "0x4AA1CA8", Offset = "0x4AA1CA8", VA = "0x4AA1CA8")] get
      {
        return new RarityTypeEnum?();
      }
      [Token(Token = "0x6014FD0"), Address(RVA = "0x4AA1CB0", Offset = "0x4AA1CB0", VA = "0x4AA1CB0")] set
      {
      }
    }

    [Token(Token = "0x170045A1")]
    public EquipmentClassificationData EquipmentClassificationData
    {
      [Token(Token = "0x6014FD1"), Address(RVA = "0x4AA1CB8", Offset = "0x4AA1CB8", VA = "0x4AA1CB8")] get
      {
        return (EquipmentClassificationData) null;
      }
      [Token(Token = "0x6014FD2"), Address(RVA = "0x4AA1CC0", Offset = "0x4AA1CC0", VA = "0x4AA1CC0")] protected set
      {
      }
    }

    [Token(Token = "0x170045A2")]
    public int RangeMin
    {
      [Token(Token = "0x6014FD3"), Address(RVA = "0x4AA1CC8", Offset = "0x4AA1CC8", VA = "0x4AA1CC8")] get
      {
        return new int();
      }
      [Token(Token = "0x6014FD4"), Address(RVA = "0x4AA1CD0", Offset = "0x4AA1CD0", VA = "0x4AA1CD0")] protected set
      {
      }
    }

    [Token(Token = "0x170045A3")]
    public int RangeMax
    {
      [Token(Token = "0x6014FD5"), Address(RVA = "0x4AA1CD8", Offset = "0x4AA1CD8", VA = "0x4AA1CD8")] get
      {
        return new int();
      }
      [Token(Token = "0x6014FD6"), Address(RVA = "0x4AA1CE0", Offset = "0x4AA1CE0", VA = "0x4AA1CE0")] protected set
      {
      }
    }

    [Token(Token = "0x170045A4")]
    public int RangeTypeID
    {
      [Token(Token = "0x6014FD7"), Address(RVA = "0x4AA1CE8", Offset = "0x4AA1CE8", VA = "0x4AA1CE8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170045A5")]
    public RangeExtentionTypeEnum RangeExtentionType
    {
      [Token(Token = "0x6014FD8"), Address(RVA = "0x4AA1D00", Offset = "0x4AA1D00", VA = "0x4AA1D00")] get
      {
        return new RangeExtentionTypeEnum();
      }
      [Token(Token = "0x6014FD9"), Address(RVA = "0x4AA1D08", Offset = "0x4AA1D08", VA = "0x4AA1D08")] protected set
      {
      }
    }

    [Token(Token = "0x170045A6")]
    public SkillEffectIconNameUtility.SkillEffectIconData[] SubIconAssets
    {
      [Token(Token = "0x6014FDA"), Address(RVA = "0x4AA1D10", Offset = "0x4AA1D10", VA = "0x4AA1D10")] get
      {
        return (SkillEffectIconNameUtility.SkillEffectIconData[]) null;
      }
      [Token(Token = "0x6014FDB"), Address(RVA = "0x4AA1D18", Offset = "0x4AA1D18", VA = "0x4AA1D18")] set
      {
      }
    }

    [Token(Token = "0x170045A7")]
    public bool IsCustomSkill
    {
      [Token(Token = "0x6014FDC"), Address(RVA = "0x4AA1D20", Offset = "0x4AA1D20", VA = "0x4AA1D20")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014FDD"), Address(RVA = "0x4AA1D28", Offset = "0x4AA1D28", VA = "0x4AA1D28")] protected set
      {
      }
    }

    [Token(Token = "0x170045A8")]
    public bool IsExSkill
    {
      [Token(Token = "0x6014FDE"), Address(RVA = "0x4AA1D34", Offset = "0x4AA1D34", VA = "0x4AA1D34")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014FDF"), Address(RVA = "0x4AA1D3C", Offset = "0x4AA1D3C", VA = "0x4AA1D3C")] protected set
      {
      }
    }

    [Token(Token = "0x170045A9")]
    public bool IsEmpty
    {
      [Token(Token = "0x6014FE0"), Address(RVA = "0x4AA1D48", Offset = "0x4AA1D48", VA = "0x4AA1D48")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170045AA")]
    public bool IsFierceSkill
    {
      [Token(Token = "0x6014FE1"), Address(RVA = "0x4AA1D68", Offset = "0x4AA1D68", VA = "0x4AA1D68")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170045AB")]
    public int LatentCount
    {
      [Token(Token = "0x6014FE2"), Address(RVA = "0x4AA1D88", Offset = "0x4AA1D88", VA = "0x4AA1D88")] get
      {
        return new int();
      }
      [Token(Token = "0x6014FE3"), Address(RVA = "0x4AA1D90", Offset = "0x4AA1D90", VA = "0x4AA1D90")] protected set
      {
      }
    }

    [Token(Token = "0x170045AC")]
    public bool IsLatentSkill
    {
      [Token(Token = "0x6014FE4"), Address(RVA = "0x4AA1D98", Offset = "0x4AA1D98", VA = "0x4AA1D98")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170045AD")]
    public bool IsEnableLatent
    {
      [Token(Token = "0x6014FE5"), Address(RVA = "0x4AA1DA8", Offset = "0x4AA1DA8", VA = "0x4AA1DA8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014FE6"), Address(RVA = "0x4AA1DB0", Offset = "0x4AA1DB0", VA = "0x4AA1DB0")] protected set
      {
      }
    }

    [Token(Token = "0x170045AE")]
    public bool IsDisable
    {
      [Token(Token = "0x6014FE7"), Address(RVA = "0x4AA1DBC", Offset = "0x4AA1DBC", VA = "0x4AA1DBC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014FE8"), Address(RVA = "0x4AA1DC4", Offset = "0x4AA1DC4", VA = "0x4AA1DC4")] set
      {
      }
    }

    [Token(Token = "0x170045AF")]
    public bool IsWeaponBroken
    {
      [Token(Token = "0x6014FE9"), Address(RVA = "0x4AA1DD0", Offset = "0x4AA1DD0", VA = "0x4AA1DD0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014FEA"), Address(RVA = "0x4AA1DD8", Offset = "0x4AA1DD8", VA = "0x4AA1DD8")] set
      {
      }
    }

    [Token(Token = "0x6014FEB")]
    [Address(RVA = "0x4AA1DE4", Offset = "0x4AA1DE4", VA = "0x4AA1DE4")]
    public void Set(SkillModelBase skill)
    {
    }

    [Token(Token = "0x6014FEC")]
    [Address(RVA = "0x4AA1F5C", Offset = "0x4AA1F5C", VA = "0x4AA1F5C")]
    protected void SetData(SkillDetailData detailData)
    {
    }

    [Token(Token = "0x6014FED")]
    [Address(RVA = "0x4AA243C", Offset = "0x4AA243C", VA = "0x4AA243C")]
    public void UpdateStyle(int skillId)
    {
    }

    [Token(Token = "0x6014FEE")]
    [Address(RVA = "0x4AA24E8", Offset = "0x4AA24E8", VA = "0x4AA24E8")]
    protected SkillModelBase()
    {
    }
  }
}
