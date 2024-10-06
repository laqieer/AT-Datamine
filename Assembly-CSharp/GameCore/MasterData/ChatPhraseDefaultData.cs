// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChatPhraseDefaultData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E77")]
  [Serializable]
  public sealed class ChatPhraseDefaultData : IMasterDataEntity
  {
    [Token(Token = "0x40045F1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40045F2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int slot;
    [Token(Token = "0x40045F3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string content;

    [Token(Token = "0x17000D1D")]
    public int Key
    {
      [Token(Token = "0x6005836"), Address(RVA = "0x3E4701C", Offset = "0x3E4701C", VA = "0x3E4701C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005837")]
    [Address(RVA = "0x3E47024", Offset = "0x3E47024", VA = "0x3E47024", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005838")]
    [Address(RVA = "0x3E47190", Offset = "0x3E47190", VA = "0x3E47190", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005839")]
    [Address(RVA = "0x3E47228", Offset = "0x3E47228", VA = "0x3E47228")]
    public ChatPhraseDefaultData()
    {
    }
  }
}
