// Decompiled with JetBrains decompiler
// Type: Story.TestUI.StoryActionIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Story.TestUI
{
  [Token(Token = "0x2000606")]
  public class StoryActionIcon : MonoBehaviour
  {
    [Token(Token = "0x4001DB8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Vector2 baseSize;
    [Token(Token = "0x4001DB9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform parent3D;

    [Token(Token = "0x170004FB")]
    public Transform Parent3D
    {
      [Token(Token = "0x60022F0"), Address(RVA = "0x2DA2B0C", Offset = "0x2DA2B0C", VA = "0x2DA2B0C")] set
      {
      }
    }

    [Token(Token = "0x60022F1")]
    [Address(RVA = "0x2DA2B14", Offset = "0x2DA2B14", VA = "0x2DA2B14")]
    private void Update()
    {
    }

    [Token(Token = "0x60022F2")]
    [Address(RVA = "0x2DA2C70", Offset = "0x2DA2C70", VA = "0x2DA2C70")]
    public void SetTapAction(UnityAction tapAction)
    {
    }

    [Token(Token = "0x60022F3")]
    [Address(RVA = "0x2DA2CE0", Offset = "0x2DA2CE0", VA = "0x2DA2CE0")]
    public void OnTap()
    {
    }

    [Token(Token = "0x60022F4")]
    [Address(RVA = "0x2DA2CE4", Offset = "0x2DA2CE4", VA = "0x2DA2CE4")]
    public StoryActionIcon()
    {
    }
  }
}
