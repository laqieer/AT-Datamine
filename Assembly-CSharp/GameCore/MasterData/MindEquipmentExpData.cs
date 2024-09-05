// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MindEquipmentExpData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F5F")]
  [Serializable]
  public sealed class MindEquipmentExpData : IMasterDataEntity
  {
    [Token(Token = "0x4004D20")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D21")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004D22")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x4004D23")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;

    [Token(Token = "0x17000D68")]
    public int Key
    {
      [Token(Token = "0x6005A71"), Address(RVA = "0x3C3E340", Offset = "0x3C3E340", VA = "0x3C3E340", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A72")]
    [Address(RVA = "0x3C3E348", Offset = "0x3C3E348", VA = "0x3C3E348", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A73")]
    [Address(RVA = "0x3C3E514", Offset = "0x3C3E514", VA = "0x3C3E514", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005A74")]
    [Address(RVA = "0x3C3DDD0", Offset = "0x3C3DDD0", VA = "0x3C3DDD0")]
    public MindEquipmentExpData()
    {
    }
  }
}
