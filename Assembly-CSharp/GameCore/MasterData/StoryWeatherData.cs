// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryWeatherData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012FE")]
  [Serializable]
  public sealed class StoryWeatherData : IMasterDataEntity
  {
    [Token(Token = "0x40059E3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40059E4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40059E5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int characterLookWeatherTypeID;

    [Token(Token = "0x17001038")]
    public int Key
    {
      [Token(Token = "0x6006B5C"), Address(RVA = "0x48E18DC", Offset = "0x48E18DC", VA = "0x48E18DC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B5D")]
    [Address(RVA = "0x48E18E4", Offset = "0x48E18E4", VA = "0x48E18E4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B5E")]
    [Address(RVA = "0x48E1A50", Offset = "0x48E1A50", VA = "0x48E1A50", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006B5F")]
    [Address(RVA = "0x48E1AE8", Offset = "0x48E1AE8", VA = "0x48E1AE8")]
    public StoryWeatherData()
    {
    }
  }
}
