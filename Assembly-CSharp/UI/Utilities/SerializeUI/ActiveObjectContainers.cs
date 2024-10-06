// Decompiled with JetBrains decompiler
// Type: UI.Utilities.SerializeUI.ActiveObjectContainers
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
  [Token(Token = "0x2000893")]
  [Serializable]
  public class ActiveObjectContainers
  {
    [Token(Token = "0x400285C")]
    [FieldOffset(Offset = "0x10")]
    private List<ActiveObjectContainers.Argument> arguments;
    [Token(Token = "0x400285D")]
    [FieldOffset(Offset = "0x18")]
    private Queue<int?> integerArgumentQueue;
    [Token(Token = "0x400285E")]
    [FieldOffset(Offset = "0x20")]
    private Queue<string> stringArgumentQueue;
    [Token(Token = "0x400285F")]
    [FieldOffset(Offset = "0x28")]
    private Queue<DateTime?> dateTimeArgumentQueue;
    [Token(Token = "0x4002860")]
    [FieldOffset(Offset = "0x30")]
    private Queue<bool?> booleanArgumentQueue;
    [Token(Token = "0x4002861")]
    [FieldOffset(Offset = "0x38")]
    private List<bool?> evaluationResults;
    [Token(Token = "0x4002862")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<ActiveObjectParameter> elements;

    [Token(Token = "0x6003106")]
    [Address(RVA = "0x3C12EB0", Offset = "0x3C12EB0", VA = "0x3C12EB0")]
    public ActiveObjectContainers Set(
      int? intValue = null,
      string stringValue = null,
      DateTime? dateTimeValue = null,
      bool? booleanValue = null)
    {
      return (ActiveObjectContainers) null;
    }

    [Token(Token = "0x6003107")]
    [Address(RVA = "0x3C130FC", Offset = "0x3C130FC", VA = "0x3C130FC")]
    public ActiveObjectContainers SetInteger(int? value) => (ActiveObjectContainers) null;

    [Token(Token = "0x6003108")]
    [Address(RVA = "0x3C131F0", Offset = "0x3C131F0", VA = "0x3C131F0")]
    public ActiveObjectContainers SetString(string value) => (ActiveObjectContainers) null;

    [Token(Token = "0x6003109")]
    [Address(RVA = "0x3C1328C", Offset = "0x3C1328C", VA = "0x3C1328C")]
    public ActiveObjectContainers SetDateTime(DateTime? value) => (ActiveObjectContainers) null;

    [Token(Token = "0x600310A")]
    [Address(RVA = "0x3C13384", Offset = "0x3C13384", VA = "0x3C13384")]
    public ActiveObjectContainers SetBoolean(bool? value) => (ActiveObjectContainers) null;

    [Token(Token = "0x600310B")]
    [Address(RVA = "0x3C13474", Offset = "0x3C13474", VA = "0x3C13474")]
    public ActiveObjectContainers Evaluation(ActiveObjectContainers.EvaluationType type)
    {
      return (ActiveObjectContainers) null;
    }

    [Token(Token = "0x600310C")]
    [Address(RVA = "0x3C13C8C", Offset = "0x3C13C8C", VA = "0x3C13C8C")]
    public void Active()
    {
    }

    [Token(Token = "0x600310D")]
    [Address(RVA = "0x3C14010", Offset = "0x3C14010", VA = "0x3C14010")]
    public void Inactive()
    {
    }

    [Token(Token = "0x600310E")]
    [Address(RVA = "0x3C14194", Offset = "0x3C14194", VA = "0x3C14194")]
    public void GetObjects(ref List<GameObject> gameObjects)
    {
    }

    [Token(Token = "0x600310F")]
    [Address(RVA = "0x3C143B0", Offset = "0x3C143B0", VA = "0x3C143B0")]
    public void Active(
      int? integerValue,
      DateTime? dateTimeValue = null,
      string stringValue = null,
      bool? booleanValue = null)
    {
    }

    [Token(Token = "0x6003110")]
    [Address(RVA = "0x3C144BC", Offset = "0x3C144BC", VA = "0x3C144BC")]
    public void Active(DateTime? value)
    {
    }

    [Token(Token = "0x6003111")]
    [Address(RVA = "0x3C145A4", Offset = "0x3C145A4", VA = "0x3C145A4")]
    public void Active(string value)
    {
    }

    [Token(Token = "0x6003112")]
    [Address(RVA = "0x3C14688", Offset = "0x3C14688", VA = "0x3C14688")]
    public void Active(bool? value)
    {
    }

    [Token(Token = "0x6003113")]
    [Address(RVA = "0x3C1476C", Offset = "0x3C1476C", VA = "0x3C1476C")]
    public void ForceActive()
    {
    }

    [Token(Token = "0x6003114")]
    [Address(RVA = "0x3C1486C", Offset = "0x3C1486C", VA = "0x3C1486C")]
    public void ForceInactive()
    {
    }

    [Token(Token = "0x6003115")]
    [Address(RVA = "0x3C1496C", Offset = "0x3C1496C", VA = "0x3C1496C")]
    public ActiveObjectContainers()
    {
    }

    [Token(Token = "0x2000894")]
    private class Argument
    {
      [Token(Token = "0x4002863")]
      [FieldOffset(Offset = "0x10")]
      public int? Integer;
      [Token(Token = "0x4002864")]
      [FieldOffset(Offset = "0x18")]
      public string String;
      [Token(Token = "0x4002865")]
      [FieldOffset(Offset = "0x20")]
      public DateTime? DateTime;
      [Token(Token = "0x4002866")]
      [FieldOffset(Offset = "0x30")]
      public bool? Boolean;

      [Token(Token = "0x6003117")]
      [Address(RVA = "0x3C13BC4", Offset = "0x3C13BC4", VA = "0x3C13BC4")]
      public Argument(
        int? intValue = null,
        string stringValue = null,
        DateTime? dateTimeValue = null,
        bool? booleanValue = null)
      {
      }
    }

    [Token(Token = "0x2000895")]
    public enum EvaluationType
    {
      [Token(Token = "0x4002868")] Any,
      [Token(Token = "0x4002869")] All,
    }
  }
}
