// Decompiled with JetBrains decompiler
// Type: Scenes.Information.InformationObjectGetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Information
{
  [Token(Token = "0x2002AB7")]
  public class InformationObjectGetter : MonoBehaviour
  {
    [Token(Token = "0x400B5C0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x400B5C1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject tagOther;
    [Token(Token = "0x400B5C2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject tagPrivate;

    [Token(Token = "0x170039D3")]
    public GameObject NewBadge
    {
      [Token(Token = "0x6010B32"), Address(RVA = "0x4BD38C4", Offset = "0x4BD38C4", VA = "0x4BD38C4")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170039D4")]
    public GameObject TagOther
    {
      [Token(Token = "0x6010B33"), Address(RVA = "0x4BD38CC", Offset = "0x4BD38CC", VA = "0x4BD38CC")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170039D5")]
    public GameObject TagPrivate
    {
      [Token(Token = "0x6010B34"), Address(RVA = "0x4BD38D4", Offset = "0x4BD38D4", VA = "0x4BD38D4")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6010B35")]
    [Address(RVA = "0x4BD38DC", Offset = "0x4BD38DC", VA = "0x4BD38DC")]
    public InformationObjectGetter()
    {
    }
  }
}
