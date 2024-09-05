// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestCalendarElapsedGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001293")]
  [Serializable]
  public sealed class StoryMainQuestCalendarElapsedGroupData : IMasterDataEntity
  {
    [Token(Token = "0x40058AC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40058AD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x40058AE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int param;
    [Token(Token = "0x40058AF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public bool flag;
    [Token(Token = "0x40058B0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int routteID;
    [Token(Token = "0x40058B1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int sequenceBegin;
    [Token(Token = "0x40058B2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int sequenceEnd;

    [Token(Token = "0x17000FF3")]
    public int Key
    {
      [Token(Token = "0x600698A"), Address(RVA = "0x48D11A4", Offset = "0x48D11A4", VA = "0x48D11A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600698B")]
    [Address(RVA = "0x48D11AC", Offset = "0x48D11AC", VA = "0x48D11AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600698C")]
    [Address(RVA = "0x48D149C", Offset = "0x48D149C", VA = "0x48D149C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600698D")]
    [Address(RVA = "0x48D1570", Offset = "0x48D1570", VA = "0x48D1570")]
    public StoryMainQuestCalendarElapsedGroupData()
    {
    }
  }
}
