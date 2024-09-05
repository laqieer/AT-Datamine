// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityboardCustomANodeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200133F")]
  [Serializable]
  public sealed class AbilityboardCustomANodeData : IMasterDataEntity
  {
    [Token(Token = "0x4005AAD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005AAE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int customAID;
    [Token(Token = "0x4005AAF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public MoldTypeEnum moldType;
    [Token(Token = "0x4005AB0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rawardType;
    [Token(Token = "0x4005AB1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int bonusRewardType;

    [Token(Token = "0x17001063")]
    public int Key
    {
      [Token(Token = "0x6006C90"), Address(RVA = "0x46F4DA8", Offset = "0x46F4DA8", VA = "0x46F4DA8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C91")]
    [Address(RVA = "0x46F4DB0", Offset = "0x46F4DB0", VA = "0x46F4DB0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C92")]
    [Address(RVA = "0x46F4FDC", Offset = "0x46F4FDC", VA = "0x46F4FDC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006C93")]
    [Address(RVA = "0x46F5090", Offset = "0x46F5090", VA = "0x46F5090")]
    public AbilityboardCustomANodeData()
    {
    }
  }
}
