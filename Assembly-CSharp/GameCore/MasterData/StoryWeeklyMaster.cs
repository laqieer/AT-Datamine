// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryWeeklyMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001300")]
  [Serializable]
  public sealed class StoryWeeklyMaster : BaseMaster<StoryWeeklyData>
  {
    [Token(Token = "0x6006B60")]
    [Address(RVA = "0x48E1AF0", Offset = "0x48E1AF0", VA = "0x48E1AF0")]
    public IReadOnlyDictionary<int, StoryWeeklyData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryWeeklyData>) null;
    }

    [Token(Token = "0x6006B61")]
    [Address(RVA = "0x48E1AF8", Offset = "0x48E1AF8", VA = "0x48E1AF8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B62")]
    [Address(RVA = "0x48E1B58", Offset = "0x48E1B58", VA = "0x48E1B58", Slot = "5")]
    protected override StoryWeeklyData LoadEntity(IMasterDataReader reader)
    {
      return (StoryWeeklyData) null;
    }

    [Token(Token = "0x6006B63")]
    [Address(RVA = "0x48E1BB0", Offset = "0x48E1BB0", VA = "0x48E1BB0")]
    public StoryWeeklyMaster()
    {
    }
  }
}
