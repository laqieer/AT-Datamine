// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CharacterVoiceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001394")]
  [Serializable]
  public sealed class CharacterVoiceData : IMasterDataEntity
  {
    [Token(Token = "0x4005B6C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B6D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17001090")]
    public int Key
    {
      [Token(Token = "0x6006E0C"), Address(RVA = "0x47019A4", Offset = "0x47019A4", VA = "0x47019A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E0D")]
    [Address(RVA = "0x47019AC", Offset = "0x47019AC", VA = "0x47019AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006E0E")]
    [Address(RVA = "0x4701AB8", Offset = "0x4701AB8", VA = "0x4701AB8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006E0F")]
    [Address(RVA = "0x4701B40", Offset = "0x4701B40", VA = "0x4701B40")]
    public CharacterVoiceData()
    {
    }
  }
}
