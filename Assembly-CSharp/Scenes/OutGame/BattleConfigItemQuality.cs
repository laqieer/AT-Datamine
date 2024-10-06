// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.BattleConfigItemQuality
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031C9")]
  public class BattleConfigItemQuality : MonoBehaviour
  {
    [Token(Token = "0x400D419")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject lowActiveButton;
    [Token(Token = "0x400D41A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject lowDeactiveButton;
    [Token(Token = "0x400D41B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject midActiveButton;
    [Token(Token = "0x400D41C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject midDeactiveButton;
    [Token(Token = "0x400D41D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject hiActiveButton;
    [Token(Token = "0x400D41E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject hiDeactiveButton;

    [Token(Token = "0x170040E3")]
    private Action<int> OnSelect
    {
      [Token(Token = "0x60136DC"), Address(RVA = "0x4E09CA8", Offset = "0x4E09CA8", VA = "0x4E09CA8")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x60136DD"), Address(RVA = "0x4E09CB0", Offset = "0x4E09CB0", VA = "0x4E09CB0")] set
      {
      }
    }

    [Token(Token = "0x60136DE")]
    [Address(RVA = "0x4E09CB8", Offset = "0x4E09CB8", VA = "0x4E09CB8")]
    public void Initialize(int speedIndex, Action<int> onSelectAction)
    {
    }

    [Token(Token = "0x60136DF")]
    [Address(RVA = "0x4E09D5C", Offset = "0x4E09D5C", VA = "0x4E09D5C")]
    private void UpdateButtonActive(int index)
    {
    }

    [Token(Token = "0x60136E0")]
    [Address(RVA = "0x4E09E7C", Offset = "0x4E09E7C", VA = "0x4E09E7C")]
    public void OnClickToOnButton(int index)
    {
    }

    [Token(Token = "0x60136E1")]
    [Address(RVA = "0x4E09EBC", Offset = "0x4E09EBC", VA = "0x4E09EBC")]
    public BattleConfigItemQuality()
    {
    }
  }
}
