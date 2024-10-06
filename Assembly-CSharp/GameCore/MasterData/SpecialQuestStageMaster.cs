// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SpecialQuestStageMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200114A")]
  [Serializable]
  public sealed class SpecialQuestStageMaster : BaseMaster<SpecialQuestStageData>, IQuestStageMaster
  {
    [Token(Token = "0x6006366")]
    [Address(RVA = "0x4AE8464", Offset = "0x4AE8464", VA = "0x4AE8464")]
    public IReadOnlyDictionary<int, SpecialQuestStageData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SpecialQuestStageData>) null;
    }

    [Token(Token = "0x6006367")]
    [Address(RVA = "0x4AE846C", Offset = "0x4AE846C", VA = "0x4AE846C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006368")]
    [Address(RVA = "0x4AE84CC", Offset = "0x4AE84CC", VA = "0x4AE84CC", Slot = "5")]
    protected override SpecialQuestStageData LoadEntity(IMasterDataReader reader)
    {
      return (SpecialQuestStageData) null;
    }

    [Token(Token = "0x6006369")]
    [Address(RVA = "0x4AE8524", Offset = "0x4AE8524", VA = "0x4AE8524", Slot = "6")]
    public IQuestStage GetStage(int id) => (IQuestStage) null;

    [Token(Token = "0x600636A")]
    [Address(RVA = "0x4AE857C", Offset = "0x4AE857C", VA = "0x4AE857C")]
    public SpecialQuestStageMaster()
    {
    }
  }
}
