// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestCalendarElapsedData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001297")]
  [Serializable]
  public sealed class StoryMainQuestCalendarElapsedData : IMasterDataEntity
  {
    [Token(Token = "0x40058B6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40058B7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string label;
    [Token(Token = "0x40058B8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x40058B9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int paramID;

    [Token(Token = "0x17000FF5")]
    public int Key
    {
      [Token(Token = "0x600699A"), Address(RVA = "0x48D199C", Offset = "0x48D199C", VA = "0x48D199C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600699B")]
    [Address(RVA = "0x48D19A4", Offset = "0x48D19A4", VA = "0x48D19A4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600699C")]
    [Address(RVA = "0x48D1B70", Offset = "0x48D1B70", VA = "0x48D1B70", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600699D")]
    [Address(RVA = "0x48D1C18", Offset = "0x48D1C18", VA = "0x48D1C18")]
    public StoryMainQuestCalendarElapsedData()
    {
    }
  }
}
