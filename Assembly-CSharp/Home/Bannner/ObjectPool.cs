// Decompiled with JetBrains decompiler
// Type: Home.Bannner.ObjectPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Home.Bannner
{
  [Token(Token = "0x2000B8B")]
  internal class ObjectPool
  {
    [Token(Token = "0x4003494")]
    [FieldOffset(Offset = "0x10")]
    private readonly GameObject templateObject;
    [Token(Token = "0x4003495")]
    [FieldOffset(Offset = "0x18")]
    private Queue<GameObject> objectPool;
    [Token(Token = "0x4003496")]
    [FieldOffset(Offset = "0x20")]
    private GameObject poolRoot;

    [Token(Token = "0x60041D0")]
    [Address(RVA = "0x2A30844", Offset = "0x2A30844", VA = "0x2A30844")]
    public ObjectPool(GameObject gameObject, Transform poolRoot)
    {
    }

    [Token(Token = "0x60041D1")]
    [Address(RVA = "0x2A310F8", Offset = "0x2A310F8", VA = "0x2A310F8")]
    public GameObject Get(int index) => (GameObject) null;

    [Token(Token = "0x60041D2")]
    [Address(RVA = "0x2A31280", Offset = "0x2A31280", VA = "0x2A31280")]
    public void Release(GameObject gameObject)
    {
    }

    [Token(Token = "0x60041D3")]
    [Address(RVA = "0x2A31FFC", Offset = "0x2A31FFC", VA = "0x2A31FFC")]
    private void MoveToPool(GameObject gameObject)
    {
    }
  }
}
