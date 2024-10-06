// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBookCompleteImpressionsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012D3")]
  [Serializable]
  public sealed class StoryBookCompleteImpressionsMaster : 
    BaseMaster<StoryBookCompleteImpressionsData>
  {
    [Token(Token = "0x6006AA1")]
    [Address(RVA = "0x48DADF8", Offset = "0x48DADF8", VA = "0x48DADF8")]
    public IReadOnlyDictionary<int, StoryBookCompleteImpressionsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryBookCompleteImpressionsData>) null;
    }

    [Token(Token = "0x6006AA2")]
    [Address(RVA = "0x48DAE00", Offset = "0x48DAE00", VA = "0x48DAE00", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006AA3")]
    [Address(RVA = "0x48DAE60", Offset = "0x48DAE60", VA = "0x48DAE60", Slot = "5")]
    protected override StoryBookCompleteImpressionsData LoadEntity(IMasterDataReader reader)
    {
      return (StoryBookCompleteImpressionsData) null;
    }

    [Token(Token = "0x6006AA4")]
    [Address(RVA = "0x48DAEB8", Offset = "0x48DAEB8", VA = "0x48DAEB8")]
    public StoryBookCompleteImpressionsMaster()
    {
    }
  }
}
