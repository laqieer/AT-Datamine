// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAbilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011C7")]
  [Serializable]
  public sealed class StoryAbilityData : IMasterDataEntity
  {
    [Token(Token = "0x4005580")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005581")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005582")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string condition;
    [Token(Token = "0x4005583")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int tutorialID;
    [Token(Token = "0x4005584")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x17000F59")]
    public int Key
    {
      [Token(Token = "0x60065BF"), Address(RVA = "0x4D1E804", Offset = "0x4D1E804", VA = "0x4D1E804", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60065C0")]
    [Address(RVA = "0x4D1E80C", Offset = "0x4D1E80C", VA = "0x4D1E80C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60065C1")]
    [Address(RVA = "0x4D1E9D8", Offset = "0x4D1E9D8", VA = "0x4D1E9D8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F5A")]
    public string Name
    {
      [Token(Token = "0x60065C2"), Address(RVA = "0x4D1EA84", Offset = "0x4D1EA84", VA = "0x4D1EA84")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F5B")]
    public string Discription
    {
      [Token(Token = "0x60065C3"), Address(RVA = "0x4D1EB60", Offset = "0x4D1EB60", VA = "0x4D1EB60")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60065C4")]
    [Address(RVA = "0x4D1EC3C", Offset = "0x4D1EC3C", VA = "0x4D1EC3C")]
    public StoryAbilityData()
    {
    }
  }
}
