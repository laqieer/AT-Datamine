// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ElementTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EE7")]
  [Serializable]
  public sealed class ElementTypeData : IMasterDataEntity
  {
    [Token(Token = "0x400490F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004910")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004911")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string displayName;

    [Token(Token = "0x17000D47")]
    public int Key
    {
      [Token(Token = "0x600595E"), Address(RVA = "0x3C31AF4", Offset = "0x3C31AF4", VA = "0x3C31AF4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600595F")]
    [Address(RVA = "0x3C31AFC", Offset = "0x3C31AFC", VA = "0x3C31AFC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005960")]
    [Address(RVA = "0x3C31C68", Offset = "0x3C31C68", VA = "0x3C31C68", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005961")]
    [Address(RVA = "0x3C31D04", Offset = "0x3C31D04", VA = "0x3C31D04")]
    public ElementTypeData()
    {
    }
  }
}
