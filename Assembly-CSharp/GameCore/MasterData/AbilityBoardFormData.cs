// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardFormData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200134A")]
  [Serializable]
  public sealed class AbilityBoardFormData : IMasterDataEntity
  {
    [Token(Token = "0x4005ACD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005ACE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string resource;

    [Token(Token = "0x17001068")]
    public int Key
    {
      [Token(Token = "0x6006CBF"), Address(RVA = "0x46F691C", Offset = "0x46F691C", VA = "0x46F691C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006CC0")]
    [Address(RVA = "0x46F6924", Offset = "0x46F6924", VA = "0x46F6924", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006CC1")]
    [Address(RVA = "0x46F6A30", Offset = "0x46F6A30", VA = "0x46F6A30", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006CC2")]
    [Address(RVA = "0x46F6AB8", Offset = "0x46F6AB8", VA = "0x46F6AB8")]
    public AbilityBoardFormData()
    {
    }
  }
}
