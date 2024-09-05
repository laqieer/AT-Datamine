// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildStampData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200100E")]
  [Serializable]
  public sealed class GuildStampData : IMasterDataEntity
  {
    [Token(Token = "0x4004FEF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FF0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004FF1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int image;
    [Token(Token = "0x4004FF2")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public bool possession;

    [Token(Token = "0x17000DC5")]
    public int Key
    {
      [Token(Token = "0x6005D87"), Address(RVA = "0x27949B8", Offset = "0x27949B8", VA = "0x27949B8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D88")]
    [Address(RVA = "0x27949C0", Offset = "0x27949C0", VA = "0x27949C0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005D89")]
    [Address(RVA = "0x2794B90", Offset = "0x2794B90", VA = "0x2794B90", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005D8A")]
    [Address(RVA = "0x2794C38", Offset = "0x2794C38", VA = "0x2794C38")]
    public GuildStampData()
    {
    }
  }
}
