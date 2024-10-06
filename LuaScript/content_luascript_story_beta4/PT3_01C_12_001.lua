-- このluaスクリプトは、PT3_01C_12_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "挨拶")
-- ▲直接出力

	--★★マーリン★★:ノワール様<br>ルーシャス皇太子の救援、お疲れ様でした
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT3_01C_12_001001")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:マーリンさん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_12_001002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★マーリン★★:聞くところによると<br>魔女グリーテンの討伐にも成功されたとか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT3_01C_12_001003")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:あの、マーリンさん<br>俺、気になっていることがあるんです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_12_001004")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ルーシャスはアーサーと戦っていた<br>魔女はルーシャスと袂を分かった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_12_001005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:それはつまり<br>アーサーと魔女との繋がりを意味している…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_12_001006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:私が思うに<br>魔女たちは一枚岩ではありません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT3_01C_12_001007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★マーリン★★:アーサー様につく者がいる可能性もあります<br>ですが、たとえそうだとしても…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT3_01C_12_001008")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうだとしても？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_12_001009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:アーサー様と魔女たちとが目指す未来は異なる<br>私はそう考えています
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT3_01C_12_001010")

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
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
