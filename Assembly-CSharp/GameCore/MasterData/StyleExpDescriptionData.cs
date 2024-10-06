// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleExpDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013B0")]
  [Serializable]
  public sealed class StyleExpDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4005BB7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005BB8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int styleExp;
    [Token(Token = "0x4005BB9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4005BBA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int from;
    [Token(Token = "0x4005BBB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int to;

    [Token(Token = "0x17001098")]
    public int Key
    {
      [Token(Token = "0x6006E96"), Address(RVA = "0x4708274", Offset = "0x4708274", VA = "0x4708274", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E97")]
    [Address(RVA = "0x470827C", Offset = "0x470827C", VA = "0x470827C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006E98")]
    [Address(RVA = "0x47084A8", Offset = "0x47084A8", VA = "0x47084A8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006E99")]
    [Address(RVA = "0x470855C", Offset = "0x470855C", VA = "0x470855C")]
    public StyleExpDescriptionData()
    {
    }
  }
}
