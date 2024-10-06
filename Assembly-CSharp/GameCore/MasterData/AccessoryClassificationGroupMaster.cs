// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryClassificationGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001374")]
  [Serializable]
  public sealed class AccessoryClassificationGroupMaster : 
    BaseMaster<AccessoryClassificationGroupData>
  {
    [Token(Token = "0x6006D7E")]
    [Address(RVA = "0x46FD744", Offset = "0x46FD744", VA = "0x46FD744")]
    public IReadOnlyDictionary<int, AccessoryClassificationGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoryClassificationGroupData>) null;
    }

    [Token(Token = "0x6006D7F")]
    [Address(RVA = "0x46FD74C", Offset = "0x46FD74C", VA = "0x46FD74C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D80")]
    [Address(RVA = "0x46FD7AC", Offset = "0x46FD7AC", VA = "0x46FD7AC", Slot = "5")]
    protected override AccessoryClassificationGroupData LoadEntity(IMasterDataReader reader)
    {
      return (AccessoryClassificationGroupData) null;
    }

    [Token(Token = "0x6006D81")]
    [Address(RVA = "0x46FD804", Offset = "0x46FD804", VA = "0x46FD804")]
    public AccessoryClassificationGroupMaster()
    {
    }
  }
}
