// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.AdvStageHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using Il2CppDummyDll;
using Story.Adv;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x20016F7")]
  public class AdvStageHandler
  {
    [Token(Token = "0x4006689")]
    [FieldOffset(Offset = "0x10")]
    private bool isLoaded;
    [Token(Token = "0x400668A")]
    [FieldOffset(Offset = "0x11")]
    private bool isChangeArea;
    [Token(Token = "0x400668B")]
    [FieldOffset(Offset = "0x12")]
    private bool isAreaEnd;
    [Token(Token = "0x400668C")]
    [FieldOffset(Offset = "0x18")]
    private IReadOnlyList<int> selected;
    [Token(Token = "0x400668D")]
    [FieldOffset(Offset = "0x20")]
    private IReadOnlyDictionary<int, int> localFalgs;
    [Token(Token = "0x400668E")]
    [FieldOffset(Offset = "0x28")]
    private IReadOnlyList<int> unlockedoption;
    [Token(Token = "0x400668F")]
    [FieldOffset(Offset = "0x30")]
    private IReadOnlyList<int> alreadyReadChoices;
    [Token(Token = "0x4006690")]
    [FieldOffset(Offset = "0x38")]
    private Adv2LuaNetworkConnection.APICallOnAdv apicallOnAdv;

    [Token(Token = "0x17001444")]
    public bool Canceled
    {
      [Token(Token = "0x60081F1"), Address(RVA = "0x41FD868", Offset = "0x41FD868", VA = "0x41FD868")] get
      {
        return new bool();
      }
      [Token(Token = "0x60081F2"), Address(RVA = "0x41FD870", Offset = "0x41FD870", VA = "0x41FD870")] private set
      {
      }
    }

    [Token(Token = "0x60081F3")]
    [Address(RVA = "0x41FD87C", Offset = "0x41FD87C", VA = "0x41FD87C")]
    public IEnumerator Load(AdvStage advStage) => (IEnumerator) null;

    [Token(Token = "0x60081F4")]
    [Address(RVA = "0x41FD918", Offset = "0x41FD918", VA = "0x41FD918")]
    public bool IsLoaded() => new bool();

    [Token(Token = "0x60081F5")]
    [Address(RVA = "0x41FD920", Offset = "0x41FD920", VA = "0x41FD920")]
    public IEnumerator Play(AdvStage advStage) => (IEnumerator) null;

    [Token(Token = "0x60081F6")]
    [Address(RVA = "0x41FD9BC", Offset = "0x41FD9BC", VA = "0x41FD9BC")]
    public void ExtractSelect(AdvStage advStage)
    {
    }

    [Token(Token = "0x60081F7")]
    [Address(RVA = "0x41FD9E4", Offset = "0x41FD9E4", VA = "0x41FD9E4")]
    public IReadOnlyList<int> GetPlayerSelectedIndex() => (IReadOnlyList<int>) null;

    [Token(Token = "0x60081F8")]
    [Address(RVA = "0x41FDA60", Offset = "0x41FDA60", VA = "0x41FDA60")]
    public IReadOnlyDictionary<int, int> GetPlayerSelectedFlag()
    {
      return (IReadOnlyDictionary<int, int>) null;
    }

    [Token(Token = "0x60081F9")]
    [Address(RVA = "0x41FDADC", Offset = "0x41FDADC", VA = "0x41FDADC")]
    public IReadOnlyList<int> GetUnlockedOption() => (IReadOnlyList<int>) null;

    [Token(Token = "0x60081FA")]
    [Address(RVA = "0x41FDB58", Offset = "0x41FDB58", VA = "0x41FDB58")]
    public IReadOnlyList<int> GetAlreadyReadChoices() => (IReadOnlyList<int>) null;

    [Token(Token = "0x60081FB")]
    [Address(RVA = "0x41FDBD4", Offset = "0x41FDBD4", VA = "0x41FDBD4")]
    public AdvStageHandler()
    {
    }
  }
}
