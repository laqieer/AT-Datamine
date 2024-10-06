// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionIconTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200125C")]
  [Serializable]
  public sealed class StoryFreeActionIconTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40057D3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40057D4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40057D5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string textureName;
    [Token(Token = "0x40057D6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float distance;

    [Token(Token = "0x17000FBE")]
    public int Key
    {
      [Token(Token = "0x6006865"), Address(RVA = "0x4D38730", Offset = "0x4D38730", VA = "0x4D38730", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006866")]
    [Address(RVA = "0x4D38738", Offset = "0x4D38738", VA = "0x4D38738", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006867")]
    [Address(RVA = "0x4D38904", Offset = "0x4D38904", VA = "0x4D38904", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006868")]
    [Address(RVA = "0x4D389B0", Offset = "0x4D389B0", VA = "0x4D389B0")]
    public StoryFreeActionIconTypeData()
    {
    }
  }
}
