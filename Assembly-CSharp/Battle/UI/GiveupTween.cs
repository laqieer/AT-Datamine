// Decompiled with JetBrains decompiler
// Type: Battle.UI.GiveupTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002311")]
  public sealed class GiveupTween : TweenWrapper
  {
    [Token(Token = "0x4009462")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    [SerializeField]
    private string showName;
    [Token(Token = "0x4009463")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    [SerializeField]
    private string hideName;

    [Token(Token = "0x600D638")]
    [Address(RVA = "0x1D1C254", Offset = "0x1D1C254", VA = "0x1D1C254")]
    public void Show()
    {
    }

    [Token(Token = "0x600D639")]
    [Address(RVA = "0x1D1C498", Offset = "0x1D1C498", VA = "0x1D1C498")]
    public new void Hide()
    {
    }

    [Token(Token = "0x600D63A")]
    [Address(RVA = "0x1D1C5C8", Offset = "0x1D1C5C8", VA = "0x1D1C5C8", Slot = "7")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600D63B")]
    [Address(RVA = "0x1D1C5CC", Offset = "0x1D1C5CC", VA = "0x1D1C5CC")]
    public GiveupTween()
    {
    }
  }
}
