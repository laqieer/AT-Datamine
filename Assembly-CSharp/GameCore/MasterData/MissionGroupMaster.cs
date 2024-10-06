// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200109B")]
  [Serializable]
  public sealed class MissionGroupMaster : BaseMaster<MissionGroupData>
  {
    [Token(Token = "0x600602D")]
    [Address(RVA = "0x28D50A0", Offset = "0x28D50A0", VA = "0x28D50A0")]
    public IReadOnlyDictionary<int, MissionGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MissionGroupData>) null;
    }

    [Token(Token = "0x600602E")]
    [Address(RVA = "0x28D50A8", Offset = "0x28D50A8", VA = "0x28D50A8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600602F")]
    [Address(RVA = "0x28D5108", Offset = "0x28D5108", VA = "0x28D5108", Slot = "5")]
    protected override MissionGroupData LoadEntity(IMasterDataReader reader)
    {
      return (MissionGroupData) null;
    }

    [Token(Token = "0x6006030")]
    [Address(RVA = "0x28D5160", Offset = "0x28D5160", VA = "0x28D5160")]
    public MissionGroupMaster()
    {
    }
  }
}
