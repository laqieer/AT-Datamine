-- このluaスクリプトは、PT3_01A_11_003.csvから自動生成されました --
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
PlayPartVoice("ギネマウア","挨拶")
-- ▲直接出力

	--★★ギネマウア★★:ノワール様、おはようございます
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01A_11_0030003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:ギネマウアさん、おはようございます<br>今朝はギネヴィアと一緒じゃないんですね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア","肯定")
-- ▲直接出力

	--★★ギネマウア★★:今朝は私用がありまして<br>私だけ一足先に登校いたしました
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01A_11_0030005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ギネヴィア、遅刻せずに来られますかね？<br>ギネマウアさんが起こさなくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0030006")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネマウア","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:…私にできるのは、信じることのみです
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01A_11_0030007")

-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネマウア","挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:話は変わりますが
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01A_11_0030009")


	--★★ギネマウア★★:ノワール様に残る記憶のなかで<br>一番古いものはどういった内容でしょうか？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01A_11_0030010")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:一番古い記憶ですか？<br>…うーん、なんだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0030011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:３歳か４歳くらいの頃<br>家の近くの湖に落ちて溺れかけたことかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0030012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア","納得")
-- ▲直接出力

	--★★ギネマウア★★:では、ディナタンについての記憶で<br>一番古いものはいかがでしょう？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01A_11_0030013")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ディナタンについての記憶？<br>何歳くらいの頃かは忘れてしまったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0030014")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:たまに思い出すのは家族４人で<br>楽しく降誕祭のパーティをやったことかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0030015")

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:そうですか
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01A_11_0030016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:大切にしてくださいね<br>ご自身の記憶、ディナタンとの記憶
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT3_01A_11_0030017")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？<br>それはどういう…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0030018")

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
