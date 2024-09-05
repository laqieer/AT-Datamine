// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityWorkData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001234")]
  [Serializable]
  public sealed class StoryFacilityWorkData : IMasterDataEntity
  {
    [Token(Token = "0x40056F7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40056F8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int facilityAttachID;
    [Token(Token = "0x40056F9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40056FA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int ability;
    [Token(Token = "0x40056FB")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int rewardLabel;

    [Token(Token = "0x17000F97")]
    public int Key
    {
      [Token(Token = "0x600679E"), Address(RVA = "0x4D30F84", Offset = "0x4D30F84", VA = "0x4D30F84", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600679F")]
    [Address(RVA = "0x4D30F8C", Offset = "0x4D30F8C", VA = "0x4D30F8C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60067A0")]
    [Address(RVA = "0x4D311B8", Offset = "0x4D311B8", VA = "0x4D311B8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F98")]
    public string Text
    {
      [Token(Token = "0x60067A1"), Address(RVA = "0x4D31270", Offset = "0x4D31270", VA = "0x4D31270")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60067A2")]
    [Address(RVA = "0x4D3134C", Offset = "0x4D3134C", VA = "0x4D3134C")]
    public StoryFacilityWorkData()
    {
    }
  }
}
