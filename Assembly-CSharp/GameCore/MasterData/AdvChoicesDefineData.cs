// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvChoicesDefineData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DA6")]
  [Serializable]
  public sealed class AdvChoicesDefineData : IMasterDataEntity
  {
    [Token(Token = "0x4004172")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004173")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int advScene;
    [Token(Token = "0x4004174")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string messageId;

    [Token(Token = "0x17000BF4")]
    public int Key
    {
      [Token(Token = "0x600539B"), Address(RVA = "0x3A9B884", Offset = "0x3A9B884", VA = "0x3A9B884", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600539C")]
    [Address(RVA = "0x3A9B88C", Offset = "0x3A9B88C", VA = "0x3A9B88C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600539D")]
    [Address(RVA = "0x3A9B9F8", Offset = "0x3A9B9F8", VA = "0x3A9B9F8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600539E")]
    [Address(RVA = "0x3A9BA90", Offset = "0x3A9BA90", VA = "0x3A9BA90")]
    public AdvChoicesDefineData()
    {
    }
  }
}
