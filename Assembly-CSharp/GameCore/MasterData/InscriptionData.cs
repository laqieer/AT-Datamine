// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.InscriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F57")]
  [Serializable]
  public sealed class InscriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004D0E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D0F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004D10")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int acquired;

    [Token(Token = "0x17000D65")]
    public int Key
    {
      [Token(Token = "0x6005A49"), Address(RVA = "0x3C3CB60", Offset = "0x3C3CB60", VA = "0x3C3CB60", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A4A")]
    [Address(RVA = "0x3C3CB68", Offset = "0x3C3CB68", VA = "0x3C3CB68", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A4B")]
    [Address(RVA = "0x3C3CCD4", Offset = "0x3C3CCD4", VA = "0x3C3CCD4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D66")]
    public string Name
    {
      [Token(Token = "0x6005A4C"), Address(RVA = "0x3C3CD6C", Offset = "0x3C3CD6C", VA = "0x3C3CD6C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005A4D")]
    [Address(RVA = "0x3C3CE48", Offset = "0x3C3CE48", VA = "0x3C3CE48")]
    public InscriptionData()
    {
    }
  }
}
