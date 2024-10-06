// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.Loader`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x200162C")]
  public class Loader<T> where T : MonoBehaviour
  {
    [Token(Token = "0x40064B6")]
    [FieldOffset(Offset = "0x0")]
    public Action<T> OnInstantiated;

    [Token(Token = "0x17001360")]
    public virtual string ABName
    {
      [Token(Token = "0x6007DA1")] get => (string) null;
    }

    [Token(Token = "0x17001361")]
    public virtual string AssetName
    {
      [Token(Token = "0x6007DA2")] get => (string) null;
    }

    [Token(Token = "0x17001362")]
    public T InstantiatedObject
    {
      [Token(Token = "0x6007DA3")] get => (T) null;
      [Token(Token = "0x6007DA4")] private set
      {
      }
    }

    [Token(Token = "0x6007DA5")]
    public IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x6007DA6")]
    private IEnumerator LoadAsset() => (IEnumerator) null;

    [Token(Token = "0x6007DA7")]
    public Loader()
    {
    }
  }
}
