// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.APIconView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.APRecovery
{
  [Token(Token = "0x200394C")]
  public class APIconView : MonoBehaviour
  {
    [Token(Token = "0x400FA69")]
    private const int ApMax = 5;
    [Token(Token = "0x400FA6A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image[] _imgsAps;
    [Token(Token = "0x400FA6B")]
    [FieldOffset(Offset = "0x20")]
    [Header("回復アニメ")]
    [Tooltip("回復アニメ不要ならNoneで良いです")]
    [SerializeField]
    private UITweenGroup _tween;

    [Token(Token = "0x6016851")]
    [Address(RVA = "0x42EBD80", Offset = "0x42EBD80", VA = "0x42EBD80")]
    public void SetAP(int ap, int recoveryAp = 0)
    {
    }

    [Token(Token = "0x6016852")]
    [Address(RVA = "0x42EBF1C", Offset = "0x42EBF1C", VA = "0x42EBF1C")]
    private GameObject IconObj(int index) => (GameObject) null;

    [Token(Token = "0x6016853")]
    [Address(RVA = "0x42EBFF0", Offset = "0x42EBFF0", VA = "0x42EBFF0")]
    public APIconView()
    {
    }
  }
}
