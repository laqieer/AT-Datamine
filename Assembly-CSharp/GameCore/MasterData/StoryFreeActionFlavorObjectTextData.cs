// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionFlavorObjectTextData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200125A")]
  [Serializable]
  public sealed class StoryFreeActionFlavorObjectTextData : IMasterDataEntity
  {
    [Token(Token = "0x40057D0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40057D1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int flavorTextID;
    [Token(Token = "0x40057D2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int flavorText;

    [Token(Token = "0x17000FBD")]
    public int Key
    {
      [Token(Token = "0x600685D"), Address(RVA = "0x4D38418", Offset = "0x4D38418", VA = "0x4D38418", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600685E")]
    [Address(RVA = "0x4D38420", Offset = "0x4D38420", VA = "0x4D38420", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600685F")]
    [Address(RVA = "0x4D3858C", Offset = "0x4D3858C", VA = "0x4D3858C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006860")]
    [Address(RVA = "0x4D38620", Offset = "0x4D38620", VA = "0x4D38620")]
    public StoryFreeActionFlavorObjectTextData()
    {
    }
  }
}
