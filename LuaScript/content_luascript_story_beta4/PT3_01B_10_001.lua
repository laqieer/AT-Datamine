-- このluaスクリプトは、PT3_01B_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_002)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:キミはあのじゃじゃ馬娘のお目付け役だろう！？<br>しっかり見ておいてくれなければ困る！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT3_01B_10_001002")

	PlayAction(Actor001,"to Greet_one")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、おはようパーシヴァル<br>朝からなんだよ、藪から棒に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_10_001003")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それに、じゃじゃ馬娘って…<br>ガラハッドのことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_10_001004")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:他に誰がいるっていうんだい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT3_01B_10_001005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:「聖杯を調べるから」といって<br>大図書院の一画を占拠したり
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT3_01B_10_001006")


	--★★パーシヴァル★★:「姉上に元気になってもらうため」といって<br>ガレスにメニューにない料理を作らせたり
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT3_01B_10_001007")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:まったくお騒がせにもほどがある！<br>騎士の風上にも置けない！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT3_01B_10_001008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…悪い。よく言い聞かせておくよ<br>でも、それだけ焦ってるってことなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_10_001009")


	--★★ノワール★★:パーシヴァルだって身内に<br>なにかあったら心配でたまらないだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_10_001010")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力

	--★★パーシヴァル★★:フン。そんな心配はする必要がないね<br>ぼくがいれば、身内にはなにも起こらない
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT3_01B_10_001011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へ、へえ…<br>（身内を大事にしてるんだな）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_10_001012")

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
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
