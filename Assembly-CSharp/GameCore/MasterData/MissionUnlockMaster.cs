// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionUnlockMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010A9")]
  [Serializable]
  public sealed class MissionUnlockMaster : BaseMaster<MissionUnlockData>
  {
    [Token(Token = "0x600606A")]
    [Address(RVA = "0x28D7490", Offset = "0x28D7490", VA = "0x28D7490")]
    public IReadOnlyDictionary<int, MissionUnlockData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MissionUnlockData>) null;
    }

    [Token(Token = "0x600606B")]
    [Address(RVA = "0x28D7498", Offset = "0x28D7498", VA = "0x28D7498", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600606C")]
    [Address(RVA = "0x28D74F8", Offset = "0x28D74F8", VA = "0x28D74F8", Slot = "5")]
    protected override MissionUnlockData LoadEntity(IMasterDataReader reader)
    {
      return (MissionUnlockData) null;
    }

    [Token(Token = "0x600606D")]
    [Address(RVA = "0x28D7550", Offset = "0x28D7550", VA = "0x28D7550")]
    public MissionUnlockMaster()
    {
    }
  }
}
