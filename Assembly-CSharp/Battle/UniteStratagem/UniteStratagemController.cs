// Decompiled with JetBrains decompiler
// Type: Battle.UniteStratagem.UniteStratagemController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.UniteStratagem.UI;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UniteStratagem
{
  [Token(Token = "0x20022B0")]
  public class UniteStratagemController : MonoBehaviour
  {
    [Token(Token = "0x4009225")]
    private const string RENDER_TEX_NAME_FORMAT = "us_rt_{0}";
    [Token(Token = "0x4009226")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UniteStratagemRTSettings rtSettings;
    [Token(Token = "0x4009227")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UniteStratagemUI stratagemUI;
    [Token(Token = "0x4009228")]
    [FieldOffset(Offset = "0x28")]
    private RenderTexture[] renderTextures;

    [Token(Token = "0x17002DD5")]
    public bool IsPlaying
    {
      [Token(Token = "0x600D388"), Address(RVA = "0x19D7744", Offset = "0x19D7744", VA = "0x19D7744")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D389")]
    [Address(RVA = "0x19D77B8", Offset = "0x19D77B8", VA = "0x19D77B8")]
    public void Prepare(GameObject[] characters)
    {
    }

    [Token(Token = "0x600D38A")]
    [Address(RVA = "0x19D77BC", Offset = "0x19D77BC", VA = "0x19D77BC")]
    private void CreateRenderTextures(int requiredCount)
    {
    }

    [Token(Token = "0x600D38B")]
    [Address(RVA = "0x19D79D4", Offset = "0x19D79D4", VA = "0x19D79D4")]
    public void PlayAnimation()
    {
    }

    [Token(Token = "0x600D38C")]
    [Address(RVA = "0x19D79D8", Offset = "0x19D79D8", VA = "0x19D79D8")]
    public void StopAnimation()
    {
    }

    [Token(Token = "0x600D38D")]
    [Address(RVA = "0x19D79DC", Offset = "0x19D79DC", VA = "0x19D79DC")]
    public void Release()
    {
    }

    [Token(Token = "0x600D38E")]
    [Address(RVA = "0x19D79E0", Offset = "0x19D79E0", VA = "0x19D79E0")]
    public UniteStratagemController()
    {
    }
  }
}
