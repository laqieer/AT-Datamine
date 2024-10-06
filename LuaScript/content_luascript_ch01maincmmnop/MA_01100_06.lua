-- このluaスクリプトは、MA_01100_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114061_01","114061_01_h")
Include("content_adv_advsmall_114061_01","Template114061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera114061_01()
	InitializeTemplate114061_01()
-- ▼直接出力
ShowGlobalMenuButton(false)
SetTrackingId(35)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114061)
	Actor001 = InitializeCharacter_2DOnly("101009","005","101009005")
	Actor002 = InitializeCharacter_2DOnly("101010","003","101010003")
	Actor003 = InitializeCharacter_2DOnly("101021","003","101021003")
	template1()
end

function Play()
	StartPlay()

	open_cutin(2,1)
	on_cutin(2,Actor002,"Normal")

	--★★ランスロット★★:来い、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","N","MA_01100_060002")

	on_cutin(1,Actor001,"Anger")
	on_cutin(2,Actor002,"Normal")

	--★★ノワール★★:決闘だ、ランスロット！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01100_060003")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
se_play("SE_ADV_MA_01100_06_WoodSword_Fight")
shake_camera(RndCamera001,1.2,0.3)
wait_time(0.7)
se_play("SE_ADV_MA_01100_06_WoodSword_Blow")
shake_camera(RndCamera001,1.2,0.3)
wait_time(0.4)
shake_camera(RndCamera001,1.7,0.3)
wait_time(2.0)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:俺の勝ちだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01100_060005")


	--★★ノワール★★:負けてない！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_060006")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:師匠、なんとか言ってやってくれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01100_060007")


	--★★ノワール★★:父さん！なんとか言ってやってくれよ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_060008")

	change_face(Actor003,"Smile")

	--★★ブルーノ★★:ノワールもすぐに追いつくさ
	Talk(Actor003,"CHRNAME_BRUNO","speech","L","MA_01100_060009")

	change_face(Actor001,"Sad")

	--★★ノワール★★:父さんみたいな『円卓の騎士』になりたいんだよ<br>ランスロットごときには負けられないの！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_060010")


	--★★ランスロット★★:ごときとか言うな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01100_060012")

	change_face(Actor003,"Normal")

	--★★ブルーノ★★:急がなくていいんだ、ノワール<br>お前の武器をゆっくり見つければいい
	Talk(Actor003,"CHRNAME_BRUNO","speech","L","MA_01100_060013")

	open_cutin(1,1)
	on_cutin(1,Actor001,"Normal")

	--★★ノワール★★:世界平和の願いを叶える聖杯を探し求め<br>その聖杯へ導く妖精さんを守る騎士…！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01100_060014")

	on_cutin(1,Actor001,"Smile")

	--★★ノワール★★:俺は、円卓の騎士になるんだ！！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01100_060015")

	close_cutin()
	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺が先だよな、師匠？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01100_060016")

	change_face(Actor003,"Smile")

	--★★ブルーノ★★:ふたり並んだ姿が見たいな
	Talk(Actor003,"CHRNAME_BRUNO","speech","L","MA_01100_060017")

	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")

	--★★ランスロット★★:待ってるぞ、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","N","MA_01100_060018")

-- ▼直接出力
SetTrackingId(36)
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
	load_area_scene_preload(114061)
	InitializeCharacter_2DOnly_Preload("101009","005","101009005")
	InitializeCharacter_2DOnly_Preload("101010","003","101010003")
	InitializeCharacter_2DOnly_Preload("101021","003","101021003")
	system.PreLoadRequest(CameraAssetBundleName114061_01)
end
