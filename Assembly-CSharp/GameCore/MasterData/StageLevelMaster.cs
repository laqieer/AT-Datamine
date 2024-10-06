// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StageLevelMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001152")]
  [Serializable]
  public sealed class StageLevelMaster : BaseMaster<StageLevelData>
  {
    [Token(Token = "0x400540C")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<(int stageId, int level), StageLevelData> stageDic;

    [Token(Token = "0x6006394")]
    [Address(RVA = "0x4AE94D8", Offset = "0x4AE94D8", VA = "0x4AE94D8")]
    public IReadOnlyDictionary<int, StageLevelData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StageLevelData>) null;
    }

    [Token(Token = "0x6006395")]
    [Address(RVA = "0x4AE94E0", Offset = "0x4AE94E0", VA = "0x4AE94E0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006396")]
    [Address(RVA = "0x4AE9540", Offset = "0x4AE9540", VA = "0x4AE9540", Slot = "5")]
    protected override StageLevelData LoadEntity(IMasterDataReader reader) => (StageLevelData) null;

    [Token(Token = "0x6006397")]
    [Address(RVA = "0x4AE95B0", Offset = "0x4AE95B0", VA = "0x4AE95B0")]
    private void OnLoadEntity(StageLevelData entity)
    {
    }

    [Token(Token = "0x6006398")]
    [Address(RVA = "0x4AE969C", Offset = "0x4AE969C", VA = "0x4AE969C")]
    public StageLevelData GetByStageId(int stageId, int level) => (StageLevelData) null;

    [Token(Token = "0x6006399")]
    [Address(RVA = "0x4AE974C", Offset = "0x4AE974C", VA = "0x4AE974C")]
    public StageLevelMaster()
    {
    }
  }
}
