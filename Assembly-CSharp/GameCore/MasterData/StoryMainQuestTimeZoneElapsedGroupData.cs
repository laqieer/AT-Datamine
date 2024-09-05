// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestTimeZoneElapsedGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012B0")]
  [Serializable]
  public sealed class StoryMainQuestTimeZoneElapsedGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4005902")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005903")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x4005904")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int paramID;
    [Token(Token = "0x4005905")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public bool flag;
    [Token(Token = "0x4005906")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int routteID;
    [Token(Token = "0x4005907")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int sequenceBegin;
    [Token(Token = "0x4005908")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int sequenceEnd;
    [Token(Token = "0x4005909")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int timeZone;

    [Token(Token = "0x17001009")]
    public int Key
    {
      [Token(Token = "0x6006A1D"), Address(RVA = "0x48D6784", Offset = "0x48D6784", VA = "0x48D6784", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A1E")]
    [Address(RVA = "0x48D678C", Offset = "0x48D678C", VA = "0x48D678C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A1F")]
    [Address(RVA = "0x48D6ADC", Offset = "0x48D6ADC", VA = "0x48D6ADC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A20")]
    [Address(RVA = "0x48D6BC0", Offset = "0x48D6BC0", VA = "0x48D6BC0")]
    public StoryMainQuestTimeZoneElapsedGroupData()
    {
    }
  }
}
