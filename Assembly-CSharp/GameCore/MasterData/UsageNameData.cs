// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.UsageNameData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200106F")]
  [Serializable]
  public sealed class UsageNameData : IMasterDataEntity
  {
    [Token(Token = "0x400514D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400514E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string usageName;

    [Token(Token = "0x17000E26")]
    public int Key
    {
      [Token(Token = "0x6005F54"), Address(RVA = "0x28CD088", Offset = "0x28CD088", VA = "0x28CD088", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F55")]
    [Address(RVA = "0x28CD090", Offset = "0x28CD090", VA = "0x28CD090", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F56")]
    [Address(RVA = "0x28CD19C", Offset = "0x28CD19C", VA = "0x28CD19C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E27")]
    public string UsageName
    {
      [Token(Token = "0x6005F57"), Address(RVA = "0x28CD224", Offset = "0x28CD224", VA = "0x28CD224")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005F58")]
    [Address(RVA = "0x28CD300", Offset = "0x28CD300", VA = "0x28CD300")]
    public UsageNameData()
    {
    }
  }
}
