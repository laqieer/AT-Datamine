// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaReleaseConditionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001102")]
  [Serializable]
  public sealed class AreaQuestAreaReleaseConditionData : IMasterDataEntity
  {
    [Token(Token = "0x4005303")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005304")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string refName;

    [Token(Token = "0x17000EA3")]
    public int Key
    {
      [Token(Token = "0x6006211"), Address(RVA = "0x4ADBD28", Offset = "0x4ADBD28", VA = "0x4ADBD28", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006212")]
    [Address(RVA = "0x4ADBD30", Offset = "0x4ADBD30", VA = "0x4ADBD30", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006213")]
    [Address(RVA = "0x4ADBE3C", Offset = "0x4ADBE3C", VA = "0x4ADBE3C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006214")]
    [Address(RVA = "0x4ADBEC4", Offset = "0x4ADBEC4", VA = "0x4ADBEC4")]
    public AreaQuestAreaReleaseConditionData()
    {
    }
  }
}
