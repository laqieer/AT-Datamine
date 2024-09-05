// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Position.UITransformAvoidElementListComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Position
{
  [Token(Token = "0x20016AE")]
  public class UITransformAvoidElementListComponent : MonoBehaviour, IAvoidRectTransfromAccessor
  {
    [Token(Token = "0x40065B3")]
    [FieldOffset(Offset = "0x18")]
    [Header("TransformAvoidコンポーネントを登録")]
    [SerializeField]
    private List<UITransfromAvoidElementBase> avoidIconRectTransformList;

    [Token(Token = "0x170013EA")]
    public List<UITransfromAvoidElementBase> AvoidIconRectTransformList
    {
      [Token(Token = "0x6008067"), Address(RVA = "0x41F3548", Offset = "0x41F3548", VA = "0x41F3548", Slot = "4")] get
      {
        return (List<UITransfromAvoidElementBase>) null;
      }
    }

    [Token(Token = "0x6008068")]
    [Address(RVA = "0x41F3550", Offset = "0x41F3550", VA = "0x41F3550")]
    public UITransformAvoidElementListComponent()
    {
    }
  }
}
