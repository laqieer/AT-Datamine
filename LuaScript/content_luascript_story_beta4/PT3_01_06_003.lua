-- このluaスクリプトは、PT3_01_06_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_03","110191_03_h")
Include("content_adv_advsmall_110191_03","Template110191_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_002)
	InitializeTemplateRandomCamera110191_03()
	InitializeTemplate110191_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:ごきげんよう、ノワール
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01_06_0030003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？<br>あっ、おはよう…イゾルデ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_06_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★イゾルデ★★:なにを驚いているの<br>私がお前に朝の挨拶をするのがそんなに珍しい？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01_06_0030005")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、そういうわけじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_06_0030006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力

	--★★イゾルデ★★:それはともかくとして<br>カレドニア城に行くそうね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01_06_0030007")


	--★★イゾルデ★★:覚悟はできているの？<br>魔女の強さは一般的なバルバロイの比ではない
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01_06_0030008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★イゾルデ★★:それに…あのブライアンという男
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01_06_0030009")

-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:ただものではないのでしょう？<br>お前やディナタンにとっては、特に
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01_06_0030010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:覚悟はできてる…つもりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_06_0030011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:…そう<br>カレドニアの遠征には同行させてもらうわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01_06_0030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★イゾルデ★★:見せてちょうだい<br>私とトリスタンに、お前の覚悟を
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01_06_0030013")

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
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
