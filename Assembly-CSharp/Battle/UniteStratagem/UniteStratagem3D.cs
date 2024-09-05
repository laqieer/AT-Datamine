// Decompiled with JetBrains decompiler
// Type: Battle.UniteStratagem.UniteStratagem3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UniteStratagem
{
  [Token(Token = "0x20022AE")]
  public class UniteStratagem3D : MonoBehaviour
  {
    [Token(Token = "0x4009220")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Stage3DController[] controllers;

    [Token(Token = "0x17002DD4")]
    public bool IsPlaying
    {
      [Token(Token = "0x600D37D"), Address(RVA = "0x19D7224", Offset = "0x19D7224", VA = "0x19D7224")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D37E")]
    [Address(RVA = "0x19D7320", Offset = "0x19D7320", VA = "0x19D7320")]
    public void Prepare(RenderTexture[] textures, GameObject[] characters)
    {
    }

    [Token(Token = "0x600D37F")]
    [Address(RVA = "0x19D73CC", Offset = "0x19D73CC", VA = "0x19D73CC")]
    public void PlayAnimation()
    {
    }

    [Token(Token = "0x600D380")]
    [Address(RVA = "0x19D74C8", Offset = "0x19D74C8", VA = "0x19D74C8")]
    public void StopAnimation()
    {
    }

    [Token(Token = "0x600D381")]
    [Address(RVA = "0x19D75C4", Offset = "0x19D75C4", VA = "0x19D75C4")]
    public void Release()
    {
    }

    [Token(Token = "0x600D382")]
    [Address(RVA = "0x19D7628", Offset = "0x19D7628", VA = "0x19D7628")]
    public UniteStratagem3D()
    {
    }
  }
}
