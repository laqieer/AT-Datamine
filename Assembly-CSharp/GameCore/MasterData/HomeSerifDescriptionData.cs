// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.HomeSerifDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001029")]
  [Serializable]
  public sealed class HomeSerifDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x400503F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005040")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int homeSerif;
    [Token(Token = "0x4005041")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int timelineActId;
    [Token(Token = "0x4005042")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string voiceBankId;
    [Token(Token = "0x4005043")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string voiceId;
    [Token(Token = "0x4005044")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int timeAnnouncement;
    [Token(Token = "0x4005045")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public bool isSoliloquy;
    [Token(Token = "0x4005046")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int eventSeason;
    [Token(Token = "0x4005047")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public bool isLoginBonus;

    [Token(Token = "0x17000DDC")]
    public int Key
    {
      [Token(Token = "0x6005E04"), Address(RVA = "0x27991F0", Offset = "0x27991F0", VA = "0x27991F0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E05")]
    [Address(RVA = "0x27991F8", Offset = "0x27991F8", VA = "0x27991F8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E06")]
    [Address(RVA = "0x27995AC", Offset = "0x27995AC", VA = "0x27995AC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DDD")]
    public string SerifText
    {
      [Token(Token = "0x6005E07"), Address(RVA = "0x27996A8", Offset = "0x27996A8", VA = "0x27996A8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005E08")]
    [Address(RVA = "0x2799784", Offset = "0x2799784", VA = "0x2799784")]
    public HomeSerifDescriptionData()
    {
    }
  }
}
