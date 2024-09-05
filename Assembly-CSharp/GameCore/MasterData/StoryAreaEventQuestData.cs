// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaEventQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011DF")]
  [Serializable]
  public sealed class StoryAreaEventQuestData : IMasterDataEntity
  {
    [Token(Token = "0x40055C7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40055C8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int sequence;
    [Token(Token = "0x40055C9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40055CA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int nextQuest;

    [Token(Token = "0x17000F69")]
    public int Key
    {
      [Token(Token = "0x600662C"), Address(RVA = "0x4D22E2C", Offset = "0x4D22E2C", VA = "0x4D22E2C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600662D")]
    [Address(RVA = "0x4D22E34", Offset = "0x4D22E34", VA = "0x4D22E34", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600662E")]
    [Address(RVA = "0x4D23000", Offset = "0x4D23000", VA = "0x4D23000", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F6A")]
    public string Title
    {
      [Token(Token = "0x600662F"), Address(RVA = "0x4D230A8", Offset = "0x4D230A8", VA = "0x4D230A8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F6B")]
    public string DescriptionText
    {
      [Token(Token = "0x6006630"), Address(RVA = "0x4D23184", Offset = "0x4D23184", VA = "0x4D23184")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006631")]
    [Address(RVA = "0x4D23260", Offset = "0x4D23260", VA = "0x4D23260")]
    public StoryAreaEventQuestData()
    {
    }
  }
}
