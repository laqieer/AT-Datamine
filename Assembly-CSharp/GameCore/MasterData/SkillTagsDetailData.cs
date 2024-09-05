// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillTagsDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011BF")]
  [Serializable]
  public sealed class SkillTagsDetailData : IMasterDataEntity
  {
    [Token(Token = "0x400556F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005570")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x4005571")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public SkillTagTypeEnum tag;

    [Token(Token = "0x17000F55")]
    public int Key
    {
      [Token(Token = "0x600659C"), Address(RVA = "0x4D1D6F4", Offset = "0x4D1D6F4", VA = "0x4D1D6F4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600659D")]
    [Address(RVA = "0x4D1D6FC", Offset = "0x4D1D6FC", VA = "0x4D1D6FC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600659E")]
    [Address(RVA = "0x4D1D868", Offset = "0x4D1D868", VA = "0x4D1D868", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600659F")]
    [Address(RVA = "0x4D1D8FC", Offset = "0x4D1D8FC", VA = "0x4D1D8FC")]
    public SkillTagsDetailData()
    {
    }
  }
}
