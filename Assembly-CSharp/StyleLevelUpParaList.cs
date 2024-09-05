// Decompiled with JetBrains decompiler
// Type: StyleLevelUpParaList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002A1")]
public class StyleLevelUpParaList : MonoBehaviour
{
  [Token(Token = "0x4000F72")]
  [FieldOffset(Offset = "0x18")]
  private float n;
  [Token(Token = "0x4000F73")]
  [FieldOffset(Offset = "0x1C")]
  private float m;
  [Token(Token = "0x4000F74")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Slider baseSlider;
  [Token(Token = "0x4000F75")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private Slider addSlider;
  [Token(Token = "0x4000F76")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private Text basePara;
  [Token(Token = "0x4000F77")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private Text fixPara;
  [Token(Token = "0x4000F78")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private Text addPara;
  [Token(Token = "0x4000F79")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private Text fromAverage;
  [Token(Token = "0x4000F7A")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private Text toAverage;
  [Token(Token = "0x4000F7B")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private GameObject UP3Obj;
  [Token(Token = "0x4000F7C")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  private GameObject UP2Obj;
  [Token(Token = "0x4000F7D")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  private GameObject UP1Obj;
  [Token(Token = "0x4000F7E")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  private GameObject DownObj;
  [Token(Token = "0x4000F7F")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private GameObject SameObj;
  [Token(Token = "0x4000F80")]
  [FieldOffset(Offset = "0x80")]
  [SerializeField]
  private TrackAsset UP3;
  [Token(Token = "0x4000F81")]
  [FieldOffset(Offset = "0x88")]
  private string UP3Name;
  [Token(Token = "0x4000F82")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private TrackAsset UP2;
  [Token(Token = "0x4000F83")]
  [FieldOffset(Offset = "0x98")]
  private string UP2Name;
  [Token(Token = "0x4000F84")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private TrackAsset UP1;
  [Token(Token = "0x4000F85")]
  [FieldOffset(Offset = "0xA8")]
  private string UP1Name;
  [Token(Token = "0x4000F86")]
  [FieldOffset(Offset = "0xB0")]
  [SerializeField]
  private TrackAsset Down;
  [Token(Token = "0x4000F87")]
  [FieldOffset(Offset = "0xB8")]
  private string DownName;
  [Token(Token = "0x4000F88")]
  [FieldOffset(Offset = "0xC0")]
  [SerializeField]
  private TrackAsset Same;
  [Token(Token = "0x4000F89")]
  [FieldOffset(Offset = "0xC8")]
  private string SameName;
  [Token(Token = "0x4000F8A")]
  [FieldOffset(Offset = "0xD0")]
  [SerializeField]
  private GameObject imgPlusBase;
  [Token(Token = "0x4000F8B")]
  [FieldOffset(Offset = "0xD8")]
  [SerializeField]
  private Image pinMark;

  [Token(Token = "0x6001050")]
  [Address(RVA = "0x1BE65A4", Offset = "0x1BE65A4", VA = "0x1BE65A4")]
  public float Init(
    int baseParam,
    int maxStatus,
    int fromLevelupParam,
    int toLevelupParam,
    int fromLevel,
    int toLevel,
    TrackAsset trackAsset,
    bool isMark)
  {
    return new float();
  }

  [Token(Token = "0x6001051")]
  [Address(RVA = "0x1BE6920", Offset = "0x1BE6920", VA = "0x1BE6920")]
  private void SetTrack(TrackAsset trackAsset)
  {
  }

  [Token(Token = "0x6001052")]
  [Address(RVA = "0x1BE6D64", Offset = "0x1BE6D64", VA = "0x1BE6D64")]
  private void EnableObj(float pinValue)
  {
  }

  [Token(Token = "0x6001053")]
  [Address(RVA = "0x1BE6CF0", Offset = "0x1BE6CF0", VA = "0x1BE6CF0")]
  private void DisableObj()
  {
  }

  [Token(Token = "0x6001054")]
  [Address(RVA = "0x1BE6E14", Offset = "0x1BE6E14", VA = "0x1BE6E14")]
  public StyleLevelUpParaList()
  {
  }
}
