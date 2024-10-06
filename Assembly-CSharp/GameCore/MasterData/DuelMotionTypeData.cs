// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.DuelMotionTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EE3")]
  [Serializable]
  public sealed class DuelMotionTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40048F5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40048F6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D46")]
    public int Key
    {
      [Token(Token = "0x6005956"), Address(RVA = "0x3C31848", Offset = "0x3C31848", VA = "0x3C31848", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005957")]
    [Address(RVA = "0x3C31850", Offset = "0x3C31850", VA = "0x3C31850", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005958")]
    [Address(RVA = "0x3C3195C", Offset = "0x3C3195C", VA = "0x3C3195C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005959")]
    [Address(RVA = "0x3C319E4", Offset = "0x3C319E4", VA = "0x3C319E4")]
    public DuelMotionTypeData()
    {
    }
  }
}
