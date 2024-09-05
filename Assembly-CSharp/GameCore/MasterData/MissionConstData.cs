// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200109A")]
  [Serializable]
  public sealed class MissionConstData : IMasterDataEntity
  {
    [Token(Token = "0x40051E7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051E8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int dailyGroupId;
    [Token(Token = "0x40051E9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int weeklyGroupId;
    [Token(Token = "0x40051EA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int eventGroupId;
    [Token(Token = "0x40051EB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int mainGroupId;

    [Token(Token = "0x17000E55")]
    public int Key
    {
      [Token(Token = "0x6006029"), Address(RVA = "0x28D4DB0", Offset = "0x28D4DB0", VA = "0x28D4DB0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600602A")]
    [Address(RVA = "0x28D4DB8", Offset = "0x28D4DB8", VA = "0x28D4DB8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600602B")]
    [Address(RVA = "0x28D4FE4", Offset = "0x28D4FE4", VA = "0x28D4FE4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600602C")]
    [Address(RVA = "0x28D5098", Offset = "0x28D5098", VA = "0x28D5098")]
    public MissionConstData()
    {
    }
  }
}
