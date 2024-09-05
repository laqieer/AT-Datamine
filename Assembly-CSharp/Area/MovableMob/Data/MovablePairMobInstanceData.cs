// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Data.MovablePairMobInstanceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Instance;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Data
{
  [Token(Token = "0x200283D")]
  [Serializable]
  public class MovablePairMobInstanceData : MovableMobInstanceDataBase
  {
    [Token(Token = "0x400AB96")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MovableSingleMobInstanceData param1;
    [Token(Token = "0x400AB97")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private MovableSingleMobInstanceData param2;
    [Token(Token = "0x400AB98")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject soundObject;
    [Token(Token = "0x400AB99")]
    [FieldOffset(Offset = "0x30")]
    private string[] soundEvents;

    [Token(Token = "0x170037B7")]
    public MovableSingleMobInstanceData Param1
    {
      [Token(Token = "0x600FD58"), Address(RVA = "0x442E31C", Offset = "0x442E31C", VA = "0x442E31C")] get
      {
        return (MovableSingleMobInstanceData) null;
      }
    }

    [Token(Token = "0x170037B8")]
    public MovableSingleMobInstanceData Param2
    {
      [Token(Token = "0x600FD59"), Address(RVA = "0x442E324", Offset = "0x442E324", VA = "0x442E324")] get
      {
        return (MovableSingleMobInstanceData) null;
      }
    }

    [Token(Token = "0x170037B9")]
    public GameObject SoundObject
    {
      [Token(Token = "0x600FD5A"), Address(RVA = "0x442E32C", Offset = "0x442E32C", VA = "0x442E32C")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170037BA")]
    public string[] SoundEvents
    {
      [Token(Token = "0x600FD5B"), Address(RVA = "0x442E334", Offset = "0x442E334", VA = "0x442E334")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x600FD5C")]
    [Address(RVA = "0x442E33C", Offset = "0x442E33C", VA = "0x442E33C", Slot = "4")]
    public override MovableMobType GetMobType() => new MovableMobType();

    [Token(Token = "0x600FD5D")]
    [Address(RVA = "0x442E344", Offset = "0x442E344", VA = "0x442E344", Slot = "5")]
    public override MovableMobInstanceBase CreateInstance(
      MovableMobRouteHandler owner,
      IMovableMobAnchor startAnchor,
      Transform player)
    {
      return (MovableMobInstanceBase) null;
    }

    [Token(Token = "0x600FD5E")]
    [Address(RVA = "0x442E348", Offset = "0x442E348", VA = "0x442E348")]
    public MovablePairMobInstanceData(
      MovableSingleMobInstanceData data1,
      MovableSingleMobInstanceData data2,
      GameObject soundObject,
      string[] soundEvents)
    {
    }
  }
}
