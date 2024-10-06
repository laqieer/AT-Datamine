-- このluaスクリプトは、MA_01A112_58.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114042_01","114042_01_h")
Include("content_adv_advsmall_114042_01","Template114042_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera114042_01()
	InitializeTemplate114042_01()
-- ▼直接出力
change_face(Actor001,"Surprise")
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Surprise")
-- ▲直接出力
-- ▼直接出力
change_face(Actor003,"Surprise")
-- ▲直接出力
-- ▼直接出力
change_face(Actor004,"Sad")
-- ▲直接出力
-- ▼直接出力
change_face(Actor005,"Sad")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("10103036", "content_still_10103036_image", "101030360_StillImage")
-- ▲直接出力
-- ▼直接出力
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114043)
	Actor001 = InitializeCharacter_2DOnly("101009","001","101009001")
	Actor002 = InitializeCharacter_2DOnly("101011","001","101011001")
	Actor003 = InitializeCharacter_2DOnly("101030","002","101030002")
	Actor004 = InitializeCharacter_2DOnly("101015","001","101015001")
	Actor005 = InitializeCharacter_2DOnly("101020","001","101020001")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★テロップ★★:「誰にも抜けないこの剣は太古から<br>バルバロイの封だとも言われていたわ」
	Talk(Actor006,"telop","narration","N","MA_01A112_580002")


	--★★テロップ★★:「この地の歴史における封印であり──」
	Talk(Actor006,"telop","narration","N","MA_01A112_580003")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
off_cameraframe()
off_screencolor()
fadein(FADE_TIME)
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★アーサー★★:…そうだ。ギネヴィア
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A112_580004")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:まっ、て
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_580005")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力

	--★★アーサー★★:継承者のキラーズは聖遺物として<br>この地に突き立ち、封とならねばならない
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A112_580006")


	--★★ギネヴィア★★:うそ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_580007")

	change_face(Actor003,"Sad")

	--★★エレイン★★:ど、どれだけのあいだ、ですか<br>どのくらいギネヴィアさんは封として…！？
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_580008")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:………ティルフィング、みたいに…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_580009")

-- ▼直接出力
CloseTalkWindow()
wait_time(2.0)
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★マーリン★★:一千年以上<br>伝承によればそれだけの時を
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01A112_580010")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:一千年…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_580011")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:わたし…そのあいだ、ずっと…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_580012")

	change_face(Actor003,"Pain")

	--★★エレイン★★:………そんな、だって…！<br>せっかくここまで一緒いっしょに………っ
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_580013")

-- ▼直接出力
CloseTalkWindow()

show_image("101010140", 0.0, 0.0,FADE_TIME,false,false)
set_scale_image(20,20)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ぜ、ぜんぶおわったら<br>へいわな、旅に…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_580014")


	--★★ギネヴィア★★:…なのに、わたし<br>剣になったまま…え、え…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A112_580015")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィア…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_580016")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0,1.0)
wait_time(1.5)
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("10103036", 0.0, 0.0, 0.0 ,true,false)
fadein(2.0)
wait_time(1.5)
 voiceSignalS = voice_play("VO_story01_G_1512")
wait_time(1.0)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(1.5)
fadeout(0,0,0,1.0,2.0)
wait_time(2.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("10103036", "content_still_10103036_image", "101030360_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114043)
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	InitializeCharacter_2DOnly_Preload("101030","002","101030002")
	InitializeCharacter_2DOnly_Preload("101015","001","101015001")
	InitializeCharacter_2DOnly_Preload("101020","001","101020001")
	system.PreLoadRequest(CameraAssetBundleName114042_01)
end
