// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011B5")]
  [Serializable]
  public sealed class SkillDetailMaster : BaseMaster<SkillDetailData>
  {
    [Token(Token = "0x400553A")]
    public const string TEXT_AB = "text_masterdata_skill";
    [Token(Token = "0x400553B")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<SkillDetailData>> mapBySkill;

    [Token(Token = "0x6006569")]
    [Address(RVA = "0x4D1AB3C", Offset = "0x4D1AB3C", VA = "0x4D1AB3C")]
    public IReadOnlyDictionary<int, SkillDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SkillDetailData>) null;
    }

    [Token(Token = "0x600656A")]
    [Address(RVA = "0x4D1AB44", Offset = "0x4D1AB44", VA = "0x4D1AB44", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600656B")]
    [Address(RVA = "0x4D1AE2C", Offset = "0x4D1AE2C", VA = "0x4D1AE2C", Slot = "5")]
    protected override SkillDetailData LoadEntity(IMasterDataReader reader)
    {
      return (SkillDetailData) null;
    }

    [Token(Token = "0x600656C")]
    [Address(RVA = "0x4D1AE9C", Offset = "0x4D1AE9C", VA = "0x4D1AE9C")]
    private void OnLoadEntity(SkillDetailData entity)
    {
    }

    [Token(Token = "0x600656D")]
    [Address(RVA = "0x4D1ABAC", Offset = "0x4D1ABAC", VA = "0x4D1ABAC")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x600656E")]
    [Address(RVA = "0x4D1AFF0", Offset = "0x4D1AFF0", VA = "0x4D1AFF0")]
    public List<SkillDetailData> GetByBaseId(int baseMasterId) => (List<SkillDetailData>) null;

    [Token(Token = "0x600656F")]
    [Address(RVA = "0x4D1B0B0", Offset = "0x4D1B0B0", VA = "0x4D1B0B0")]
    public SkillDetailData GetByBaseIdAndLevel(int baseMasterId, int level)
    {
      return (SkillDetailData) null;
    }

    [Token(Token = "0x6006570")]
    [Address(RVA = "0x4D1B1E0", Offset = "0x4D1B1E0", VA = "0x4D1B1E0")]
    public int GetMaxLevelByBaseId(int baseMasterId) => new int();

    [Token(Token = "0x6006571")]
    [Address(RVA = "0x4D1B274", Offset = "0x4D1B274", VA = "0x4D1B274")]
    public SkillDetailData GetHeighestByBaseIdAndLevel(int baseMasterId, int level)
    {
      return (SkillDetailData) null;
    }

    [Token(Token = "0x6006572")]
    [Address(RVA = "0x4D1B3A0", Offset = "0x4D1B3A0", VA = "0x4D1B3A0")]
    public string GetExplanationText(int baseMasterId, int level) => (string) null;

    [Token(Token = "0x6006573")]
    [Address(RVA = "0x4D1B530", Offset = "0x4D1B530", VA = "0x4D1B530")]
    public SkillDetailMaster()
    {
    }
  }
}
