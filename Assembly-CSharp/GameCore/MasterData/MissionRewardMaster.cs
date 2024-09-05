// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionRewardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010A1")]
  [Serializable]
  public sealed class MissionRewardMaster : BaseMaster<MissionRewardData>
  {
    [Token(Token = "0x6006047")]
    [Address(RVA = "0x28D5F40", Offset = "0x28D5F40", VA = "0x28D5F40")]
    public IReadOnlyDictionary<int, MissionRewardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MissionRewardData>) null;
    }

    [Token(Token = "0x6006048")]
    [Address(RVA = "0x28D5F48", Offset = "0x28D5F48", VA = "0x28D5F48", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006049")]
    [Address(RVA = "0x28D5FA8", Offset = "0x28D5FA8", VA = "0x28D5FA8", Slot = "5")]
    protected override MissionRewardData LoadEntity(IMasterDataReader reader)
    {
      return (MissionRewardData) null;
    }

    [Token(Token = "0x600604A")]
    [Address(RVA = "0x28D6000", Offset = "0x28D6000", VA = "0x28D6000")]
    public MissionRewardMaster()
    {
    }
  }
}
