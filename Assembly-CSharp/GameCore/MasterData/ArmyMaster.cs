// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArmyMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001378")]
  [Serializable]
  public sealed class ArmyMaster : BaseMaster<ArmyData>
  {
    [Token(Token = "0x6006D8E")]
    [Address(RVA = "0x46FDD7C", Offset = "0x46FDD7C", VA = "0x46FDD7C")]
    public IReadOnlyDictionary<int, ArmyData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArmyData>) null;
    }

    [Token(Token = "0x6006D8F")]
    [Address(RVA = "0x46FDD84", Offset = "0x46FDD84", VA = "0x46FDD84", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D90")]
    [Address(RVA = "0x46FDDE4", Offset = "0x46FDDE4", VA = "0x46FDDE4", Slot = "5")]
    protected override ArmyData LoadEntity(IMasterDataReader reader) => (ArmyData) null;

    [Token(Token = "0x6006D91")]
    [Address(RVA = "0x46FDE3C", Offset = "0x46FDE3C", VA = "0x46FDE3C")]
    public IReadOnlyCollection<ArmyData> GetList() => (IReadOnlyCollection<ArmyData>) null;

    [Token(Token = "0x6006D92")]
    [Address(RVA = "0x46FDE8C", Offset = "0x46FDE8C", VA = "0x46FDE8C")]
    public ArmyMaster()
    {
    }
  }
}
