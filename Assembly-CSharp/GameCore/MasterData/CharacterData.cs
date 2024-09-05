// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CharacterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200136A")]
  [Serializable]
  public sealed class CharacterData : IMasterDataEntity
  {
    [Token(Token = "0x4005B16")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B17")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string englishName;
    [Token(Token = "0x4005B18")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int defaultStyleId;
    [Token(Token = "0x4005B19")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int characterLimitRelease;
    [Token(Token = "0x4005B1A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int initialProficiency;
    [Token(Token = "0x4005B1B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string motifColor;
    [Token(Token = "0x4005B1C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public bool hasVoice;

    [Token(Token = "0x17001076")]
    public int Key
    {
      [Token(Token = "0x6006D51"), Address(RVA = "0x46FBB94", Offset = "0x46FBB94", VA = "0x46FBB94", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D52")]
    [Address(RVA = "0x46FBB9C", Offset = "0x46FBB9C", VA = "0x46FBB9C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D53")]
    [Address(RVA = "0x46FBE8C", Offset = "0x46FBE8C", VA = "0x46FBE8C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001077")]
    public string Name
    {
      [Token(Token = "0x6006D54"), Address(RVA = "0x46FBF68", Offset = "0x46FBF68", VA = "0x46FBF68")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006D55")]
    [Address(RVA = "0x46FC044", Offset = "0x46FC044", VA = "0x46FC044")]
    public IReadOnlyCollection<CharacterLimitReleaseDetailData> GetLimitReleaseList()
    {
      return (IReadOnlyCollection<CharacterLimitReleaseDetailData>) null;
    }

    [Token(Token = "0x6006D56")]
    [Address(RVA = "0x46FC0C8", Offset = "0x46FC0C8", VA = "0x46FC0C8")]
    public CharacterData()
    {
    }
  }
}
