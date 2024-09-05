// Decompiled with JetBrains decompiler
// Type: UnitDetail.UnitModelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x20004A5")]
  [Serializable]
  public class UnitModelController
  {
    [Token(Token = "0x4001888")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform target;
    [Token(Token = "0x4001889")]
    [FieldOffset(Offset = "0x18")]
    private GameObject instance;
    [Token(Token = "0x400188A")]
    [FieldOffset(Offset = "0x20")]
    private Animator animator;
    [Token(Token = "0x400188B")]
    [FieldOffset(Offset = "0x28")]
    private string playingStateName;

    [Token(Token = "0x6001A0E")]
    [Address(RVA = "0x2C24538", Offset = "0x2C24538", VA = "0x2C24538")]
    public void InstantiateModel(GameObject asset)
    {
    }

    [Token(Token = "0x6001A0F")]
    [Address(RVA = "0x2C24604", Offset = "0x2C24604", VA = "0x2C24604")]
    public void DestroyModel()
    {
    }

    [Token(Token = "0x6001A10")]
    [Address(RVA = "0x2C24664", Offset = "0x2C24664", VA = "0x2C24664")]
    public void Show()
    {
    }

    [Token(Token = "0x6001A11")]
    [Address(RVA = "0x2C24690", Offset = "0x2C24690", VA = "0x2C24690")]
    public void Hide()
    {
    }

    [Token(Token = "0x6001A12")]
    [Address(RVA = "0x2C246BC", Offset = "0x2C246BC", VA = "0x2C246BC")]
    public void PlayAnimation(string stateName)
    {
    }

    [Token(Token = "0x6001A13")]
    [Address(RVA = "0x2C246E0", Offset = "0x2C246E0", VA = "0x2C246E0")]
    public void CrossFade(string stateName, float duration)
    {
    }

    [Token(Token = "0x6001A14")]
    [Address(RVA = "0x2C246FC", Offset = "0x2C246FC", VA = "0x2C246FC")]
    public void Rotate(Quaternion rotate)
    {
    }

    [Token(Token = "0x6001A15")]
    [Address(RVA = "0x2C247B8", Offset = "0x2C247B8", VA = "0x2C247B8")]
    public IEnumerator Reset(float duration) => (IEnumerator) null;

    [Token(Token = "0x6001A16")]
    [Address(RVA = "0x2C24858", Offset = "0x2C24858", VA = "0x2C24858")]
    public IEnumerator WaitEndAnimation(Action endCallback) => (IEnumerator) null;

    [Token(Token = "0x6001A17")]
    [Address(RVA = "0x2C248F4", Offset = "0x2C248F4", VA = "0x2C248F4")]
    public UnitModelController()
    {
    }
  }
}
