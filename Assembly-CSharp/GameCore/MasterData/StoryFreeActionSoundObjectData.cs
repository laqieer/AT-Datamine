// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionSoundObjectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001280")]
  [Serializable]
  public sealed class StoryFreeActionSoundObjectData : IMasterDataEntity
  {
    [Token(Token = "0x4005869")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400586A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400586B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string fileName;
    [Token(Token = "0x400586C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string eventName;
    [Token(Token = "0x400586D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string prefabName;

    [Token(Token = "0x17000FEB")]
    public int Key
    {
      [Token(Token = "0x6006929"), Address(RVA = "0x48CD494", Offset = "0x48CD494", VA = "0x48CD494", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600692A")]
    [Address(RVA = "0x48CD49C", Offset = "0x48CD49C", VA = "0x48CD49C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600692B")]
    [Address(RVA = "0x48CD6C8", Offset = "0x48CD6C8", VA = "0x48CD6C8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600692C")]
    [Address(RVA = "0x48CD78C", Offset = "0x48CD78C", VA = "0x48CD78C")]
    public StoryFreeActionSoundObjectData()
    {
    }
  }
}
