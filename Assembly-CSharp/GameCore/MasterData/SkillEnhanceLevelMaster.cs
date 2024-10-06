// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillEnhanceLevelMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F68")]
  [Serializable]
  public sealed class SkillEnhanceLevelMaster : BaseMaster<SkillEnhanceLevelData>
  {
    [Token(Token = "0x6005AAA")]
    [Address(RVA = "0x3C42498", Offset = "0x3C42498", VA = "0x3C42498")]
    public IReadOnlyDictionary<int, SkillEnhanceLevelData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SkillEnhanceLevelData>) null;
    }

    [Token(Token = "0x6005AAB")]
    [Address(RVA = "0x3C424A0", Offset = "0x3C424A0", VA = "0x3C424A0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005AAC")]
    [Address(RVA = "0x3C42500", Offset = "0x3C42500", VA = "0x3C42500", Slot = "5")]
    protected override SkillEnhanceLevelData LoadEntity(IMasterDataReader reader)
    {
      return (SkillEnhanceLevelData) null;
    }

    [Token(Token = "0x6005AAD")]
    [Address(RVA = "0x3C42558", Offset = "0x3C42558", VA = "0x3C42558")]
    public SkillEnhanceLevelMaster()
    {
    }
  }
}
