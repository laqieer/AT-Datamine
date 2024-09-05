// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CustomSkillCategoryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011A6")]
  [Serializable]
  public sealed class CustomSkillCategoryData : IMasterDataEntity
  {
    [Token(Token = "0x40054F5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054F6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public SkillCategoryTypeEnum category;
    [Token(Token = "0x40054F7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int maxCount;

    [Token(Token = "0x17000F47")]
    public int Key
    {
      [Token(Token = "0x6006525"), Address(RVA = "0x4AF6150", Offset = "0x4AF6150", VA = "0x4AF6150", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006526")]
    [Address(RVA = "0x4AF6158", Offset = "0x4AF6158", VA = "0x4AF6158", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006527")]
    [Address(RVA = "0x4AF62C4", Offset = "0x4AF62C4", VA = "0x4AF62C4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006528")]
    [Address(RVA = "0x4AF6358", Offset = "0x4AF6358", VA = "0x4AF6358")]
    public CustomSkillCategoryData()
    {
    }
  }
}
