-- このluaスクリプトは、PT3_01B_11_002.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
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

	--★★イゾルデ★★:ごきげんよう、ノワール<br>銀卓騎士団のキラーズの処遇は聞いたかしら？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01B_11_002002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ああ、俺もその場にいたからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_002003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:まったく、我らが王はとことん甘いわね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01B_11_002004")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あのふたりを<br>学園の生徒として迎え入れたことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_002005")

	change_face(Actor002,"Normal")

	--★★イゾルデ★★:他になにがあるっていうの？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01B_11_002006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:イゾルデは疑ってるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_002007")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:疑わないほうがどうかしているわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01B_11_002008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★イゾルデ★★:あのふたりとそのマスターは<br>お前たちを殺そうとしたと聞くわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01B_11_002009")


	--★★イゾルデ★★:そんなマスターを逃がして投降なんて<br>なにかあるに違いなくてよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01B_11_002010")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:トリスタンも同意見なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_002011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:当然でしょう
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01B_11_002012")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:だよな…<br>でもそんなキミやトリスタンがいてくれるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_002013")


	--★★ノワール★★:アーサーは<br>あのふたりを迎え入れたんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_002014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:万が一の事態が起きたとしても<br>あとを任せられる仲間がいるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_002015")

-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力

	--★★イゾルデ★★:…どうかしらね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01B_11_002016")

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
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
