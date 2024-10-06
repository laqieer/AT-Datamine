// Decompiled with JetBrains decompiler
// Type: UnitView.ModelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace UnitView
{
  [Token(Token = "0x20003BF")]
  [Serializable]
  public class ModelController
  {
    [Token(Token = "0x4001626")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform parent;
    [Token(Token = "0x4001627")]
    [FieldOffset(Offset = "0x18")]
    private GameObject instance;
    [Token(Token = "0x4001628")]
    [FieldOffset(Offset = "0x20")]
    private Animator animator;
    [Token(Token = "0x4001629")]
    [FieldOffset(Offset = "0x28")]
    private string playingStateName;

    [Token(Token = "0x17000239")]
    public Transform Parent
    {
      [Token(Token = "0x60015BA"), Address(RVA = "0x2483ACC", Offset = "0x2483ACC", VA = "0x2483ACC")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x60015BB")]
    [Address(RVA = "0x2483AD4", Offset = "0x2483AD4", VA = "0x2483AD4")]
    public void InstantiateModel(GameObject asset)
    {
    }

    [Token(Token = "0x60015BC")]
    [Address(RVA = "0x2483BA0", Offset = "0x2483BA0", VA = "0x2483BA0")]
    public void DestroyModel()
    {
    }

    [Token(Token = "0x60015BD")]
    [Address(RVA = "0x2483C00", Offset = "0x2483C00", VA = "0x2483C00")]
    public void PlayAnimation(string stateName)
    {
    }

    [Token(Token = "0x60015BE")]
    [Address(RVA = "0x2483C2C", Offset = "0x2483C2C", VA = "0x2483C2C")]
    public void CrossFade(string stateName, float duration)
    {
    }

    [Token(Token = "0x60015BF")]
    [Address(RVA = "0x2483C48", Offset = "0x2483C48", VA = "0x2483C48")]
    public void Rotate(Quaternion rotate)
    {
    }

    [Token(Token = "0x60015C0")]
    [Address(RVA = "0x2483D04", Offset = "0x2483D04", VA = "0x2483D04")]
    public IEnumerator Reset(float duration) => (IEnumerator) null;

    [Token(Token = "0x60015C1")]
    [Address(RVA = "0x2483DA4", Offset = "0x2483DA4", VA = "0x2483DA4")]
    public IEnumerator WaitEndAnimation(Action endEvent) => (IEnumerator) null;

    [Token(Token = "0x60015C2")]
    [Address(RVA = "0x2483E40", Offset = "0x2483E40", VA = "0x2483E40")]
    public ModelController()
    {
    }
  }
}
