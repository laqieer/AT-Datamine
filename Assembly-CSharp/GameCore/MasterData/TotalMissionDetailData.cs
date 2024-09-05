// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TotalMissionDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010AF")]
  [Serializable]
  public sealed class TotalMissionDetailData : IMasterDataEntity
  {
    [Token(Token = "0x400521E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400521F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int tabID;
    [Token(Token = "0x4005220")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string borderValue;
    [Token(Token = "0x4005221")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int missionRewardID;

    [Token(Token = "0x17000E61")]
    public int Key
    {
      [Token(Token = "0x6006085"), Address(RVA = "0x28D80F0", Offset = "0x28D80F0", VA = "0x28D80F0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006086")]
    [Address(RVA = "0x28D80F8", Offset = "0x28D80F8", VA = "0x28D80F8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006087")]
    [Address(RVA = "0x28D82C4", Offset = "0x28D82C4", VA = "0x28D82C4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006088")]
    [Address(RVA = "0x28D836C", Offset = "0x28D836C", VA = "0x28D836C")]
    public TotalMissionDetailData()
    {
    }
  }
}
