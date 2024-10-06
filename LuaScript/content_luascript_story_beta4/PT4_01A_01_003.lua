-- このluaスクリプトは、PT4_01A_01_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",242,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:ギネヴィアさん、大丈夫かな…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","PT4_01A_01_0030002")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:厳しい戦いが続いていたからな<br>心身ともに相当な負担がかかっていたはずだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_01_0030003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ギネヴィアなら大丈夫だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_01_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:えっ？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","PT4_01A_01_0030005")


	--★★ノワール★★:彼女はいつも気丈に<br>飾って自分を見せようとしてたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_01_0030006")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:でも、実際は強い心をもってる<br>俺なんかよりも、ずっとずっと強い心を
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_01_0030007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:だから大丈夫だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_01_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:他でもないお前が言うのだから<br>そうなんだろうな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_01_0030009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:うん<br>じゃあ、私たちにできることはひとつだね
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","PT4_01A_01_0030010")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ<br>信じて待とう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_01_0030011")

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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
