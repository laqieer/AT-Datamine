// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ColliderEvent.FreeMapActionCircleMonobehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.ColliderEvent
{
  [Token(Token = "0x20016C8")]
  [RequireComponent(typeof (Collider))]
  public class FreeMapActionCircleMonobehaviour : MonoBehaviour, IFreeMapColliderEventObject
  {
    [Token(Token = "0x40065EF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("ScalingMode=Hierarchyでない場合エラーを出力する")]
    private bool alertScalingMode;
    [Token(Token = "0x40065F0")]
    [FieldOffset(Offset = "0x19")]
    [SerializeField]
    [Header("全ての子のParticleSystemをチェックする")]
    private bool checkChild;
    [Token(Token = "0x40065F1")]
    [FieldOffset(Offset = "0x20")]
    private Action action;
    [Token(Token = "0x40065F2")]
    [FieldOffset(Offset = "0x28")]
    private FreeMapInstance target;

    [Token(Token = "0x170013FC")]
    public bool AlertScalingMode
    {
      [Token(Token = "0x60080CF"), Address(RVA = "0x41F6B80", Offset = "0x41F6B80", VA = "0x41F6B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013FD")]
    public bool CheckChild
    {
      [Token(Token = "0x60080D0"), Address(RVA = "0x41F6B88", Offset = "0x41F6B88", VA = "0x41F6B88")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013FE")]
    private GameObject FreeMap\u002EUI\u002EColliderEvent\u002EIFreeMapColliderEventObject\u002ESelf
    {
      [Token(Token = "0x60080D1"), Address(RVA = "0x41F6B90", Offset = "0x41F6B90", VA = "0x41F6B90", Slot = "4")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013FF")]
    private GameObject FreeMap\u002EUI\u002EColliderEvent\u002EIFreeMapColliderEventObject\u002ETarget
    {
      [Token(Token = "0x60080D2"), Address(RVA = "0x41F6B98", Offset = "0x41F6B98", VA = "0x41F6B98", Slot = "5")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x60080D3")]
    [Address(RVA = "0x41F6BB4", Offset = "0x41F6BB4", VA = "0x41F6BB4", Slot = "6")]
    private bool FreeMap\u002EUI\u002EColliderEvent\u002EIFreeMapColliderEventObject\u002EOnEnter(
      FreeMapInstance instance)
    {
      return new bool();
    }

    [Token(Token = "0x60080D4")]
    [Address(RVA = "0x41F6BDC", Offset = "0x41F6BDC", VA = "0x41F6BDC")]
    public void Initialize(FreeMapInstance target, Action action)
    {
    }

    [Token(Token = "0x60080D5")]
    [Address(RVA = "0x41F6BFC", Offset = "0x41F6BFC", VA = "0x41F6BFC")]
    public void Register(Action action)
    {
    }

    [Token(Token = "0x60080D6")]
    [Address(RVA = "0x41F6C24", Offset = "0x41F6C24", VA = "0x41F6C24")]
    public FreeMapActionCircleMonobehaviour()
    {
    }
  }
}
