// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyTimeslotData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200108D")]
  [Serializable]
  public sealed class LobbyTimeslotData : IMasterDataEntity
  {
    [Token(Token = "0x40051C4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051C5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40051C6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int beginMinute;
    [Token(Token = "0x40051C7")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int endMinute;

    [Token(Token = "0x17000E4E")]
    public int Key
    {
      [Token(Token = "0x6005FF2"), Address(RVA = "0x28D3434", Offset = "0x28D3434", VA = "0x28D3434", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005FF3")]
    [Address(RVA = "0x28D343C", Offset = "0x28D343C", VA = "0x28D343C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005FF4")]
    [Address(RVA = "0x28D3608", Offset = "0x28D3608", VA = "0x28D3608", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005FF5")]
    [Address(RVA = "0x28D36B0", Offset = "0x28D36B0", VA = "0x28D36B0")]
    public LobbyTimeslotData()
    {
    }
  }
}
