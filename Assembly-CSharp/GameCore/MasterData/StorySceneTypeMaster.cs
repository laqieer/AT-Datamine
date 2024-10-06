// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySceneTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012C5")]
  [Serializable]
  public sealed class StorySceneTypeMaster : BaseMaster<StorySceneTypeData>
  {
    [Token(Token = "0x6006A6D")]
    [Address(RVA = "0x48D8E28", Offset = "0x48D8E28", VA = "0x48D8E28")]
    public IReadOnlyDictionary<int, StorySceneTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySceneTypeData>) null;
    }

    [Token(Token = "0x6006A6E")]
    [Address(RVA = "0x48D8E30", Offset = "0x48D8E30", VA = "0x48D8E30", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A6F")]
    [Address(RVA = "0x48D8E90", Offset = "0x48D8E90", VA = "0x48D8E90", Slot = "5")]
    protected override StorySceneTypeData LoadEntity(IMasterDataReader reader)
    {
      return (StorySceneTypeData) null;
    }

    [Token(Token = "0x6006A70")]
    [Address(RVA = "0x48D8EE8", Offset = "0x48D8EE8", VA = "0x48D8EE8")]
    public StorySceneTypeMaster()
    {
    }
  }
}
