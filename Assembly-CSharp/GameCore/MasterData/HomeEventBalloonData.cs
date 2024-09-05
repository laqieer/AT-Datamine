// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.HomeEventBalloonData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001023")]
  [Serializable]
  public sealed class HomeEventBalloonData : IMasterDataEntity
  {
    [Token(Token = "0x400502B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400502C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int eventID;
    [Token(Token = "0x400502D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public EventBalloonTypeEnum eventType;
    [Token(Token = "0x400502E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x400502F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime endAt;
    [Token(Token = "0x4005030")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string image;

    [Token(Token = "0x17000DD7")]
    public int Key
    {
      [Token(Token = "0x6005DE8"), Address(RVA = "0x2798088", Offset = "0x2798088", VA = "0x2798088", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005DE9")]
    [Address(RVA = "0x2798090", Offset = "0x2798090", VA = "0x2798090", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005DEA")]
    [Address(RVA = "0x279831C", Offset = "0x279831C", VA = "0x279831C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005DEB")]
    [Address(RVA = "0x2797F80", Offset = "0x2797F80", VA = "0x2797F80")]
    public bool IsPlayableTime() => new bool();

    [Token(Token = "0x6005DEC")]
    [Address(RVA = "0x279843C", Offset = "0x279843C", VA = "0x279843C")]
    public HomeEventBalloonData()
    {
    }
  }
}
