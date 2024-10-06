-- このluaスクリプトは、MA_01A109_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
movie_load("MA_01A109_04")
-- ▲直接出力
-- ▼直接出力
movie_set_active(true)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Genocide")
load_sound("BGM_ADV_DarkBrave")
-- ▲直接出力
-- ▼直接出力
 --bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
bgm_play("BGM_ADV_Genocide")
movie_play()
movie_wait_playing()
movie_stop()
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_DarkBrave")
-- ▲直接出力

	--★★テロップ★★:命の価値は忘却の彼方
	Talk(Actor001,"","narration","N","MA_01A109_380002")


	--★★テロップ★★:ブリテン島　六世紀　八月
	Talk(Actor001,"","narration","N","MA_01A109_380003")


	--★★テロップ★★:ブリテン島東部を<br>支配下に置いていたカレドニアは
	Talk(Actor001,"","narration","N","MA_01A109_380004")


	--★★テロップ★★:その王ライエンスの死によって<br>国内の混乱が収束
	Talk(Actor001,"","narration","N","MA_01A109_380005")


	--★★テロップ★★:手を下したのはローマ皇太子ルーシャス<br>彼はログレスから離反、魔女と共に姿を消した
	Talk(Actor001,"","narration","N","MA_01A109_380006")


	--★★テロップ★★:黒き怪異、不死の異民族──<br>バルバロイは増殖の一途を辿っており…
	Talk(Actor001,"","narration","N","MA_01A109_380007")


	--★★テロップ★★:間もなく歴史を侵し尽くす<br>人々に打つ手はないように思えた
	Talk(Actor001,"","narration","N","MA_01A109_380008")


	--★★テロップ★★:ただ、一手を除いては
	Talk(Actor001,"","narration","N","MA_01A109_380009")


	--★★テロップ★★:それは<ruby=ギネヴィア>革命の劒</ruby><br><ruby=アロンダイト>災厄の時代から運命を革める刃</ruby>
	Talk(Actor001,"","narration","N","MA_01A109_380010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
movie_load_preload("MA_01A109_04")
preload_sound("BGM_ADV_Genocide")
preload_sound("BGM_ADV_DarkBrave")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
