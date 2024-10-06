// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ButtonLongPressSEData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E85")]
  [Serializable]
  public sealed class ButtonLongPressSEData : IMasterDataEntity
  {
    [Token(Token = "0x400460F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004610")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public ButtonLongPressSETypeEnum ButtonLongPressSEType;
    [Token(Token = "0x4004611")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string SEName;

    [Token(Token = "0x17000D22")]
    public int Key
    {
      [Token(Token = "0x6005869"), Address(RVA = "0x3E48A64", Offset = "0x3E48A64", VA = "0x3E48A64", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600586A")]
    [Address(RVA = "0x3E48A6C", Offset = "0x3E48A6C", VA = "0x3E48A6C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600586B")]
    [Address(RVA = "0x3E48CA8", Offset = "0x3E48CA8", VA = "0x3E48CA8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600586C")]
    [Address(RVA = "0x3E48D40", Offset = "0x3E48D40", VA = "0x3E48D40")]
    public ButtonLongPressSEData()
    {
    }
  }
}
