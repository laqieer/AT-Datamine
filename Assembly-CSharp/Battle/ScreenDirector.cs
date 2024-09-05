// Decompiled with JetBrains decompiler
// Type: Battle.ScreenDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002281")]
  public sealed class ScreenDirector : MonoBehaviour, ISubDirector<MainDirector>
  {
    [Token(Token = "0x400917D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RawImage[] screenDisplays;
    [Token(Token = "0x400917E")]
    [FieldOffset(Offset = "0x20")]
    private int currentDisplayIndex;
    [Token(Token = "0x400917F")]
    [FieldOffset(Offset = "0x28")]
    private MainDirector mainDirector;
    [Token(Token = "0x4009181")]
    [FieldOffset(Offset = "0x34")]
    private float defaultShadowdistance;

    [Token(Token = "0x17002DAB")]
    public bool Initialized
    {
      [Token(Token = "0x600D25B"), Address(RVA = "0x1960FC8", Offset = "0x1960FC8", VA = "0x1960FC8", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D25C"), Address(RVA = "0x1960FD0", Offset = "0x1960FD0", VA = "0x1960FD0")] private set
      {
      }
    }

    [Token(Token = "0x600D25D")]
    [Address(RVA = "0x19584FC", Offset = "0x19584FC", VA = "0x19584FC", Slot = "5")]
    public void Initialize(MainDirector mainDirector)
    {
    }

    [Token(Token = "0x600D25E")]
    [Address(RVA = "0x1960FDC", Offset = "0x1960FDC", VA = "0x1960FDC", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600D25F")]
    [Address(RVA = "0x19586B8", Offset = "0x19586B8", VA = "0x19586B8", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x600D260")]
    [Address(RVA = "0x1960FE0", Offset = "0x1960FE0", VA = "0x1960FE0")]
    public ScreenDirector()
    {
    }

    [Token(Token = "0x2002282")]
    public enum MainScreenType
    {
      [Token(Token = "0x4009183")] Map,
      [Token(Token = "0x4009184")] Duel,
      [Token(Token = "0x4009185")] Skill,
    }
  }
}
