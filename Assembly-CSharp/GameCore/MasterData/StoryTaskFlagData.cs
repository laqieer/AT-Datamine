// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryTaskFlagData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012F7")]
  [Serializable]
  public sealed class StoryTaskFlagData : IMasterDataEntity
  {
    [Token(Token = "0x40059D0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40059D1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40059D2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int value;

    [Token(Token = "0x17001035")]
    public int Key
    {
      [Token(Token = "0x6006B3F"), Address(RVA = "0x48E0C3C", Offset = "0x48E0C3C", VA = "0x48E0C3C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B40")]
    [Address(RVA = "0x48E0C44", Offset = "0x48E0C44", VA = "0x48E0C44", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B41")]
    [Address(RVA = "0x48E0DB0", Offset = "0x48E0DB0", VA = "0x48E0DB0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006B42")]
    [Address(RVA = "0x48E0E48", Offset = "0x48E0E48", VA = "0x48E0E48")]
    public StoryTaskFlagData()
    {
    }
  }
}
