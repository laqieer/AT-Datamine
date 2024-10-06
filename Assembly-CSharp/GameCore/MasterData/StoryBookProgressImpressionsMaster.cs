// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBookProgressImpressionsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012D7")]
  [Serializable]
  public sealed class StoryBookProgressImpressionsMaster : 
    BaseMaster<StoryBookProgressImpressionsData>
  {
    [Token(Token = "0x6006AB5")]
    [Address(RVA = "0x48DBB8C", Offset = "0x48DBB8C", VA = "0x48DBB8C")]
    public IReadOnlyDictionary<int, StoryBookProgressImpressionsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryBookProgressImpressionsData>) null;
    }

    [Token(Token = "0x6006AB6")]
    [Address(RVA = "0x48DBB94", Offset = "0x48DBB94", VA = "0x48DBB94", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006AB7")]
    [Address(RVA = "0x48DBBF4", Offset = "0x48DBBF4", VA = "0x48DBBF4", Slot = "5")]
    protected override StoryBookProgressImpressionsData LoadEntity(IMasterDataReader reader)
    {
      return (StoryBookProgressImpressionsData) null;
    }

    [Token(Token = "0x6006AB8")]
    [Address(RVA = "0x48DBC4C", Offset = "0x48DBC4C", VA = "0x48DBC4C")]
    public StoryBookProgressImpressionsMaster()
    {
    }
  }
}
