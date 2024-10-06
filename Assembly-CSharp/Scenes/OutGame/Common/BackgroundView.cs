// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Common.BackgroundView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Common
{
  [Token(Token = "0x20036FC")]
  [AddComponentMenu("Scenes/OutGame/Common/BackgroundView")]
  public class BackgroundView : MonoBehaviour
  {
    [Token(Token = "0x400F027")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image background;
    [Token(Token = "0x400F028")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mist;

    [Token(Token = "0x170047A2")]
    public Image Backgound
    {
      [Token(Token = "0x6015A85"), Address(RVA = "0x1D839D4", Offset = "0x1D839D4", VA = "0x1D839D4")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x170047A3")]
    public GameObject Mist
    {
      [Token(Token = "0x6015A86"), Address(RVA = "0x1D839DC", Offset = "0x1D839DC", VA = "0x1D839DC")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6015A87")]
    [Address(RVA = "0x1D839E4", Offset = "0x1D839E4", VA = "0x1D839E4")]
    public BackgroundView()
    {
    }
  }
}
