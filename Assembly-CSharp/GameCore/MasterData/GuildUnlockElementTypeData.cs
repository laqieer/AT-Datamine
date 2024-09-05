// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildUnlockElementTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FD2")]
  [Serializable]
  public sealed class GuildUnlockElementTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004F65")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F66")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000DAB")]
    public int Key
    {
      [Token(Token = "0x6005C8C"), Address(RVA = "0x278C6FC", Offset = "0x278C6FC", VA = "0x278C6FC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C8D")]
    [Address(RVA = "0x278C704", Offset = "0x278C704", VA = "0x278C704", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C8E")]
    [Address(RVA = "0x278C810", Offset = "0x278C810", VA = "0x278C810", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DAC")]
    public string Name
    {
      [Token(Token = "0x6005C8F"), Address(RVA = "0x278C898", Offset = "0x278C898", VA = "0x278C898")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005C90")]
    [Address(RVA = "0x278C974", Offset = "0x278C974", VA = "0x278C974")]
    public GuildUnlockElementTypeData()
    {
    }
  }
}
