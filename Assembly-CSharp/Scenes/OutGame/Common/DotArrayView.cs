// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Common.DotArrayView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Common
{
  [Token(Token = "0x20036FE")]
  [AddComponentMenu("Scenes/OutGame/Common/DotArrayView")]
  public class DotArrayView : MonoBehaviour, IDotArrayControl
  {
    [Token(Token = "0x400F029")]
    [FieldOffset(Offset = "0x18")]
    [Tooltip("自動レイアウト調整対策でON/OFF 対象を選ぶ")]
    [SerializeField]
    private DotArrayView.TargetType targetType;
    [Token(Token = "0x400F02A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Tooltip("点灯オブジェクト列")]
    private GameObject[] onObjects;
    [Token(Token = "0x400F02B")]
    [FieldOffset(Offset = "0x28")]
    [Tooltip("消灯時切り替えるオブジェクト列")]
    [SerializeField]
    private GameObject[] offObjects;
    [Token(Token = "0x400F02C")]
    [FieldOffset(Offset = "0x30")]
    [Tooltip("初期点灯状態を指定する")]
    [SerializeField]
    private bool firstActives;
    [Token(Token = "0x400F02D")]
    [FieldOffset(Offset = "0x38")]
    [Tooltip("ルートオブジェクト")]
    [SerializeField]
    private GameObject rootObject;
    [Token(Token = "0x400F02E")]
    [FieldOffset(Offset = "0x40")]
    private bool doneStart;
    [Token(Token = "0x400F02F")]
    [FieldOffset(Offset = "0x48")]
    private Func<int, bool> checkActive;
    [Token(Token = "0x400F030")]
    [FieldOffset(Offset = "0x50")]
    private Action<int, bool> setActiveDot;
    [Token(Token = "0x400F031")]
    [FieldOffset(Offset = "0x58")]
    private UnityEngine.Object[] onSets;
    [Token(Token = "0x400F032")]
    [FieldOffset(Offset = "0x60")]
    private UnityEngine.Object[] offSets;
    [Token(Token = "0x400F033")]
    [FieldOffset(Offset = "0x68")]
    private int? displaySize;

    [Token(Token = "0x170047A8")]
    public GameObject Root
    {
      [Token(Token = "0x6015A8F"), Address(RVA = "0x1D839EC", Offset = "0x1D839EC", VA = "0x1D839EC", Slot = "4")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170047A9")]
    public bool this[int index]
    {
      [Token(Token = "0x6015A90"), Address(RVA = "0x1D83A6C", Offset = "0x1D83A6C", VA = "0x1D83A6C", Slot = "5")] get
      {
        return new bool();
      }
      [Token(Token = "0x6015A91"), Address(RVA = "0x1D83AF4", Offset = "0x1D83AF4", VA = "0x1D83AF4", Slot = "6")] set
      {
      }
    }

    [Token(Token = "0x170047AA")]
    public int Size
    {
      [Token(Token = "0x6015A92"), Address(RVA = "0x1D83EA0", Offset = "0x1D83EA0", VA = "0x1D83EA0", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170047AB")]
    public int DisplaySize
    {
      [Token(Token = "0x6015A93"), Address(RVA = "0x1D83EBC", Offset = "0x1D83EBC", VA = "0x1D83EBC", Slot = "8")] get
      {
        return new int();
      }
      [Token(Token = "0x6015A94"), Address(RVA = "0x1D83F34", Offset = "0x1D83F34", VA = "0x1D83F34", Slot = "9")] set
      {
      }
    }

    [Token(Token = "0x6015A95")]
    [Address(RVA = "0x1D8410C", Offset = "0x1D8410C", VA = "0x1D8410C", Slot = "10")]
    public void SetNumber(int number)
    {
    }

    [Token(Token = "0x6015A96")]
    [Address(RVA = "0x1D84208", Offset = "0x1D84208", VA = "0x1D84208")]
    private void Start()
    {
    }

    [Token(Token = "0x6015A97")]
    [Address(RVA = "0x1D83B58", Offset = "0x1D83B58", VA = "0x1D83B58")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6015A98")]
    [Address(RVA = "0x1D83AD4", Offset = "0x1D83AD4", VA = "0x1D83AD4")]
    private bool CheckOutOfRange(int index) => new bool();

    [Token(Token = "0x6015A99")]
    [Address(RVA = "0x1D84260", Offset = "0x1D84260", VA = "0x1D84260")]
    private bool CheckActiveObject(int index) => new bool();

    [Token(Token = "0x6015A9A")]
    [Address(RVA = "0x1D84298", Offset = "0x1D84298", VA = "0x1D84298")]
    private bool CheckEnabledImage(int index) => new bool();

    [Token(Token = "0x6015A9B")]
    [Address(RVA = "0x1D84338", Offset = "0x1D84338", VA = "0x1D84338")]
    private void SetActiveOnlyON(int index, bool active)
    {
    }

    [Token(Token = "0x6015A9C")]
    [Address(RVA = "0x1D84374", Offset = "0x1D84374", VA = "0x1D84374")]
    private void SetImageEnableON(int index, bool enable)
    {
    }

    [Token(Token = "0x6015A9D")]
    [Address(RVA = "0x1D84424", Offset = "0x1D84424", VA = "0x1D84424")]
    private void SwitchDotObject(int index, bool active)
    {
    }

    [Token(Token = "0x6015A9E")]
    [Address(RVA = "0x1D844B0", Offset = "0x1D844B0", VA = "0x1D844B0")]
    private void SwitchDotImage(int index, bool enable)
    {
    }

    [Token(Token = "0x6015A9F")]
    [Address(RVA = "0x1D845C0", Offset = "0x1D845C0", VA = "0x1D845C0")]
    public DotArrayView()
    {
    }

    [Token(Token = "0x20036FF")]
    private enum TargetType
    {
      [Token(Token = "0x400F035")] Image,
      [Token(Token = "0x400F036")] GameObject,
    }
  }
}
