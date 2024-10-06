// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionAreaData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001245")]
  [Serializable]
  public sealed class StoryFreeActionAreaData : IMasterDataEntity
  {
    [Token(Token = "0x4005770")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005771")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x4005772")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int order;
    [Token(Token = "0x4005773")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int region;
    [Token(Token = "0x4005774")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int areaID;
    [Token(Token = "0x4005775")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int sameAreaClassificationID;

    [Token(Token = "0x17000FAE")]
    public int Key
    {
      [Token(Token = "0x60067EE"), Address(RVA = "0x4D33E60", Offset = "0x4D33E60", VA = "0x4D33E60", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60067EF")]
    [Address(RVA = "0x4D33E68", Offset = "0x4D33E68", VA = "0x4D33E68", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60067F0")]
    [Address(RVA = "0x4D340F4", Offset = "0x4D340F4", VA = "0x4D340F4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000FAF")]
    public string AreaName
    {
      [Token(Token = "0x60067F1"), Address(RVA = "0x4D341BC", Offset = "0x4D341BC", VA = "0x4D341BC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60067F2")]
    [Address(RVA = "0x4D34298", Offset = "0x4D34298", VA = "0x4D34298")]
    public StoryFreeActionAreaData()
    {
    }
  }
}
