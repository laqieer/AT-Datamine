-- このluaスクリプトは、PT3_01B_12_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:おはよう、ノワール<br>降誕祭が月末に迫ってきたわね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT3_01B_12_001002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、クレア<br>キミはもう降誕祭の予定、立ててるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_001003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:あら？<br>あなたはまだ知らないのね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT3_01B_12_001004")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？知らないって…なにをだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_001005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:知らないならいいわ<br>いずれわかることだから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT3_01B_12_001006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや…<br>知ってるなら教えてほしいんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_001007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★クレア★★:そうね…。あえて言うならわたしとヴォールスは<br>グラストンベリーに行くことになっているわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT3_01B_12_001008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ふたりで行くってことは円卓の任務か？<br>俺も付いて行こうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_001009")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力

	--★★クレア★★:いいえ、その必要はないわ<br>あなたにはあなたの役割がある。頑張って
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT3_01B_12_001010")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:え？<br>頑張るって…なにをだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_001011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
