// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionOverrideSequeceMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001269")]
  [Serializable]
  public sealed class StoryFreeActionOverrideSequeceMaster : 
    BaseMaster<StoryFreeActionOverrideSequeceData>
  {
    [Token(Token = "0x60068AC")]
    [Address(RVA = "0x48C8F4C", Offset = "0x48C8F4C", VA = "0x48C8F4C")]
    public IReadOnlyDictionary<int, StoryFreeActionOverrideSequeceData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionOverrideSequeceData>) null;
    }

    [Token(Token = "0x60068AD")]
    [Address(RVA = "0x48C8F54", Offset = "0x48C8F54", VA = "0x48C8F54", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60068AE")]
    [Address(RVA = "0x48C8FB4", Offset = "0x48C8FB4", VA = "0x48C8FB4", Slot = "5")]
    protected override StoryFreeActionOverrideSequeceData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionOverrideSequeceData) null;
    }

    [Token(Token = "0x60068AF")]
    [Address(RVA = "0x48C900C", Offset = "0x48C900C", VA = "0x48C900C")]
    public StoryFreeActionOverrideSequeceMaster()
    {
    }
  }
}
