// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChatConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E75")]
  [Serializable]
  public sealed class ChatConstData : IMasterDataEntity
  {
    [Token(Token = "0x40045E6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40045E7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int postThrottle;
    [Token(Token = "0x40045E8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int logMax;
    [Token(Token = "0x40045E9")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int postLengthMax;
    [Token(Token = "0x40045EA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int phraseLengthMax;
    [Token(Token = "0x40045EB")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int phraseSlotNum;
    [Token(Token = "0x40045EC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int historyPinNum;
    [Token(Token = "0x40045ED")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int historyLogNum;
    [Token(Token = "0x40045EE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int simpleMessageShowSecond;
    [Token(Token = "0x40045EF")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int guildInviteRoomID;
    [Token(Token = "0x40045F0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int guildInviteLengthMax;

    [Token(Token = "0x17000D1C")]
    public int Key
    {
      [Token(Token = "0x600582E"), Address(RVA = "0x3E46984", Offset = "0x3E46984", VA = "0x3E46984", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600582F")]
    [Address(RVA = "0x3E4698C", Offset = "0x3E4698C", VA = "0x3E4698C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005830")]
    [Address(RVA = "0x3E46DF8", Offset = "0x3E46DF8", VA = "0x3E46DF8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005831")]
    [Address(RVA = "0x3E46F0C", Offset = "0x3E46F0C", VA = "0x3E46F0C")]
    public ChatConstData()
    {
    }
  }
}
