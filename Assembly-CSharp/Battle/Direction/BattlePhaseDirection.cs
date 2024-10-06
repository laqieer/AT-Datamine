// Decompiled with JetBrains decompiler
// Type: Battle.Direction.BattlePhaseDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.UI;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.Direction
{
  [Token(Token = "0x20025BC")]
  public class BattlePhaseDirection : MonoBehaviour
  {
    [Token(Token = "0x400A253")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController controller;
    [Token(Token = "0x400A254")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400A255")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI turnTitle;
    [Token(Token = "0x400A256")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI turnValue;
    [Token(Token = "0x400A257")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI phaseValue;
    [Token(Token = "0x400A258")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<BattlePhaseDirection.BattlePhaseDirectionSchema> battlePhaseDirectionSettingParameter;

    [Token(Token = "0x170031B7")]
    public bool IsInitialized
    {
      [Token(Token = "0x600E8F9"), Address(RVA = "0x4C464F0", Offset = "0x4C464F0", VA = "0x4C464F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170031B8")]
    public bool IsPlaying
    {
      [Token(Token = "0x600E8FA"), Address(RVA = "0x4C4650C", Offset = "0x4C4650C", VA = "0x4C4650C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E8FB")]
    [Address(RVA = "0x4C46528", Offset = "0x4C46528", VA = "0x4C46528")]
    public void Awake()
    {
    }

    [Token(Token = "0x600E8FC")]
    [Address(RVA = "0x4C46578", Offset = "0x4C46578", VA = "0x4C46578")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E8FD")]
    [Address(RVA = "0x4C465C8", Offset = "0x4C465C8", VA = "0x4C465C8")]
    public void Release()
    {
    }

    [Token(Token = "0x600E8FE")]
    [Address(RVA = "0x4C465E4", Offset = "0x4C465E4", VA = "0x4C465E4")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E8FF")]
    [Address(RVA = "0x4C46638", Offset = "0x4C46638", VA = "0x4C46638")]
    public void Display()
    {
    }

    [Token(Token = "0x600E900")]
    [Address(RVA = "0x4C4652C", Offset = "0x4C4652C", VA = "0x4C4652C")]
    public void Hide()
    {
    }

    [Token(Token = "0x600E901")]
    [Address(RVA = "0x4C46684", Offset = "0x4C46684", VA = "0x4C46684")]
    public void Play(AttentionTween.Mode mode, int turnNumber)
    {
    }

    [Token(Token = "0x600E902")]
    [Address(RVA = "0x4C46970", Offset = "0x4C46970", VA = "0x4C46970")]
    public BattlePhaseDirection()
    {
    }

    [Token(Token = "0x20025BD")]
    [Serializable]
    public class ColorSchema
    {
      [Token(Token = "0x400A259")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      [Tooltip("対象Image")]
      private Image image;
      [Token(Token = "0x400A25A")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      [Tooltip("上書きするカラー値")]
      private Color color;

      [Token(Token = "0x170031B9")]
      public Image Image
      {
        [Token(Token = "0x600E903"), Address(RVA = "0x4C46978", Offset = "0x4C46978", VA = "0x4C46978")] get
        {
          return (Image) null;
        }
      }

      [Token(Token = "0x170031BA")]
      public Color Color
      {
        [Token(Token = "0x600E904"), Address(RVA = "0x4C46980", Offset = "0x4C46980", VA = "0x4C46980")] get
        {
          return new Color();
        }
      }

      [Token(Token = "0x600E905")]
      [Address(RVA = "0x4C4698C", Offset = "0x4C4698C", VA = "0x4C4698C")]
      public ColorSchema()
      {
      }
    }

    [Token(Token = "0x20025BE")]
    [Serializable]
    public class BattlePhaseDirectionSchema
    {
      [Token(Token = "0x400A25B")]
      [FieldOffset(Offset = "0x10")]
      [Tooltip("軍勢")]
      [SerializeField]
      private AttentionTween.Mode mode;
      [Token(Token = "0x400A25C")]
      [FieldOffset(Offset = "0x18")]
      [Tooltip("上書きするImageとカラー値情報リスト")]
      [SerializeField]
      private List<BattlePhaseDirection.ColorSchema> objectColors;
      [Token(Token = "0x400A25D")]
      [FieldOffset(Offset = "0x20")]
      [Tooltip("TextMeshProUGUIのColorGradient")]
      [SerializeField]
      private TMP_ColorGradient textColorPreset;
      [Token(Token = "0x400A25E")]
      [FieldOffset(Offset = "0x28")]
      [Tooltip("Img_PhaseBaseのマテリアル")]
      [SerializeField]
      private Material phaseValueMaterial;
      [Token(Token = "0x400A25F")]
      [FieldOffset(Offset = "0x30")]
      [Tooltip("Img_PhaseBaseのテキストデータ")]
      [SerializeField]
      private string phaseValue;

      [Token(Token = "0x170031BB")]
      public AttentionTween.Mode Mode
      {
        [Token(Token = "0x600E906"), Address(RVA = "0x4C46994", Offset = "0x4C46994", VA = "0x4C46994")] get
        {
          return new AttentionTween.Mode();
        }
      }

      [Token(Token = "0x170031BC")]
      public List<BattlePhaseDirection.ColorSchema> ObjectColors
      {
        [Token(Token = "0x600E907"), Address(RVA = "0x4C4699C", Offset = "0x4C4699C", VA = "0x4C4699C")] get
        {
          return (List<BattlePhaseDirection.ColorSchema>) null;
        }
      }

      [Token(Token = "0x170031BD")]
      public TMP_ColorGradient TextColorPreset
      {
        [Token(Token = "0x600E908"), Address(RVA = "0x4C469A4", Offset = "0x4C469A4", VA = "0x4C469A4")] get
        {
          return (TMP_ColorGradient) null;
        }
      }

      [Token(Token = "0x170031BE")]
      public Material PhaseValueMaterial
      {
        [Token(Token = "0x600E909"), Address(RVA = "0x4C469AC", Offset = "0x4C469AC", VA = "0x4C469AC")] get
        {
          return (Material) null;
        }
      }

      [Token(Token = "0x170031BF")]
      public string PhaseValue
      {
        [Token(Token = "0x600E90A"), Address(RVA = "0x4C469B4", Offset = "0x4C469B4", VA = "0x4C469B4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600E90B")]
      [Address(RVA = "0x4C469BC", Offset = "0x4C469BC", VA = "0x4C469BC")]
      public BattlePhaseDirectionSchema()
      {
      }
    }
  }
}
