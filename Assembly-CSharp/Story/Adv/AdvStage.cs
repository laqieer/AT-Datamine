// Decompiled with JetBrains decompiler
// Type: Story.Adv.AdvStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Adv
{
  [Token(Token = "0x2000747")]
  public class AdvStage : AdvStageBase
  {
    [Token(Token = "0x4002181")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<int, int> localInt;
    [Token(Token = "0x4002182")]
    [FieldOffset(Offset = "0x40")]
    private Func<string, GameObject> getAreaOjectRefMethod;
    [Token(Token = "0x4002183")]
    [FieldOffset(Offset = "0x48")]
    private Func<GameObject> getAreaPlayerOjectRefMethod;
    [Token(Token = "0x4002185")]
    [FieldOffset(Offset = "0x58")]
    private Action onChangeArea;

    [Token(Token = "0x17000601")]
    public bool Canceled
    {
      [Token(Token = "0x60028AD"), Address(RVA = "0x3678638", Offset = "0x3678638", VA = "0x3678638")] get
      {
        return new bool();
      }
      [Token(Token = "0x60028AE"), Address(RVA = "0x3678640", Offset = "0x3678640", VA = "0x3678640")] private set
      {
      }
    }

    [Token(Token = "0x60028AF")]
    [Address(RVA = "0x367858C", Offset = "0x367858C", VA = "0x367858C")]
    public AdvStage(
      AdvDemoInfoData demoInfo,
      Func<string, GameObject> areaObjectModelRefGetMethod,
      Func<GameObject> getPlayerOjectModelRefMethod,
      Action onChangeArea)
    {
    }

    [Token(Token = "0x60028B0")]
    [Address(RVA = "0x3678878", Offset = "0x3678878", VA = "0x3678878")]
    public void OnChangeArea()
    {
    }

    [Token(Token = "0x60028B1")]
    [Address(RVA = "0x3678894", Offset = "0x3678894", VA = "0x3678894")]
    public GameObject GetAreaObjectModelRef(string objectAccessName) => (GameObject) null;

    [Token(Token = "0x60028B2")]
    [Address(RVA = "0x36788B4", Offset = "0x36788B4", VA = "0x36788B4")]
    public GameObject GetAreaPlayerObjectModelRef() => (GameObject) null;

    [Token(Token = "0x60028B3")]
    [Address(RVA = "0x36788D4", Offset = "0x36788D4", VA = "0x36788D4")]
    public void SendLocalFlag(int flagID, int value)
    {
    }

    [Token(Token = "0x60028B4")]
    [Address(RVA = "0x367893C", Offset = "0x367893C", VA = "0x367893C")]
    public IReadOnlyDictionary<int, int> GetLocalIntFlag() => (IReadOnlyDictionary<int, int>) null;

    [Token(Token = "0x60028B5")]
    [Address(RVA = "0x3678944", Offset = "0x3678944", VA = "0x3678944")]
    public void Cancel()
    {
    }
  }
}
