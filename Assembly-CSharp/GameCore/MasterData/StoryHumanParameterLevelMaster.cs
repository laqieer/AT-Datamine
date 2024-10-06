// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryHumanParameterLevelMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012E0")]
  [Serializable]
  public sealed class StoryHumanParameterLevelMaster : BaseMaster<StoryHumanParameterLevelData>
  {
    [Token(Token = "0x6006AE0")]
    [Address(RVA = "0x48DD370", Offset = "0x48DD370", VA = "0x48DD370")]
    public IReadOnlyDictionary<int, StoryHumanParameterLevelData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryHumanParameterLevelData>) null;
    }

    [Token(Token = "0x6006AE1")]
    [Address(RVA = "0x48DD378", Offset = "0x48DD378", VA = "0x48DD378", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006AE2")]
    [Address(RVA = "0x48DD3D8", Offset = "0x48DD3D8", VA = "0x48DD3D8", Slot = "5")]
    protected override StoryHumanParameterLevelData LoadEntity(IMasterDataReader reader)
    {
      return (StoryHumanParameterLevelData) null;
    }

    [Token(Token = "0x6006AE3")]
    [Address(RVA = "0x48DD430", Offset = "0x48DD430", VA = "0x48DD430")]
    public StoryHumanParameterLevelData Level(int humanParameterID, int value)
    {
      return (StoryHumanParameterLevelData) null;
    }

    [Token(Token = "0x6006AE4")]
    [Address(RVA = "0x48DD5BC", Offset = "0x48DD5BC", VA = "0x48DD5BC")]
    public StoryHumanParameterLevelData GetTargetLevel(int humanParameterId, int targetLevel)
    {
      return (StoryHumanParameterLevelData) null;
    }

    [Token(Token = "0x6006AE5")]
    [Address(RVA = "0x48DD750", Offset = "0x48DD750", VA = "0x48DD750")]
    public StoryHumanParameterLevelData GetByLevel(int parameterId, int level)
    {
      return (StoryHumanParameterLevelData) null;
    }

    [Token(Token = "0x6006AE6")]
    [Address(RVA = "0x48DD85C", Offset = "0x48DD85C", VA = "0x48DD85C")]
    public StoryHumanParameterLevelMaster()
    {
    }
  }
}
