// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.MissionTreasureBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002AA7")]
  public class MissionTreasureBox : MonoBehaviour
  {
    [Token(Token = "0x400B57F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI _treasureChestLabel;
    [Token(Token = "0x400B580")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector _treasureChestAnime;
    [Token(Token = "0x400B581")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image _image;
    [Token(Token = "0x400B582")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton _button;
    [Token(Token = "0x400B583")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITweenGroup _tween;
    [Token(Token = "0x400B584")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject[] particleEffect;
    [Token(Token = "0x400B585")]
    [FieldOffset(Offset = "0x48")]
    private MissionTreasureBox.IconKind currKind;

    [Token(Token = "0x6010AF7")]
    [Address(RVA = "0x4BD1D98", Offset = "0x4BD1D98", VA = "0x4BD1D98")]
    public void SetProgressPoint(int point)
    {
    }

    [Token(Token = "0x6010AF8")]
    [Address(RVA = "0x4BD1DE0", Offset = "0x4BD1DE0", VA = "0x4BD1DE0")]
    public void PlayShakeAnim()
    {
    }

    [Token(Token = "0x6010AF9")]
    [Address(RVA = "0x4BD1DFC", Offset = "0x4BD1DFC", VA = "0x4BD1DFC")]
    public void StopShakeAnim()
    {
    }

    [Token(Token = "0x6010AFA")]
    [Address(RVA = "0x4BD1E18", Offset = "0x4BD1E18", VA = "0x4BD1E18")]
    public void PlayCheckLoop()
    {
    }

    [Token(Token = "0x6010AFB")]
    [Address(RVA = "0x4BD1EE0", Offset = "0x4BD1EE0", VA = "0x4BD1EE0")]
    public void PlayCheckAnim()
    {
    }

    [Token(Token = "0x6010AFC")]
    [Address(RVA = "0x4BD1F70", Offset = "0x4BD1F70", VA = "0x4BD1F70")]
    public void PlayCheckOn()
    {
    }

    [Token(Token = "0x6010AFD")]
    [Address(RVA = "0x4BD1FC8", Offset = "0x4BD1FC8", VA = "0x4BD1FC8")]
    public void PlayCheckOff()
    {
    }

    [Token(Token = "0x6010AFE")]
    [Address(RVA = "0x4BD2020", Offset = "0x4BD2020", VA = "0x4BD2020")]
    public void SetIcon(MissionTreasureBox.IconKind iconKind, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6010AFF")]
    [Address(RVA = "0x4BD2150", Offset = "0x4BD2150", VA = "0x4BD2150")]
    public void SetOnClickEvent(Action<int> callback, int treasureIndex)
    {
    }

    [Token(Token = "0x6010B00")]
    [Address(RVA = "0x4BD2248", Offset = "0x4BD2248", VA = "0x4BD2248")]
    public MissionTreasureBox()
    {
    }

    [Token(Token = "0x2002AA8")]
    public enum IconKind
    {
      [Token(Token = "0x400B587")] Bronze = 1,
      [Token(Token = "0x400B588")] Silver = 2,
      [Token(Token = "0x400B589")] Gold = 3,
      [Token(Token = "0x400B58A")] Platinum = 4,
    }
  }
}
