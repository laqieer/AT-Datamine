-- このluaスクリプトは、PT3_01C_09_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力

	--★★ギネマウア★★:おはようございます、ノワール様
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01C_09_003002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはようございます、ギネマウアさん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_003003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア", "挨拶")
-- ▲直接出力

	--★★ギネマウア★★:ＧＳを果たされてから<br>体調にお変わりはありませんか？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01C_09_003004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はい、おかげさまで<br>前より調子がいい気がします
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_003005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それに…なんとなくですが<br>ディナタンをより身近に感じられるようになって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_003006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:これまで以上に<br>頑張らなきゃなって思いが強くなってきました
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_003007")

	change_face(Actor001,"Serious")

	--★★ノワール★★:ブライアンや…<br>これまでの戦いで亡くなった人たちのためにも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_003008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネマウア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:ふふっ<br>私の目にもノワール様の変化は感じ取れています
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01C_09_003009")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:それは周りの方々にも伝播しているようですよ<br>殿下もあなたの力になろうと
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01C_09_003010")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネマウア★★:ランスロット先生に武術を習ったり<br>ケイ先生に政治を学んだりと忙しくしています
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01C_09_003011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ、ギネヴィアが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_003012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:私も殿下と一緒にサポートいたします<br>１日でも早く、この国に平穏をもたらしましょう
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01C_09_003013")

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
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
