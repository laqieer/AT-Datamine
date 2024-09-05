// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillTagsDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011BE")]
  [Serializable]
  public sealed class SkillTagsDetailMaster : BaseMaster<SkillTagsDetailData>
  {
    [Token(Token = "0x400556E")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<SkillTagTypeEnum>> groupMap;

    [Token(Token = "0x6006596")]
    [Address(RVA = "0x4D1D39C", Offset = "0x4D1D39C", VA = "0x4D1D39C")]
    public IReadOnlyDictionary<int, SkillTagsDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SkillTagsDetailData>) null;
    }

    [Token(Token = "0x6006597")]
    [Address(RVA = "0x4D1D3A4", Offset = "0x4D1D3A4", VA = "0x4D1D3A4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006598")]
    [Address(RVA = "0x4D1D404", Offset = "0x4D1D404", VA = "0x4D1D404", Slot = "5")]
    protected override SkillTagsDetailData LoadEntity(IMasterDataReader reader)
    {
      return (SkillTagsDetailData) null;
    }

    [Token(Token = "0x6006599")]
    [Address(RVA = "0x4D1D474", Offset = "0x4D1D474", VA = "0x4D1D474")]
    private void OnLoadEntity(SkillTagsDetailData entity)
    {
    }

    [Token(Token = "0x600659A")]
    [Address(RVA = "0x4D1D5F4", Offset = "0x4D1D5F4", VA = "0x4D1D5F4")]
    public List<SkillTagTypeEnum> GetListByGroupID(int groupId) => (List<SkillTagTypeEnum>) null;

    [Token(Token = "0x600659B")]
    [Address(RVA = "0x4D1D664", Offset = "0x4D1D664", VA = "0x4D1D664")]
    public SkillTagsDetailMaster()
    {
    }
  }
}
