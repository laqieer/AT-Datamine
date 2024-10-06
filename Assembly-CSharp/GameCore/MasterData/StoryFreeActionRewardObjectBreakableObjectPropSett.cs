// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionRewardObjectBreakableObjectPropSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001273")]
  [Serializable]
  public sealed class StoryFreeActionRewardObjectBreakableObjectPropSettingMaster : 
    BaseMaster<StoryFreeActionRewardObjectBreakableObjectPropSettingData>
  {
    [Token(Token = "0x60068E4")]
    [Address(RVA = "0x48CA69C", Offset = "0x48CA69C", VA = "0x48CA69C")]
    public IReadOnlyDictionary<int, StoryFreeActionRewardObjectBreakableObjectPropSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionRewardObjectBreakableObjectPropSettingData>) null;
    }

    [Token(Token = "0x60068E5")]
    [Address(RVA = "0x48CA6A4", Offset = "0x48CA6A4", VA = "0x48CA6A4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60068E6")]
    [Address(RVA = "0x48CA704", Offset = "0x48CA704", VA = "0x48CA704", Slot = "5")]
    protected override StoryFreeActionRewardObjectBreakableObjectPropSettingData LoadEntity(
      IMasterDataReader reader)
    {
      return (StoryFreeActionRewardObjectBreakableObjectPropSettingData) null;
    }

    [Token(Token = "0x60068E7")]
    [Address(RVA = "0x48CA75C", Offset = "0x48CA75C", VA = "0x48CA75C")]
    public StoryFreeActionRewardObjectBreakableObjectPropSettingMaster()
    {
    }
  }
}
