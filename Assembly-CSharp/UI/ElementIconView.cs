// Decompiled with JetBrains decompiler
// Type: UI.ElementIconView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI
{
  [Token(Token = "0x200087C")]
  public class ElementIconView : MonoBehaviour
  {
    [Token(Token = "0x4002813")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [HideInInspector]
    private ElementIconView.ElementObject[] elementObjects;
    [Token(Token = "0x4002814")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject NoneObj;
    [Token(Token = "0x4002815")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject diamondObj;
    [Token(Token = "0x4002816")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject hexagonObj;

    [Token(Token = "0x60030A0")]
    [Address(RVA = "0x3E7A458", Offset = "0x3E7A458", VA = "0x3E7A458")]
    public void SetElementType(
      ElementTypeEnum elementType,
      ElementIconView.ElementIconBGType bgType = ElementIconView.ElementIconBGType.None)
    {
    }

    [Token(Token = "0x60030A1")]
    [Address(RVA = "0x3E7A590", Offset = "0x3E7A590", VA = "0x3E7A590")]
    public void SetNoneObj()
    {
    }

    [Token(Token = "0x60030A2")]
    [Address(RVA = "0x3E7A514", Offset = "0x3E7A514", VA = "0x3E7A514")]
    private void UpdateBg(ElementIconView.ElementIconBGType type)
    {
    }

    [Token(Token = "0x60030A3")]
    [Address(RVA = "0x3E7A634", Offset = "0x3E7A634", VA = "0x3E7A634")]
    public ElementIconView()
    {
    }

    [Token(Token = "0x200087D")]
    [Serializable]
    private struct ElementObject
    {
      [Token(Token = "0x4002817")]
      [FieldOffset(Offset = "0x0")]
      public ElementTypeEnum ElementType;
      [Token(Token = "0x4002818")]
      [FieldOffset(Offset = "0x8")]
      public GameObject IconObject;
    }

    [Token(Token = "0x200087E")]
    public enum ElementIconBGType
    {
      [Token(Token = "0x400281A")] None,
      [Token(Token = "0x400281B")] Diamond,
      [Token(Token = "0x400281C")] Hexagon,
    }
  }
}
