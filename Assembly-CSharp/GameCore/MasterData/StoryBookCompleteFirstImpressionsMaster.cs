// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBookCompleteFirstImpressionsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012D1")]
  [Serializable]
  public sealed class StoryBookCompleteFirstImpressionsMaster : 
    BaseMaster<StoryBookCompleteFirstImpressionsData>
  {
    [Token(Token = "0x6006A98")]
    [Address(RVA = "0x48DA994", Offset = "0x48DA994", VA = "0x48DA994")]
    public IReadOnlyDictionary<int, StoryBookCompleteFirstImpressionsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryBookCompleteFirstImpressionsData>) null;
    }

    [Token(Token = "0x6006A99")]
    [Address(RVA = "0x48DA99C", Offset = "0x48DA99C", VA = "0x48DA99C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A9A")]
    [Address(RVA = "0x48DA9FC", Offset = "0x48DA9FC", VA = "0x48DA9FC", Slot = "5")]
    protected override StoryBookCompleteFirstImpressionsData LoadEntity(IMasterDataReader reader)
    {
      return (StoryBookCompleteFirstImpressionsData) null;
    }

    [Token(Token = "0x6006A9B")]
    [Address(RVA = "0x48DAA54", Offset = "0x48DAA54", VA = "0x48DAA54")]
    public StoryBookCompleteFirstImpressionsMaster()
    {
    }
  }
}
