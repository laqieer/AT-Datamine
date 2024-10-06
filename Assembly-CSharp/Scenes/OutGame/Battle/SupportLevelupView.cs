// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.SupportLevelupView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x200378D")]
  public sealed class SupportLevelupView : ResultViewBase
  {
    [Token(Token = "0x400F295")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string showName;
    [Token(Token = "0x400F296")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string hideName;
    [Token(Token = "0x400F297")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400F298")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private float waitTime;

    [Token(Token = "0x6015DF8")]
    [Address(RVA = "0x231F150", Offset = "0x231F150", VA = "0x231F150", Slot = "5")]
    public override void Initialize(BattleResultSubScene subScene)
    {
    }

    [Token(Token = "0x6015DF9")]
    [Address(RVA = "0x231F270", Offset = "0x231F270", VA = "0x231F270", Slot = "6")]
    public override void Play()
    {
    }

    [Token(Token = "0x6015DFA")]
    [Address(RVA = "0x231F160", Offset = "0x231F160", VA = "0x231F160")]
    public void Hide(bool immediate = false)
    {
    }

    [Token(Token = "0x6015DFB")]
    [Address(RVA = "0x231F2C0", Offset = "0x231F2C0", VA = "0x231F2C0", Slot = "8")]
    protected override IEnumerator ExecutePlayFlow() => (IEnumerator) null;

    [Token(Token = "0x6015DFC")]
    [Address(RVA = "0x231F350", Offset = "0x231F350", VA = "0x231F350")]
    public SupportLevelupView()
    {
    }
  }
}
