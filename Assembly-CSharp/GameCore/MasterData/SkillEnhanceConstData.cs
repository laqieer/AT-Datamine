// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillEnhanceConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F67")]
  [Serializable]
  public sealed class SkillEnhanceConstData : IMasterDataEntity
  {
    [Token(Token = "0x4004D84")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D85")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int maxTryCount;

    [Token(Token = "0x17000D6F")]
    public int Key
    {
      [Token(Token = "0x6005AA6"), Address(RVA = "0x3C422F8", Offset = "0x3C422F8", VA = "0x3C422F8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005AA7")]
    [Address(RVA = "0x3C42300", Offset = "0x3C42300", VA = "0x3C42300", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005AA8")]
    [Address(RVA = "0x3C4240C", Offset = "0x3C4240C", VA = "0x3C4240C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005AA9")]
    [Address(RVA = "0x3C42490", Offset = "0x3C42490", VA = "0x3C42490")]
    public SkillEnhanceConstData()
    {
    }
  }
}
