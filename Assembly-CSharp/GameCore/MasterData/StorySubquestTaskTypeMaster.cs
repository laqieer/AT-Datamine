// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestTaskTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200131E")]
  [Serializable]
  public sealed class StorySubquestTaskTypeMaster : BaseMaster<StorySubquestTaskTypeData>
  {
    [Token(Token = "0x6006BF5")]
    [Address(RVA = "0x48E74A4", Offset = "0x48E74A4", VA = "0x48E74A4")]
    public IReadOnlyDictionary<int, StorySubquestTaskTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySubquestTaskTypeData>) null;
    }

    [Token(Token = "0x6006BF6")]
    [Address(RVA = "0x48E74AC", Offset = "0x48E74AC", VA = "0x48E74AC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006BF7")]
    [Address(RVA = "0x48E750C", Offset = "0x48E750C", VA = "0x48E750C", Slot = "5")]
    protected override StorySubquestTaskTypeData LoadEntity(IMasterDataReader reader)
    {
      return (StorySubquestTaskTypeData) null;
    }

    [Token(Token = "0x6006BF8")]
    [Address(RVA = "0x48E7564", Offset = "0x48E7564", VA = "0x48E7564")]
    public StorySubquestTaskTypeMaster()
    {
    }
  }
}
