// Decompiled with JetBrains decompiler
// Type: Battle.UI.Rewind.BattleRewindUnitMessageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.UI.Rewind
{
  [Token(Token = "0x2002469")]
  [Serializable]
  public class BattleRewindUnitMessageData
  {
    [Token(Token = "0x4009C2F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Tooltip("撤退ユニット文言タイプ")]
    public BattleRewindUnitMessageData.MessageType Type;
    [Token(Token = "0x4009C30")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Tooltip("撤退ユニット文言")]
    public string Message;

    [Token(Token = "0x600DF45")]
    [Address(RVA = "0x2018E7C", Offset = "0x2018E7C", VA = "0x2018E7C")]
    public BattleRewindUnitMessageData()
    {
    }

    [Token(Token = "0x200246A")]
    public enum MessageType
    {
      [Token(Token = "0x4009C32")] Lost,
      [Token(Token = "0x4009C33")] MultipleLost,
      [Token(Token = "0x4009C34")] DownFP,
      [Token(Token = "0x4009C35")] MultipleDownFP,
    }
  }
}
