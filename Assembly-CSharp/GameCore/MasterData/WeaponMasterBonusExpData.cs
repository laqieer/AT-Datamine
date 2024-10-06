// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponMasterBonusExpData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010DB")]
  [Serializable]
  public sealed class WeaponMasterBonusExpData : IMasterDataEntity
  {
    [Token(Token = "0x400529B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400529C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int level;
    [Token(Token = "0x400529D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x400529E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;

    [Token(Token = "0x17000E7E")]
    public int Key
    {
      [Token(Token = "0x6006157"), Address(RVA = "0x28DFFDC", Offset = "0x28DFFDC", VA = "0x28DFFDC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006158")]
    [Address(RVA = "0x28DFFE4", Offset = "0x28DFFE4", VA = "0x28DFFE4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006159")]
    [Address(RVA = "0x28E01B0", Offset = "0x28E01B0", VA = "0x28E01B0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600615A")]
    [Address(RVA = "0x28E0254", Offset = "0x28E0254", VA = "0x28E0254")]
    public WeaponMasterBonusExpData()
    {
    }
  }
}
