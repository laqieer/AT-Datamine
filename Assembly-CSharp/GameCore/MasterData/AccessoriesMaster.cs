// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoriesMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F3D")]
  [Serializable]
  public sealed class AccessoriesMaster : BaseMaster<AccessoriesData>
  {
    [Token(Token = "0x4004C48")]
    public const string TEXT_AB = "text_masterdata_equipment";

    [Token(Token = "0x60059CC")]
    [Address(RVA = "0x3C34860", Offset = "0x3C34860", VA = "0x3C34860")]
    public IReadOnlyDictionary<int, AccessoriesData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoriesData>) null;
    }

    [Token(Token = "0x60059CD")]
    [Address(RVA = "0x3C34868", Offset = "0x3C34868", VA = "0x3C34868", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60059CE")]
    [Address(RVA = "0x3C348C8", Offset = "0x3C348C8", VA = "0x3C348C8", Slot = "5")]
    protected override AccessoriesData LoadEntity(IMasterDataReader reader)
    {
      return (AccessoriesData) null;
    }

    [Token(Token = "0x60059CF")]
    [Address(RVA = "0x3C34920", Offset = "0x3C34920", VA = "0x3C34920")]
    public IReadOnlyCollection<AccessoriesData> GetList()
    {
      return (IReadOnlyCollection<AccessoriesData>) null;
    }

    [Token(Token = "0x60059D0")]
    [Address(RVA = "0x3C34970", Offset = "0x3C34970", VA = "0x3C34970")]
    public AccessoriesMaster()
    {
    }
  }
}
