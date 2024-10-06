// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleBadStatusDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E00")]
  [Serializable]
  public sealed class BattleBadStatusDetailData : IMasterDataEntity, IBadStatusData
  {
    [Token(Token = "0x40042DE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40042DF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public BattleBadStatusTypeEnum type;
    [Token(Token = "0x40042E0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int context1;
    [Token(Token = "0x40042E1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int context2;
    [Token(Token = "0x40042E2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int context3;
    [Token(Token = "0x40042E3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int context4;
    [Token(Token = "0x40042E4")]
    [FieldOffset(Offset = "0x28")]
    private int[] badStatusParams;

    [Token(Token = "0x17000C3E")]
    public int Key
    {
      [Token(Token = "0x6005565"), Address(RVA = "0x3AB0360", Offset = "0x3AB0360", VA = "0x3AB0360", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005566")]
    [Address(RVA = "0x3AB0368", Offset = "0x3AB0368", VA = "0x3AB0368", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005567")]
    [Address(RVA = "0x3AB05F4", Offset = "0x3AB05F4", VA = "0x3AB05F4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C3F")]
    public BattleBadStatusTypeEnum Type
    {
      [Token(Token = "0x6005568"), Address(RVA = "0x3AB06B8", Offset = "0x3AB06B8", VA = "0x3AB06B8", Slot = "7")] get
      {
        return new BattleBadStatusTypeEnum();
      }
    }

    [Token(Token = "0x17000C40")]
    public IReadOnlyList<int> BadStatusParams
    {
      [Token(Token = "0x6005569"), Address(RVA = "0x3AB06C0", Offset = "0x3AB06C0", VA = "0x3AB06C0")] get
      {
        return (IReadOnlyList<int>) null;
      }
    }

    [Token(Token = "0x600556A")]
    [Address(RVA = "0x3AAFF74", Offset = "0x3AAFF74", VA = "0x3AAFF74")]
    public void CollectParams()
    {
    }

    [Token(Token = "0x17000C41")]
    public string Name
    {
      [Token(Token = "0x600556B"), Address(RVA = "0x3AB06C8", Offset = "0x3AB06C8", VA = "0x3AB06C8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600556C")]
    [Address(RVA = "0x3AB07A4", Offset = "0x3AB07A4", VA = "0x3AB07A4")]
    public BattleBadStatusDetailData()
    {
    }
  }
}
