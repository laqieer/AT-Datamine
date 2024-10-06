// Decompiled with JetBrains decompiler
// Type: Battle.UI.ElementIconParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200242E")]
  [Serializable]
  internal class ElementIconParam
  {
    [Token(Token = "0x4009AD5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ElementTypeEnum element;
    [Token(Token = "0x4009AD6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string iconName;

    [Token(Token = "0x17002FA3")]
    public ElementTypeEnum Element
    {
      [Token(Token = "0x600DDB4"), Address(RVA = "0x1E2B22C", Offset = "0x1E2B22C", VA = "0x1E2B22C")] get
      {
        return new ElementTypeEnum();
      }
    }

    [Token(Token = "0x17002FA4")]
    public string IconName
    {
      [Token(Token = "0x600DDB5"), Address(RVA = "0x1E2B234", Offset = "0x1E2B234", VA = "0x1E2B234")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600DDB6")]
    [Address(RVA = "0x1E2B23C", Offset = "0x1E2B23C", VA = "0x1E2B23C")]
    public ElementIconParam()
    {
    }
  }
}
