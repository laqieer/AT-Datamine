// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAdvChoicesData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DC9")]
  [Serializable]
  public sealed class StoryAdvChoicesData : IMasterDataEntity
  {
    [Token(Token = "0x40041E9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40041EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string refName;
    [Token(Token = "0x40041EB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int type1;
    [Token(Token = "0x40041EC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int id1;
    [Token(Token = "0x40041ED")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int value1;
    [Token(Token = "0x40041EE")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int type2;
    [Token(Token = "0x40041EF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int id2;
    [Token(Token = "0x40041F0")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int value2;
    [Token(Token = "0x40041F1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int type3;
    [Token(Token = "0x40041F2")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int id3;
    [Token(Token = "0x40041F3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int value3;
    [Token(Token = "0x40041F4")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int type4;
    [Token(Token = "0x40041F5")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int id4;
    [Token(Token = "0x40041F6")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int value4;
    [Token(Token = "0x40041F7")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int type5;
    [Token(Token = "0x40041F8")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int id5;
    [Token(Token = "0x40041F9")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int value5;

    [Token(Token = "0x17000C06")]
    public int Key
    {
      [Token(Token = "0x6005439"), Address(RVA = "0x3AA2D44", Offset = "0x3AA2D44", VA = "0x3AA2D44", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600543A")]
    [Address(RVA = "0x3AA2D4C", Offset = "0x3AA2D4C", VA = "0x3AA2D4C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600543B")]
    [Address(RVA = "0x3AA33F8", Offset = "0x3AA33F8", VA = "0x3AA33F8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600543C")]
    [Address(RVA = "0x3AA3570", Offset = "0x3AA3570", VA = "0x3AA3570")]
    public StoryAdvChoicesData()
    {
    }
  }
}
