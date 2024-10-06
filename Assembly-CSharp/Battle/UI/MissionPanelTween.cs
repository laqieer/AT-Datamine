// Decompiled with JetBrains decompiler
// Type: Battle.UI.MissionPanelTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002315")]
  public sealed class MissionPanelTween : TweenWrapper
  {
    [Token(Token = "0x400947A")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    [SerializeField]
    private string showName;
    [Token(Token = "0x400947B")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    [SerializeField]
    private string hideName;

    [Token(Token = "0x17002E3C")]
    public UITweenGroup TweenGroup
    {
      [Token(Token = "0x600D656"), Address(RVA = "0x1D1DBE8", Offset = "0x1D1DBE8", VA = "0x1D1DBE8")] get
      {
        return (UITweenGroup) null;
      }
    }

    [Token(Token = "0x600D657")]
    [Address(RVA = "0x1D1D7A0", Offset = "0x1D1D7A0", VA = "0x1D1D7A0")]
    public void Show()
    {
    }

    [Token(Token = "0x600D658")]
    [Address(RVA = "0x1D1D9E4", Offset = "0x1D1D9E4", VA = "0x1D1D9E4")]
    public new void Hide()
    {
    }

    [Token(Token = "0x600D659")]
    [Address(RVA = "0x1D1DBF0", Offset = "0x1D1DBF0", VA = "0x1D1DBF0", Slot = "7")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600D65A")]
    [Address(RVA = "0x1D1DBF4", Offset = "0x1D1DBF4", VA = "0x1D1DBF4")]
    public MissionPanelTween()
    {
    }
  }
}
