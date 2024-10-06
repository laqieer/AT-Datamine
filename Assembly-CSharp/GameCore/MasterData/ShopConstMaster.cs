// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ShopConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001185")]
  [Serializable]
  public sealed class ShopConstMaster : BaseMaster<ShopConstData>
  {
    [Token(Token = "0x60064B1")]
    [Address(RVA = "0x4AF1D28", Offset = "0x4AF1D28", VA = "0x4AF1D28")]
    public IReadOnlyDictionary<int, ShopConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ShopConstData>) null;
    }

    [Token(Token = "0x60064B2")]
    [Address(RVA = "0x4AF1D30", Offset = "0x4AF1D30", VA = "0x4AF1D30", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60064B3")]
    [Address(RVA = "0x4AF1E0C", Offset = "0x4AF1E0C", VA = "0x4AF1E0C", Slot = "5")]
    protected override ShopConstData LoadEntity(IMasterDataReader reader) => (ShopConstData) null;

    [Token(Token = "0x60064B4")]
    [Address(RVA = "0x4AF1D98", Offset = "0x4AF1D98", VA = "0x4AF1D98")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x17000F3D")]
    public ShopConstData Data
    {
      [Token(Token = "0x60064B5"), Address(RVA = "0x4AF1E64", Offset = "0x4AF1E64", VA = "0x4AF1E64")] get
      {
        return (ShopConstData) null;
      }
      [Token(Token = "0x60064B6"), Address(RVA = "0x4AF1E6C", Offset = "0x4AF1E6C", VA = "0x4AF1E6C")] private set
      {
      }
    }

    [Token(Token = "0x60064B7")]
    [Address(RVA = "0x4AF1E74", Offset = "0x4AF1E74", VA = "0x4AF1E74")]
    public ShopConstMaster()
    {
    }
  }
}
