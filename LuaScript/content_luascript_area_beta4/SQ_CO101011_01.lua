Include("content_luascript_common","ADVSmallPack")

function Load()
  InitializeLoadActive()
  Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
  Actor002 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")

	load_sound("BGM_ADV_Ginevia_Theme")
end

function Play()
  StartPlayActive()

	bgm_play("BGM_ADV_Ginevia_Theme")

  Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","SQ_CO101011_010001")
  Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","SQ_CO101011_010002")
  Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","SQ_CO101011_010003")

  CloseTalkWindow()

  EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
  InitializeActiveCharacter_Preload("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
	preload_sound("BGM_ADV_Ginevia_Theme")
end
