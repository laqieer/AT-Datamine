// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionUnlockDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010A7")]
  [Serializable]
  public sealed class MissionUnlockDescriptionMaster : BaseMaster<MissionUnlockDescriptionData>
  {
    [Token(Token = "0x6006062")]
    [Address(RVA = "0x28D7028", Offset = "0x28D7028", VA = "0x28D7028")]
    public IReadOnlyDictionary<int, MissionUnlockDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MissionUnlockDescriptionData>) null;
    }

    [Token(Token = "0x6006063")]
    [Address(RVA = "0x28D7030", Offset = "0x28D7030", VA = "0x28D7030", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006064")]
    [Address(RVA = "0x28D7090", Offset = "0x28D7090", VA = "0x28D7090", Slot = "5")]
    protected override MissionUnlockDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (MissionUnlockDescriptionData) null;
    }

    [Token(Token = "0x6006065")]
    [Address(RVA = "0x28D70E8", Offset = "0x28D70E8", VA = "0x28D70E8")]
    public MissionUnlockDescriptionMaster()
    {
    }
  }
}
