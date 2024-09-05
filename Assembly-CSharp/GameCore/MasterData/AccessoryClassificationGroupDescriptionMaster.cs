// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryClassificationGroupDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001372")]
  [Serializable]
  public sealed class AccessoryClassificationGroupDescriptionMaster : 
    BaseMaster<AccessoryClassificationGroupDescriptionData>
  {
    [Token(Token = "0x6006D76")]
    [Address(RVA = "0x46FD42C", Offset = "0x46FD42C", VA = "0x46FD42C")]
    public IReadOnlyDictionary<int, AccessoryClassificationGroupDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoryClassificationGroupDescriptionData>) null;
    }

    [Token(Token = "0x6006D77")]
    [Address(RVA = "0x46FD434", Offset = "0x46FD434", VA = "0x46FD434", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D78")]
    [Address(RVA = "0x46FD494", Offset = "0x46FD494", VA = "0x46FD494", Slot = "5")]
    protected override AccessoryClassificationGroupDescriptionData LoadEntity(
      IMasterDataReader reader)
    {
      return (AccessoryClassificationGroupDescriptionData) null;
    }

    [Token(Token = "0x6006D79")]
    [Address(RVA = "0x46FD4EC", Offset = "0x46FD4EC", VA = "0x46FD4EC")]
    public AccessoryClassificationGroupDescriptionMaster()
    {
    }
  }
}
