// Decompiled with JetBrains decompiler
// Type: UI.Utilities.SerializeUI.ActiveObjectParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UI.Utilities.SerializeUI
{
  [Token(Token = "0x200089B")]
  [Serializable]
  public class ActiveObjectParameter
  {
    [Token(Token = "0x4002874")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string description;
    [Token(Token = "0x4002875")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<GameObject> gameObjects;
    [Token(Token = "0x4002876")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ActiveObjectParameter.MatchPattern match;
    [Token(Token = "0x4002877")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<ActiveObjectInteger> integers;
    [Token(Token = "0x4002878")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<ActiveObjectDateTime> dateTimes;
    [Token(Token = "0x4002879")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<ActiveObjectString> strings;
    [Token(Token = "0x400287A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<ActiveObjectBoolean> booleans;

    [Token(Token = "0x1700071C")]
    public List<GameObject> GameObjects
    {
      [Token(Token = "0x6003124"), Address(RVA = "0x3C14E3C", Offset = "0x3C14E3C", VA = "0x3C14E3C")] get
      {
        return (List<GameObject>) null;
      }
    }

    [Token(Token = "0x6003125")]
    [Address(RVA = "0x3C14C9C", Offset = "0x3C14C9C", VA = "0x3C14C9C")]
    public void TargetActiveAndAnotherInActive(
      int? integerValue = null,
      DateTime? dateTimeValue = null,
      string stringValue = null,
      bool? booleanValue = null)
    {
    }

    [Token(Token = "0x6003126")]
    [Address(RVA = "0x3C14E4C", Offset = "0x3C14E4C", VA = "0x3C14E4C")]
    public void TargetInactiveAndAnotherActive(
      int? integerValue = null,
      DateTime? dateTimeValue = null,
      string stringValue = null,
      bool? booleanValue = null)
    {
    }

    [Token(Token = "0x6003127")]
    [Address(RVA = "0x3C13E10", Offset = "0x3C13E10", VA = "0x3C13E10")]
    public void Active()
    {
    }

    [Token(Token = "0x6003128")]
    [Address(RVA = "0x3C13F10", Offset = "0x3C13F10", VA = "0x3C13F10")]
    public void ForceInactive()
    {
    }

    [Token(Token = "0x6003129")]
    [Address(RVA = "0x3C13C70", Offset = "0x3C13C70", VA = "0x3C13C70")]
    public bool Judge(
      int index,
      int? integerValue = null,
      DateTime? dateTimeValue = null,
      string stringValue = null,
      bool? booleanValue = null)
    {
      return new bool();
    }

    [Token(Token = "0x600312A")]
    [Address(RVA = "0x3C15508", Offset = "0x3C15508", VA = "0x3C15508")]
    private bool AnyJudge(
      int index,
      int? integerValue = null,
      DateTime? dateTimeValue = null,
      string stringValue = null,
      bool? booleanValue = null)
    {
      return new bool();
    }

    [Token(Token = "0x600312B")]
    [Address(RVA = "0x3C14F78", Offset = "0x3C14F78", VA = "0x3C14F78")]
    private bool AllJudge(
      int index,
      int? integerValue = null,
      DateTime? dateTimeValue = null,
      string stringValue = null,
      bool? booleanValue = null)
    {
      return new bool();
    }

    [Token(Token = "0x600312C")]
    [Address(RVA = "0x3C15EF8", Offset = "0x3C15EF8", VA = "0x3C15EF8")]
    public ActiveObjectParameter()
    {
    }

    [Token(Token = "0x200089C")]
    public enum MatchPattern
    {
      [Token(Token = "0x400287C")] AnyTrue,
      [Token(Token = "0x400287D")] AllTrue,
      [Token(Token = "0x400287E")] AnyFalse,
      [Token(Token = "0x400287F")] AllFalse,
    }
  }
}
