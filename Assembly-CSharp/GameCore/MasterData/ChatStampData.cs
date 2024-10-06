// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChatStampData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E80")]
  [Serializable]
  public sealed class ChatStampData : IMasterDataEntity
  {
    [Token(Token = "0x4004601")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004602")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004603")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string imageName;
    [Token(Token = "0x4004604")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string sound;

    [Token(Token = "0x17000D20")]
    public int Key
    {
      [Token(Token = "0x6005859"), Address(RVA = "0x3E482E4", Offset = "0x3E482E4", VA = "0x3E482E4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600585A")]
    [Address(RVA = "0x3E482EC", Offset = "0x3E482EC", VA = "0x3E482EC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600585B")]
    [Address(RVA = "0x3E484B8", Offset = "0x3E484B8", VA = "0x3E484B8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600585C")]
    [Address(RVA = "0x3E48568", Offset = "0x3E48568", VA = "0x3E48568")]
    public ChatStampData()
    {
    }
  }
}
