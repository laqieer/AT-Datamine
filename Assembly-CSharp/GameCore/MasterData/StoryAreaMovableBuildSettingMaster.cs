// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaMovableBuildSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011C8")]
  [Serializable]
  public sealed class StoryAreaMovableBuildSettingMaster : 
    BaseMaster<StoryAreaMovableBuildSettingData>
  {
    [Token(Token = "0x60065C5")]
    [Address(RVA = "0x4D1EC44", Offset = "0x4D1EC44", VA = "0x4D1EC44")]
    public IReadOnlyDictionary<int, StoryAreaMovableBuildSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAreaMovableBuildSettingData>) null;
    }

    [Token(Token = "0x60065C6")]
    [Address(RVA = "0x4D1EC4C", Offset = "0x4D1EC4C", VA = "0x4D1EC4C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60065C7")]
    [Address(RVA = "0x4D1ECAC", Offset = "0x4D1ECAC", VA = "0x4D1ECAC", Slot = "5")]
    protected override StoryAreaMovableBuildSettingData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAreaMovableBuildSettingData) null;
    }

    [Token(Token = "0x60065C8")]
    [Address(RVA = "0x4D1ED04", Offset = "0x4D1ED04", VA = "0x4D1ED04")]
    public StoryAreaMovableBuildSettingMaster()
    {
    }
  }
}
