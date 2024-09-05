// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionSoulTankData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FAC")]
  [Serializable]
  public sealed class ExpeditionSoulTankData : IMasterDataEntity
  {
    [Token(Token = "0x4004EE7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EE8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int soulType;
    [Token(Token = "0x4004EE9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004EEA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int storage;
    [Token(Token = "0x4004EEB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int paymentAmount;

    [Token(Token = "0x17000D94")]
    public int Key
    {
      [Token(Token = "0x6005BF9"), Address(RVA = "0x2787B5C", Offset = "0x2787B5C", VA = "0x2787B5C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005BFA")]
    [Address(RVA = "0x2787B64", Offset = "0x2787B64", VA = "0x2787B64", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005BFB")]
    [Address(RVA = "0x2787D90", Offset = "0x2787D90", VA = "0x2787D90", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005BFC")]
    [Address(RVA = "0x2787E44", Offset = "0x2787E44", VA = "0x2787E44")]
    public ExpeditionSoulTankData()
    {
    }
  }
}
