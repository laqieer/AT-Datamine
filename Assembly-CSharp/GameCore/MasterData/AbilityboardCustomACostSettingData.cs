// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityboardCustomACostSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001339")]
  [Serializable]
  public sealed class AbilityboardCustomACostSettingData : IMasterDataEntity
  {
    [Token(Token = "0x4005A9E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A9F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int itemId;
    [Token(Token = "0x4005AA0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int elementType;
    [Token(Token = "0x4005AA1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int moldType;

    [Token(Token = "0x17001061")]
    public int Key
    {
      [Token(Token = "0x6006C72"), Address(RVA = "0x46F38B0", Offset = "0x46F38B0", VA = "0x46F38B0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C73")]
    [Address(RVA = "0x46F38B8", Offset = "0x46F38B8", VA = "0x46F38B8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C74")]
    [Address(RVA = "0x46F3A84", Offset = "0x46F3A84", VA = "0x46F3A84", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006C75")]
    [Address(RVA = "0x46F3B28", Offset = "0x46F3B28", VA = "0x46F3B28")]
    public AbilityboardCustomACostSettingData()
    {
    }
  }
}
