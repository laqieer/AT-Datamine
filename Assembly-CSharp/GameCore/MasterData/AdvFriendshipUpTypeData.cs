// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvFriendshipUpTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DB3")]
  [Serializable]
  public sealed class AdvFriendshipUpTypeData : IMasterDataEntity
  {
    [Token(Token = "0x400419D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400419E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int minValue;
    [Token(Token = "0x400419F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int maxValue;
    [Token(Token = "0x40041A0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string seName;
    [Token(Token = "0x40041A1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int[] trackNums;

    [Token(Token = "0x17000BFA")]
    public int Key
    {
      [Token(Token = "0x60053D2"), Address(RVA = "0x3A9DCFC", Offset = "0x3A9DCFC", VA = "0x3A9DCFC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60053D3")]
    [Address(RVA = "0x3A9DD04", Offset = "0x3A9DD04", VA = "0x3A9DD04", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60053D4")]
    [Address(RVA = "0x3A9DFC0", Offset = "0x3A9DFC0", VA = "0x3A9DFC0")]
    public AdvFriendshipUpTypeData()
    {
    }
  }
}
