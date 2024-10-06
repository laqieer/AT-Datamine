// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryTaskFlagMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012F6")]
  [Serializable]
  public sealed class StoryTaskFlagMaster : BaseMaster<StoryTaskFlagData>
  {
    [Token(Token = "0x6006B3B")]
    [Address(RVA = "0x48E0B34", Offset = "0x48E0B34", VA = "0x48E0B34")]
    public IReadOnlyDictionary<int, StoryTaskFlagData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryTaskFlagData>) null;
    }

    [Token(Token = "0x6006B3C")]
    [Address(RVA = "0x48E0B3C", Offset = "0x48E0B3C", VA = "0x48E0B3C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B3D")]
    [Address(RVA = "0x48E0B9C", Offset = "0x48E0B9C", VA = "0x48E0B9C", Slot = "5")]
    protected override StoryTaskFlagData LoadEntity(IMasterDataReader reader)
    {
      return (StoryTaskFlagData) null;
    }

    [Token(Token = "0x6006B3E")]
    [Address(RVA = "0x48E0BF4", Offset = "0x48E0BF4", VA = "0x48E0BF4")]
    public StoryTaskFlagMaster()
    {
    }
  }
}
