-- このluaスクリプトは、PT4_01A_12_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力

	--★★ガウェイン★★:暗いカオしてんな、ノワール
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT4_01A_12_0010002")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ガウェイン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_12_0010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:ごめん。せっかくガウェインたちが<br>ローマ軍を抑えていてくれたのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_12_0010004")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:俺、聖杯を手に入れられなかった…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_12_0010005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:おいおい、謝ることなんかねーって<br>お前は十分頑張ったよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT4_01A_12_0010006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ただ<br>予想外のことが起きすぎたってだけだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT4_01A_12_0010007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:俺がその場にいたらさ<br>きっとパニクってなにもできなかったと思うぜ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT4_01A_12_0010008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:ありがとう、ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_12_0010009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:元気出せって。お前がそんなじゃ<br>みんなますます落ち込んじまうよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT4_01A_12_0010010")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:特にギネヴィアなんかな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT4_01A_12_0010011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ギネヴィア…そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_12_0010012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力

	--★★ガウェイン★★:明るいカオ、見せてやってこいよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT4_01A_12_0010013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
