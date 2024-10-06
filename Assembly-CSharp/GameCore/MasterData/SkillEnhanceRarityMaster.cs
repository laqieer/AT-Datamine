// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillEnhanceRarityMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F6A")]
  [Serializable]
  public sealed class SkillEnhanceRarityMaster : BaseMaster<SkillEnhanceRarityData>
  {
    [Token(Token = "0x6005AB2")]
    [Address(RVA = "0x3C42820", Offset = "0x3C42820", VA = "0x3C42820")]
    public IReadOnlyDictionary<int, SkillEnhanceRarityData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SkillEnhanceRarityData>) null;
    }

    [Token(Token = "0x6005AB3")]
    [Address(RVA = "0x3C42828", Offset = "0x3C42828", VA = "0x3C42828", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005AB4")]
    [Address(RVA = "0x3C42888", Offset = "0x3C42888", VA = "0x3C42888", Slot = "5")]
    protected override SkillEnhanceRarityData LoadEntity(IMasterDataReader reader)
    {
      return (SkillEnhanceRarityData) null;
    }

    [Token(Token = "0x6005AB5")]
    [Address(RVA = "0x3C428E0", Offset = "0x3C428E0", VA = "0x3C428E0")]
    public SkillEnhanceRarityMaster()
    {
    }
  }
}
