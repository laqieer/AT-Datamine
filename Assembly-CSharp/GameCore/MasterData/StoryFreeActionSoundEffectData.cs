// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionSoundEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200127E")]
  [Serializable]
  public sealed class StoryFreeActionSoundEffectData : IMasterDataEntity
  {
    [Token(Token = "0x4005865")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005866")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupLabel;
    [Token(Token = "0x4005867")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int targetObject;
    [Token(Token = "0x4005868")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int soundObject;

    [Token(Token = "0x17000FEA")]
    public int Key
    {
      [Token(Token = "0x6006921"), Address(RVA = "0x48CD10C", Offset = "0x48CD10C", VA = "0x48CD10C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006922")]
    [Address(RVA = "0x48CD114", Offset = "0x48CD114", VA = "0x48CD114", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006923")]
    [Address(RVA = "0x48CD2E0", Offset = "0x48CD2E0", VA = "0x48CD2E0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006924")]
    [Address(RVA = "0x48CD384", Offset = "0x48CD384", VA = "0x48CD384")]
    public StoryFreeActionSoundEffectData()
    {
    }
  }
}
