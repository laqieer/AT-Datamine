-- このluaスクリプトは、PT3_01B_11_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ヴォールス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴォールス★★:ノワール、聖杯探索の件はご苦労だったな<br>あまり力になってやれず、すまなかった
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT3_01B_11_003002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、ヴォールス<br>そんなことはないさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_003003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺もランスロットが無事に帰ってこられたのも<br>あんたが鍛えてくれた武器のおかげだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_003004")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:そういってもらえるのは嬉しいことだが…
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT3_01B_11_003005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか気になることでもあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_003006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ヴォールス★★:クレアが言っていただろう<br>「魔女姉妹が分散するメリットはない」と
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT3_01B_11_003007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:円卓会議でマーリンさんも懸念していたな<br>順調すぎるって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_003008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なにか理由があるんだろうか？<br>力を分散させた…させざるを得なかった理由が
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_003009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴォールス★★:まだわからない<br>自分にも、クレアにも
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT3_01B_11_003010")

	change_face(Actor002,"Normal")

	--★★ヴォールス★★:だが、なにかあると思って<br>動いたほうがいい
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT3_01B_11_003011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった。でも、なにかがあったとしても<br>あんたとクレアが協力してくれるんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_003012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定2")
-- ▲直接出力

	--★★ヴォールス★★:無論だ
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT3_01B_11_003013")

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
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
