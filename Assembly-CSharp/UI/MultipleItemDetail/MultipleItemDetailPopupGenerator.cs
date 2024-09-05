// Decompiled with JetBrains decompiler
// Type: UI.MultipleItemDetail.MultipleItemDetailPopupGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace UI.MultipleItemDetail
{
  [Token(Token = "0x20008BB")]
  public class MultipleItemDetailPopupGenerator : IDisposable
  {
    [Token(Token = "0x1700072B")]
    public bool IsLoaded
    {
      [Token(Token = "0x6003188"), Address(RVA = "0x3C19044", Offset = "0x3C19044", VA = "0x3C19044")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003189"), Address(RVA = "0x3C1904C", Offset = "0x3C1904C", VA = "0x3C1904C")] private set
      {
      }
    }

    [Token(Token = "0x1700072C")]
    public MultipleItemDetailPopupResource Resource
    {
      [Token(Token = "0x600318A"), Address(RVA = "0x3C19058", Offset = "0x3C19058", VA = "0x3C19058")] get
      {
        return (MultipleItemDetailPopupResource) null;
      }
      [Token(Token = "0x600318B"), Address(RVA = "0x3C19060", Offset = "0x3C19060", VA = "0x3C19060")] private set
      {
      }
    }

    [Token(Token = "0x600318C")]
    [Address(RVA = "0x3C19068", Offset = "0x3C19068", VA = "0x3C19068")]
    public IEnumerator LoadAssetAsync(Action onFinish = null) => (IEnumerator) null;

    [Token(Token = "0x600318D")]
    [Address(RVA = "0x3C19104", Offset = "0x3C19104", VA = "0x3C19104")]
    public MultipleItemDetailPopup Generate(Transform parent) => (MultipleItemDetailPopup) null;

    [Token(Token = "0x600318E")]
    [Address(RVA = "0x3C191C0", Offset = "0x3C191C0", VA = "0x3C191C0", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600318F")]
    [Address(RVA = "0x3C19254", Offset = "0x3C19254", VA = "0x3C19254")]
    public MultipleItemDetailPopupGenerator()
    {
    }
  }
}
