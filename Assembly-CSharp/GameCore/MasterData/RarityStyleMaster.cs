// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RarityStyleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001399")]
  [Serializable]
  public sealed class RarityStyleMaster : BaseMaster<RarityStyleData>
  {
    [Token(Token = "0x4005B76")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, RarityStyleData> rarityStarMap;

    [Token(Token = "0x6006E20")]
    [Address(RVA = "0x470226C", Offset = "0x470226C", VA = "0x470226C")]
    public IReadOnlyDictionary<int, RarityStyleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, RarityStyleData>) null;
    }

    [Token(Token = "0x6006E21")]
    [Address(RVA = "0x4702274", Offset = "0x4702274", VA = "0x4702274", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006E22")]
    [Address(RVA = "0x47022D4", Offset = "0x47022D4", VA = "0x47022D4", Slot = "5")]
    protected override RarityStyleData LoadEntity(IMasterDataReader reader)
    {
      return (RarityStyleData) null;
    }

    [Token(Token = "0x6006E23")]
    [Address(RVA = "0x4702344", Offset = "0x4702344", VA = "0x4702344")]
    private void OnLoadEntity(RarityStyleData entity)
    {
    }

    [Token(Token = "0x6006E24")]
    [Address(RVA = "0x47023E0", Offset = "0x47023E0", VA = "0x47023E0")]
    public RarityStyleData GetRarityStyleByStar(int rarityStar) => (RarityStyleData) null;

    [Token(Token = "0x6006E25")]
    [Address(RVA = "0x4702458", Offset = "0x4702458", VA = "0x4702458")]
    public RarityStyleData GetRarityStarKey(int rarityStar) => (RarityStyleData) null;

    [Token(Token = "0x6006E26")]
    [Address(RVA = "0x4702900", Offset = "0x4702900", VA = "0x4702900")]
    public List<RarityStyleData> GetListByRarityStar(int rarityStar)
    {
      return (List<RarityStyleData>) null;
    }

    [Token(Token = "0x6006E27")]
    [Address(RVA = "0x4702B68", Offset = "0x4702B68", VA = "0x4702B68")]
    public List<RarityStyleData> GetListByRarityStarType(int rarityStarType)
    {
      return (List<RarityStyleData>) null;
    }

    [Token(Token = "0x6006E28")]
    [Address(RVA = "0x4702D9C", Offset = "0x4702D9C", VA = "0x4702D9C")]
    public RarityStyleData GetMaxRarityStarStep() => (RarityStyleData) null;

    [Token(Token = "0x6006E29")]
    [Address(RVA = "0x4702F90", Offset = "0x4702F90", VA = "0x4702F90")]
    public RarityStyleData GetMinRarityStarStep() => (RarityStyleData) null;

    [Token(Token = "0x6006E2A")]
    [Address(RVA = "0x4703184", Offset = "0x4703184", VA = "0x4703184")]
    public int GetMaxRarityStar() => new int();

    [Token(Token = "0x6006E2B")]
    [Address(RVA = "0x4703384", Offset = "0x4703384", VA = "0x4703384")]
    public int GetTargetRarityTableLength(int rarityStar) => new int();

    [Token(Token = "0x6006E2C")]
    [Address(RVA = "0x4703508", Offset = "0x4703508", VA = "0x4703508")]
    public bool UnlockSlotByAccessorie(int rarityCount) => new bool();

    [Token(Token = "0x6006E2D")]
    [Address(RVA = "0x4703624", Offset = "0x4703624", VA = "0x4703624")]
    public int GetSlotNumBySubWeapon(int rarityCount) => new int();

    [Token(Token = "0x6006E2E")]
    [Address(RVA = "0x4703738", Offset = "0x4703738", VA = "0x4703738")]
    public int GetSlotNumByCustomSkill(int rarityCount) => new int();

    [Token(Token = "0x6006E2F")]
    [Address(RVA = "0x470384C", Offset = "0x470384C", VA = "0x470384C")]
    public int GetLimitBreakNum(int rarityStar) => new int();

    [Token(Token = "0x6006E30")]
    [Address(RVA = "0x4703904", Offset = "0x4703904", VA = "0x4703904")]
    public int GetRarityStarTypeBySubWeaponSlotNum(int subWeaponSlotNum) => new int();

    [Token(Token = "0x6006E31")]
    [Address(RVA = "0x4703B04", Offset = "0x4703B04", VA = "0x4703B04")]
    public int GetRarityStarTypeByFlgAccessory() => new int();

    [Token(Token = "0x6006E32")]
    [Address(RVA = "0x4703D10", Offset = "0x4703D10", VA = "0x4703D10")]
    public RarityStyleData GetRarityStyleBySkillType(StyleSkillTypeEnum styleSkillType)
    {
      return (RarityStyleData) null;
    }

    [Token(Token = "0x6006E33")]
    [Address(RVA = "0x4703E18", Offset = "0x4703E18", VA = "0x4703E18")]
    public IReadOnlyCollection<RarityStyleData> GetList()
    {
      return (IReadOnlyCollection<RarityStyleData>) null;
    }

    [Token(Token = "0x6006E34")]
    [Address(RVA = "0x4703E68", Offset = "0x4703E68", VA = "0x4703E68")]
    public RarityStyleMaster()
    {
    }
  }
}
