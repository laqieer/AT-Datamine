-- このluaスクリプトは、MA_01104_08.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(8,false)
setup_template_moveobj_110122_01(7,false)
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★ディナタン★★:正直に言っていいかな？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_080002")


	--★★ディナタン★★:すこしつらいね<br>兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_080003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:ランス兄ちゃんのこと…<br>なにもわからない
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_080004")


	--★★ディナタン★★:せめて兄さんと一緒に…<br>一緒のクラスならよかったのに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_080005")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…これまで敵同士だった相手を簡単には<br>受け入れられないよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_080006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:そのことを根に持っている人も<br>いるんじゃ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_080007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:いるだろうな<br>でも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_080008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:でもね、いいこともあるから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_080010")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:いいこと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_080011")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:こんなふうに落ち着いて<br>一緒に食事をとるの、久しぶりでしょ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_080012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:…そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_080013")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:あと、雨風の心配もしなくていいって<br>それだけですごくありがたいことだよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_080014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:ね、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_080015")


	--★★ノワール★★:…わかってるよ<br>この席が、誰が用意してくれたものかくらい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_080017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:…がんばろうね、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_080019")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
