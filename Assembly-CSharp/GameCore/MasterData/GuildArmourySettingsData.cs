// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildArmourySettingsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FBA")]
  [Serializable]
  public sealed class GuildArmourySettingsData : IMasterDataEntity
  {
    [Token(Token = "0x4004F1A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F1B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D9C")]
    public int Key
    {
      [Token(Token = "0x6005C43"), Address(RVA = "0x278A830", Offset = "0x278A830", VA = "0x278A830", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C44")]
    [Address(RVA = "0x278A838", Offset = "0x278A838", VA = "0x278A838", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C45")]
    [Address(RVA = "0x278A944", Offset = "0x278A944", VA = "0x278A944", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005C46")]
    [Address(RVA = "0x278A9CC", Offset = "0x278A9CC", VA = "0x278A9CC")]
    public GuildArmourySettingsData()
    {
    }
  }
}
