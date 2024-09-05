// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipChange.AnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI.EquipChange
{
  [Token(Token = "0x2000480")]
  [Serializable]
  public class AnimationController
  {
    [Token(Token = "0x4001843")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001844")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string AnimationGroupIn;
    [Token(Token = "0x4001845")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string AnimationGroupOut;
    [Token(Token = "0x4001846")]
    [FieldOffset(Offset = "0x28")]
    private bool playing;

    [Token(Token = "0x6001938")]
    [Address(RVA = "0x249197C", Offset = "0x249197C", VA = "0x249197C")]
    public void In()
    {
    }

    [Token(Token = "0x6001939")]
    [Address(RVA = "0x2491B44", Offset = "0x2491B44", VA = "0x2491B44")]
    public void Out()
    {
    }

    [Token(Token = "0x600193A")]
    [Address(RVA = "0x24920E8", Offset = "0x24920E8", VA = "0x24920E8")]
    public bool IsPlaying() => new bool();

    [Token(Token = "0x600193B")]
    [Address(RVA = "0x24943BC", Offset = "0x24943BC", VA = "0x24943BC")]
    public AnimationController()
    {
    }
  }
}
