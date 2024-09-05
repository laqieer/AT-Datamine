// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PlayerConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010BE")]
  [Serializable]
  public sealed class PlayerConstMaster : BaseMaster<PlayerConstData>
  {
    [Token(Token = "0x60060CB")]
    [Address(RVA = "0x28DAA28", Offset = "0x28DAA28", VA = "0x28DAA28")]
    public IReadOnlyDictionary<int, PlayerConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, PlayerConstData>) null;
    }

    [Token(Token = "0x60060CC")]
    [Address(RVA = "0x28DAA30", Offset = "0x28DAA30", VA = "0x28DAA30", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60060CD")]
    [Address(RVA = "0x28DAB0C", Offset = "0x28DAB0C", VA = "0x28DAB0C", Slot = "5")]
    protected override PlayerConstData LoadEntity(IMasterDataReader reader)
    {
      return (PlayerConstData) null;
    }

    [Token(Token = "0x60060CE")]
    [Address(RVA = "0x28DAA98", Offset = "0x28DAA98", VA = "0x28DAA98")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x17000E6B")]
    public PlayerConstData Data
    {
      [Token(Token = "0x60060CF"), Address(RVA = "0x28DAB64", Offset = "0x28DAB64", VA = "0x28DAB64")] get
      {
        return (PlayerConstData) null;
      }
      [Token(Token = "0x60060D0"), Address(RVA = "0x28DAB6C", Offset = "0x28DAB6C", VA = "0x28DAB6C")] private set
      {
      }
    }

    [Token(Token = "0x60060D1")]
    [Address(RVA = "0x28DAB74", Offset = "0x28DAB74", VA = "0x28DAB74")]
    public PlayerConstMaster()
    {
    }
  }
}
