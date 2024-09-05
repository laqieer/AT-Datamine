// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionRewardObjectBreakableObjectMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001275")]
  [Serializable]
  public sealed class StoryFreeActionRewardObjectBreakableObjectMaster : 
    BaseMaster<StoryFreeActionRewardObjectBreakableObjectData>
  {
    [Token(Token = "0x60068EC")]
    [Address(RVA = "0x48CAA9C", Offset = "0x48CAA9C", VA = "0x48CAA9C")]
    public IReadOnlyDictionary<int, StoryFreeActionRewardObjectBreakableObjectData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionRewardObjectBreakableObjectData>) null;
    }

    [Token(Token = "0x60068ED")]
    [Address(RVA = "0x48CAAA4", Offset = "0x48CAAA4", VA = "0x48CAAA4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60068EE")]
    [Address(RVA = "0x48CAB04", Offset = "0x48CAB04", VA = "0x48CAB04", Slot = "5")]
    protected override StoryFreeActionRewardObjectBreakableObjectData LoadEntity(
      IMasterDataReader reader)
    {
      return (StoryFreeActionRewardObjectBreakableObjectData) null;
    }

    [Token(Token = "0x60068EF")]
    [Address(RVA = "0x48CAB78", Offset = "0x48CAB78", VA = "0x48CAB78")]
    private void OnLoadEntity(
      StoryFreeActionRewardObjectBreakableObjectData entity)
    {
    }

    [Token(Token = "0x60068F0")]
    [Address(RVA = "0x48CABB0", Offset = "0x48CABB0", VA = "0x48CABB0")]
    public StoryFreeActionRewardObjectBreakableObjectMaster()
    {
    }
  }
}
